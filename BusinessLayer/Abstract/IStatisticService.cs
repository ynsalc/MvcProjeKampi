using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IStatisticService
    {
        int getCount();
        int findTitle();
        int charWriter();
        string categoryName();
        int trueFalse();
    }
}
