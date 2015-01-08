using System;
using System.Configuration;
namespace Maticsoft.DBUtility
{
    
    public class PubConstant
    {        
        /// <summary>
        /// ��ȡ�����ַ���
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string _connectionString = "";
                try
                {
                    _connectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;
                }
                catch
                {
                    _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                }
                //string ConStringEncrypt = ConfigurationManager.AppSettings["ERP"];
                ////if (ConStringEncrypt == "true")
                ////{
                ////    _connectionString = DESEncrypt.Decrypt(_connectionString);
                ////}
                //string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                //string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                //if (ConStringEncrypt == "true")
                //{
                //    _connectionString = DESEncrypt.Decrypt(_connectionString);
                //}
              //  ConStringEncrypt = DESEncrypt.Encrypt(_connectionString);
                return _connectionString; 
            }
        }
        public static string ReportConn
        {
            get
            {
                string _conn = ConfigurationManager.ConnectionStrings["FastReport"].ConnectionString;
                return _conn;
            }
        }

        /// <summary>
        /// �õ�web.config������������ݿ������ַ�����
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }


    }
}
