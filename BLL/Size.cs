using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���Size ��ժҪ˵����
	/// </summary>
	public class Size
	{
		private readonly Hownet.DAL.Size dal=new Hownet.DAL.Size();
		public Size()
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
		public int  Add(Hownet.Model.Size model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Size> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.Size model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.Size> li=DataTableToList(dt);
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
		public Hownet.Model.Size GetModel(int ID)
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
		public List<Hownet.Model.Size> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.Size> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.Size> modelList = new List<Hownet.Model.Size>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.Size model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.Size();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.Name=dt.Rows[n]["Name"].ToString();
					model.Sn=dt.Rows[n]["Sn"].ToString();
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
					if(dt.Rows[n]["IsEnd"].ToString()!="")
					{
						model.IsEnd=int.Parse(dt.Rows[n]["IsEnd"].ToString());
					}
					if(dt.Rows[n]["SizeTypeID"].ToString()!="")
					{
						model.SizeTypeID=int.Parse(dt.Rows[n]["SizeTypeID"].ToString());
					}
                    if (dt.Rows[n]["Orders"] != null && dt.Rows[n]["Orders"].ToString() != "")
                    {
                        model.Orders = int.Parse(dt.Rows[n]["Orders"].ToString());
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
           /// <summary>
        /// ����ĳ�������ID
        /// </summary>
        /// <param name="CName"></param>
        /// <returns></returns>
        public int GetID(string SName)
        {
            return dal.GetID(SName);
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

