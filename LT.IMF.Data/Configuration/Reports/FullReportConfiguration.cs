using Ipm.Entities.Reports;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Data.Configuration.Reports
{    
    public class FullReportConfiguration : EntityTypeConfiguration<FullReport>
    {
        public FullReportConfiguration()
        {
            //// Primary Key
            //this.HasKey(t => t.CountryCode);

            //// Table & Column Mappings
            //this.ToTable("Countries", "dbo");

            MapToStoredProcedures();
        }
    }
}
