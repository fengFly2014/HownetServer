using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���CaicDayMoney ��ժҪ˵����
	/// </summary>
	public class CaicDayMoney
	{
		private readonly Hownet.DAL.CaicDayMoney dal=new Hownet.DAL.CaicDayMoney();
		public CaicDayMoney()
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
		public int  Add(Hownet.Model.CaicDayMoney model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.CaicDayMoney> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.CaicDayMoney model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.CaicDayMoney> li=DataTableToList(dt);
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
		public Hownet.Model.CaicDayMoney GetModel(int ID)
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
		public List<Hownet.Model.CaicDayMoney> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.CaicDayMoney> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.CaicDayMoney> modelList = new List<Hownet.Model.CaicDayMoney>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.CaicDayMoney model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.CaicDayMoney();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["DayMoney"].ToString()!="")
					{
						model.DayMoney=decimal.Parse(dt.Rows[n]["DayMoney"].ToString());
					}
					else
					{
						model.DayMoney=0;
					}
					if(dt.Rows[n]["NightMoney"].ToString()!="")
					{
						model.NightMoney=decimal.Parse(dt.Rows[n]["NightMoney"].ToString());
					}
					else
					{
						model.NightMoney=0;
					}
					if(dt.Rows[n]["LateAtNightMoney"].ToString()!="")
					{
						model.LateAtNightMoney=decimal.Parse(dt.Rows[n]["LateAtNightMoney"].ToString());
					}
					else
					{
						model.LateAtNightMoney=0;
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["TXBT"].ToString()!="")
					{
						model.TXBT=decimal.Parse(dt.Rows[n]["TXBT"].ToString());
					}
					else
					{
						model.TXBT=0;
					}
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
        public DataSet GetLookupList()
        {
            return dal.GetLookupList();
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

