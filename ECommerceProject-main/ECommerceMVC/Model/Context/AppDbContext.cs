using Common;
using Core.CoreEntity;
using Model.Entity;
using Model.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Model.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = "server=.;database=ECommerceDB;pwd=123;uid=sa;";
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserRole> Roles { get; set; }
        public DbSet<AppUserAndRole> AppUserAndRoles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Log> Logs { get; set; }

        //çoka çok tablo için onModelCreating metodu ezilecek.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AppUserRoleMap());
            modelBuilder.Configurations.Add(new AppUserAndRoleMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new SubCategoryMap());
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified || x.State == EntityState.Added).ToList();

            string identity= WindowsIdentity.GetCurrent().Name;
            string computerName= Environment.MachineName;
            string ip= IpAddresses.GetHostName();
            DateTime currentDate = DateTime.Now;
            string userName = null;

            try
            {
                if (HttpContext.Current.Session["user"] != null)
                {
                    userName = (HttpContext.Current.Session["user"] as AppUser).UserName;
                }
                else
                {
                    userName = "tanımsız";
                }
            }
            catch (Exception)
            {

                throw;
            }

            foreach (var item in modifiedEntries)
            {
                var baseEntity = item.Entity as BaseEntity;

                if (item != null)
                {
                    if (item.State==EntityState.Added)
                    {
                        baseEntity.CreatedAdUsername = identity;
                        baseEntity.CreatedBy = userName;
                        baseEntity.CreatedComputerName = computerName;
                        baseEntity.CreatedDate = currentDate;
                        baseEntity.CreatedIP = ip;
                        baseEntity.Status = Core.CoreEnum.Status.Active;
                    }
                    else if(item.State==EntityState.Modified)
                    {
                        baseEntity.UpdatedAdUsername = identity;
                        baseEntity.UpdatedBy = userName;
                        baseEntity.UpdatedComputerName = computerName;
                        baseEntity.UpdatedDate = currentDate;
                        baseEntity.UpdatedIP = ip;
                    }
                }
                
            }
            return base.SaveChanges();
        }
    }
}
