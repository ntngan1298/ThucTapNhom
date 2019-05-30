using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TTNhom.Models.EF;
namespace TTNhom.DAO
{
    public class NhanVienDao
    {
        NuocHoaDbContext db = null;
        public NhanVienDao()
        {
            db = new NuocHoaDbContext();

        }
        public long Insert(NhanVien entity)
        {
            db.NhanViens.Add(entity);
            db.SaveChanges();
            return entity.MaNV;
        }

        public bool Update(NhanVien entity)
        {
            try
            {
                var user = db.NhanViens.Find(entity);
                if (!string.IsNullOrEmpty(entity.HoTen))
                {
                    user.HoTen = entity.HoTen;
                }
                user.SDT = entity.SDT;
                user.GT = entity.GT;
                user.DiaChi = entity.DiaChi;
                db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}