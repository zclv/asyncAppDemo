using MyProjectAOP.Models;
using MyProjectAOP.Unity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProjectAOP.Unity.Service
{
    public class UserService : IUserService
    {
        private DbContext _DbContext = null;
        public UserService(DbContext context)
        {
            this._DbContext = context;
        }

        public List<UserModel> GetList()
        {
            List<UserModel> _userList = new List<UserModel>
             {
                 new UserModel {UserID = 1, UserName = "Superman", UserEmail = "Superman@cnblogs.com"},
                 new UserModel {UserID = 2, UserName = "Spiderman", UserEmail = "Spiderman@cnblogs.com"},
                 new UserModel {UserID = 3, UserName = "Batman", UserEmail = "Batman@cnblogs.com"}
            };
            return _userList;
        }
    }
}