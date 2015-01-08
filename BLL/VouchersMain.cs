using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// VouchersMain
	/// </summary>
	public partial class VouchersMain
	{
		private readonly Hownet.DAL.VouchersMain dal=new Hownet.DAL.VouchersMain();
		public VouchersMain()
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
		public int  Add(Hownet.Model.VouchersMain model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.VouchersMain> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.VouchersMain model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.VouchersMain> li = DataTableToList(dt);
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
		public Hownet.Model.VouchersMain GetModel(int ID)
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
		public List<Hownet.Model.VouchersMain> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.VouchersMain> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.VouchersMain> modelList = new List<Hownet.Model.VouchersMain>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.VouchersMain model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.VouchersMain();
					if(dt.Rows[n]["A"].ToString()!="")
					{
					model.A=int.Parse(dt.Rows[n]["A"].ToString());
					}
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["FillDate"].ToString()!="")
					{
						model.FillDate=DateTime.Parse(dt.Rows[n]["FillDate"].ToString());
					}
					if(dt.Rows[n]["FillMan"].ToString()!="")
					{
						model.FillMan=int.Parse(dt.Rows[n]["FillMan"].ToString());
					}
					if(dt.Rows[n]["CaiKuai"].ToString()!="")
					{
						model.CaiKuai=int.Parse(dt.Rows[n]["CaiKuai"].ToString());
					}
					if(dt.Rows[n]["CKDate"].ToString()!="")
					{
						model.CKDate=DateTime.Parse(dt.Rows[n]["CKDate"].ToString());
					}
					if(dt.Rows[n]["JiZhang"].ToString()!="")
					{
						model.JiZhang=int.Parse(dt.Rows[n]["JiZhang"].ToString());
					}
					if(dt.Rows[n]["JZDate"].ToString()!="")
					{
						model.JZDate=DateTime.Parse(dt.Rows[n]["JZDate"].ToString());
					}
					if(dt.Rows[n]["FuHe"].ToString()!="")
					{
						model.FuHe=int.Parse(dt.Rows[n]["FuHe"].ToString());
					}
					if(dt.Rows[n]["FHDate"].ToString()!="")
					{
						model.FHDate=DateTime.Parse(dt.Rows[n]["FHDate"].ToString());
					}
					if(dt.Rows[n]["ZhiZheng"].ToString()!="")
					{
						model.ZhiZheng=int.Parse(dt.Rows[n]["ZhiZheng"].ToString());
					}
					if(dt.Rows[n]["ZZDate"].ToString()!="")
					{
						model.ZZDate=DateTime.Parse(dt.Rows[n]["ZZDate"].ToString());
					}
					if(dt.Rows[n]["SumNum"].ToString()!="")
					{
						model.SumNum=int.Parse(dt.Rows[n]["SumNum"].ToString());
					}
					if(dt.Rows[n]["Num"].ToString()!="")
					{
						model.Num=int.Parse(dt.Rows[n]["Num"].ToString());
					}
					if(dt.Rows[n]["AttachmentSum"].ToString()!="")
					{
						model.AttachmentSum=int.Parse(dt.Rows[n]["AttachmentSum"].ToString());
					}
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    if (dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
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
        public DataSet GetIDList()
        {
            return dal.GetIDList();
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

