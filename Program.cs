// See https://aka.ms/new-console-template for more information
using Generic.Model;
using Generic.Service;

Console.WriteLine("Hello, World!");


NhanVienService _nhanVienService = new NhanVienService();
_nhanVienService.Add(new Generic.Model.NhanVien(){
    Ten = "Messi",
    NgaySinh = DateTime.Parse("1993-09-18"),
    ChucVu = "Da penalty"
});
_nhanVienService.Add(new Generic.Model.NhanVien(){
    Ten = "Ronaldo",
    NgaySinh = DateTime.Parse("1993-09-18"),
    ChucVu = "That nghiep"
});

_nhanVienService.Add(new Generic.Model.NhanVien(){
    Ten = "Neymar",
    NgaySinh = DateTime.Parse("1993-09-18"),
    ChucVu = "Dien vien"
});

_nhanVienService.Add(new Generic.Model.NhanVien(){
    Ten = "Nunez",
    NgaySinh = DateTime.Parse("1993-09-18"),
    ChucVu = "Chuyen hoa ban thang thanh co hoi"
});



_nhanVienService.Add(new Generic.Model.NhanVien(){
    Ten = "Maguire",
    NgaySinh = DateTime.Parse("1993-09-18"),
    ChucVu = "Dien vien hai"
});
/* Nunez - Chuyen hoa ban thang thanh co hoi
   Ronaldo - That nghiep
   ...
   */



var _nhanVienArr = _nhanVienService._data;


foreach(var item in _nhanVienArr){
    Console.WriteLine(item.Ten + " - " + item.ChucVu);
}
Console.WriteLine("==================================================");

// var _nvCoTenChuCaiE = _nhanVienService.FilterNameWithCharactor("a");
// foreach(var item in _nvCoTenChuCaiE){
//     Console.WriteLine(item.Ten + " - " + item.ChucVu);
// }

var _nvCoTenChuCaiInterator = _nhanVienService.FilterNameWithCharactorInterator("a");
foreach(var item in _nvCoTenChuCaiInterator){
    Console.WriteLine(item.Ten + " - " + item.ChucVu);

    
}
// var timKiemTheoTen = _nhanVienService.Filter("Huy");
// var timKiemTheoNgayThang = _nhanVienService.Filter(DateTime.Now);
// var timKiemLuong = _nhanVienService.Filter(1000000);


// PhongBanService _phongBanService = new PhongBanService();


// NganhNgheService _nganhNgheService = new NganhNgheService();
// _nganhNgheService.Add(new NganhNghe(){
//     Ten = "CNTT",
//     Code = "AABBCC",
//     PhanTramVAT = 10

// });

// _nganhNgheService.Add(new NganhNghe(){
//     Ten = "Am nhac",
//     Code = "AN",
//     PhanTramVAT = 5

// });

// _phongBanService.Add(new PhongBan(){
//     Ten = "Phong Tester",
//     SoNhanVien = 10,
//     CoSo = "Doi Can"
// });

// Console.WriteLine("TRuoc khi delete");
// var _resultNganhNghe = _nganhNgheService.GetAll();
// foreach(var item in _resultNganhNghe){
//     Console.WriteLine(item.Id +" - " + item.Ten + " - " + item.Code + " - " + item.PhanTramVAT);
// }

// Console.WriteLine("====================================");
// Console.WriteLine("Nhap Id can xoa");
// _nganhNgheService.Delete(int.Parse(Console.ReadLine()));
// foreach(var item in _resultNganhNghe){
//     Console.WriteLine(item.Id +" - " + item.Ten + " - " + item.Code + " - " + item.PhanTramVAT);
// }

