namespace EntityFrameWork_BaiTapLon.Migrations
{
    using Entities_BaiTapLon;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameWork_BaiTapLon.DataAcces.QLSVDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFrameWork_BaiTapLon.DataAcces.QLSVDatabaseContext context)
        {
            ///////////////////////////////////KHOA HOC//////////////////////
            var KH = new List<KhoaHoc>
            {
                new KhoaHoc { TCTThieu = 8, TCTDa = 20 },
                new KhoaHoc { TCTThieu = 10, TCTDa = 21 },
                new KhoaHoc { TCTThieu = 8, TCTDa = 17 },
            };
            KH.ForEach(kh => context.KhoaHocs.AddOrUpdate(a => a.TCTDa, kh));
            context.SaveChanges();
            ////////////////////////////////HOC KY//////////////////////////////
            var hk = new List<HocKy>
            {
                new HocKy { tenHocKy ="I" },
                new HocKy { tenHocKy ="II" },
                new HocKy { tenHocKy ="III" }
            };
            hk.ForEach(hk1 => context.HocKies.AddOrUpdate(a => a.tenHocKy, hk1));
            context.SaveChanges();
            ////////////////////////////////MON HOC /////////////////////////////
            var mh = new List<MonHoc>
            {
                new MonHoc {TenMonHoc ="Lap trinh WWW",Sotinchi=3 },
                new MonHoc {TenMonHoc ="Tu Tuong Nguoi May",Sotinchi=3 },
                new MonHoc {TenMonHoc ="Kien truc va thiet ke phan mem",Sotinchi=4 },
                new MonHoc {TenMonHoc ="Dam bao va kiem thu phan mem",Sotinchi=3 }
            };
            mh.ForEach(mh1 => context.MonHocs.AddOrUpdate(a => a.TenMonHoc, mh1));
            context.SaveChanges();
            /////////////////////////GIANG VIEN//////////////////////////////////////////

            var gv = new List<GiangVien>
            {
                new GiangVien {TenGiangVien="Thanh Van", ChuyenNganh ="KTMT", Diachi="2 Nguyen Van Bao", Email="Van@gmail.com", Gioitinh="Nu" ,Ngaysinh = DateTime.Parse("01-01-1989") },
                new GiangVien {TenGiangVien="Ngoc Tram", ChuyenNganh ="KTPM", Diachi="40 Le Lai", Email="TramNgoc@gmail.com", Gioitinh= "Nu",Ngaysinh = DateTime.Parse("03-03-1979") },
                new GiangVien {TenGiangVien="Hai Hoang", ChuyenNganh ="CNTT", Diachi="3 Le Loi", Email="Hoang@gmail.com", Gioitinh="Nam",Ngaysinh = DateTime.Parse("02-10-1980") }
            };
            gv.ForEach(gv1 => context.GiangViens.AddOrUpdate(a => a.TenGiangVien, gv1));
            context.SaveChanges();
            /////////////////////////// LOP HOC PHAN ////////////////////////////////////

            var lhp = new List<LopHocPhan>
            {
                new LopHocPhan {tenLopHocPhan="WWW01", Mota="Lap trinh WWW", NgayBD= DateTime.Parse("02-02-2020"),NgayKTDK= DateTime.Parse("12-02-2020"), NgayKT=DateTime.Parse("05-05-2020"), GiangVienid=2, Hockyid=2, soLuongSV=50,TrangThai="Danh Mo", MonHocId = 1},
                new LopHocPhan {tenLopHocPhan="WWW02", Mota="Lap trinh WWW", NgayBD= DateTime.Parse("02-02-2020"),NgayKTDK= DateTime.Parse("12-02-2020"), NgayKT=DateTime.Parse("05-05-2020"), GiangVienid=1, Hockyid=2, soLuongSV=50,TrangThai="Du so luong sv", MonHocId = 1},
                new LopHocPhan {tenLopHocPhan="TTNM01", Mota="Tuong Tac Nguoi May", NgayBD= DateTime.Parse("02-08-2020"),NgayKTDK= DateTime.Parse("12-08-2020"), NgayKT=DateTime.Parse("12-12-2020"), GiangVienid=3, Hockyid=1, soLuongSV=80,TrangThai="Danh Mo", MonHocId = 2},
                new LopHocPhan {tenLopHocPhan="TTNM02", Mota="Tuong Tac Nguoi May", NgayBD= DateTime.Parse("02-08-2020"),NgayKTDK= DateTime.Parse("12-08-2020"), NgayKT=DateTime.Parse("12-12-2020"), GiangVienid=3, Hockyid=1, soLuongSV=80,TrangThai="Danh Mo", MonHocId = 2},
                new LopHocPhan {tenLopHocPhan="Kientruc01", Mota="Kien Truc Va Thiet Ke Phan Mem", NgayBD= DateTime.Parse("02-02-2020"),NgayKTDK= DateTime.Parse("12-02-2020"), NgayKT=DateTime.Parse("05-05-2020"), GiangVienid=2, Hockyid=2, soLuongSV=90,TrangThai="Danh Mo", MonHocId = 3},
                new LopHocPhan {tenLopHocPhan="Kientruc02", Mota="Kien Truc Va Thiet Ke Phan Mem", NgayBD= DateTime.Parse("02-02-2020"),NgayKTDK= DateTime.Parse("12-02-2020"), NgayKT=DateTime.Parse("05-05-2020"), GiangVienid=3, Hockyid=2, soLuongSV=90,TrangThai="Huy hoc phan", MonHocId = 3 },
                new LopHocPhan {tenLopHocPhan="Kientruc03", Mota="Kien Truc Va Thiet Ke Phan Mem", NgayBD= DateTime.Parse("02-08-2020"),NgayKTDK= DateTime.Parse("12-08-2020"), NgayKT=DateTime.Parse("12-12-2020"), GiangVienid=3, Hockyid=1, soLuongSV=90,TrangThai="Danh Mo", MonHocId = 3},
                new LopHocPhan {tenLopHocPhan="DBKT01", Mota="Dam Bao Va Kiem Thu Phan Mem", NgayBD= DateTime.Parse("02-02-2020"),NgayKTDK= DateTime.Parse("12-02-2020"), NgayKT=DateTime.Parse("05-05-2020"), GiangVienid=1, Hockyid=2, soLuongSV=40,TrangThai="Danh Mo", MonHocId = 4}
            };
            lhp.ForEach(lhp1 => context.LopHocPhans.AddOrUpdate(a => a.tenLopHocPhan, lhp1));
            context.SaveChanges();
            /////////////////////////////////SINH VIEN////////////////////////////////////

            var sv = new List<SinhVien>
            {
                new SinhVien { tenSinhVien = "Thanh Nghia", ChuyenNganh="KTPM", Gioitinh="Nam", Diachi ="3 Hoang Hoa Tham", soDienThoai="09256263366", Ngaysinh=DateTime.Parse("01-10-1999"), BacDT="Dai Hoc", KhoaHocID=1 },
                new SinhVien { tenSinhVien = "Hoanh Anh", ChuyenNganh="CNTT", Gioitinh="Nu", Diachi ="35 Hai Ba Trung", soDienThoai="09745454526", Ngaysinh=DateTime.Parse("01-05-1999"), BacDT="Dai Hoc", KhoaHocID=1 },
                new SinhVien { tenSinhVien = "Hoai Sa", ChuyenNganh="HTMT", Gioitinh="Nam", Diachi ="100 Do Son", soDienThoai="09223243346", Ngaysinh=DateTime.Parse("12-11-1998"), BacDT="Cao Dang", KhoaHocID=2 },
                new SinhVien { tenSinhVien = "Truong An", ChuyenNganh="HTMT", Gioitinh="Nam", Diachi ="23 Thanh Tinh", soDienThoai="0935628946", Ngaysinh=DateTime.Parse("01-11-2000"), BacDT="Cao Dang", KhoaHocID=1 }
            };
            sv.ForEach(sv1 => context.SinhViens.AddOrUpdate(a => a.tenSinhVien, sv1));
            context.SaveChanges();
            //////////////////////////////////// KET QUA HOC TAP///////////////////////////

            var kqht = new List<KetQuaHocTap>
            {
                new KetQuaHocTap {LopHocPhanId= 1, SinhVienId=1, ThuongKy= 9.0, GiuaKy= 7.5, CuoiKy= 8.0 },
                new KetQuaHocTap {LopHocPhanId= 6, SinhVienId=1, ThuongKy= 9.0, GiuaKy= 9.5, CuoiKy= 8.75 },
                new KetQuaHocTap {LopHocPhanId= 1, SinhVienId=2, ThuongKy= 9.0, GiuaKy= 7.5, CuoiKy= 8.0 },
                new KetQuaHocTap {LopHocPhanId= 3, SinhVienId=2, ThuongKy= 4.3, GiuaKy= 7.5, CuoiKy= 6.0 },
                new KetQuaHocTap {LopHocPhanId= 5, SinhVienId=2, ThuongKy= 7.3, GiuaKy= 5.0, CuoiKy= 6.5 },
                new KetQuaHocTap {LopHocPhanId= 1, SinhVienId=3, ThuongKy= 8.3, GiuaKy= 6.5, CuoiKy= 6.9 },
                new KetQuaHocTap {LopHocPhanId= 3, SinhVienId=3, ThuongKy= 5.3, GiuaKy= 5.5, CuoiKy= 5.9 },
                new KetQuaHocTap {LopHocPhanId= 8, SinhVienId=3, ThuongKy= 7.0, GiuaKy= 8.75, CuoiKy= 6.0 },
                new KetQuaHocTap {LopHocPhanId= 2, SinhVienId=4, ThuongKy= 8.3, GiuaKy= 6.5, CuoiKy= 6.9 },
            };

            kqht.ForEach(kqht1 => context.KetQuaHocTaps.AddOrUpdate(a => a.ThuongKy, kqht1));
            context.SaveChanges();

            //////////////////////////////////// Diem Danh ////////////////////////////////

            var dd = new List<DiemDanh>
            {
                new DiemDanh { kqhtID=1 , tragthai="Co mat",ngayDD = DateTime.Parse("03-01-2020") },
                new DiemDanh { kqhtID=1 , tragthai="Co mat",ngayDD = DateTime.Parse("03-08-2020") },
                new DiemDanh { kqhtID=1 , tragthai="Tre",ngayDD = DateTime.Parse("03-15-2020") },
                new DiemDanh { kqhtID=1 , tragthai="Co mat",ngayDD = DateTime.Parse("03-22-2020") },
                new DiemDanh { kqhtID=1 , tragthai="Co mat",ngayDD = DateTime.Parse("03-29-2020") },
                new DiemDanh { kqhtID=2 , tragthai="Co mat",ngayDD = DateTime.Parse("03-03-2020") },
                new DiemDanh { kqhtID=2 , tragthai="Tre",ngayDD = DateTime.Parse("03-10-2020") },
                new DiemDanh { kqhtID=2 , tragthai="Co mat",ngayDD = DateTime.Parse("03-17-2020") },
                new DiemDanh { kqhtID=3 , tragthai="Co mat",ngayDD = DateTime.Parse("02-10-2020") },
                new DiemDanh { kqhtID=3 , tragthai="Tre",ngayDD = DateTime.Parse("03-23-2020") },
                new DiemDanh { kqhtID=3 , tragthai="Co mat",ngayDD = DateTime.Parse("03-20-2020") },
            };
            dd.ForEach(dd1 => context.DiemDanhs.AddOrUpdate(a => a.tragthai, dd1));
            context.SaveChanges();

        }
    }
}

