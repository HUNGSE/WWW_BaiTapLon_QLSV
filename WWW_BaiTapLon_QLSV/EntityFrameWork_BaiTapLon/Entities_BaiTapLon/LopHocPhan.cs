using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity.Migrations.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_BaiTapLon.Entities_BaiTapLon
{
    public class LopHocPhan
    {
        public int LopHocPhanId { get; set; }
        public string tenLopHocPhan { get; set; }
        public int MonHocId { get; set; }
        public int soLuongSV { get; set; }
        public string TrangThai { get; set; }
        public string Mota { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKTDK { get; set; }
        public DateTime NgayKT { get; set; }
        public virtual MonHoc MonHoc { get; set; }
        public int Hockyid { get; set; }
        public virtual HocKy HocKy { get; set; }
        public int GiangVienid { get; set; }
        public virtual GiangVien GiangVien { get; set; }
        public virtual List<KetQuaHocTap> KetQuaHocTaps { get; set; }
    }
}
