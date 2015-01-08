using System;
using System.Data;

using Hownet.Model;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���MaterielDemand ��ժҪ˵����
	/// </summary>
	public class MaterielDemand
	{
		private readonly Hownet.DAL.MaterielDemand dal=new Hownet.DAL.MaterielDemand();
		public MaterielDemand()
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
		public int  Add(Hownet.Model.MaterielDemand model)
		{
			return dal.Add(model);
		}

        /// <summary>
        /// ����һ������,����ԴΪDataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.MaterielDemand> li = DataTableToList(dt);
            if (li.Count > 0)
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
        public void Update(Hownet.Model.MaterielDemand model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.MaterielDemand> li = DataTableToList(dt);
            if (li.Count > 0)
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
		public Hownet.Model.MaterielDemand GetModel(int ID)
		{
			return dal.GetModel(ID);
		}

        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.MaterielDemand> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.MaterielDemand> modelList = new List<Hownet.Model.MaterielDemand>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.MaterielDemand model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.MaterielDemand();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["ProduceTaskID"].ToString() != "")
                    {
                        model.ProduceTaskID = int.Parse(dt.Rows[n]["ProduceTaskID"].ToString());
                    }
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    if (dt.Rows[n]["ColorID"].ToString() != "")
                    {
                        model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                    }
                    if (dt.Rows[n]["ColorOneID"].ToString() != "")
                    {
                        model.ColorOneID = int.Parse(dt.Rows[n]["ColorOneID"].ToString());
                    }
                    if (dt.Rows[n]["ColorTwoID"].ToString() != "")
                    {
                        model.ColorTwoID = int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
                    }
                    if (dt.Rows[n]["Amount"].ToString() != "")
                    {
                        model.Amount = decimal.Parse(dt.Rows[n]["Amount"].ToString());
                    }
                    if (dt.Rows[n]["NotAllotAmount"].ToString() != "")
                    {
                        model.NotAllotAmount = decimal.Parse(dt.Rows[n]["NotAllotAmount"].ToString());
                    }
                    if (dt.Rows[n]["stockAmount"].ToString() != "")
                    {
                        model.stockAmount = decimal.Parse(dt.Rows[n]["stockAmount"].ToString());
                    }
                    if (dt.Rows[n]["stockNotAmount"].ToString() != "")
                    {
                        model.stockNotAmount = decimal.Parse(dt.Rows[n]["stockNotAmount"].ToString());
                    }
                    if (dt.Rows[n]["SizeID"].ToString() != "")
                    {
                        model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
                    }
                    if (dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    if (dt.Rows[n]["DepID"].ToString() != "")
                    {
                        model.DepID = int.Parse(dt.Rows[n]["DepID"].ToString());
                    }
                    if (dt.Rows[n]["MListID"].ToString() != "")
                    {
                        model.MListID = int.Parse(dt.Rows[n]["MListID"].ToString());
                    }
                    if (dt.Rows[n]["TableTypeID"].ToString() != "")
                    {
                        model.TableTypeID = int.Parse(dt.Rows[n]["TableTypeID"].ToString());
                    }
                    else
                    {
                        model.TableTypeID = 0;
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
                    modelList.Add(model);
                }
            }
            return modelList;
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
		public DataSet GetAllList()
		{
			return GetList("");
		}
        
        /// <summary>
        /// ȡ����������ֺ���б�
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetTask(int TaskID, int TableTypeID)
        {
            return dal.GetTask(TaskID, TableTypeID);
        }
          /// <summary>
        /// ȡ��ĳһδ������ϵ���ϸ
        /// </summary>
        /// <param name="AttributeID"></param>
        /// <returns></returns>
        public DataSet ShowInfo(int MListID)
        {
            return dal.ShowInfo(MListID);
        }
        /// <summary>
        /// ɾ��ĳ���Ѽ������������GetNeedAmountByMListID
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        public void DelNeed(int MainID, int TableTypeID)
        {
            dal.DelNeed(MainID, TableTypeID);
        }
          /// <summary>
        /// �����ϼƻ�ʱ������һϵ�мƻ������������
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetNeedAmount(string strWhere,string strTask)
        {
            return dal.GetNeedAmount(strWhere,strTask);
        }
          /// <summary>
        /// ��ȡ��һЩ�ƻ����У�ʹ��ĳ���ϵ���ϸ�����ڷ���ʹ�ÿ������ʹ�òɹ�����
        /// </summary>
        /// <param name="MListID"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetNeedAmountByMListID(int MListID, string strWhere,int TypeID,string strTaskID)
        {
            return dal.GetNeedAmountByMListID(MListID, strWhere,TypeID,strTaskID);
        }
        /// <summary>
        /// ����ĳ�����ƻ����������������������ֶ������깺��
        /// </summary>
        /// <param name="PlanID"></param>
        /// <param name="TableTypeID"></param>
        /// <returns></returns>
        public DataSet GetListByPlanID(int PlanID, int TableTypeID)
        {
            return dal.GetListByPlanID(PlanID, TableTypeID);
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

