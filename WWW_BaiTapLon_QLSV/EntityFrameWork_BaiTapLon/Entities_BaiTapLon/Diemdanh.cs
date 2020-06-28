using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_BaiTapLon.Entities_BaiTapLon
{
    public class DiemDanh
    {
        [Column(Order = 1)]
        public int SinhVienId { get; set; }

        [Column(Order = 2)]
        public int LopHocPhanId { get; set; }
        [Key]
        public virtual int idDD { get; set; }
        public DateTime ngayDD { get; set; }
        public string Trgthai { get; set; }
        public virtual KetQuaHocTap Ketquahoctap { get; set; } 
    }
}
