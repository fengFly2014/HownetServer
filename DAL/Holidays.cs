using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace Hownet.DAL
{
	/// <summary>
	/// ���ݷ�����Holidays��
	/// </summary>
	public class Holidays
	{
		public Holidays()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Holidays"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Holidays");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(Hownet.Model.Holidays model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Holidays(");
			strSql.Append("TypeID,TimeOne,TimeTwo,EmployeeID,Remark,MainID,IsCaicMoney,Times)");
			strSql.Append(" values (");
			strSql.Append("@TypeID,@TimeOne,@TimeTwo,@EmployeeID,@Remark,@MainID,@IsCaicMoney,@Times)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TimeOne", SqlDbType.DateTime),
					new SqlParameter("@TimeTwo", SqlDbType.DateTime),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@IsCaicMoney", SqlDbType.Bit,1),
					new SqlParameter("@Times", SqlDbType.Int,4)};
			parameters[0].Value = model.TypeID;
			parameters[1].Value = model.TimeOne;
			parameters[2].Value = model.TimeTwo;
			parameters[3].Value = model.EmployeeID;
			parameters[4].Value = model.Remark;
			parameters[5].Value = model.MainID;
			parameters[6].Value = model.IsCaicMoney;
			parameters[7].Value = model.Times;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 1;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(Hownet.Model.Holidays model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Holidays set ");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("TimeOne=@TimeOne,");
			strSql.Append("TimeTwo=@TimeTwo,");
			strSql.Append("EmployeeID=@EmployeeID,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("MainID=@MainID,");
			strSql.Append("IsCaicMoney=@IsCaicMoney,");
			strSql.Append("Times=@Times");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TimeOne", SqlDbType.DateTime),
					new SqlParameter("@TimeTwo", SqlDbType.DateTime),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@IsCaicMoney", SqlDbType.Bit,1),
					new SqlParameter("@Times", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.TypeID;
			parameters[2].Value = model.TimeOne;
			parameters[3].Value = model.TimeTwo;
			parameters[4].Value = model.EmployeeID;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.MainID;
			parameters[7].Value = model.IsCaicMoney;
			parameters[8].Value = model.Times;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Holidays ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Hownet.Model.Holidays GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,TypeID,TimeOne,TimeTwo,EmployeeID,Remark,MainID,IsCaicMoney,Times from Holidays ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.Holidays model=new Hownet.Model.Holidays();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TimeOne"].ToString()!="")
				{
					model.TimeOne=DateTime.Parse(ds.Tables[0].Rows[0]["TimeOne"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TimeTwo"].ToString()!="")
				{
					model.TimeTwo=DateTime.Parse(ds.Tables[0].Rows[0]["TimeTwo"].ToString());
				}
				if(ds.Tables[0].Rows[0]["EmployeeID"].ToString()!="")
				{
					model.EmployeeID=int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["MainID"].ToString()!="")
				{
					model.MainID=int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsCaicMoney"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsCaicMoney"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsCaicMoney"].ToString().ToLower()=="true"))
					{
						model.IsCaicMoney=true;
					}
					else
					{
						model.IsCaicMoney=false;
					}
				}
				if(ds.Tables[0].Rows[0]["Times"].ToString()!="")
				{
					model.Times=int.Parse(ds.Tables[0].Rows[0]["Times"].ToString());
				}
				model.A=1;
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select 1 as A,ID,TypeID,TimeOne,TimeTwo,EmployeeID,Remark,MainID,IsCaicMoney,Times ");
			strSql.Append(" FROM Holidays ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,TypeID,TimeOne,TimeTwo,EmployeeID,Remark,MainID,IsCaicMoney,Times ");
			strSql.Append(" FROM Holidays ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Holidays";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  ��Ա����
	}
}

