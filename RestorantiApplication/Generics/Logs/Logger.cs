using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantiApplication.Generics.Logs
{
    public static class Logger
    {
        public static string? logPath = ConfigurationManager.AppSettings["logPath"];
        public static void Write(string Message)
        {
            try
            {
                if (!string.IsNullOrEmpty(logPath))
                {
                    if (Directory.Exists(logPath.Substring(0, logPath.IndexOf("/"))))
                    {
                        if (!File.Exists(logPath))
                            File.Create(logPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(logPath.Substring(0, logPath.IndexOf("/")));
                    }

                    using (StreamWriter writer = new StreamWriter(logPath, true))
                    {
                        writer.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - {Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
