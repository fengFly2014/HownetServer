﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:ImageList
	/// </summary>
	public partial class ImageList
	{
		public ImageList()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ImageList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ImageList");
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
		public int Add(Hownet.Model.ImageList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ImageList(");
			strSql.Append("Remark,Image,MainID,TableTypeID,SerName)");
			strSql.Append(" values (");
			strSql.Append("@Remark,@Image,@MainID,@TableTypeID,@SerName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@Image", SqlDbType.NVarChar,50),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@SerName", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Remark;
			parameters[1].Value = model.Image;
			parameters[2].Value = model.MainID;
			parameters[3].Value = model.TableTypeID;
			parameters[4].Value = model.SerName;

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
		public bool Update(Hownet.Model.ImageList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ImageList set ");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Image=@Image,");
			strSql.Append("MainID=@MainID,");
			strSql.Append("TableTypeID=@TableTypeID,");
			strSql.Append("SerName=@SerName");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@Image", SqlDbType.NVarChar,50),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@SerName", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Remark;
			parameters[1].Value = model.Image;
			parameters[2].Value = model.MainID;
			parameters[3].Value = model.TableTypeID;
			parameters[4].Value = model.SerName;
			parameters[5].Value = model.ID;

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
			strSql.Append("delete from ImageList ");
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
			strSql.Append("delete from ImageList ");
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
		public Hownet.Model.ImageList GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Remark,Image,MainID,TableTypeID,SerName from ImageList ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.ImageList model=new Hownet.Model.ImageList();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
					model.Image=ds.Tables[0].Rows[0]["Image"].ToString();
				if(ds.Tables[0].Rows[0]["MainID"]!=null && ds.Tables[0].Rows[0]["MainID"].ToString()!="")
				{
					model.MainID=int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TableTypeID"]!=null && ds.Tables[0].Rows[0]["TableTypeID"].ToString()!="")
				{
					model.TableTypeID=int.Parse(ds.Tables[0].Rows[0]["TableTypeID"].ToString());
				}
					model.SerName=ds.Tables[0].Rows[0]["SerName"].ToString();
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
			strSql.Append("select  1 as A,ID,Remark,Image,MainID,TableTypeID,SerName ");
			strSql.Append(" FROM ImageList ");
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
			strSql.Append(" ID,Remark,Image,MainID,TableTypeID,SerName ");
			strSql.Append(" FROM ImageList ");
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
			parameters[0].Value = "ImageList";
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

