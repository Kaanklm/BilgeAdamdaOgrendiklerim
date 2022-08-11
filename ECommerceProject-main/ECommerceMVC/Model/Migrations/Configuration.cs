namespace Model.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Bogus;
    using Model.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<Model.Context.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Model.Context.AppDbContext context)
        {
            List<AppUserRole> roleList = new List<AppUserRole>()
            {
                new AppUserRole
                {
                    ID=Guid.NewGuid(),
                    Role="Admin",
                    CreatedDate=DateTime.Now,
                    MasterId=1,
                    Status=Core.CoreEnum.Status.Active

                },
                new AppUserRole
                {
                    ID=Guid.NewGuid(),
                    Role="Member",
                    CreatedDate=DateTime.Now,
                    MasterId=2,
                    Status=Core.CoreEnum.Status.Active

                },
                new AppUserRole
                {
                    ID=Guid.NewGuid(),
                    Role="Accounting",
                    CreatedDate=DateTime.Now,
                    MasterId=3,
                    Status=Core.CoreEnum.Status.Active

                },
                new AppUserRole
                {
                    ID=Guid.NewGuid(),
                    Role="Sales",
                    CreatedDate=DateTime.Now,
                    MasterId=4,
                    Status=Core.CoreEnum.Status.Active

                }
            };

            List<AppUser> userList = new List<AppUser>()
            {
                new AppUser
                {
                    ID=Guid.NewGuid(),
                    MasterId=1,
                    UserName="fatih",
                    Password="1234",
                    Email="fatih.gunalp@bilgeadam.com"

                },
                new AppUser
                {
                    ID=Guid.NewGuid(),
                    MasterId=2,
                    UserName="ali",
                    Password="1234",
                    Email="ali@gmail.com"

                },
                new AppUser
                {
                    ID=Guid.NewGuid(),
                    MasterId=3,
                    UserName="kadir",
                    Password="1234",
                    Email="kadir@gmail.com"

                },
                new AppUser
                {
                    ID=Guid.NewGuid(),
                    MasterId=4,
                    UserName="irem",
                    Password="1234",
                    Email="irem@gmail.com"

                }
            };

            AppUserAndRole userAndRole = new AppUserAndRole();


            if (!context.Roles.Any())
            {
                foreach (AppUserRole role in roleList)
                {
                    context.Roles.Add(role);
                    context.SaveChanges();
                }
            }

            if (!context.AppUsers.Any())
            {
                foreach (AppUser user in userList)
                {
                    context.AppUsers.Add(user);
                    context.SaveChanges();
                }

                userAndRole.AppUserId = context.AppUsers.Where(x => x.UserName == "fatih").FirstOrDefault().ID;
                userAndRole.AppUserRoleId = context.Roles.Where(x => x.Role == "Admin").FirstOrDefault().ID;
                context.AppUserAndRoles.Add(userAndRole);

            }




        }
    }
}
