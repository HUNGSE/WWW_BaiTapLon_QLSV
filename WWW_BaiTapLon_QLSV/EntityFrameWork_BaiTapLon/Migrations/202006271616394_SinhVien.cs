namespace EntityFrameWork_BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SinhVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiemDanhs",
                c => new
                    {
                        SinhVienId = c.Int(nullable: false),
                        LopHocPhanId = c.Int(nullable: false),
                        idDD = c.Int(nullable: false, identity: true),
                        ngayDD = c.DateTime(nullable: false),
                        Trgthai = c.String(),
                    })
                .PrimaryKey(t => t.idDD)
                .ForeignKey("dbo.KetQuaHocTaps", t => new { t.SinhVienId, t.LopHocPhanId }, cascadeDelete: true)
                .Index(t => new { t.SinhVienId, t.LopHocPhanId });
            
            CreateTable(
                "dbo.KetQuaHocTaps",
                c => new
                    {
                        SinhVienId = c.Int(nullable: false),
                        LopHocPhanId = c.Int(nullable: false),
                        LoaiDiem = c.Int(nullable: false),
                        idDD = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SinhVienId, t.LopHocPhanId })
                .ForeignKey("dbo.LopHocPhans", t => t.LopHocPhanId, cascadeDelete: true)
                .ForeignKey("dbo.SinhViens", t => t.SinhVienId, cascadeDelete: true)
                .Index(t => t.SinhVienId)
                .Index(t => t.LopHocPhanId);
            
            CreateTable(
                "dbo.LopHocPhans",
                c => new
                    {
                        LopHocPhanId = c.Int(nullable: false, identity: true),
                        tenLopHocPhan = c.String(),
                        MonHocId = c.Int(nullable: false),
                        soLuongSV = c.Int(nullable: false),
                        TrangThai = c.String(),
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
                        TenGiangVien = c.String(),
                        Gioitinh = c.String(),
                        Ngaysinh = c.DateTime(nullable: false),
                        Diachi = c.String(),
                        Email = c.String(),
                        ChuyenNganh = c.String(),
                    })
                .PrimaryKey(t => t.GiangVienid);
            
            CreateTable(
                "dbo.HocKies",
                c => new
                    {
                        Hockyid = c.Int(nullable: false, identity: true),
                        tenHocKy = c.String(),
                    })
                .PrimaryKey(t => t.Hockyid);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        MonhocId = c.Int(nullable: false, identity: true),
                        TenMonHoc = c.String(),
                        Sotinchi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MonhocId);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        SinhVienId = c.Int(nullable: false, identity: true),
                        tenSinhVien = c.String(),
                        Gioitinh = c.String(),
                        Ngaysinh = c.DateTime(nullable: false),
                        Diachi = c.String(),
                        ChuyenNganh = c.String(),
                        BacDT = c.String(),
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
            DropForeignKey("dbo.DiemDanhs", new[] { "SinhVienId", "LopHocPhanId" }, "dbo.KetQuaHocTaps");
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
            DropIndex("dbo.DiemDanhs", new[] { "SinhVienId", "LopHocPhanId" });
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
