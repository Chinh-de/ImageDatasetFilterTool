using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


namespace Filter_Images
{
    public partial class Form1 : Form
    {
        private List<string> verifiedList = new List<string>();
        private List<string> removedList = new List<string>();
        private int verifiedCount = 0;
        private int removedCount = 0;
        private List<string> unprocessedFiles = new List<string>();
        private string pathToFolder = null;
        private string pathToJson = null;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.folderTxt.PreviewKeyDown += InputBox_PreviewKeyDown;
            this.jsonTxt.PreviewKeyDown += InputBox_PreviewKeyDown;
            MessageBox.Show("Bấm phím lui hoặc xuống để bỏ \n Bấm phím tới hoặc lên để giữ lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void InputBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            this.pathToFolder = folderTxt.Text.Trim();
            this.pathToJson = jsonTxt.Text.Trim();

            if (string.IsNullOrEmpty(this.pathToFolder) || string.IsNullOrEmpty(this.pathToJson))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ cả đường dẫn thư mục và file JSON.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(this.pathToFolder))
            {
                MessageBox.Show("Thư mục không tồn tại: " + this.pathToFolder, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Path.GetExtension(this.pathToJson).ToLower() != ".json")
            {
                MessageBox.Show("Tên tập tin không đúng định dạng JSON (.json)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            verifiedList.Clear();
            removedList.Clear();

            if (File.Exists(this.pathToJson))
            {
                try
                {
                    LoadJson(this.pathToJson, out verifiedList, out removedList);
                    verifiedCount = verifiedList.Count;
                    removedCount = removedList.Count;
                    this.updateCount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc file JSON: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                verifiedCount = 0;
                removedCount = 0;
                this.updateCount();
            }

            List<string> allJpgFiles = Directory.GetFiles(this.pathToFolder)
                    .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase))
                    .Select(f => Path.GetFileName(f))
                    .ToList();

            // Loại bỏ file đã verified hoặc removed
            this.unprocessedFiles = allJpgFiles
                .Where(file => !verifiedList.Contains(file) && !removedList.Contains(file))
                .ToList();

            MessageBox.Show($"Tổng số file chưa xử lý: {this.unprocessedFiles.Count}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.ShowNextImage();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.pathToJson))
            {
                MessageBox.Show("Chưa chọn file JSON để lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveJson(this.pathToJson, verifiedList, removedList);
                MessageBox.Show("Đã lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file JSON: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            HandleCurrentImage("remove");
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            HandleCurrentImage("verify");
        }



        private void HandleCurrentImage(string action)
        {
            if (unprocessedFiles.Count == 0)
            {
                MessageBox.Show("Không còn ảnh để xử lý.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string currentFile = unprocessedFiles[0]; // Lấy ảnh đầu tiên
            if (action == "remove")
            {
                removedList.Add(currentFile);
                removedCount++;
            }
            else if (action == "verify")
            {
                verifiedList.Add(currentFile);
                verifiedCount++;
            }

            unprocessedFiles.RemoveAt(0); // Xóa khỏi danh sách chưa xử lý
            updateCount(); // Cập nhật UI

            ShowNextImage(); // Hiển thị ảnh tiếp theo
        }


        private void updateCount()
        {
            removeTxt.Text = removedCount.ToString();
            verifiedTxt.Text = verifiedCount.ToString();
        }

        private Size CalculateFitSize(Size original, Size max)
        {
            float widthRatio = (float)max.Width / original.Width;
            float heightRatio = (float)max.Height / original.Height;
            float scale = Math.Min(widthRatio, heightRatio);

            return new Size(
                (int)(original.Width * scale),
                (int)(original.Height * scale)
            );
        }
        private void ShowNextImage()
        {
            if (unprocessedFiles.Count > 0)
            {
                string nextImagePath = Path.Combine(this.pathToFolder, unprocessedFiles[0]);
                if (File.Exists(nextImagePath))
                {
                    using (var originalImage = Image.FromFile(nextImagePath))
                    {
                        Size boxSize = picBox.ClientSize;
                        Size scaledSize = CalculateFitSize(originalImage.Size, boxSize);

                        // Tạo ảnh với nền trắng và vẽ ảnh vào giữa
                        Bitmap canvas = new Bitmap(boxSize.Width, boxSize.Height);
                        using (Graphics g = Graphics.FromImage(canvas))
                        {
                            g.Clear(Color.White); // hoặc Color.Black tùy bạn
                            int x = (boxSize.Width - scaledSize.Width) / 2;
                            int y = (boxSize.Height - scaledSize.Height) / 2;
                            g.DrawImage(originalImage, x, y, scaledSize.Width, scaledSize.Height);
                        }

                        // Giải phóng ảnh cũ nếu có
                        picBox.Image?.Dispose();
                        picBox.Image = canvas;
                        picBox.SizeMode = PictureBoxSizeMode.Normal;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ảnh tiếp theo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                picBox.Image = null;
                MessageBox.Show("Đã xử lý hết tất cả ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Down)
            {
                HandleCurrentImage("remove");
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Up)
            {
                HandleCurrentImage("verify");
            }
        }
        private void SaveJson(string path, List<string> verifiedList, List<string> removedList)
        {
            var data = new Dictionary<string, List<string>>
            {
                ["verified"] = verifiedList,
                ["removed"] = removedList
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(data, options);

            File.WriteAllText(path, json);
        }

        private void LoadJson(string path, out List<string> verifiedList, out List<string> removedList)
        {
            verifiedList = new List<string>();
            removedList = new List<string>();

            if (!File.Exists(path))
                return;

            string json = File.ReadAllText(path);

            var data = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);

            if (data != null)
            {
                if (data.ContainsKey("verified"))
                    verifiedList = data["verified"];
                if (data.ContainsKey("removed"))
                    removedList = data["removed"];
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
