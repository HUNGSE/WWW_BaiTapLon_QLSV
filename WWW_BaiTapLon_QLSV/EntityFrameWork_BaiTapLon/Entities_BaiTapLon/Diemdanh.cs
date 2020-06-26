using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_BaiTapLon.Entities_BaiTapLon
{
    public class Diemdanh
    {
        [Column(Order = 2)]
        public virtual int LopHocPhanId { get; set; }
        [Column(Order = 1)]
        public virtual int SinhVienId { get; set; }
        public string trangthai { get; set; }
        public virtual DateTime ngayDD { get; set; }
        [Key]
         public int KqHTid { get; set; }
    }
}
