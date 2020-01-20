using DatabaseFramework.Interfaces;
using Ipm.Entities;
using Ipm.Entities.MasterData;
using Ipm.Entities.Reports;
using Ipm.Entities.SearchEntities;
using Ipm.Interfaces.Api.ReportService;
using LTI.IMF.Entities.MasterData;
using LTI.IMF.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Api.ReportService
{
    public class ReportService : IReportService
    {
        private readonly IUnitOfWork<IIMFDataContext> _imfUnitOfWork;

        #region Contructor method
        public ReportService(IUnitOfWork<IIMFDataContext> imfUnitOfWork)
        {
            _imfUnitOfWork = imfUnitOfWork;
        }

        #endregion

        #region Public Method
        public IEnumerable<FullReport> GetFullReport(ReportCriteria reportCriteria)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add(Constants.StoredProcedures.GetFullReport.CountryCodes, reportCriteria.countryCodeIds);
                parameters.Add(Constants.StoredProcedures.GetFullReport.CategoryIds, reportCriteria.categoryCodeIds);
                parameters.Add(Constants.StoredProcedures.GetFullReport.Years, reportCriteria.years);
                parameters.Add(Constants.StoredProcedures.GetFullReport.Months, reportCriteria.months);

                
                var fullReport = _imfUnitOfWork.Repository<FullReport>().SqlCommand(Constants.StoredProcedures.GetFullReport.Sql, parameters);

                return fullReport;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public IEnumerable<YesIndexReport> GetYesIndex(ReportCriteria reportCriteria)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add(Constants.StoredProcedures.GetYesIndex.CountryCodes, reportCriteria.countryCodeIds);
                parameters.Add(Constants.StoredProcedures.GetYesIndex.CategoryIds, reportCriteria.categoryCodeIds);
                parameters.Add(Constants.StoredProcedures.GetYesIndex.Years, reportCriteria.years);
                parameters.Add(Constants.StoredProcedures.GetYesIndex.Months, reportCriteria.months);

                var fullReport2 = _imfUnitOfWork.Repository<YesIndexReport>().SqlCommand(Constants.StoredProcedures.GetYesIndex.Sql, parameters);
                //var fullReport1 = _imfUnitOfWork.Repository<Country>().SqlCommand(Constants.StoredProcedures.GetAllCountries.Sql);

                var fullReport = _imfUnitOfWork.Repository<FullReport>().SqlCommand(Constants.StoredProcedures.GetFullReport.Sql, parameters);

                return fullReport2;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<IndexChangeReport> GetChangeIndex(ReportCriteria reportCriteria)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add(Constants.StoredProcedures.GetIndexChange.CountryCodes, reportCriteria.countryCodeIds);
                // parameters.Add(Constants.StoredProcedures.GetIndexChange.CategoryIds, reportCriteria.categoryCodeIds);
                parameters.Add(Constants.StoredProcedures.GetIndexChange.Years, reportCriteria.years);
                //parameters.Add(Constants.StoredProcedures.GetIndexChange.Months, reportCriteria.months);

                var fullReport = _imfUnitOfWork.Repository<IndexChangeReport>().SqlCommand(Constants.StoredProcedures.GetIndexChange.Sql, parameters);
               

                return fullReport;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion

        #region Private Functions
        private static DataTable ConvertToDatatable(List<int> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));

            foreach (var id in list)
            {
                var row = dt.NewRow();

                row["ID"] = id;

                dt.Rows.Add(row);
            }

            return dt;
        }
        #endregion

        public RootObject GetYesIndexChart(ReportCriteria reportCriteria)
        {
            try
            {
                List<YesIndexReport> lstYesIndexReport = new List<YesIndexReport>();
                List<string> lstCountryName = new List<string>();
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add(Constants.StoredProcedures.GetYesIndex.CountryCodes, reportCriteria.countryCodeIds);
                parameters.Add(Constants.StoredProcedures.GetYesIndex.CategoryIds, reportCriteria.categoryCodeIds);
                parameters.Add(Constants.StoredProcedures.GetYesIndex.Years, reportCriteria.years);
                parameters.Add(Constants.StoredProcedures.GetYesIndex.Months, reportCriteria.months);

                var fullReport2 = _imfUnitOfWork.Repository<YesIndexReport>().SqlCommand(Constants.StoredProcedures.GetYesIndexChart.Sql, parameters);
                //var fullReport1 = _imfUnitOfWork.Repository<Country>().SqlCommand(Constants.StoredProcedures.GetAllCountries.Sql);
                lstYesIndexReport = fullReport2.ToList();
                lstCountryName = fullReport2.AsEnumerable().Select(o => o.CountryName).Distinct().ToList();

                RootObject objRootObject = new RootObject();
                List<datasets> lstChartList = new List<datasets>();
                List<Datum> lstDatum = new List<Datum>();

                //private Random rnd = new Random();
                var random = new Random();
                foreach (string objCountryName in lstCountryName)
                {
                    datasets objChartList = new datasets();
                    List<Datum> objDatum = new List<Datum>();
                    var color = "#{0:X6}" + Convert.ToString(random.Next(0x1000000)); //String.Format("#{0:X6}", random.Next(0x1000000));//String.Format("#{0:X6}", random.Next(0x1000000)); // = "#A197B9"
                    objChartList.strokeColor = color;// "#3cba9f";
                    //objChartList.borderColor = "#3cba9f";

                    objChartList.fill = "false";
                    objChartList.label = objCountryName.ToString();
                    objDatum = (from stad in lstYesIndexReport.Where(x => x.CountryName == objCountryName)
                                select new Datum()
                                {
                                    x = stad.Report.ToString(),
                                    y = stad.YesIndex

                                }).ToList();

                    objChartList.data = objDatum;
                    lstChartList.Add(objChartList);

                }

                objRootObject.datasets = lstChartList.ToList();
                objRootObject.lstYEARMONTH = fullReport2.AsEnumerable().Select(o => o.Report).Distinct().ToList();



                return objRootObject;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public RootObject GetChangeIndexChart(ReportCriteria reportCriteria)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add(Constants.StoredProcedures.GetIndexChange.CountryCodes, reportCriteria.countryCodeIds);
                // parameters.Add(Constants.StoredProcedures.GetIndexChange.CategoryIds, reportCriteria.categoryCodeIds);
                parameters.Add(Constants.StoredProcedures.GetIndexChange.Years, reportCriteria.years);
                //parameters.Add(Constants.StoredProcedures.GetIndexChange.Months, reportCriteria.months);

                var fullReport = _imfUnitOfWork.Repository<IndexChangeReport>().SqlCommand(Constants.StoredProcedures.GetIndexChangeChart.Sql, parameters);

                List<IndexChangeReport> lstChangeIndexReport = new List<IndexChangeReport>();
                List<string> lstCountryName = new List<string>();
                lstChangeIndexReport = fullReport.ToList();
                lstCountryName = fullReport.AsEnumerable().Select(o => o.CountryName).Distinct().ToList();


                RootObject objRootObject = new RootObject();
                List<datasets> lstChartList = new List<datasets>();
                List<Datum> lstDatum = new List<Datum>();

                List<string> lstColors = new List<string> { "#3cba9f", "#3A76BC" };
                //var tempList = new List<string> { "Name", "DOB", "Address" };
                var random = new Random();
                foreach (string objCountryName in lstCountryName)
                {
                    datasets objChartList = new datasets();
                    List<Datum> objDatum = new List<Datum>();

                    var color = "#{0:X6}" + Convert.ToString(random.Next(0x1000000)); //String.Format("#{0:X6}", random.Next(0x1000000));//String.Format("#{0:X6}", random.Next(0x1000000)); // = "#A197B9"
                    objChartList.strokeColor = color;// "#3cba9f";
                    objChartList.fill = "false";
                    objChartList.label = objCountryName.ToString();
                    objDatum = (from stad in lstChangeIndexReport.Where(x => x.CountryName == objCountryName)
                                select new Datum()
                                {
                                    x = stad.Report.ToString(),
                                    y = stad.ChangeIndex

                                }).ToList();

                    objChartList.data = objDatum;
                    lstChartList.Add(objChartList);

                }

                objRootObject.datasets = lstChartList.ToList();
                objRootObject.lstYEARMONTH = fullReport.AsEnumerable().Select(o => o.Report).Distinct().ToList();


                return objRootObject;


            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }


}
