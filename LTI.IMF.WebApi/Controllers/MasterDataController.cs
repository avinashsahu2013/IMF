using LTI.IMF.Interfaces.Business.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LTI.IMF.WebApi.Controllers
{
    [RoutePrefix("api/masterData")]    
    public class MasterDataController : ApiController
    {        
        private readonly IMasterDataManager _masterDataManager;
        public MasterDataController(IMasterDataManager masterDataManager)
        {
            _masterDataManager = masterDataManager;
        }

        [HttpGet]
        [Route("getCountries")]
        public IHttpActionResult GetCountries()
        {
            try

            {
                var countries = _masterDataManager.GetCountries();
                return Ok(countries);
            }
            catch (Exception ex)
            {
                //log.SaveErrorLog(ex, MethodBase.GetCurrentMethod().DeclaringType.ToString(), MethodBase.GetCurrentMethod().Name);
                return Ok();
            }
        }
    }
}
