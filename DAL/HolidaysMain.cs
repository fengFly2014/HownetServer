using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace Hownet.DAL
{
	/// <summary>
	/// ���ݷ�����HolidaysMain��
	/// </summary>
	public class HolidaysMain
	{
		public HolidaysMain()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "HolidaysMain"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from HolidaysMain");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(Hownet.Model.HolidaysMain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HolidaysMain(");
			strSql.Append("DateTime,Num,Remark,UpData,FillDate,FillMan)");
			strSql.Append(" values (");
			strSql.Append("@DateTime,@Num,@Remark,@UpData,@FillDate,@FillMan)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4)};
			parameters[0].Value = model.DateTime;
			parameters[1].Value = model.Num;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.UpData;
			parameters[4].Value = model.FillDate;
			parameters[5].Value = model.FillMan;

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
		public void Update(Hownet.Model.HolidaysMain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HolidaysMain set ");
			strSql.Append("DateTime=@DateTime,");
			strSql.Append("Num=@Num,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("UpData=@UpData,");
			strSql.Append("FillDate=@FillDate,");
			strSql.Append("FillMan=@FillMan");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.DateTime;
			parameters[2].Value = model.Num;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.UpData;
			parameters[5].Value = model.FillDate;
			parameters[6].Value = model.FillMan;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HolidaysMain ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Hownet.Model.HolidaysMain GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,DateTime,Num,Remark,UpData,FillDate,FillMan from HolidaysMain ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.HolidaysMain model=new Hownet.Model.HolidaysMain();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DateTime"].ToString()!="")
				{
					model.DateTime=DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Num"].ToString()!="")
				{
					model.Num=int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["UpData"].ToString()!="")
				{
					model.UpData=int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FillDate"].ToString()!="")
				{
					model.FillDate=DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FillMan"].ToString()!="")
				{
					model.FillMan=int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
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
			strSql.Append("select 1 as A,ID,DateTime,Num,Remark,UpData,FillDate,FillMan ");
			strSql.Append(" FROM HolidaysMain ");
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
			strSql.Append(" ID,DateTime,Num,Remark,UpData,FillDate,FillMan ");
			strSql.Append(" FROM HolidaysMain ");
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
			parameters[0].Value = "HolidaysMain";
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

