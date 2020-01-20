using DatabaseFramework;
using Ipm.Data.Configuration.Reports;
using LT.IMF.Data.Configuration.MasterData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT.IMF.Data.DataContext
{
    public class IMFDataContext : BaseDataContext
    {

        static IMFDataContext()
        {
            Database.SetInitializer<BaseDataContext>(null);
        }

        public IMFDataContext()
            : base("IMFConnectionStringName2")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public override void AddModelBuilderConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountryConfiguration());
            modelBuilder.Configurations.Add(new FullReportConfiguration());
            //modelBuilder.Configurations.Add(new RoleConfiguration());
            ////modelBuilder.Configurations.Add(new UsersToRolesConfiguration());
            //modelBuilder.Configurations.Add(new PermissionConfiguration());
            //modelBuilder.Configurations.Add(new NavigationBarItemConfiguration());
            //modelBuilder.Configurations.Add(new NavigationDropDownHeaderConfiguration());
            //modelBuilder.Configurations.Add(new NavigationDropDownItemConfiguration());
            //modelBuilder.Configurations.Add(new ErrorConfiguration());
            //modelBuilder.Configurations.Add(new ActivityTypeConfiguration());
            //modelBuilder.Configurations.Add(new ActivityLogConfiguration());
            //modelBuilder.Configurations.Add(new ApplicationConfiguration());
        }
    }
}
