
# MÔN PHÁT TRIỂN ỨNG DỤNG WEB (24C1INF50901401)

## Tên đề tài: Xây dựng trang web bán hàng - MU Store

### Mô tả và mục tiêu dự án

#### Mô tả:
**Website MU Store** được xây dựng bằng C# kết hợp với mô hình ASP.NET MVC, hỗ trợ quản lý cửa hàng bán điện thoại với các chức năng:
- Thêm, xóa, sửa sản phẩm.
- Chức năng tìm kiếm và thống kê.
- Giỏ hàng cho phép khách hàng lựa chọn sản phẩm và thanh toán.
- Phân quyền giữa Admin, Nhân viên giao hàng và User.
  - **Admin**: Quản trị toàn bộ hệ thống và quản lý các sản phẩm, đơn hàng.
  - **Nhân viên giao hàng**: Quản trị một phần hệ thống và quản lý các đơn hàng.
  - **User**: Xem sản phẩm, các trang thông tin và thực hiện mua hàng.

#### MỤC TIÊU:
Xây dựng website bán hàng đáp ứng nhu cầu quản lý và mua sắm trực tuyến, giúp khách hàng dễ dàng tìm kiếm và lựa chọn sản phẩm, tiết kiệm thời gian và chi phí.

### TÁC GIẢ:

