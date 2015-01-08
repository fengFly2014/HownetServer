using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ItemsText
	/// </summary>
	public partial class ItemsText
	{
		private readonly Hownet.DAL.ItemsText dal=new Hownet.DAL.ItemsText();
		public ItemsText()
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
		public int  Add(Hownet.Model.ItemsText model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.ItemsText> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.ItemsText model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.ItemsText> li = DataTableToList(dt);
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
		public Hownet.Model.ItemsText GetModel(int ID)
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
		public List<Hownet.Model.ItemsText> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.ItemsText> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.ItemsText> modelList = new List<Hownet.Model.ItemsText>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.ItemsText model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.ItemsText();
					if(dt.Rows[n]["A"].ToString()!="")
					{
					model.A=int.Parse(dt.Rows[n]["A"].ToString());
					}
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["ItemsID"].ToString()!="")
					{
						model.ItemsID=int.Parse(dt.Rows[n]["ItemsID"].ToString());
					}
					if(dt.Rows[n]["UserID"].ToString()!="")
					{
						model.UserID=int.Parse(dt.Rows[n]["UserID"].ToString());
					}
					model.ColumnsName=dt.Rows[n]["ColumnsName"].ToString();
					model.ShowText=dt.Rows[n]["ShowText"].ToString();
					if(dt.Rows[n]["IsVisible"].ToString()!="")
					{
						if((dt.Rows[n]["IsVisible"].ToString()=="1")||(dt.Rows[n]["IsVisible"].ToString().ToLower()=="true"))
						{
						model.IsVisible=true;
						}
						else
						{
							model.IsVisible=false;
						}
					}
                    if (dt.Rows[n]["Widths"].ToString() != "")
                    {
                        model.Widths = int.Parse(dt.Rows[n]["Widths"].ToString());
                    }
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
        /// ��ȡĳ����ʾʱ���б�ͷ���Լ��Ƿ���ʾ������
        /// </summary>
        /// <param name="FromText"></param>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public DataSet GetHeadText(string FromText, int UserID)
        {
            return dal.GetHeadText(FromText, UserID);
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

