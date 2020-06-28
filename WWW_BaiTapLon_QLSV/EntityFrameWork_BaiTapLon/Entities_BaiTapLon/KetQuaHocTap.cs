using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_BaiTapLon.Entities_BaiTapLon
{
    public class KetQuaHocTap
    {
        public int LoaiDiem { get; set; }
        [Key]
        [Column(Order = 1)]
        public int SinhVienId { get; set; }
        public virtual SinhVien SinhVien { get; set; }
        [Key]
        [Column(Order = 2)]
        public int LopHocPhanId { get; set; }
        public virtual LopHocPhan LopHocPhan { get; set; }
        public virtual  int idDD {get; set;}
      
    }
}
