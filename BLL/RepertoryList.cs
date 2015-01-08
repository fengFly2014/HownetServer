using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���RepertoryList ��ժҪ˵����
	/// </summary>
	public class RepertoryList
	{
		private readonly Hownet.DAL.RepertoryList dal=new Hownet.DAL.RepertoryList();
		public RepertoryList()
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
		public int  Add(Hownet.Model.RepertoryList model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.RepertoryList> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.RepertoryList model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.RepertoryList> li=DataTableToList(dt);
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
		public Hownet.Model.RepertoryList GetModel(int ID)
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
		public List<Hownet.Model.RepertoryList> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.RepertoryList> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.RepertoryList> modelList = new List<Hownet.Model.RepertoryList>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.RepertoryList model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.RepertoryList();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["Amount"].ToString()!="")
					{
						model.Amount=decimal.Parse(dt.Rows[n]["Amount"].ToString());
					}
					else
					{
						model.Amount=0;
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					else
					{
						model.MainID=0;
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["NotAmount"].ToString()!="")
					{
						model.NotAmount=decimal.Parse(dt.Rows[n]["NotAmount"].ToString());
					}
					else
					{
						model.NotAmount=0;
					}
					if(dt.Rows[n]["StockListID"].ToString()!="")
					{
						model.StockListID=int.Parse(dt.Rows[n]["StockListID"].ToString());
					}
					else
					{
						model.StockListID=0;
					}
					if(dt.Rows[n]["BatchNumber"].ToString()!="")
					{
						model.BatchNumber=int.Parse(dt.Rows[n]["BatchNumber"].ToString());
					}
					else
					{
						model.BatchNumber=0;
					}
					if(dt.Rows[n]["IsEnd"].ToString()!="")
					{
						if((dt.Rows[n]["IsEnd"].ToString()=="1")||(dt.Rows[n]["IsEnd"].ToString().ToLower()=="true"))
						{
						model.IsEnd=true;
						}
						else
						{
							model.IsEnd=false;
						}
					}
                    if (dt.Rows[n]["SpecID"] != null && dt.Rows[n]["SpecID"].ToString() != "")
                    {
                        model.SpecID = int.Parse(dt.Rows[n]["SpecID"].ToString());
                    }
                    model.SpecName = dt.Rows[n]["SpecName"].ToString();
                    if (dt.Rows[n]["DepotInfoID"] != null && dt.Rows[n]["DepotInfoID"].ToString() != "")
                    {
                        model.DepotInfoID = int.Parse(dt.Rows[n]["DepotInfoID"].ToString());
                    }
                    model.DepotInfoName = dt.Rows[n]["DepotInfoName"].ToString();
                    if (dt.Rows[n]["DateTime"] != null && dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    if (dt.Rows[n]["PlanID"] != null && dt.Rows[n]["PlanID"].ToString() != "")
                    {
                        model.PlanID = int.Parse(dt.Rows[n]["PlanID"].ToString());
                    }
                    model.QRID = dt.Rows[n]["QRID"].ToString();
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
        ///�����ջ���ϸ ɾ��һ������
        /// </summary>
        public bool DeleteByStockInfoID(int ID)
        {

            return dal.DeleteByStockInfoID(ID);
        }
        public void UpPlanID(int ID, int PlanID)
        {
            dal.UpPlanID(ID, PlanID);
        }
                /// <summary>
        /// ���ݿ�ź��̱꣬���ؿ������
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <param name="BrandID"></param>
        /// <param name="DepotID"></param>
        /// <returns></returns>
        public DataSet GetListByMB(int MaterielID, int BrandID, int DepotID)
        {
            return dal.GetListByMB(MaterielID, BrandID, DepotID);
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

