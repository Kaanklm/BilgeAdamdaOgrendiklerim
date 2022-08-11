﻿using Model.Entity;
using Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class AppUserService:BaseService<AppUser>
    {
       

        //Login
        public bool UserLogin(string userName, string password)
        {
            bool result = Any(x => x.UserName == userName && x.Password == password);
            return result;
        }

        //GetUser
    }
}
