using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Collections.Generic;
namespace Maticsoft.DBUtility
{
    /// <summary>
    /// ���ݷ��ʳ��������
    /// Copyright (C) 2004-2008 By LiTianPing 
    /// </summary>
    public abstract class NewDbHelperSQL
    {
        //���ݿ������ַ���(web.config������)�����Զ�̬����connectionString֧�ֶ����ݿ�.		
        public static string connectionString = PubConstant.ConnectionString;     		
        public NewDbHelperSQL()
        {
        }
        #region �洢���̲���

        /// <summary>
        /// ִ�д洢���̣�����SqlDataReader ( ע�⣺���ø÷�����һ��Ҫ��SqlDataReader����Close )
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataReader returnReader;
            connection.Open();
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.CommandType = CommandType.StoredProcedure;
            returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return returnReader;
            
        }


        /// <summary>
        /// ִ�д洢����
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <param name="tableName">DataSet����еı���</param>
        /// <returns>DataSet</returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                sqlDA.Fill(dataSet,tableName);
                connection.Close();
                return dataSet;
            }
        }
        /// <summary>
        /// ִ�д洢����
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <param name="tableName">DataSet����еı���</param>
        /// <param name="Times">�ȴ�ʱ��</param>
        /// <returns>DataSet</returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName, int Times)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                sqlDA.SelectCommand.CommandTimeout = Times;
                sqlDA.Fill(dataSet, tableName);
                connection.Close();
                return dataSet;
            }
        }


        /// <summary>
        /// ���� SqlCommand ����(��������һ���������������һ������ֵ)
        /// </summary>
        /// <param name="connection">���ݿ�����</param>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <returns>SqlCommand</returns>
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    if (parameter != null)
                    {
                        // ���δ����ֵ���������,���������DBNull.Value.
                        if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                            (parameter.Value == null))
                        {
                            parameter.Value = DBNull.Value;
                        }
                        command.Parameters.Add(parameter);
                    }
                }
            }

            return command;
        }

        public static int RunProcedureReturnID(string storedProcName, IDataParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                object obj;
                connection.Open();
                SqlCommand command = BuildIntCommand(connection, storedProcName, parameters);
                obj = command.ExecuteScalar();
                command.Parameters.Clear();
                if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                {
                    return 0;
                }
                else
                {
                    return (int)obj;
                }
            }
        }
        /// <summary>
        /// ִ�д洢���̣�����Ӱ�������		
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <param name="rowsAffected">Ӱ�������</param>
        /// <returns></returns>
        public static int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int result;
                connection.Open();
                SqlCommand command = BuildIntCommand(connection, storedProcName, parameters);
                rowsAffected = command.ExecuteNonQuery();
                result = (int)command.Parameters["ReturnValue"].Value;
                //Connection.Close();
                return result;
            }
        }
        /// <summary>
        /// ���� SqlCommand ����ʵ��(��������һ������ֵ)	
        /// </summary>
        /// <param name="storedProcName">�洢������</param>
        /// <param name="parameters">�洢���̲���</param>
        /// <returns>SqlCommand ����ʵ��</returns>
        private static SqlCommand BuildIntCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.Parameters.Add(new SqlParameter("ReturnValue",
                SqlDbType.Int, 4, ParameterDirection.ReturnValue,
                false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return command;
        }
        #endregion
        #region ������ɾ�����ݺ���Sql�洢���̰�
        /// <summary>
        ///  ����һ������
        /// </summary>
        /// <param name="TableName">����</param>
        /// <param name="Where">�����ֶ� ����Set ��:Field1,Field2,Field3 ...</param>
        /// <param name="Where">�����ֶ�ֵ ����Value() ��:Value1,Value2,Value3 ...</param>
        /// <returns>����Ӱ������</returns>
        public static int Table_Insert(string TableName, string Fields, string Values)
        {
            int result;
            SqlParameter[] parameters = {
					new SqlParameter("@TableName", SqlDbType.NVarChar,50),
					new SqlParameter("@Fields", SqlDbType.NVarChar,2000),
					new SqlParameter("@Values", SqlDbType.NVarChar,2000)};
            parameters[0].Value = TableName;
            parameters[1].Value = Fields;
            parameters[2].Value = Values;
            result = NewDbHelperSQL.RunProcedureReturnID("Pr_Table_Insert", parameters);

            return result;
            
        }
        /// <summary>
        ///  �޸�һ������
        /// </summary>
        /// <param name="TableName">����</param>
        /// <param name="FieldsAndValues">�����ֶ��б��Լ�ֵ�б� ����Set ��:Field1=Value1,Field2=Value2 ...</param>
        /// <param name="Where">�������� ����Where ��:id=1 and name='����'</param>
        /// <returns>����Ӱ������</returns>
        public static int Table_Updata(string TableName, string FieldsAndValues, string Where)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@TableName", SqlDbType.NVarChar,50),
					new SqlParameter("@FieldsAndValues", SqlDbType.NVarChar,2000),
					new SqlParameter("@Where", SqlDbType.NVarChar,2000)};
            parameters[0].Value = TableName;
            parameters[1].Value = FieldsAndValues;
            parameters[2].Value = Where;

            DbHelperSQL.RunProcedure("Pr_Table_Update", parameters, out rowsAffected);
            return rowsAffected;
        }
        /// <summary>
        ///  ɾ��һ������
        /// </summary>
        /// <param name="TableName">����</param>
        /// <param name="Where">�����ֶ� ����Set ��:Field1,Field2,Field3 ...</param>
        /// <param name="Where">�����ֶ�ֵ ����Value() ��:Value1,Value2,Value3 ...</param>
        /// <returns>����Ӱ������</returns>
        public static int Table_Delete(string TableName, string Where)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@TableName", SqlDbType.NVarChar,50),
					new SqlParameter("@Where", SqlDbType.NVarChar,2000)};
            parameters[0].Value = TableName;
            parameters[1].Value = Where;

            DbHelperSQL.RunProcedure("Pr_Table_Delete", parameters, out rowsAffected);
            return rowsAffected;
        }

        #endregion
        #region ������ѯ���ݺ���Sql�洢���̰�
        /// <summary>
        /// ������ѯ���ݺ���Sql�洢���̰�
        /// </summary>
        /// <param name="qp">��������</param>
        /// <returns>���ؼ�¼��DataSet</returns>
        public static DataSet GetListByParam(QueryParam qp, string tableName)
        {
            DataSet ds = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlParameter[] parameters = {
					new SqlParameter("@Tables", SqlDbType.VarChar,255),
					new SqlParameter("@Fields", SqlDbType.VarChar,1000),
					new SqlParameter("@Filter", SqlDbType.VarChar,1500),
                    new SqlParameter("@OrderName",SqlDbType.VarChar,255),
                    new SqlParameter("@OrderType",SqlDbType.Bit)};
                parameters[0].Value = qp.Tables;
                parameters[1].Value = qp.Fields;
                parameters[2].Value = qp.Filter;
                parameters[3].Value = qp.OrderName;
                parameters[4].Value = qp.OrderType;

                ds = RunProcedure("Pr_Table_GetModel", parameters, tableName);

            }
            return ds;
        }
        /// <summary>
        /// ������ѯ���ݺ���Sql�洢���̰�
        /// </summary>
        /// <param name="qp">��������</param>
        /// <returns>���ؼ�¼��SqlDataReader</returns>
        public static SqlDataReader GetListByParam(QueryParam qp)
        {
            SqlDataReader dr = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlParameter[] parameters = {
					new SqlParameter("@Tables", SqlDbType.VarChar,255),
					new SqlParameter("@Fields", SqlDbType.VarChar,1000),
					new SqlParameter("@Filter", SqlDbType.VarChar,1500),
                    new SqlParameter("@OrderName",SqlDbType.VarChar,255),
                    new SqlParameter("@OrderType",SqlDbType.Bit)};
                parameters[0].Value = qp.Tables;
                parameters[1].Value = qp.Fields;
                parameters[2].Value = qp.Filter;
                parameters[3].Value = qp.OrderName;
                parameters[4].Value = qp.OrderType;

                dr = RunProcedure("Pr_Table_GetModel", parameters);

            }
            return dr;
        }
        /// <summary>
        /// ������ҳ��ѯ���ݺ���Sql�洢���̰�
        /// </summary>
        /// <param name="qp">��������</param>
        /// <param name="RecordCount">���������б��ܼ�¼��</param>
        /// <returns>���ؼ�¼��DataSet</returns>
        public static DataSet GetListByPagination(QueryParam qp, out int RecordCount)
        {
            DataSet ds = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //��������
                SqlParameter[] parameters ={new SqlParameter("@Tables", SqlDbType.VarChar, 255),
                                            new SqlParameter("@Fields", SqlDbType.VarChar, 1000), 
                                            new SqlParameter("@Filter", SqlDbType.VarChar, 1500) ,
                                            new SqlParameter("@PageSize", SqlDbType.Int),
                                            new SqlParameter("@PageIndex", SqlDbType.Int),
                                            new SqlParameter("@OrderName", SqlDbType.VarChar, 255),
                                            new SqlParameter("@OrderType", SqlDbType.Bit),
                                            new SqlParameter("@doCount",SqlDbType.Bit)};
                // ���ò���
                parameters[0].Value = qp.Tables;
                parameters[1].Value = qp.Fields;
                parameters[2].Value = qp.Filter;
                parameters[3].Value = qp.PageSize;
                parameters[4].Value = qp.PageIndex;
                parameters[5].Value = qp.OrderName;
                parameters[6].Value = qp.OrderType;
                parameters[7].Value = qp.DoCount;


                ds = RunProcedure("Pr_Pagination", parameters, "ds");

                // ȡ��¼���� ��ҳ��
                //RecordCount = parameters[7].Value;
                //string dd = ds.Tables[1].Rows[0][0].ToString();
                RecordCount = GetPaginationCount(qp);
            }
            return ds;
        }
        public static int GetPaginationCount(QueryParam qp)
        {
            int RecordCount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlParameter[] parameters ={new SqlParameter("@Tables", SqlDbType.VarChar, 255),
                                            new SqlParameter("@Fields", SqlDbType.VarChar, 1000), 
                                            new SqlParameter("@Filter", SqlDbType.VarChar, 1500) ,
                                            new SqlParameter("@PageSize", SqlDbType.Int),
                                            new SqlParameter("@PageIndex", SqlDbType.Int),
                                            new SqlParameter("@OrderName", SqlDbType.VarChar, 255),
                                            new SqlParameter("@OrderType", SqlDbType.Bit),
                                            new SqlParameter("@doCount",SqlDbType.Bit)};
                // ���ò���
                parameters[0].Value = qp.Tables;
                parameters[1].Value = qp.Fields;
                parameters[2].Value = qp.Filter;
                parameters[3].Value = qp.PageSize;
                parameters[4].Value = qp.PageIndex;
                parameters[5].Value = qp.OrderName;
                parameters[6].Value = qp.OrderType;
                parameters[7].Value = 1;

                SqlDataReader Dr = RunProcedure("Pr_Pagination", parameters);

                if (Dr.Read())
                {
                    if(Dr[0].ToString()!="" || Dr[0].ToString()!=null)
                    {
                        RecordCount = Convert.ToInt32(Dr[0].ToString());
                    }
                }
            }
            return RecordCount;
        }
        #endregion
    }

}
