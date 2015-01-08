using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���PlanUseRep ��ժҪ˵����
	/// </summary>
	public class PlanUseRep
	{
		private readonly Hownet.DAL.PlanUseRep dal=new Hownet.DAL.PlanUseRep();
		public PlanUseRep()
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
		public int  Add(Hownet.Model.PlanUseRep model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.PlanUseRep> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.PlanUseRep model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.PlanUseRep> li=DataTableToList(dt);
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
		public Hownet.Model.PlanUseRep GetModel(int ID)
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
		public List<Hownet.Model.PlanUseRep> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.PlanUseRep> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.PlanUseRep> modelList = new List<Hownet.Model.PlanUseRep>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.PlanUseRep model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.PlanUseRep();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["RelatedID"].ToString()!="")
					{
						model.RelatedID=int.Parse(dt.Rows[n]["RelatedID"].ToString());
					}
					else
					{
						model.RelatedID=0;
					}
					if(dt.Rows[n]["Amount"].ToString()!="")
					{
						model.Amount=decimal.Parse(dt.Rows[n]["Amount"].ToString());
					}
					else
					{
						model.Amount=0;
					}
					if(dt.Rows[n]["DemandID"].ToString()!="")
					{
						model.DemandID=int.Parse(dt.Rows[n]["DemandID"].ToString());
					}
					else
					{
						model.DemandID=0;
					}
					if(dt.Rows[n]["TypeID"].ToString()!="")
					{
						model.TypeID=int.Parse(dt.Rows[n]["TypeID"].ToString());
					}
					else
					{
						model.TypeID=0;
					}
					if(dt.Rows[n]["MListID"].ToString()!="")
					{
						model.MListID=int.Parse(dt.Rows[n]["MListID"].ToString());
					}
					else
					{
						model.MListID=0;
					}
					if(dt.Rows[n]["TaskID"].ToString()!="")
					{
						model.TaskID=int.Parse(dt.Rows[n]["TaskID"].ToString());
					}
					else
					{
						model.TaskID=0;
					}
					if(dt.Rows[n]["StockInfoID"].ToString()!="")
					{
						model.StockInfoID=int.Parse(dt.Rows[n]["StockInfoID"].ToString());
					}
					else
					{
						model.StockInfoID=0;
					}
                    if (dt.Rows[n]["NotAmount"].ToString() != "")
                    {
                        model.NotAmount = decimal.Parse(dt.Rows[n]["NotAmount"].ToString());
                    }
                    else
                    {
                        model.NotAmount = 0;
                    }
                    if (dt.Rows[n]["IsEnd"].ToString() != "")
                    {
                        model.IsEnd = int.Parse(dt.Rows[n]["IsEnd"].ToString());
                    }
                    else
                    {
                        model.IsEnd = 0;
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
        public decimal GetAmount(int MListID, int TypeID, string strTask)
        {
            return dal.GetAmount(MListID, TypeID, strTask);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MListID"></param>
        /// <param name="DemandID"></param>
        /// <param name="StockInfoID"></param>
        /// <param name="Amount"></param>
        /// <param name="TypeID"></param>
        /// <param name="TaskID"></param>
        /// <param name="RelatedID"></param>
        /// <param name="t">�����Ӽ�¼����Ϊɾ����¼</param>
        public void UpAmount(int MListID, int DemandID, int StockInfoID, decimal Amount, int TypeID,int TaskID,int RelatedID,bool t,int DepotID)
        {
            #region ʹ��ԭ�ִ�
            if (TypeID == (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.ʹ��ԭ�ִ�)
            {
                if (t)
                {
                    //�鿴֮ǰʹ�ÿ��ļ�¼,������ʹ��ԭ�ִ�������µ����ݱ�
                    Hownet.BLL.Repertory bllRep = new Repertory();
                    Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
                    Hownet.Model.Repertory modRep = bllRep.GetModel(RelatedID);//��Ҫת���Ŀ�������
                    Hownet.Model.MaterielDemand modMD = bllMD.GetModel(DemandID);
                    modRep.Amount = modRep.Amount - Amount;//�۵���ʹ�õĿ�������
                    bllRep.Update(modRep);
                    modMD.RepertoryAmount += Amount;//�������ϲ�ֱ���ѱ�������
                    bllMD.Update(modMD);
                    //�Ƿ��ǰ�б��ƻ����ı���
                    DataTable dt = bllRep.GetList("(MListID=" + MListID + ") And  (PlanID=" + TaskID + ") And (DepartmentID=" + DepotID + ")").Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        //���У�����ϱ�������
                        dt.Rows[0]["Amount"] = Convert.ToDecimal(dt.Rows[0]["Amount"]) + Amount;
                        bllRep.UpdateByDt(dt);
                    }
                    else
                    {
                        //û������������
                        modRep.Amount = Amount;
                        modRep.PlanID = TaskID;
                        modRep.DepartmentID = DepotID;
                        bllRep.Add(modRep);
                    }
                }
                else
                {

                }
            }
            #endregion
            #region ���깺����
            else if (TypeID == (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.���깺����)
            {
                if (t)
                {
                    //������������ƻ��и����ϵ����깺����
                    DataTable dt = GetList("(StockInfoID=" + StockInfoID + ") And (TypeID=" + (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.���깺���� + ")").Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        dt.Rows[0]["Amount"] = Convert.ToDecimal(dt.Rows[0]["Amount"]) + Amount;
                        dt.Rows[0]["NotAmount"] = Convert.ToDecimal(dt.Rows[0]["NotAmount"]) + Amount;
                        UpdateByDt(dt);
                    }
                    else
                    {
                        DataRow dr = dt.NewRow();
                        dr["RelatedID"] = RelatedID;
                        dr["Amount"] = Amount;
                        dr["DemandID"] = DemandID;
                        dr["TypeID"] = (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.���깺����;
                        dr["MListID"] = MListID;
                        dr["TaskID"] = TaskID;
                        dr["StockInfoID"] = 0;
                        dr["NotAmount"] = Amount;
                        dr["IsEnd"] = 0;
                        dr["A"] = 1;
                        dt.Rows.Add(dr);
                        AddByDt(dt);
                    }
                }
                else
                {

                }
            }
            #endregion
            #region �Ѳɹ�����
            else if (TypeID == (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.�Ѳɹ�����)
            {

            }
            #endregion
        }
        /// <summary>
        /// ����ĳ��������ĳ������ɹ����������ϼ������ɹ���-���п��-���깺-�Ѳɹ�������������������ֱ��������
        /// �����StockNotAmount�ֶ��пۼ���
        /// </summary>
        /// <param name="MListID"></param>
        /// <param name="DemandID"></param>
        /// <returns></returns>
        public decimal GetNeedStock(int MListID, int DemandID)
        {
            return dal.GetNeedStock(MListID, DemandID, (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.ʹ��ԭ�ִ�, (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.���깺����, (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.�Ѳɹ�����, (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.��������������);
        }
         /// <summary>
        /// ɾ��ĳһ�깺�����ɹ������ɹ��ջ����ķֶ�����ϸ
        /// </summary>
        /// <param name="MainID"></param>
        public void DelStockByStockMainID(int MainID)
        {
            dal.DelStockByStockMainID(MainID);
        }
         /// <summary>
        /// ɾ��ĳһ�깺���ķֶ�����ϸ���ۼ����ϲ�����Ѳɹ�����
        /// </summary>
        /// <param name="MainID"></param>
        public void DelNeedByStockMainID(int MainID)
        {
            dal.DelNeedByStockMainID(MainID);
        }
         /// <summary>
        /// ����ɹ��ջ�������ϵ�б�
        /// </summary>
        /// <param name="MainID"></param>
        public void DelStockBackByMainID(int MainID)
        {
            dal.DelStockBackByMainID(MainID);
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

