using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class StatisticManager : IStatisticService
    {
        private CategoryManager cm = new CategoryManager(new EfCategoryDal());
        private HeadingManager hm = new HeadingManager(new EfHeadingDal());
        private WriterManager wm = new WriterManager(new EfWriterDal());
                  
        public string categoryName()
        {
            var a = hm.GetList().Max(e => e.CategoryID);
            if (a == 12)
            {
                return "Yazılım";
            }
            return "null";
        }

        public int charWriter()
        {
            var h = wm.GetList();
            var deger = from s in h
                        where s.WriterName.Contains("A")
                        select s;
            int count = deger.ToList().Count;
            return count;
        }

        public int findTitle()
        {
            var h = hm.GetList();
            int count = h.Where(x => x.CategoryID == 12).ToList().Count;
            return count;
        }

        public int getCount()
        {
            var categoryCount = cm.GetList().Count;
            return categoryCount;
        }

        public int trueFalse()
        {
            var ct = cm.GetList().Where(c => c.CategoryStatus == true).ToList().Count;
            var cf = cm.GetList().Where(c => c.CategoryStatus == false).ToList().Count;
            int fark = ct - cf;
            return fark;
        }
    }
}
