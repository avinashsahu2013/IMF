namespace Ipm.Entities
{
    public class Constants
    {
        #region Website Constants
        public class Website
        {
            public class Permissions
            {
                public const string Login = "Login";
            }
            public class Settings
            {
                public class WebConfig
                {
                    public const string LogFilePath = "LogFilePath";
                    public const string EnvironmentString = "Environment";
                    public const string EnvironmentCssTag = "EnvironmentCss";
                    public const string DomainIdentifier = "DomainIdentifier";
                    public const string EnvironmentURLPrefix = "EnvironmentURLPrefix";
                }
            }
        }
        #endregion

        #region Master Data
        public class MasterData
        {
            public class Permissions
            {
                public const string CanViewDivisionData = "MasterData.CanViewDivisionData";
                public const string CanViewAccountTypeData = "MasterData.CanViewAccountTypeData";
                public const string CanViewProductTypeData = "MasterData.CanViewProductTypeData";
            }
            public class StoredProcedures
            {
                public class Division
                {
                    public const string SqlGetDivisions = " SELECT DivisionCode as Code, Name, ActiveFlag FROM dbo.Division order by divisioncode ";
                }

                public class ProductType
                {
                    public const string GetProductTypes = " SELECT ProductTypeCode as Code, Description as Name, ActiveFlag FROM dbo.ProductType order by Description ";
                }
            }
        }


        #endregion

        #region Legacy Master Data
        
        public class StoredProcedures
        {
            public class GetAllCountries
            {                
                public const string Sql = " EXEC Sp_GetAllActiveCountries ";                
            }

            public class GetCategories
            {
                public const string Sql = " EXEC Sp_GetCategories ";
            }

            public class GetMonths
            {
                public const string Sql = " EXEC Sp_GetMonths ";
            }

            public class AddCountry
            {
                public const string CountryName = "@CountryName";
                public const string Sql = " EXEC Sp_InsertCountry ";
            }

            public class AddCategory
            {
                public const string CategoryName = "@CategoryName";
                public const string Sql = " EXEC Sp_InsertCategory ";
            }
            public class GetYears
            {

                public const string Sql = " EXEC Sp_GetYears ";
            }

            public class GetFullReport
            {
                public const string CountryCodes = "@CountryCodes";
                public const string CategoryIds = "@CategoryIds";
                public const string Years = "@Years";
                public const string Months = "@Months";
                public const string Sql = " Exec [Sp_GenerateFullReport] " + CountryCodes + ", " + CategoryIds + ", " + Years + ", " + Months + " ";
            }

            public class GetYesIndex
            {
                public const string CountryCodes = "@CountryCodes";
                public const string CategoryIds = "@CategoryIds";
                public const string Years = "@Years";
                public const string Months = "@Months";
                public const string Sql = " Exec [Sp_GenerateYesIndex] " + CountryCodes + ", " + CategoryIds + ", " + Years + ", " + Months + " ";
            }

            public class GetIndexChange
            {
                public const string CountryCodes = "@CountryCodes";
                public const string CategoryIds = "@CategoryIds";
                public const string Years = "@Years";
                public const string Months = "@Months";
                public const string Sql = " Exec [Sp_GenerateChangeIndex] " + CountryCodes + ", " + Years;
            }
            public class ProductSearchTypeAhead
            {
                public const string ParameterSearchTerm = "@SearchTerm";
                public const string ParameterResultLimit = "@ResultLimit";
                public const string Sql = " EXEC ProductInquery.ProductTypeAheadQuery " + ParameterSearchTerm + ", " + ParameterResultLimit + " ";
            }

            public class GetYesIndexChart
            {
                public const string CountryCodes = "@CountryCodes";
                public const string CategoryIds = "@CategoryIds";
                public const string Years = "@Years";
                public const string Months = "@Months";
                public const string Sql = " Exec [Sp_GenerateYesIndexChart] " + CountryCodes + ", " + CategoryIds + ", " + Years + ", " + Months + " ";
            }
            

            public class GetIndexChangeChart
            {
                public const string CountryCodes = "@CountryCodes";
                public const string CategoryIds = "@CategoryIds";
                public const string Years = "@Years";
                public const string Months = "@Months";
                public const string Sql = " Exec [Sp_GenerateChangeIndexChart] " + CountryCodes + ", " + Years;
            }

        }


        #endregion

        #region AccessControl
        public class AccessControl
        {
            public class Permissions
            {
                public const string CanViewAccessControl = "SecurityInquery.CanViewSecurityData";
                public const string CanEditAccessControl = "SecurityInquery.CanEditSecurityData";
            }
        }
        #endregion

        #region ActivityLog
        public class ActivityLog
        {
            public class ActivityType
            {
                public const string AddUser = "{0} added a new user {1} as {2}.";
                public const string EditUser = "{0} edited user {1}.";
                public const string DeleteUser = "{0} deleted user {1}.";
                public const string AddRole = "{0} assigned a new role {1} to user {2}.";
                public const string RemoveRole = "{0} removed a role {1} from user {2}.";
                public const string EnableDisableUser = "{0} edited and {1} user {2}.";
            }

            public class Permissions
            {
                public const string CanViewActivityLog = "SecurityInquery.CanViewActivityLog";                
            }
        }
        #endregion

        #region PPSecure User Specific Deal Search Query
        public const string SqlCommandCheckUserInPPsecure = "SELECT pu.* FROM IpmSales.security.Users iu INNER JOIN ppsecure.dbo.Users pu ON pu.ADName = iu.UserName WHERE iu.IsDisabled = 0 ";
        #endregion

    }
}
