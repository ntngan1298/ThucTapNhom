using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TTNhom.Models.EF;
namespace TTNhom.DAO
{
    public class SPDao
    {
        NuocHoaDbContext db = null;
        public SPDao()
        {
            db = new NuocHoaDbContext();

        }
        public long Insert(SP entity)
        {
            db.SPs.Add(entity);
            db.SaveChanges();
            return entity.MaSP;
        }
    }
}