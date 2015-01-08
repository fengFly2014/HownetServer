using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���SizeTableInfo ��ժҪ˵����
	/// </summary>
	public class SizeTableInfo
	{
		private readonly Hownet.DAL.SizeTableInfo dal=new Hownet.DAL.SizeTableInfo();
		public SizeTableInfo()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Hownet.Model.SizeTableInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.SizeTableInfo> li=DataTableToList(dt);
			if(li.Count>0)
			{
				return dal.Add(li[0]);
			}
			else
			{
				return 0;
			}
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(Hownet.Model.SizeTableInfo model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.SizeTableInfo> li=DataTableToList(dt);
			if(li.Count>0)
			{
				dal.Update(li[0]);
			}
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			
			dal.Delete(ID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Hownet.Model.SizeTableInfo GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}



		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetTopList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.SizeTableInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.SizeTableInfo> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.SizeTableInfo> modelList = new List<Hownet.Model.SizeTableInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.SizeTableInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.SizeTableInfo();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					else
					{
						model.MainID=0;
					}
					model.Orders=dt.Rows[n]["Orders"].ToString();
					if(dt.Rows[n]["Measurement"].ToString()!="")
					{
						model.Measurement=int.Parse(dt.Rows[n]["Measurement"].ToString());
					}
					else
					{
						model.Measurement=0;
					}
					model.Size1=dt.Rows[n]["Size1"].ToString();
					model.Size2=dt.Rows[n]["Size2"].ToString();
					model.Size3=dt.Rows[n]["Size3"].ToString();
					model.Size4=dt.Rows[n]["Size4"].ToString();
					model.Size5=dt.Rows[n]["Size5"].ToString();
					model.Size6=dt.Rows[n]["Size6"].ToString();
					model.Size7=dt.Rows[n]["Size7"].ToString();
					model.Size8=dt.Rows[n]["Size8"].ToString();
					model.Size9=dt.Rows[n]["Size9"].ToString();
					model.Size10=dt.Rows[n]["Size10"].ToString();
					model.Size11=dt.Rows[n]["Size11"].ToString();
					model.Size12=dt.Rows[n]["Size12"].ToString();
					model.A=int.Parse(dt.Rows[n]["A"].ToString());
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
        public DataSet GetInfoList(int MainID)
        {
            return dal.GetInfoList(MainID);
        }
		/// <summary>
		/// ��÷�ҳ�����б�
		/// </summary>
		//public DataSet GetPageList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}

