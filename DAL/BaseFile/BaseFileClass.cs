using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;

namespace Hownet.DAL.BaseFile
{
   public class BaseFileClass
    {
        /// <summary>
        /// ���Sn�Ƿ��ظ���ע�⣺���ID�ֶ���Ϊ����+ID
        /// </summary>
        /// <param name="Sn">������޸ĺ��Sn</param>
        /// <param name="ID"></param>
        /// <param name="t">�Ƿ�Ϊ�������</param>
        /// <param name="TableName">����</param>
        /// <returns></returns>
        public static bool CheckSn(string Sn, int ID, bool t, string TableName)
        {
            string tableID = TableName + "ID";
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as Exp1  FROM '" + TableName + "' where (Sn=@SN)  ");
            if (!t)
            {
                strSql.Append("And ('" + tableID + "'<>@ID)");
            }
            SqlParameter[] parameters =    { new SqlParameter("@ID", ID), new SqlParameter("@sn", Sn) };
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj.ToString() == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
