﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void headingAdd(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public Heading GetById(int id)
        {
            return _headingDal.Get(x=>x.CategoryID==id);
        }

        public List<Heading> GetList()
        {
            return _headingDal.List();
        }

        public void headingDelete(Heading heading)
        {
            _headingDal.Delete(heading);
        }

        public void headingUpdate(Heading heading)
        {
            _headingDal.Update(heading);
        }

    }
}
