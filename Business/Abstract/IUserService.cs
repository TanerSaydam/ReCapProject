﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<IList<User>> GetAll();
        IDataResult<User> Get(int userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
