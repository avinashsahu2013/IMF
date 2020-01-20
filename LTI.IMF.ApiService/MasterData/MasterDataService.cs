using DatabaseFramework.Interfaces;
using Ipm.Entities;
using Ipm.Entities.MasterData;
using Ipm.Interfaces.Api.MasterData;
using LT.IMF.Data.DataContext;
using LTI.IMF.Entities.MasterData;
using LTI.IMF.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTI.IMF.ApiService.MasterData
{
    public class MasterDataService : IMasterDataService
    {
        private readonly IUnitOfWork<IIMFDataContext> _imfUnitOfWork;

        public MasterDataService(IUnitOfWork<IIMFDataContext> imfUnitOfWork)
        {
            _imfUnitOfWork = imfUnitOfWork;
        }        

        public FilterCriteria GetCountries()
        {
            try
            {
                var countries = _imfUnitOfWork.Repository<Country>().SqlCommand(Constants.StoredProcedures.GetAllCountries.Sql);
                var categories = _imfUnitOfWork.Repository<Category>().SqlCommand(Constants.StoredProcedures.GetCategories.Sql);
                var months = _imfUnitOfWork.Repository<Month>().SqlCommand(Constants.StoredProcedures.GetMonths.Sql);
                var years = _imfUnitOfWork.Repository<Year>().SqlCommand(Constants.StoredProcedures.GetYears.Sql);

                FilterCriteria filterCriteria = new FilterCriteria();
                filterCriteria.Countries = countries;
                filterCriteria.Categories = categories;
                filterCriteria.Years = years;
                filterCriteria.Months = months;

                return filterCriteria;
            }
            catch (Exception ex)
            {
                return null;
            }
           
        }

        public bool AddCountry(string countryName)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add(Constants.StoredProcedures.AddCountry.CountryName, countryName);
            var resultSet = _imfUnitOfWork.Repository<Country>().SqlCommand(Constants.StoredProcedures.AddCategory.Sql, parameters);
            return true;
        }

        public bool AddCategory(string categoryName)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add(Constants.StoredProcedures.AddCategory.CategoryName, categoryName);
             var resultSet = _imfUnitOfWork.Repository<Category>().SqlCommand(Constants.StoredProcedures.AddCategory.Sql,parameters);
            return true;
        }
    }
}
