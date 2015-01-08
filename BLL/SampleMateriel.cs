using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���SampleMateriel ��ժҪ˵����
	/// </summary>
	public class SampleMateriel
	{
		private readonly Hownet.DAL.SampleMateriel dal=new Hownet.DAL.SampleMateriel();
		public SampleMateriel()
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
		public int  Add(Hownet.Model.SampleMateriel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.SampleMateriel> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.SampleMateriel model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.SampleMateriel> li=DataTableToList(dt);
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
		public Hownet.Model.SampleMateriel GetModel(int ID)
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
		public List<Hownet.Model.SampleMateriel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.SampleMateriel> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.SampleMateriel> modelList = new List<Hownet.Model.SampleMateriel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.SampleMateriel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.SampleMateriel();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					else
					{
						model.MainID=0;
					}
					model.Fabric1=dt.Rows[n]["Fabric1"].ToString();
					model.Fabric2=dt.Rows[n]["Fabric2"].ToString();
					model.Fabric3=dt.Rows[n]["Fabric3"].ToString();
					model.Fabric4=dt.Rows[n]["Fabric4"].ToString();
					model.Fabric5=dt.Rows[n]["Fabric5"].ToString();
					model.Materiel1=dt.Rows[n]["Materiel1"].ToString();
					model.Materiel2=dt.Rows[n]["Materiel2"].ToString();
					model.Materiel3=dt.Rows[n]["Materiel3"].ToString();
					model.Materiel4=dt.Rows[n]["Materiel4"].ToString();
					model.Materiel5=dt.Rows[n]["Materiel5"].ToString();
					model.Materiel6=dt.Rows[n]["Materiel6"].ToString();
					model.Materiel7=dt.Rows[n]["Materiel7"].ToString();
					model.Company1=dt.Rows[n]["Company1"].ToString();
					model.LH1=dt.Rows[n]["LH1"].ToString();
					model.Plant1=dt.Rows[n]["Plant1"].ToString();
					model.Company2=dt.Rows[n]["Company2"].ToString();
					model.LH2=dt.Rows[n]["LH2"].ToString();
					model.Plant2=dt.Rows[n]["Plant2"].ToString();
					model.SumAmount=dt.Rows[n]["SumAmount"].ToString();
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

