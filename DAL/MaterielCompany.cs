﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:MaterielCompany
	/// </summary>
	public partial class MaterielCompany
	{
		public MaterielCompany()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "MaterielCompany"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MaterielCompany");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.MaterielCompany model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MaterielCompany(");
			strSql.Append("MaterielID,CompanyID,CompanySN,CompanyRemark,Price,Remark)");
			strSql.Append(" values (");
			strSql.Append("@MaterielID,@CompanyID,@CompanySN,@CompanyRemark,@Price,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@CompanySN", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyRemark", SqlDbType.NVarChar,50),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000)};
			parameters[0].Value = model.MaterielID;
			parameters[1].Value = model.CompanyID;
			parameters[2].Value = model.CompanySN;
			parameters[3].Value = model.CompanyRemark;
			parameters[4].Value = model.Price;
			parameters[5].Value = model.Remark;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Hownet.Model.MaterielCompany model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MaterielCompany set ");
			strSql.Append("MaterielID=@MaterielID,");
			strSql.Append("CompanyID=@CompanyID,");
			strSql.Append("CompanySN=@CompanySN,");
			strSql.Append("CompanyRemark=@CompanyRemark,");
			strSql.Append("Price=@Price,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@CompanySN", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyRemark", SqlDbType.NVarChar,50),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.MaterielID;
			parameters[1].Value = model.CompanyID;
			parameters[2].Value = model.CompanySN;
			parameters[3].Value = model.CompanyRemark;
			parameters[4].Value = model.Price;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MaterielCompany ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MaterielCompany ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.MaterielCompany GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MaterielID,CompanyID,CompanySN,CompanyRemark,Price,Remark from MaterielCompany ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.MaterielCompany model=new Hownet.Model.MaterielCompany();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MaterielID"]!=null && ds.Tables[0].Rows[0]["MaterielID"].ToString()!="")
				{
					model.MaterielID=int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CompanyID"]!=null && ds.Tables[0].Rows[0]["CompanyID"].ToString()!="")
				{
					model.CompanyID=int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
				}
					model.CompanySN=ds.Tables[0].Rows[0]["CompanySN"].ToString();
					model.CompanyRemark=ds.Tables[0].Rows[0]["CompanyRemark"].ToString();
				if(ds.Tables[0].Rows[0]["Price"]!=null && ds.Tables[0].Rows[0]["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
				}
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				model.A=1;
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  1 as A,ID,MaterielID,CompanyID,CompanySN,CompanyRemark,Price,Remark ");
			strSql.Append(" FROM MaterielCompany ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,MaterielID,CompanyID,CompanySN,CompanyRemark,Price,Remark ");
			strSql.Append(" FROM MaterielCompany ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
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
			parameters[0].Value = "MaterielCompany";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

