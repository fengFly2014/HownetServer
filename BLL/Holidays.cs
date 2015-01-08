using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���Holidays ��ժҪ˵����
	/// </summary>
	public class Holidays
	{
		private readonly Hownet.DAL.Holidays dal=new Hownet.DAL.Holidays();
		public Holidays()
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
		public int  Add(Hownet.Model.Holidays model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Holidays> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.Holidays model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.Holidays> li=DataTableToList(dt);
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
		public Hownet.Model.Holidays GetModel(int ID)
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
		public List<Hownet.Model.Holidays> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.Holidays> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.Holidays> modelList = new List<Hownet.Model.Holidays>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.Holidays model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.Holidays();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["TypeID"].ToString()!="")
					{
						model.TypeID=int.Parse(dt.Rows[n]["TypeID"].ToString());
					}
					else
					{
						model.TypeID=0;
					}
					if(dt.Rows[n]["TimeOne"].ToString()!="")
					{
						model.TimeOne=DateTime.Parse(dt.Rows[n]["TimeOne"].ToString());
					}
					else
					{
						model.TimeOne=DateTime.Parse("1900-1-1");
					}
					if(dt.Rows[n]["TimeTwo"].ToString()!="")
					{
						model.TimeTwo=DateTime.Parse(dt.Rows[n]["TimeTwo"].ToString());
					}
					else
					{
						model.TimeTwo=DateTime.Parse("1900-1-1");
					}
					if(dt.Rows[n]["EmployeeID"].ToString()!="")
					{
						model.EmployeeID=int.Parse(dt.Rows[n]["EmployeeID"].ToString());
					}
					else
					{
						model.EmployeeID=0;
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					else
					{
						model.MainID=0;
					}
					if(dt.Rows[n]["IsCaicMoney"].ToString()!="")
					{
						if((dt.Rows[n]["IsCaicMoney"].ToString()=="1")||(dt.Rows[n]["IsCaicMoney"].ToString().ToLower()=="true"))
						{
						model.IsCaicMoney=true;
						}
						else
						{
							model.IsCaicMoney=false;
						}
					}
					if(dt.Rows[n]["Times"].ToString()!="")
					{
						model.Times=int.Parse(dt.Rows[n]["Times"].ToString());
					}
					else
					{
						model.Times=0;
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
		/// ��÷�ҳ�����б�
		/// </summary>
		//public DataSet GetPageList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}

