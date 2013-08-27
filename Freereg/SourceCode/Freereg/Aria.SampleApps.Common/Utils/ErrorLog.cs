// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ErrorLog.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Error Log
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Aria.SampleApps.Common.Configuration;

namespace Aria.SampleApps.Common.Utils
{
    public class ErrorLog
    {
        /// <summary>
        /// Saves the exception log.
        /// </summary>
        /// <param name="exp">The exp.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public static bool SaveExceptionLog(Exception exp)
        {
            var logPath = HttpContext.Current.Server.MapPath(SampleAppsSettings.Default.LogPath);
            var userName = Environment.UserName;
            bool returnVal = true;
            try
            {
                //Check if the folder exists
                if (Directory.Exists(logPath))
                {
                    if (!logPath.Substring(logPath.Length - 2, 1).Equals("\\")) logPath += "\\";

                    //Check if the file of the day exists, if doesn't, create the file.
                    string filePath = logPath + "log" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

                    if (!File.Exists(filePath))
                    {
                        using (FileStream fsNew = File.Create(filePath))
                        {
                            //format: date|user|message|source|stack
                            string content = "{0}|{1}|{2}|{3}|{4}";
                            if (exp.InnerException != null)
                                content = string.Format(content, DateTime.Now.ToString(), userName, 
                                    exp.InnerException.Message, exp.InnerException.Source, exp.InnerException.StackTrace);
                            else
                                content = string.Format(content, DateTime.Now.ToString(), userName, exp.Message, exp.Source, exp.StackTrace);

                            byte[] info = new UTF8Encoding(true).GetBytes(content);
                            fsNew.Write(info, 0, info.Length);

                            fsNew.Close();
                        }
                    }
                    else
                    {
                        FileStream fs = new FileStream(filePath, FileMode.Append);
                        if (fs.CanWrite)
                        {
                            //format: date|user|message|source|stack
                            string content = "\n{0}|{1}|{2}|{3}|{4}";
                            if (exp.InnerException != null)
                                content = string.Format(content, DateTime.Now.ToString(), userName, 
                                    exp.InnerException.Message, exp.InnerException.Source, exp.InnerException.StackTrace);
                            else
                                content = string.Format(content, DateTime.Now.ToString(), userName, exp.Message, exp.Source, exp.StackTrace);

                            byte[] info = new UTF8Encoding(true).GetBytes(content);
                            fs.Write(info, 0, info.Length);
                        }

                        fs.Close();
                    }
                }
            }
            catch
            {
                returnVal = false;
            }

            return returnVal;
        }   
    }
}
