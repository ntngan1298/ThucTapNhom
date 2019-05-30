using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TTNhom.Models.EF;
namespace TTNhom.DAO
{
    public class UserDao
    {
        NuocHoaDbContext db = null;
        public UserDao()
        {
            db = new NuocHoaDbContext();
        }
        public long Insert (TaiKhoan entity)
        {
            db.TaiKhoans.Add(entity);
            db.SaveChanges();
            return entity.userId;
        }
        public bool Login(string username, string password)
        {
            var result = db.TaiKhoans.Count(x => x.userName == username && x.password == password);
            if (result > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public TaiKhoan GetById(string userName)
        {
            return db.TaiKhoans.SingleOrDefault(x => x.userName == userName);
        }
        public bool Update (TaiKhoan entity)
        {
            try
            {
                var user = db.TaiKhoans.Find(entity.userId);
                user.userName = entity.userName;
                if (!string.IsNullOrEmpty(entity.password))
                {
                    user.password = entity.password;

                }
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public TaiKhoan ViewDetail(int id)
        {
            return db.TaiKhoans.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {

                var user = db.TaiKhoans.Find(id);
                db.TaiKhoans.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
    }
}