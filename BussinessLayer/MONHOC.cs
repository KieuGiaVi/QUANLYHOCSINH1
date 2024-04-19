using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BussinessLayer
{
    public class MONHOC
    {
        QUANLYHOCSINHEntities8 db = null;
        public MONHOC()
        {
            db = new QUANLYHOCSINHEntities8();
        }
        public tb_MonHoc getItem(int mamh)
        {
            return db.tb_MonHoc.FirstOrDefault(x => x.MaMH == mamh);
        }
        public List<tb_MonHoc> getList()
        {
            return db.tb_MonHoc.ToList();
        }
        public tb_MonHoc Add(tb_MonHoc mh)
        {
            try
            {
                db.tb_MonHoc.Add(mh);
                db.SaveChanges();
                return mh;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_MonHoc Update(tb_MonHoc mh)
        {
            try
            {
                var _mh = db.tb_MonHoc.FirstOrDefault(x => x.MaMH == mh.MaMH);
                _mh.TenMH = mh.TenMH;
                _mh.SoTiet = mh.SoTiet;
                _mh.HeSo = mh.HeSo;
              
                _mh.Updated_By = mh.Updated_By;
                _mh.Updated_Date = mh.Updated_Date;

                db.SaveChanges();
                return mh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete (int mamh, int UserID)
        {
            try
            {
                var _mh = db.tb_MonHoc.FirstOrDefault(x => x.MaMH == mamh);
                _mh.Deleted_By = UserID;
                _mh.Deleted_Date = DateTime.Now;
                db.SaveChanges();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
