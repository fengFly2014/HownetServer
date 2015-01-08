using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// VouchersInfo
	/// </summary>
	public partial class VouchersInfo
	{
		private readonly Hownet.DAL.VouchersInfo dal=new Hownet.DAL.VouchersInfo();
		public VouchersInfo()
		{}
		#region  Method

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
		public int  Add(Hownet.Model.VouchersInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.VouchersInfo> li = DataTableToList(dt);
			int a=0;
			if (li.Count > 0)
			{
				for (int i = 0; i < li.Count; i++)
				{
					a=Add(li[i]);
				}
			}
				return a;
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Hownet.Model.VouchersInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.VouchersInfo> li = DataTableToList(dt);
			if (li.Count > 0)
			{
				for (int i = 0; i < li.Count; i++)
				{
					 dal.Update(li[i]);
				}
			}
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Hownet.Model.VouchersInfo GetModel(int ID)
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
		public List<Hownet.Model.VouchersInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.VouchersInfo> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.VouchersInfo> modelList = new List<Hownet.Model.VouchersInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.VouchersInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.VouchersInfo();
					if(dt.Rows[n]["A"].ToString()!="")
					{
					model.A=int.Parse(dt.Rows[n]["A"].ToString());
					}
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					model.Summary=dt.Rows[n]["Summary"].ToString();
					if(dt.Rows[n]["AccountsOne"].ToString()!="")
					{
						model.AccountsOne=int.Parse(dt.Rows[n]["AccountsOne"].ToString());
					}
					if(dt.Rows[n]["AccountsTwo"].ToString()!="")
					{
						model.AccountsTwo=int.Parse(dt.Rows[n]["AccountsTwo"].ToString());
					}
					if(dt.Rows[n]["DebitMoney"].ToString()!="")
					{
						model.DebitMoney=decimal.Parse(dt.Rows[n]["DebitMoney"].ToString());
					}
					if(dt.Rows[n]["CreditMoney"].ToString()!="")
					{
						model.CreditMoney=decimal.Parse(dt.Rows[n]["CreditMoney"].ToString());
					}
					if(dt.Rows[n]["IsPosting"].ToString()!="")
					{
						if((dt.Rows[n]["IsPosting"].ToString()=="1")||(dt.Rows[n]["IsPosting"].ToString().ToLower()=="true"))
						{
						model.IsPosting=true;
						}
						else
						{
							model.IsPosting=false;
						}
					}
                    model.AOne = dt.Rows[n]["AOne"].ToString();
                    model.ATwo = dt.Rows[n]["ATwo"].ToString();
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
        /// ɾ��һ������
        /// </summary>
        public bool DeleteByMainID(int MainID)
        {
            return dal.DeleteByMainID(MainID);
        }
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

