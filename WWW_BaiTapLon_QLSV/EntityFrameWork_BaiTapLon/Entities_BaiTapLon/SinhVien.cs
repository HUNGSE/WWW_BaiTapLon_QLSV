using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_BaiTapLon.Entities_BaiTapLon
{
    public class SinhVien
    {
        public int SinhVienId { get; set; }
        public string tenSinhVien { get; set; }
        public string Gioitinh { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public string ChuyenNganh { get; set; }
        public string BacDT { get; set; }

        public string soDienThoai { get; set; }

        public virtual List<KetQuaHocTap> KetQuaHocTaps { get; set; }
        public int KhoaHocID { get; set; }
        public virtual KhoaHoc KhoaHoc { get; set; }
    }
}
