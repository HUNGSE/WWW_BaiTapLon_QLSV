using EntityFrameWork_BaiTapLon.Entities_BaiTapLon;
using Repository_BaiTapLon;
using Services_Interface_BaiTapLon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Services_BaiTapLon
{
    public class KetQuaHocTapService : IKetquahoctapService
    {
        private IQSinhVienRepository<KetQuaHocTap> ketquahoctaprepository;
        public KetQuaHocTapService()
        {
            ketquahoctaprepository = new QLSinhVienRepository<KetQuaHocTap>();
        }
        public KetQuaHocTap Add(KetQuaHocTap kqht)
        {
            return ketquahoctaprepository.Add(kqht);
        }

        public bool delete(int KqhtId)
        {
            try
            {
                ketquahoctaprepository.Delete(KqhtId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<KetQuaHocTap> GetAll()
        {
            return ketquahoctaprepository.GetByWhere(s => true);
        }

        public KetQuaHocTap getById(object id)
        {
            return ketquahoctaprepository.GetById(id);
        }

        public KetQuaHocTap Update(KetQuaHocTap kqht)
        {
            var exting = ketquahoctaprepository.GetById(kqht.SinhVienId);
            if (exting != null)
            {
                exting.LoaiDiem = kqht.LoaiDiem;
                exting.LopHocPhanId = kqht.LopHocPhanId;
                ketquahoctaprepository.Update(exting);
            }
            return null;
        }
    }
}
