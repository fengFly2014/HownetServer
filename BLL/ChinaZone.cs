using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���ChinaZone ��ժҪ˵����
	/// </summary>
	public class ChinaZone
	{
		private readonly Hownet.DAL.ChinaZone dal=new Hownet.DAL.ChinaZone();
		public ChinaZone()
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
		public bool Exists(int ZoneID)
		{
			return dal.Exists(ZoneID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Hownet.Model.ChinaZone model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.ChinaZone> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.ChinaZone model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.ChinaZone> li=DataTableToList(dt);
			if(li.Count>0)
			{
				dal.Update(li[0]);
			}
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ZoneID)
		{
			
			dal.Delete(ZoneID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Hownet.Model.ChinaZone GetModel(int ZoneID)
		{
			
			return dal.GetModel(ZoneID);
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
		public List<Hownet.Model.ChinaZone> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.ChinaZone> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.ChinaZone> modelList = new List<Hownet.Model.ChinaZone>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.ChinaZone model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.ChinaZone();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ZoneID"].ToString());
					}
					model.ParentID=dt.Rows[n]["ParentID"].ToString();
					if(dt.Rows[n]["OrderNum"].ToString()!="")
					{
						model.OrderNum=int.Parse(dt.Rows[n]["OrderNum"].ToString());
					}
					model.InfoNum=dt.Rows[n]["InfoNum"].ToString();
					model.Name=dt.Rows[n]["Name"].ToString();
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

