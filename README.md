# Image Filter Application
![image](https://github.com/user-attachments/assets/a4a3d274-8dd0-4124-980d-087b28f314c7)

## Overview
This is a Windows Forms application developed in C# that allows users to filter and categorize image files (.jpg) into "verified" and "removed" groups. The application helps users quickly process large batches of images by facilitating easy reviewing and sorting with keyboard shortcuts. It is commonly used for manually filtering and cleaning image datasets for machine learning projects.

## Features
- Load images from a specified folder
- View images one by one in a convenient viewer
- Categorize images as "verified" or "removed" using keyboard shortcuts or buttons
- Save categorization progress to a JSON file for later continuation
- Resume previous categorization sessions
- Display counters for verified and removed images
- Auto-resize images to fit the display area

## Installation
1. Go to the GitHub repository's "Releases" section
2. Download the latest ZIP file from the releases
3. Extract the ZIP file to your preferred location on your computer
4. Run the application by double-clicking the executable file (*.exe)

## How to Use
1. Enter the path to the folder containing your images in the first text box
2. Enter the path to a JSON file (new or existing) to save your progress in the second text box
3. Click "Start" to begin the image filtering process
4. For each image, choose to:
   - Keep the image (press Right or Up arrow key, or click "Verify")
   - Discard the image (press Left or Down arrow key, or click "Remove")
5. Click "Save" at any time to save your progress
6. Continue until all images are processed

## Keyboard Shortcuts
- **Right Arrow** or **Up Arrow**: Mark the current image as "verified"
- **Left Arrow** or **Down Arrow**: Mark the current image as "removed"

## Requirements
- .NET Framework
- Windows operating system
- System.Text.Json for JSON serialization

## Implementation Details
The application maintains two lists:
- `verifiedList`: Contains filenames of images marked as verified
- `removedList`: Contains filenames of images marked as removed

These lists are saved to a JSON file with the structure:
```json
{
  "verified": ["image1.jpg", "image2.jpg", ...],
  "removed": ["image3.jpg", "image4.jpg", ...]
}
```

---

# Ứng dụng Lọc Ảnh

## Tổng quan
Đây là ứng dụng Windows Forms được phát triển bằng C# cho phép người dùng lọc và phân loại các tệp ảnh (.jpg) thành các nhóm "đã xác minh" và "đã loại bỏ". Ứng dụng giúp người dùng xử lý nhanh chóng số lượng lớn ảnh bằng cách tạo điều kiện xem xét và phân loại dễ dàng với các phím tắt. Ứng dụng thường được sử dụng để lọc thủ công bộ dữ liệu (dataset) phục vụ cho các dự án học máy (machine learning).Ứng dụng thường được sử dụng để lọc thủ công bộ dữ liệu (dataset) phục vụ cho các dự án học máy (machine learning).

## Tính năng
- Tải ảnh từ thư mục được chỉ định
- Xem ảnh lần lượt trong trình xem thuận tiện
- Phân loại ảnh là "đã xác minh" hoặc "đã loại bỏ" bằng phím tắt hoặc nút bấm
- Lưu tiến trình phân loại vào file JSON để tiếp tục sau này
- Tiếp tục các phiên phân loại trước đó
- Hiển thị số lượng ảnh đã xác minh và đã loại bỏ
- Tự động điều chỉnh kích thước ảnh cho vừa với khu vực hiển thị

## Cài đặt
1. Đi đến phần "Releases" của repository GitHub
2. Tải về tệp ZIP mới nhất từ phần releases
3. Giải nén tệp ZIP đến vị trí bạn muốn trên máy tính
4. Chạy ứng dụng bằng cách nhấp đúp vào tệp thực thi (*.exe)

## Cách sử dụng
1. Nhập đường dẫn đến thư mục chứa ảnh vào ô văn bản đầu tiên
2. Nhập đường dẫn đến file JSON (mới hoặc có sẵn) để lưu tiến trình vào ô văn bản thứ hai
3. Nhấp "Start" để bắt đầu quá trình lọc ảnh
4. Đối với mỗi ảnh, chọn:
   - Giữ lại ảnh (nhấn phím mũi tên Phải hoặc Lên, hoặc nhấp "Verify")
   - Loại bỏ ảnh (nhấn phím mũi tên Trái hoặc Xuống, hoặc nhấp "Remove")
5. Nhấp "Save" bất cứ lúc nào để lưu tiến trình
6. Tiếp tục cho đến khi tất cả ảnh được xử lý

## Phím tắt
- **Mũi tên Phải** hoặc **Mũi tên Lên**: Đánh dấu ảnh hiện tại là "đã xác minh"
- **Mũi tên Trái** hoặc **Mũi tên Xuống**: Đánh dấu ảnh hiện tại là "đã loại bỏ"

## Yêu cầu
- .NET Framework
- Hệ điều hành Windows
- System.Text.Json để tuần tự hóa JSON

## Chi tiết triển khai
Ứng dụng duy trì hai danh sách:
- `verifiedList`: Chứa tên tệp của ảnh được đánh dấu là đã xác minh
- `removedList`: Chứa tên tệp của ảnh được đánh dấu là đã loại bỏ

Các danh sách này được lưu vào tệp JSON với cấu trúc:
```json
{
  "verified": ["image1.jpg", "image2.jpg", ...],
  "removed": ["image3.jpg", "image4.jpg", ...]
}
```
