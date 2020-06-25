using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_BaiTapLon.Entities_BaiTapLon
{
    public class GiangVien
    {
        public int GiangVienid { get; set; }
        public string TenGiangVien { get; set; }
        public string Gioitinh { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public string ChuyenNganh { get; set; }
        public virtual List<LopHocPhan> LopHocPhans { get; set; }
    }
}
