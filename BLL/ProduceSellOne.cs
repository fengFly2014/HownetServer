using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���ProduceSellOne ��ժҪ˵����
	/// </summary>
	public class ProduceSellOne
	{
		private readonly Hownet.DAL.ProduceSellOne dal=new Hownet.DAL.ProduceSellOne();
		public ProduceSellOne()
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
		public int  Add(Hownet.Model.ProduceSellOne model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.ProduceSellOne> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.ProduceSellOne model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.ProduceSellOne> li=DataTableToList(dt);
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
		public Hownet.Model.ProduceSellOne GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}



		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
            DataSet ds = dal.GetList(strWhere);
            ds.Tables[0].Columns.Add("RepAmount", typeof(decimal));
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ds.Tables[0].Rows[i]["RepAmount"] = DBNull.Value;
                }
            }
			return ds;
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
		public List<Hownet.Model.ProduceSellOne> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.ProduceSellOne> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.ProduceSellOne> modelList = new List<Hownet.Model.ProduceSellOne>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.ProduceSellOne model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.ProduceSellOne();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    else
                    {
                        model.MaterielID = 0;
                    }
                    if (dt.Rows[n]["Price"].ToString() != "")
                    {
                        model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
                    }
                    else
                    {
                        model.Price = 0;
                    }
                    if (dt.Rows[n]["Amount"].ToString() != "")
                    {
                        model.Amount = decimal.Parse(dt.Rows[n]["Amount"].ToString());
                    }
                    else
                    {
                        model.Amount = 0;
                    }
                    if (dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    else
                    {
                        model.Money = 0;
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    else
                    {
                        model.MainID = 0;
                    }
                    if (dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    else
                    {
                        model.MeasureID = 0;
                    }
                    if (dt.Rows[n]["BoxMeasureID"].ToString() != "")
                    {
                        model.BoxMeasureID = int.Parse(dt.Rows[n]["BoxMeasureID"].ToString());
                    }
                    else
                    {
                        model.BoxMeasureID = 0;
                    }
                    if (dt.Rows[n]["Conversion"].ToString() != "")
                    {
                        model.Conversion = int.Parse(dt.Rows[n]["Conversion"].ToString());
                    }
                    else
                    {
                        model.Conversion = 0;
                    }
                    if (dt.Rows[n]["BoxMeasureAmount"].ToString() != "")
                    {
                        model.BoxMeasureAmount = int.Parse(dt.Rows[n]["BoxMeasureAmount"].ToString());
                    }
                    else
                    {
                        model.BoxMeasureAmount = 0;
                    }
                    if (dt.Rows[n]["BrandID"].ToString() != "")
                    {
                        model.BrandID = int.Parse(dt.Rows[n]["BrandID"].ToString());
                    }
                    else
                    {
                        model.BrandID = 0;
                    }
                    if (dt.Rows[n]["SalesOrderInfoID"].ToString() != "")
                    {
                        model.SalesOrderInfoID = int.Parse(dt.Rows[n]["SalesOrderInfoID"].ToString());
                    }
                    else
                    {
                        model.SalesOrderInfoID = 0;
                    }
                    if (dt.Rows[n]["RemarkID"].ToString() != "")
                    {
                        model.RemarkID = int.Parse(dt.Rows[n]["RemarkID"].ToString());
                    }
                    else
                    {
                        model.RemarkID = 0;
                    }
                    if (dt.Rows[n]["MTID"].ToString() != "")
                    {
                        model.MTID = int.Parse(dt.Rows[n]["MTID"].ToString());
                    }
                    else
                    {
                        model.MTID = 0;
                    }
                    model.SellRemark = dt.Rows[n]["SellRemark"].ToString();
                    try
                    {
                        model.CompanyMaterielName = dt.Rows[n]["CompanyMaterielName"].ToString();
                    }
                    catch (Exception ex)
                    {
                        model.CompanyMaterielName = string.Empty;
                    }
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
        public void DeleteByMain(int MainID)
        {
            dal.DeleteByMain(MainID);
        }        /// <summary>
        /// ĳ�ͻ������ķ�����¼
        /// </summary>
        /// <param name="SalesID"></param>
        /// <returns></returns>
        public int CountSellSales(int SalesID)
        {
            return dal.CountSellSales(SalesID);
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

