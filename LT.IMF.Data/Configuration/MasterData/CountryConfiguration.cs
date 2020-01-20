using LTI.IMF.Entities.MasterData;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT.IMF.Data.Configuration.MasterData
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration() {
            // Primary Key
            this.HasKey(t => t.CountryCode);
            
            // Table & Column Mappings
            this.ToTable("Countries", "dbo");
        }
    }
}
