using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();
        void writerAdd(Writer writer);
        Writer GetById(int id);
        void writerDelete(Writer writer);
        void writerUpdate(Writer writer);
    }
}
