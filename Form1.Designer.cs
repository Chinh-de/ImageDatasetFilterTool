namespace Filter_Images
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.jsonTxt = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.removeTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.verifiedTxt = new System.Windows.Forms.TextBox();
            this.verifyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // folderTxt
            // 
            this.folderTxt.Location = new System.Drawing.Point(126, 15);
            this.folderTxt.Name = "folderTxt";
            this.folderTxt.Size = new System.Drawing.Size(398, 22);
            this.folderTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path To Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path To JSON";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(1082, 6);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(127, 40);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start/Continue";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1261, 6);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(127, 40);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // jsonTxt
            // 
            this.jsonTxt.Location = new System.Drawing.Point(639, 15);
            this.jsonTxt.Name = "jsonTxt";
            this.jsonTxt.Size = new System.Drawing.Size(398, 22);
            this.jsonTxt.TabIndex = 6;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(27, 52);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1361, 665);
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(543, 723);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(127, 40);
            this.removeBtn.TabIndex = 8;
            this.removeBtn.Text = "<-Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // removeTxt
            // 
            this.removeTxt.Location = new System.Drawing.Point(90, 735);
            this.removeTxt.Name = "removeTxt";
            this.removeTxt.ReadOnly = true;
            this.removeTxt.Size = new System.Drawing.Size(82, 22);
            this.removeTxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 738);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Removed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1248, 738);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Verified";
            // 
            // verifiedTxt
            // 
            this.verifiedTxt.Location = new System.Drawing.Point(1303, 735);
            this.verifiedTxt.Name = "verifiedTxt";
            this.verifiedTxt.ReadOnly = true;
            this.verifiedTxt.Size = new System.Drawing.Size(85, 22);
            this.verifiedTxt.TabIndex = 12;
            // 
            // verifyBtn
            // 
            this.verifyBtn.Location = new System.Drawing.Point(749, 723);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(127, 40);
            this.verifyBtn.TabIndex = 14;
            this.verifyBtn.Text = "Verify->";
            this.verifyBtn.UseVisualStyleBackColor = true;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 775);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.verifiedTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.removeTxt);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.jsonTxt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Filter Images";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox jsonTxt;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox removeTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox verifiedTxt;
        private System.Windows.Forms.Button verifyBtn;
    }
}

