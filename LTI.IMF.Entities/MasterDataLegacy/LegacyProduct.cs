using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Entities.MasterDataLegacy
{
    public class LegacyProduct
    {
        public string ProductNumber { get; set; }
        public string ProductTitle { get; set; }
        public string SeasonCode { get; set; }
        public string EpisodeCode { get; set; }
        public string PartCode { get; set; }
        public string EpisodeTitle { get; set; }
        public string ProductType { get; set; }
        public string OwnerCode { get; set; }
        public string DivisionOwner { get; set; }
        public string PrdEnt { get; set; }
        public string PrdStat { get; set; }
        public string PrdtnStat { get; set; }
        public string DistStat { get; set; }
        public string FinRptNumber { get; set; }
        public string OriginalProductNumber { get; set; }
        public string FullProductNumber { get; set; }
        public string NewFinRptNumber { get; set; }
        public string FisFlow { get; set; }
        public decimal? AmortRt { get; set; }
        public decimal? PartRt { get; set; }
        public decimal? ResRt { get; set; }
        public decimal? DirCostRt { get; set; }
        public decimal? GrsProfitRt { get; set; }
        public string BroadcastSeason { get; set; }
        public string LibraryCode { get; set; }
    }
}
