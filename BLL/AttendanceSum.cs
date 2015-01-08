using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���AttendanceSum ��ժҪ˵����
	/// </summary>
	public class AttendanceSum
	{
		private readonly Hownet.DAL.AttendanceSum dal=new Hownet.DAL.AttendanceSum();
		public AttendanceSum()
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
		public int  Add(Hownet.Model.AttendanceSum model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.AttendanceSum> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.AttendanceSum model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.AttendanceSum> li=DataTableToList(dt);
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
		public Hownet.Model.AttendanceSum GetModel(int ID)
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
		public List<Hownet.Model.AttendanceSum> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.AttendanceSum> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.AttendanceSum> modelList = new List<Hownet.Model.AttendanceSum>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.AttendanceSum model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.AttendanceSum();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["EmployeeID"].ToString()!="")
					{
						model.EmployeeID=int.Parse(dt.Rows[n]["EmployeeID"].ToString());
					}
					else
					{
						model.EmployeeID=0;
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					else
					{
						model.MainID=0;
					}
					if(dt.Rows[n]["DayWorkMin"].ToString()!="")
					{
						model.DayWorkMin=int.Parse(dt.Rows[n]["DayWorkMin"].ToString());
					}
					else
					{
						model.DayWorkMin=0;
					}
					if(dt.Rows[n]["DayWorkTime"].ToString()!="")
					{
						model.DayWorkTime=DateTime.Parse(dt.Rows[n]["DayWorkTime"].ToString());
					}
					else
					{
						model.DayWorkTime=DateTime.Parse("1900-1-1");
					}
					if(dt.Rows[n]["BelateMin"].ToString()!="")
					{
						model.BelateMin=int.Parse(dt.Rows[n]["BelateMin"].ToString());
					}
					else
					{
						model.BelateMin=0;
					}
					if(dt.Rows[n]["LeaveEarlyMin"].ToString()!="")
					{
						model.LeaveEarlyMin=int.Parse(dt.Rows[n]["LeaveEarlyMin"].ToString());
					}
					else
					{
						model.LeaveEarlyMin=0;
					}
					if(dt.Rows[n]["AbsenteeismMin"].ToString()!="")
					{
						model.AbsenteeismMin=int.Parse(dt.Rows[n]["AbsenteeismMin"].ToString());
					}
					else
					{
						model.AbsenteeismMin=0;
					}
					if(dt.Rows[n]["Money"].ToString()!="")
					{
						model.Money=decimal.Parse(dt.Rows[n]["Money"].ToString());
					}
					else
					{
						model.Money=0;
					}
					if(dt.Rows[n]["OvertimeMin"].ToString()!="")
					{
						model.OvertimeMin=int.Parse(dt.Rows[n]["OvertimeMin"].ToString());
					}
					else
					{
						model.OvertimeMin=0;
					}
					if(dt.Rows[n]["OvertimeTime"].ToString()!="")
					{
						model.OvertimeTime=DateTime.Parse(dt.Rows[n]["OvertimeTime"].ToString());
					}
					else
					{
						model.OvertimeTime=DateTime.Parse("1900-1-1");
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

