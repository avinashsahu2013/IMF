using DatabaseFramework.Interfaces;
using Ipm.Entities.Common;
using Ipm.Interfaces.Api.Common;
//using Ipm.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipm.Api.Common
{
    //public class Logger : ILogger
    //{

        //private readonly IUnitOfWork<IIpmSalesDataContext> _ipmSupportUnitOfWork;
        //public string LogPath { get; set; }

        //public Logger(IUnitOfWork<IIpmSalesDataContext> ipmSupportUnitOfWork)
        //{
        //    _ipmSupportUnitOfWork = ipmSupportUnitOfWork;
        //}

        //private bool LogExceptionToFile(Exception exception, string location)
        //{
        //    try
        //    {
        //        string pathToSave = LogPath;
        //        var date = new DateTime(DateTime.UtcNow.Ticks);
        //        string filename = date.ToString("yyyymmddHHmmssfff") + ".log";
        //        string fullFilename = pathToSave + @"\" + filename;
        //        if (!Directory.Exists(pathToSave))
        //        {
        //            Directory.CreateDirectory(pathToSave);
        //        }
        //        while (File.Exists(fullFilename))
        //        {
        //            filename += (new DateTime(DateTime.UtcNow.Ticks)).ToString("fff");
        //        }
        //        var lineToWrite = "Date/Time" + Environment.NewLine + date.ToString("yyyy-mm-dd HH:mm:ss UTC") +
        //            Environment.NewLine + "Location" + Environment.NewLine + location +
        //            Environment.NewLine + "Error" + Environment.NewLine + exception.ToString();
        //        if (exception != null && exception.InnerException != null)
        //        {
        //            lineToWrite = lineToWrite + Environment.NewLine + "Inner Error" + Environment.NewLine + exception.InnerException.ToString();
        //        }
        //        File.WriteAllText(fullFilename, lineToWrite);
        //        return true;

        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //private bool LogExceptionToDatabase(Exception exception, string location)
        //{
        //    try
        //    {
        //        var error = new Error
        //        {
        //            ErrorMessage = exception.ToString(),
        //            Location = location,
        //            TimeOfErrorInUTC = DateTime.UtcNow
        //        };
        //        if (exception != null && exception.InnerException != null)
        //        {
        //            error.InnerErrorMessage = exception.InnerException.ToString();
        //        }
        //        _ipmSupportUnitOfWork.Repository<Error>().Insert(error);
        //        _ipmSupportUnitOfWork.Commit();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool LogException(Exception exception, string location)
        //{
        //    if (location == null)
        //    {
        //        location = "Unknown Location";
        //    }
        //    if (!LogExceptionToDatabase(exception, location))
        //    {
        //        if (!LogExceptionToFile(exception, location))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
    //}
}
