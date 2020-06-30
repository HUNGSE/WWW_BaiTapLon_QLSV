namespace EntityFrameWork_BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QLSV : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiemDanhs",
                c => new
                    {
                        kqhtID = c.Int(nullable: false),
                        ngayDD = c.DateTime(nullable: false),
                        tragthai = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.kqhtID, t.ngayDD })
                .ForeignKey("dbo.KetQuaHocTaps", t => t.kqhtID, cascadeDelete: true)
                .Index(t => t.kqhtID);
            
            CreateTable(
                "dbo.KetQuaHocTaps",
                c => new
                    {
                        kqhtID = c.Int(nullable: false, identity: true),
                        ThuongKy = c.Double(nullable: false),
                        GiuaKy = c.Double(nullable: false),
                        CuoiKy = c.Double(nullable: false),
                        SinhVienId = c.Int(nullable: false),
                        LopHocPhanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.kqhtID)
                .ForeignKey("dbo.LopHocPhans", t => t.LopHocPhanId, cascadeDelete: true)
                .ForeignKey("dbo.SinhViens", t => t.SinhVienId, cascadeDelete: true)
                .Index(t => t.SinhVienId)
                .Index(t => t.LopHocPhanId);
            
            CreateTable(
                "dbo.LopHocPhans",
                c => new
                    {
                        LopHocPhanId = c.Int(nullable: false, identity: true),
                        tenLopHocPhan = c.String(nullable: false),
                        MonHocId = c.Int(nullable: false),
                        soLuongSV = c.Int(nullable: false),
                        TrangThai = c.Int(nullable: false),
                        Mota = c.String(),
                        NgayBD = c.DateTime(nullable: false),
                        NgayKTDK = c.DateTime(nullable: false),
                        NgayKT = c.DateTime(nullable: false),
                        Hockyid = c.Int(nullable: false),
                        GiangVienid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LopHocPhanId)
                .ForeignKey("dbo.GiangViens", t => t.GiangVienid, cascadeDelete: true)
                .ForeignKey("dbo.HocKies", t => t.Hockyid, cascadeDelete: true)
                .ForeignKey("dbo.MonHocs", t => t.MonHocId, cascadeDelete: true)
                .Index(t => t.MonHocId)
                .Index(t => t.Hockyid)
                .Index(t => t.GiangVienid);
            
            CreateTable(
                "dbo.GiangViens",
                c => new
                    {
                        GiangVienid = c.Int(nullable: false, identity: true),
                        TenGiangVien = c.String(nullable: false),
                        Gioitinh = c.Int(nullable: false),
                        Ngaysinh = c.DateTime(nullable: false),
                        Diachi = c.String(nullable: false),
                        Email = c.String(),
                        ChuyenNganh = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GiangVienid);
            
            CreateTable(
                "dbo.HocKies",
                c => new
                    {
                        Hockyid = c.Int(nullable: false, identity: true),
                        tenHocKy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Hockyid);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        MonhocId = c.Int(nullable: false, identity: true),
                        TenMonHoc = c.String(nullable: false),
                        Sotinchi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MonhocId);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        SinhVienId = c.Int(nullable: false, identity: true),
                        tenSinhVien = c.String(nullable: false),
                        Gioitinh = c.Int(nullable: false),
                        Ngaysinh = c.DateTime(nullable: false),
                        Diachi = c.String(nullable: false),
                        ChuyenNganh = c.String(nullable: false),
                        BacDT = c.String(nullable: false),
                        soDienThoai = c.String(),
                        KhoaHocID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SinhVienId)
                .ForeignKey("dbo.KhoaHocs", t => t.KhoaHocID, cascadeDelete: true)
                .Index(t => t.KhoaHocID);
            
            CreateTable(
                "dbo.KhoaHocs",
                c => new
                    {
                        KhoaHocID = c.Int(nullable: false, identity: true),
                        TCTThieu = c.Int(nullable: false),
                        TCTDa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KhoaHocID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DiemDanhs", "kqhtID", "dbo.KetQuaHocTaps");
            DropForeignKey("dbo.SinhViens", "KhoaHocID", "dbo.KhoaHocs");
            DropForeignKey("dbo.KetQuaHocTaps", "SinhVienId", "dbo.SinhViens");
            DropForeignKey("dbo.LopHocPhans", "MonHocId", "dbo.MonHocs");
            DropForeignKey("dbo.KetQuaHocTaps", "LopHocPhanId", "dbo.LopHocPhans");
            DropForeignKey("dbo.LopHocPhans", "Hockyid", "dbo.HocKies");
            DropForeignKey("dbo.LopHocPhans", "GiangVienid", "dbo.GiangViens");
            DropIndex("dbo.SinhViens", new[] { "KhoaHocID" });
            DropIndex("dbo.LopHocPhans", new[] { "GiangVienid" });
            DropIndex("dbo.LopHocPhans", new[] { "Hockyid" });
            DropIndex("dbo.LopHocPhans", new[] { "MonHocId" });
            DropIndex("dbo.KetQuaHocTaps", new[] { "LopHocPhanId" });
            DropIndex("dbo.KetQuaHocTaps", new[] { "SinhVienId" });
            DropIndex("dbo.DiemDanhs", new[] { "kqhtID" });
            DropTable("dbo.KhoaHocs");
            DropTable("dbo.SinhViens");
            DropTable("dbo.MonHocs");
            DropTable("dbo.HocKies");
            DropTable("dbo.GiangViens");
            DropTable("dbo.LopHocPhans");
            DropTable("dbo.KetQuaHocTaps");
            DropTable("dbo.DiemDanhs");
        }
    }
}
