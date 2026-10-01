# ThucTapCoSoNganh111

Ứng dụng Windows Forms viết bằng C# dùng để quản lý sinh viên và các nghiệp vụ liên quan trong môi trường đào tạo: khoa, lớp, cố vấn học tập, môn học, lớp học phần, đăng ký môn, điểm và tài khoản người dùng.

## Tổng quan

Dự án sử dụng mô hình 3 lớp cơ bản:

- `GUI/`: các màn hình Windows Forms cho người dùng thao tác.
- `BLL/`: lớp xử lý nghiệp vụ, trung gian giữa giao diện và dữ liệu.
- `DAL/`: lớp truy xuất dữ liệu SQL Server và đọc dữ liệu Excel.

Điểm vào chương trình là `Program.cs`, ứng dụng khởi động bằng form đăng nhập `DangNhap`.

## Chức năng chính

- Đăng nhập hệ thống và phân loại tài khoản.
- Đổi mật khẩu người dùng.
- Quản lý sinh viên:
  - Thêm, sửa, xóa, tìm kiếm sinh viên.
  - Lưu thông tin lớp, khoa, cố vấn học tập, ảnh sinh viên.
  - Import danh sách sinh viên từ file Excel.
- Quản lý khoa.
- Quản lý lớp.
- Quản lý cố vấn học tập.
- Quản lý môn học.
- Quản lý lớp học phần.
- Đăng ký môn học cho sinh viên.
- Quản lý điểm theo lớp học phần.
- Quản lý tài khoản.
- Xem thông tin chi tiết tài khoản.

## Công nghệ sử dụng

- C# Windows Forms.
- .NET Framework 4.7.2.
- SQL Server / SQL Server Express.
- ADO.NET (`System.Data.SqlClient`).
- NuGet packages:
  - ClosedXML.
  - EPPlus.
  - ExcelDataReader.
  - DocumentFormat.OpenXml.
  - Các thư viện phụ trợ cho xử lý Excel và runtime binding.

## Cấu trúc thư mục

```text
.
├── BLL/                    # Business Logic Layer
├── DAL/                    # Data Access Layer
├── GUI/                    # Windows Forms UI
├── Properties/             # Resources, settings, assembly info
├── App.config              # Cấu hình runtime .NET Framework
├── Dayone.csproj           # File project C#
├── Dayone.sln              # Visual Studio solution
├── DataSinhVien.xlsx       # File Excel mẫu/dữ liệu sinh viên
├── HeThong.cs              # Biến trạng thái đăng nhập và hàm hash mật khẩu
├── Program.cs              # Entry point
├── packages.config         # Danh sách NuGet packages
└── README.md
```

## Yêu cầu môi trường

- Windows.
- Visual Studio 2019/2022 hoặc phiên bản hỗ trợ .NET Framework project.
- .NET Framework 4.7.2 Developer Pack.
- SQL Server hoặc SQL Server Express.
- NuGet package restore được bật trong Visual Studio.

## Cấu hình cơ sở dữ liệu

Chuỗi kết nối hiện được khai báo trực tiếp trong `DAL/DAL_KetNoi.cs`:

```csharp
Data Source=HUY-TIEN\SQLEXPRESS;Initial Catalog=QL_SVNEW1111;Integrated Security=True
```

Trước khi chạy trên máy khác, cần chỉnh lại:

- `Data Source`: tên SQL Server instance trên máy đang chạy.
- `Initial Catalog`: tên database quản lý sinh viên.
- `Integrated Security`: cấu hình xác thực Windows hoặc đổi sang user/password SQL Server nếu cần.

Ví dụ:

```csharp
Data Source=.\SQLEXPRESS;Initial Catalog=QL_SVNEW1111;Integrated Security=True
```

Dự án không kèm file script `.sql`, vì vậy cần tạo database và các bảng tương ứng trước khi chạy. Dựa theo mã nguồn, các bảng chính được sử dụng gồm:

- `TaiKhoan`
- `SinhVien`
- `Khoa`
- `Lop`
- `CoVanHocTap`
- `MonHoc`
- `LopHocPhan`
- `DangKyMon`
- `Diem`

## Cài đặt và chạy dự án

1. Clone hoặc tải mã nguồn về máy.
2. Mở `Dayone.sln` bằng Visual Studio.
3. Restore NuGet packages nếu Visual Studio chưa tự khôi phục.
4. Cài đặt/tạo database SQL Server và các bảng cần thiết.
5. Mở `DAL/DAL_KetNoi.cs` và chỉnh chuỗi kết nối phù hợp với máy đang chạy.
6. Build solution.
7. Chạy project bằng Start/F5 trong Visual Studio.
8. Đăng nhập bằng tài khoản có trong bảng `TaiKhoan`.

## Import sinh viên từ Excel

Dự án có chức năng đọc dữ liệu sinh viên từ Excel thông qua `ExcelDataReader`.

File Excel cần có hàng tiêu đề. Các cột đang được xử lý trong mã nguồn gồm:

| Cột | Ý nghĩa |
| --- | --- |
| `masv` | Mã sinh viên |
| `tensv` | Tên sinh viên |
| `ngaysinh` | Ngày sinh |
| `gioitinh` | Giới tính |
| `quequan` | Quê quán |
| `ngaynh` | Ngày nhập học |
| `malop` | Mã lớp |
| `makhoa` | Mã khoa |
| `macvht` | Mã cố vấn học tập |
| `anh` | Tên/đường dẫn ảnh |

File `DataSinhVien.xlsx` có thể được dùng làm dữ liệu mẫu hoặc tham khảo định dạng import.

## Ghi chú về tài khoản và mật khẩu

- Form đăng nhập kiểm tra tài khoản trong bảng `TaiKhoan`.
- Lớp `HeThong` có hàm hash SHA1, tuy nhiên việc lưu/kiểm tra mật khẩu phụ thuộc vào luồng xử lý hiện tại trong BLL/DAL.
- Khi tạo tài khoản hoặc đổi mật khẩu, cần đảm bảo dữ liệu mật khẩu trong database thống nhất với cách xử lý của ứng dụng.

## Một số file quan trọng

- `Program.cs`: khởi động ứng dụng và mở form đăng nhập.
- `GUI/DangNhap.cs`: xử lý đăng nhập.
- `GUI/SinhVien.cs`: màn hình chính và quản lý sinh viên.
- `DAL/DAL_KetNoi.cs`: cấu hình kết nối và các hàm query/non-query/scalar.
- `BLL/BLL_Excel.cs`: import sinh viên từ Excel vào database.
- `packages.config`: danh sách dependency NuGet.

## Lưu ý khi phát triển tiếp

- Nên chuyển chuỗi kết nối từ code sang `App.config` để dễ cấu hình theo môi trường.
- Nên bổ sung script tạo database và dữ liệu mẫu.
- Nên chuẩn hóa xử lý mật khẩu, tránh lưu mật khẩu dạng rõ nếu ứng dụng dùng thực tế.
- Nên gom các câu lệnh SQL, validate dữ liệu đầu vào và xử lý lỗi thống nhất hơn.
- Nên kiểm tra phân quyền tài khoản theo `LoaiTaiKhoan` để giới hạn chức năng phù hợp.
