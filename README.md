# TourDulich
Prerequisites

Before you continue, ensure you meet the following requirements:

* You have installed the lastest version of .Net.
* You are using a Windows machine. MacOS or Linux is not currently supported.

### Cách cài đặt DB:

1. Thay đổi giá trị Data Source trong file Context.cs ở project DAL thành tên server trên máy.

2. Vào menu Tools --> Nuget Package Manager --> Package Manager Console.

3. Gõ "Enable-Migrations" vào cửa sổ console, tiếp đến gõ "Update-Database". Kiểm tra db trong CSDL.
