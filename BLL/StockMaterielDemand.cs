using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���StockMaterielDemand ��ժҪ˵����
	/// </summary>
	public class StockMaterielDemand
	{
		private readonly Hownet.DAL.StockMaterielDemand dal=new Hownet.DAL.StockMaterielDemand();
		public StockMaterielDemand()
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
		public int  Add(Hownet.Model.StockMaterielDemand model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.StockMaterielDemand> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.StockMaterielDemand model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.StockMaterielDemand> li=DataTableToList(dt);
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
		public Hownet.Model.StockMaterielDemand GetModel(int ID)
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
		public List<Hownet.Model.StockMaterielDemand> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.StockMaterielDemand> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.StockMaterielDemand> modelList = new List<Hownet.Model.StockMaterielDemand>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
                try
                {
                    Hownet.Model.StockMaterielDemand model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new Hownet.Model.StockMaterielDemand();
                        if (dt.Rows[n]["ID"].ToString() != "")
                        {
                            model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                        }
                        else
                        {
                            model.ID = 0;
                        }
                        if (dt.Rows[n]["PlanID"].ToString() != "")
                        {
                            model.PlanID = int.Parse(dt.Rows[n]["PlanID"].ToString());
                        }
                        else
                        {
                            model.PlanID = 0;
                        }
                        if (dt.Rows[n]["MaterielID"].ToString() != "")
                        {
                            model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                        }
                        else
                        {
                            model.MaterielID = 0;
                        }
                        if (dt.Rows[n]["ColorID"].ToString() != "")
                        {
                            model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                        }
                        else
                        {
                            model.ColorID = 0;
                        }
                        if (dt.Rows[n]["ColorOneID"].ToString() != "")
                        {
                            model.ColorOneID = int.Parse(dt.Rows[n]["ColorOneID"].ToString());
                        }
                        else
                        {
                            model.ColorOneID = 0;
                        }
                        if (dt.Rows[n]["ColorTwoID"].ToString() != "")
                        {
                            model.ColorTwoID = int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
                        }
                        else
                        {
                            model.ColorTwoID = 0;
                        }
                        if (dt.Rows[n]["Amount"].ToString() != "")
                        {
                            model.Amount = decimal.Parse(dt.Rows[n]["Amount"].ToString());
                        }
                        else
                        {
                            model.Amount = 0;
                        }
                        if (dt.Rows[n]["NotAllotAmount"].ToString() != "")
                        {
                            model.NotAllotAmount = decimal.Parse(dt.Rows[n]["NotAllotAmount"].ToString());
                        }
                        else
                        {
                            model.NotAllotAmount = 0;
                        }
                        if (dt.Rows[n]["stockAmount"].ToString() != "")
                        {
                            model.stockAmount = decimal.Parse(dt.Rows[n]["stockAmount"].ToString());
                        }
                        else
                        {
                            model.stockAmount = 0;
                        }
                        if (dt.Rows[n]["stockNotAmount"].ToString() != "")
                        {
                            model.stockNotAmount = decimal.Parse(dt.Rows[n]["stockNotAmount"].ToString());
                        }
                        else
                        {
                            model.stockNotAmount = 0;
                        }
                        if (dt.Rows[n]["SizeID"].ToString() != "")
                        {
                            model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
                        }
                        else
                        {
                            model.SizeID = 0;
                        }
                        if (dt.Rows[n]["MeasureID"].ToString() != "")
                        {
                            model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                        }
                        else
                        {
                            model.MeasureID = 0;
                        }
                        if (dt.Rows[n]["DepID"].ToString() != "")
                        {
                            model.DepID = int.Parse(dt.Rows[n]["DepID"].ToString());
                        }
                        else
                        {
                            model.DepID = 0;
                        }
                        if (dt.Rows[n]["MListID"].ToString() != "")
                        {
                            model.MListID = int.Parse(dt.Rows[n]["MListID"].ToString());
                        }
                        else
                        {
                            model.MListID = 0;
                        }
                        if (dt.Rows[n]["MainID"].ToString() != "")
                        {
                            model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                        }
                        else
                        {
                            model.MainID = 0;
                        }
                        if (dt.Rows[n]["IsEnd"].ToString() != "")
                        {
                            model.IsEnd = int.Parse(dt.Rows[n]["IsEnd"].ToString());
                        }
                        else
                        {
                            model.IsEnd = 0;
                        }
                        if (dt.Rows[n]["RepertoryAmount"].ToString() != "")
                        {
                            model.RepertoryAmount = decimal.Parse(dt.Rows[n]["RepertoryAmount"].ToString());
                        }
                        else
                        {
                            model.RepertoryAmount = 0;
                        }
                        if (dt.Rows[n]["NeedAmount"].ToString() != "")
                        {
                            model.NeedAmount = decimal.Parse(dt.Rows[n]["NeedAmount"].ToString());
                        }
                        else
                        {
                            model.NeedAmount = 0;
                        }
                        if (dt.Rows[n]["HasStockAmount"].ToString() != "")
                        {
                            model.HasStockAmount = decimal.Parse(dt.Rows[n]["HasStockAmount"].ToString());
                        }
                        else
                        {
                            model.HasStockAmount = 0;
                        }
                        if (dt.Rows[n]["OutAmount"].ToString() != "")
                        {
                            model.OutAmount = decimal.Parse(dt.Rows[n]["OutAmount"].ToString());
                        }
                        else
                        {
                            model.OutAmount = 0;
                        }
                        model.A = int.Parse(dt.Rows[n]["A"].ToString());
                        modelList.Add(model);
                    }
                }
                catch (Exception ex)
                { }
            
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

