using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TTNhom.Models.EF;
namespace TTNhom.Areas.Admin.Models
{
    public class NhanHieuModel
    {
        private NuocHoaDbContext context =null;
        public NhanHieuModel()
        {
            context = new NuocHoaDbContext();

        }
        public List<NhanHieu> ListAll()
        {
            var list = context.Database.SqlQuery<NhanHieu>("Xem_NH").ToList();
            return list; 
        }
    }
}