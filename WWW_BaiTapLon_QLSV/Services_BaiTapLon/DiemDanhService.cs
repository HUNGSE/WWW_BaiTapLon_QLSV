using EntityFrameWork_BaiTapLon.Entities_BaiTapLon;
using Repository_BaiTapLon;
using Services_Interface_BaiTapLon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services_BaiTapLon
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DiemDanhService1" in both code and config file together.
    public class DiemDanhService : IDiemDanhService
    {
        private IQSinhVienRepository<Diemdanh> diemdanhrepository;

        public DiemDanhService()
        {
            diemdanhrepository = new QLSinhVienRepository<Diemdanh>();
        }
        public Diemdanh Add(Diemdanh dd)
        {
            return diemdanhrepository.Add(dd);
        }

        public bool delete(int KqhtId)
        {
            try
            {
                diemdanhrepository.Delete(KqhtId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Diemdanh> GetAll()
        {
            return diemdanhrepository.GetByWhere(s => true);
        }
        public IEnumerable<Diemdanh> getbyidSV(int Idsv)
        {
            return diemdanhrepository.GetByWhere(s => s.SinhVienId == Idsv);
        }
        public Diemdanh getById(object id)
        {
            throw new NotImplementedException();
        }
    }
}
