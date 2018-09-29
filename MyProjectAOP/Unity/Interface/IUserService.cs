using MyProjectAOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProjectAOP.Unity.Interface
{
    public interface IUserService
    {
        List<UserModel> GetList();
    }
}