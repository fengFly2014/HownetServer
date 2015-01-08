using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���Working ��ժҪ˵����
	/// </summary>
	public class Working
	{
		private readonly Hownet.DAL.Working dal=new Hownet.DAL.Working();
		public Working()
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
		/// ����һ������
		/// </summary>
		public int  Add(Hownet.Model.Working model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Working> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.Working model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.Working> li=DataTableToList(dt);
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
		public Hownet.Model.Working GetModel(int ID)
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
		public List<Hownet.Model.Working> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.Working> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.Working> modelList = new List<Hownet.Model.Working>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.Working model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.Working();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.Name=dt.Rows[n]["Name"].ToString();
					model.Sn=dt.Rows[n]["Sn"].ToString();
					if(dt.Rows[n]["WorkTypeID"].ToString()!="")
					{
						model.WorkTypeID=int.Parse(dt.Rows[n]["WorkTypeID"].ToString());
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
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
                    if (dt.Rows[n]["IsSpecial"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsSpecial"].ToString() == "1") || (dt.Rows[n]["IsSpecial"].ToString().ToLower() == "true"))
                        {
                            model.IsSpecial = true;
                        }
                        else
                        {
                            model.IsSpecial = false;
                        }
                    }
                    if (dt.Rows[n]["Price"].ToString() != "")
                    {
                        model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
                    }
                    else
                    {
                        model.Price = 0;
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
        public DataSet GetPWList(bool IsShowSn)
        {
            DataTable dt = dal.GetList("ID=0 ").Tables[0].Clone();
            string strWhere = "(IsSpecial=1) And (WorkTypeID>-1)  Order By ";
            if (IsShowSn)
                strWhere += " SnName ";
            else
                strWhere += " Name ";
            DataTable dtt = dal.GetList(strWhere).Tables[0];
            for (int i = 0; i < dtt.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr.ItemArray = dtt.Rows[i].ItemArray;
                dt.Rows.Add(dr);
            }
            DataRow drr = dt.NewRow();
            drr["ID"] = -1;
            drr["Name"] = "---------------";
            drr["IsEnd"] = 0;
            drr["SnName"] = "---------------";
            dt.Rows.Add(drr);
            strWhere = "(IsSpecial=0) And (WorkTypeID>-1)  Order By ";
            if (IsShowSn)
                strWhere += " SnName ";
            else
                strWhere += " Name ";
            DataTable dtem = dal.GetList(strWhere).Tables[0];//"(IsSpecial=0) And (WorkTypeID>-1)  Order By Name "
            for (int i = 0; i < dtem.Rows.Count; i++)
            {
                DataRow ddr = dt.NewRow();
                ddr.ItemArray = dtem.Rows[i].ItemArray;
                dt.Rows.Add(ddr);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        public bool CheckCanDelete(int ID)
        {
            return dal.CheckCanDelete(ID);
        }
        public DataSet GetWorkintNotAmount(int WorkingID)
        {
            return dal.GetWorkintNotAmount(WorkingID);
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

