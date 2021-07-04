﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    interface IColorDal:IEntityRepository<Color>
    {
        
    }
}