- Trần Nhật Khánh - Tác giả chính: [GitHub](https://github.com/tnKiness)
- Nguyễn Phụng Châu - Đồng tác giả: [GitHub](https://github.com/j1mmyhvstle)
- Lê Lộc Sơn - Đồng tác giả: [GitHub](https://github.com/SonLocLe)
- Đinh Duy Thống- Đồng tác giả: [GitHub]()

### KIẾN THỨC ÁP DỤNG

- **Kiến trúc ASP.NET MVC**: Tổ chức code theo mô hình Model-View-Controller (MVC) để dễ dàng quản lý và mở rộng các thành phần của ứng dụng. Phân tách rõ ràng giữa phần hiển thị (Views), logic nghiệp vụ (Controllers), và dữ liệu (Models).
- **C# và MySQL**: Sử dụng C# để phát triển back-end và kết nối cơ sở dữ liệu MySQL, quản lý dữ liệu sản phẩm, người dùng và đơn hàng. Viết các truy vấn SQL để xử lý dữ liệu và thực hiện các thao tác CRUD (Create, Read, Update, Delete).
- **Xử lý dữ liệu người dùng**: Thực hiện phân quyền giữa Admin, Nhân viên giao hàng và User, trong đó Admin có thể quản lý sản phẩm, đơn hàng và người dùng; Nhân viên giao hàng có thể quản lý đơn hàng và thức hiện một số thao tác thống kê, còn User chỉ có thể xem sản phẩm và thực hiện mua hàng.
- **Front-end với HTML, CSS và JavaScript**: Tạo giao diện người dùng với HTML và CSS. Sử dụng JavaScript để cải thiện trải nghiệm người dùng, xử lý tương tác trên trang như thêm sản phẩm vào giỏ hàng hoặc tìm kiếm sản phẩm.
- **Quản lý giỏ hàng**: Tạo chức năng giỏ hàng cho phép khách hàng thêm, sửa, xóa các sản phẩm trước khi thanh toán.
- **Quản lý đơn hàng**: Xây dựng chức năng quản lý đơn hàng, theo dõi trạng thái và chi tiết đơn hàng cho từng khách hàng.
- **Tìm kiếm và thống kê**: Tạo chức năng tìm kiếm sản phẩm và thống kê các thông tin quan trọng, hỗ trợ quản lý hàng hóa.
- **Thiết kế trang Web**: Xây dựng bảng màu sắc, icon, lựa chọn các hiệu ứng sao cho đồng bộ.

### TRIỂN KHAI

#### Nền tảng xây dựng:

- **Front-end**: HTML, CSS, JavaScript
- **Back-end**: C# (theo mô hình ASP.NET MVC) với Models, Views, Controllers
- **Cơ sở dữ liệu**: MySQL (được cấu hình trên Hostinger để lưu trữ thông tin người dùng, sản phẩm, giỏ hàng, đơn hàng và các thông tin khác.)
- **Thư viện bổ sung**: Bootstrap (cho giao diện), jQuery (cho các thành phần động)
- **Hosting**: Website đã được triển khai trên … với domain: **tên domain**

#### Lý do chọn C#:

- **C#** là một ngôn ngữ lập trình mạnh mẽ được phát triển bởi Microsoft, thường được sử dụng trong các ứng dụng web và phần mềm doanh nghiệp. C# tích hợp tốt với .NET Framework, cho phép xây dựng các ứng dụng mạnh mẽ, an toàn và dễ bảo trì. C# còn hỗ trợ lập trình hướng đối tượng, cung cấp nhiều thư viện và framework sẵn có để phát triển ứng dụng một cách nhanh chóng và hiệu quả.

- **Ứng dụng trong dự án**: C# được sử dụng để xây dựng toàn bộ phần backend của trang web, xử lý các yêu cầu từ người dùng, thực hiện các thao tác với cơ sở dữ liệu, và điều khiển logic nghiệp vụ của hệ thống.

#### Lý do chọn MySQL:

- **MySQL** là hệ quản trị cơ sở dữ liệu phổ biến, mã nguồn mở và có tính ổn định cao. MySQL cung cấp nhiều tính năng hữu ích, cho phép quản lý dữ liệu hiệu quả, đặc biệt là trong các hệ thống quản lý sản phẩm và đơn hàng trực tuyến.
- **Ứng dụng trong dự án**: MySQL được sử dụng để lưu trữ thông tin người dùng, sản phẩm, giỏ hàng, và đơn hàng. Nó giúp thực hiện các thao tác truy xuất, thêm, sửa, xóa dữ liệu, đảm bảo các thông tin được lưu trữ và quản lý một cách an toàn.

#### Lý do chọn HTML, CSS, và JavaScript:

- **Lý do chọn**:
    HTML: được viết tắt của cụm từ Hypertext Markup Language là ngôn ngữ đánh dấu tiêu chuẩn để tạo cấu trúc trang web.
    CSS: viết tắt của Cascading Style Sheets được sử dụng để tạo kiểu và làm cho trang web thân thiện và hấp dẫn hơn về mặt thẩm mỹ.
    JavaScript: Được sử dụng để tạo các hiệu ứng động, giúp cải thiện trải nghiệm người dùng.
- **Ứng dụng trong dự án**: HTML xây dựng cấu trúc của trang web, CSS giúp tạo phong cách và bố cục hấp dẫn, trong khi JavaScript xử lý các thao tác tương tác trên trang như tìm kiếm sản phẩm, thêm sản phẩm vào giỏ hàng, và thực hiện các xác thực cơ bản.

### Tài Liệu Thiết Kế

[Xem Tại Đây](#)

### Tài liệu cho nhà phát triển

[Xem Tại Đây](#)

### Tài liệu cho người dùng cuối

[Xem Tại Đây](#)

### Đóng góp ý kiến

[Xem Tại Đây](#)

### Danh sách lỗi

- Một số hiệu ứng chưa được mượt
- Chưa cài các bảo mật chống DDOS như Cloudflare

### Hướng Phát triển trong tương lai
- Tăng cường bảo mật cho trang Web
- Cải tiến Responsive mượt mà hơn
- Kết nối API với VNPay để thanh toán trực tuyến
- Kết nối với các nhãn hiệu để đưa trang Web sử dụng thực tế

##
### LỜI CẢM ƠN
Chúng em xin chân thành cảm ơn thầy Nguyễn Mạnh Tuấn đã tận tình hướng dẫn và giúp đỡ trong suốt quá trình học tập và thực hiện đề tài.

