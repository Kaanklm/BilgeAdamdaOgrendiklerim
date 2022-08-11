using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.ViewModels;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly MovieContext movieContext;

        public UserRepository(MovieContext _movieContext)
        {
            movieContext = _movieContext;
        }
        public List<UserRoleVM> GetUserForRole()
        {
            var userList = from user in movieContext.Users
                           join userRole in movieContext.UserRoles on user.Id equals userRole.UserId
                           join role in movieContext.Roles on userRole.RoleId equals role.Id
                           select new UserRoleVM
                           {
                               Id=user.Id,
                               UserName=user.UserName,
                               Email=user.Email,
                               IsActive=user.IsActive,
                               RoleName=role.Name
                           };
            return userList.ToList();
        }
    }
}
