using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        void headingAdd(Heading heading);
        Heading GetById(int id);
        void headingDelete(Heading heading);
        void headingUpdate(Heading heading);
    }
}
