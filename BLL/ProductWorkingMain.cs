using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���ProductWorkingMain ��ժҪ˵����
	/// </summary>
	public class ProductWorkingMain
	{
		private readonly Hownet.DAL.ProductWorkingMain dal=new Hownet.DAL.ProductWorkingMain();
		public ProductWorkingMain()
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
		public int  Add(Hownet.Model.ProductWorkingMain model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.ProductWorkingMain> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.ProductWorkingMain model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.ProductWorkingMain> li=DataTableToList(dt);
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
		public Hownet.Model.ProductWorkingMain GetModel(int ID)
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
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.ProductWorkingMain> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.ProductWorkingMain> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.ProductWorkingMain> modelList = new List<Hownet.Model.ProductWorkingMain>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.ProductWorkingMain model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.ProductWorkingMain();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["MaterielID"].ToString()!="")
					{
						model.MaterielID=int.Parse(dt.Rows[n]["MaterielID"].ToString());
					}
					if(dt.Rows[n]["CompanyID"].ToString()!="")
					{
						model.CompanyID=int.Parse(dt.Rows[n]["CompanyID"].ToString());
					}
					if(dt.Rows[n]["TaskID"].ToString()!="")
					{
						model.TaskID=int.Parse(dt.Rows[n]["TaskID"].ToString());
					}
					if(dt.Rows[n]["DateTime"].ToString()!="")
					{
						model.DateTime=DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
					}
					model.Ver=dt.Rows[n]["Ver"].ToString();
					if(dt.Rows[n]["FillDate"].ToString()!="")
					{
						model.FillDate=DateTime.Parse(dt.Rows[n]["FillDate"].ToString());
					}
					if(dt.Rows[n]["FillMan"].ToString()!="")
					{
						model.FillMan=int.Parse(dt.Rows[n]["FillMan"].ToString());
					}
					if(dt.Rows[n]["VerifyDate"].ToString()!="")
					{
						model.VerifyDate=DateTime.Parse(dt.Rows[n]["VerifyDate"].ToString());
					}
					if(dt.Rows[n]["VerifyMan"].ToString()!="")
					{
						model.VerifyMan=int.Parse(dt.Rows[n]["VerifyMan"].ToString());
					}
					if(dt.Rows[n]["IsDefault"].ToString()!="")
					{
						if((dt.Rows[n]["IsDefault"].ToString()=="1")||(dt.Rows[n]["IsDefault"].ToString().ToLower()=="true"))
						{
						model.IsDefault=true;
						}
						else
						{
							model.IsDefault=false;
						}
					}
					if(dt.Rows[n]["IsEnd"].ToString()!="")
					{
						model.IsEnd=int.Parse(dt.Rows[n]["IsEnd"].ToString());
					}
					if(dt.Rows[n]["IsUse"].ToString()!="")
					{
						if((dt.Rows[n]["IsUse"].ToString()=="1")||(dt.Rows[n]["IsUse"].ToString().ToLower()=="true"))
						{
						model.IsUse=true;
						}
						else
						{
							model.IsUse=false;
						}
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
                    model.A = int.Parse(dt.Rows[n]["A"].ToString());
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
        /// ����·���ĳ��ŵ�������Ҫ��ID�б�
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetIDList(int MaterielID,int TaskID)
        {
            return dal.GetIDList(MaterielID,TaskID);
        }
          /// <summary>
        /// ����ĳ��ŵĹ��յ�IsDefaultΪ��
        /// </summary>
        /// <param name="MaterielID"></param>
        public void UpDefault(int MaterielID)
        {
            dal.UpDefault(MaterielID);
        }
          /// <summary>
        /// ����ĳ��ŵ�Ĭ�Ϲ��յ����
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public int GetIsDefaultID(int MaterielID)
        {
            return dal.GetIsDefaultID(MaterielID);
        }
        public DataSet GetViewList(string strWhere)
        {
            return dal.GetViewList(strWhere);
        }
        public DataSet GetInfoList(int MainID)
        {
            return dal.GetInfoList(MainID);
        }
        public DataSet GetSetPrice(int WorkingID)
        {
            return dal.GetSetPrice(WorkingID);
        }
        public DataSet GetWorkPriceList(int MaterielID, int WorkingID)
        {
            return dal.GetWorkPriceList(MaterielID, WorkingID);
        }
        public decimal GetWorkingMoney(int MaterielID)
        {
            return dal. GetWorkingMoney(MaterielID);
        }
        public DataSet GetSetNoPrice()
        {
            return dal.GetSetNoPrice();
        }
		/// <summary>
		/// ��������б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}

