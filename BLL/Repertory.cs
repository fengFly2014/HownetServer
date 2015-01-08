using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// ҵ���߼���Repertory ��ժҪ˵����
    /// </summary>
    public class Repertory
    {
        private readonly Hownet.DAL.Repertory dal = new Hownet.DAL.Repertory();
        public Repertory()
        { }
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
        public int Add(Hownet.Model.Repertory model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������,����ԴΪDataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.Repertory> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.Repertory model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.Repertory> li = DataTableToList(dt);
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
        public Hownet.Model.Repertory GetModel(int ID)
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
        public DataSet GetTopList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.Repertory> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.Repertory> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.Repertory> modelList = new List<Hownet.Model.Repertory>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.Repertory model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.Repertory();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["MListID"].ToString() != "")
                    {
                        model.MListID = int.Parse(dt.Rows[n]["MListID"].ToString());
                    }
                    if (dt.Rows[n]["Amount"].ToString() != "")
                    {
                        model.Amount = decimal.Parse(dt.Rows[n]["Amount"].ToString());
                    }
                    if (dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    if (dt.Rows[n]["DepartmentID"].ToString() != "")
                    {
                        model.DepartmentID = int.Parse(dt.Rows[n]["DepartmentID"].ToString());
                    }
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    if (dt.Rows[n]["SizeID"].ToString() != "")
                    {
                        model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
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
                    if (dt.Rows[n]["BrandID"].ToString() != "")
                    {
                        model.BrandID = int.Parse(dt.Rows[n]["BrandID"].ToString());
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    else
                    {
                        model.CompanyID = 0;
                    }
                    if (dt.Rows[n]["PlanID"].ToString() != "")
                    {
                        model.PlanID = int.Parse(dt.Rows[n]["PlanID"].ToString());
                    }
                    else
                    {
                        model.PlanID = 0;
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["SupplierID"] != null && dt.Rows[n]["SupplierID"].ToString() != "")
                    {
                        model.SupplierID = int.Parse(dt.Rows[n]["SupplierID"].ToString());
                    }
                    model.SupplierName = dt.Rows[n]["SupplierName"].ToString();
                    model.SupplierSN = dt.Rows[n]["SupplierSN"].ToString();
                    if (dt.Rows[n]["SpecID"] != null && dt.Rows[n]["SpecID"].ToString() != "")
                    {
                        model.SpecID = int.Parse(dt.Rows[n]["SpecID"].ToString());
                    }
                    model.SpecName = dt.Rows[n]["SpecName"].ToString();
                    model.MaterielName = dt.Rows[n]["MaterielName"].ToString();
                    model.ColorName = dt.Rows[n]["ColorName"].ToString();
                    model.SizeName = dt.Rows[n]["SizeName"].ToString();
                    model.ColorOneName = dt.Rows[n]["ColorOneName"].ToString();
                    model.ColorTwoName = dt.Rows[n]["ColorTwoName"].ToString();
                    model.BrandName = dt.Rows[n]["BrandName"].ToString();
                    model.CompanyName = dt.Rows[n]["CompanyName"].ToString();
                    model.MeasureName = dt.Rows[n]["MeasureName"].ToString();
                    model.DeparmentName = dt.Rows[n]["DeparmentName"].ToString();
                    if (dt.Rows[n]["DepotInfoID"] != null && dt.Rows[n]["DepotInfoID"].ToString() != "")
                    {
                        model.DepotInfoID = int.Parse(dt.Rows[n]["DepotInfoID"].ToString());
                    }
                    model.DepotInfoName = dt.Rows[n]["DepotInfoName"].ToString();
                    if (dt.Rows[n]["Price"] != null && dt.Rows[n]["Price"].ToString() != "")
                    {
                        model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
                    }
                    if (dt.Rows[n]["Money"] != null && dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
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
        /// <summary>
        /// ���/�������
        /// </summary>
        /// <param name="model"></param>
        /// <param name="t">��Ϊ��⣬��Ϊ����</param>
        public int InOrOut(Model.Repertory model, bool t)
        {
         return   dal.InOrOut(model, t);
        }
        /// <summary>
        /// ��Ʒ����б�
        /// </summary>
        /// <returns></returns>
        public DataSet GetProductList()
        {
            return dal.GetProductList();
        }
        public DataSet GetColor(int MaterielID, int BrandID, int DepotID)
        {
            DataSet ds = dal.GetColor(MaterielID, BrandID, DepotID);
            return ds;
        }
        public DataSet GetSize(int MaterielID, int BrandID)
        {
            DataSet ds = dal.GetSize(MaterielID, BrandID);
            return ds;
        }
        public DataSet GetAmount(object mat, object ColorID, object size, object _depotID, object _measureID, object _companyID, object _ColorOne, object _ColorTwo, object _brandID,int PlanID)
        {
            string strSql = "(MaterielID=" + mat + ") And (ColorID=" + ColorID + ") And (SizeID=" + size + ") ";
            strSql = strSql + "And (DepartmentID=" + _depotID + ") And (MeasureID=" + _measureID + ") And (CompanyID=" + _companyID + ")";
            strSql = strSql + "And (ColorOneID=" + _ColorOne + ") And (ColorTwoID=" + _ColorTwo + ") And(BrandID=" + _brandID + ")";
            strSql = strSql + " And (PlanID=" + PlanID + ")";
            return dal.GetList(strSql);
        }
        public double GetPlanAmount(int MListID, int DepotID, string PlanID)
        {
            string strSql = "(MListID=" + MListID + ") ";
            strSql = strSql + "And (DepartmentID=" + DepotID + ") ";
            strSql = strSql + " And (PlanID=" + PlanID + ")";
            DataTable dt = dal.GetList(strSql).Tables[0];
            if (dt.Rows.Count == 0)
                return 0;
            else
                return Convert.ToDouble(dt.Rows[0]["Amount"]);
        }

        public DataSet GetPrice(object _companyID, object mat, object ColorID, object size, object _measureID)
        {
            DataSet ds = dal.GetList("(MaterielID=" + mat + ") And (ColorID=" + ColorID + ") And (SizeID=" + size + ") And (MeasureID=" + _measureID + ")");
            return ds;
        }
        /// <summary>
        /// ��Ʒ����б�
        /// </summary>
        /// <returns></returns>
        public DataSet GetMaterielList(int DepotID, int MTID,int MaterielID)
        {
            return dal.GetMaterielList(DepotID, MTID, MaterielID);
        }
        public decimal GetAmountByModel(Hownet.Model.Repertory model)
        {
            return dal.GetAmountByModel(model);
        }
        public DataSet GetGroupList(int MaterielID, int BrandID)
        {
            return dal.GetGroupList(MaterielID, BrandID);
        }
        public DataSet GetReAmount(int MaterielID, int BrandID)
        {
            return dal.GetReAmount(MaterielID, BrandID);
        }
        /// <summary>
        /// Ϊ���������ȡ�������
        /// </summary>
        /// <param name="AttributeID"></param>
        /// <returns></returns>
        public DataSet GetFenXi(int AttributeID)
        {
            return dal.GetFenXi(AttributeID);
        }
        /// <summary>
        /// ����ĳ������û�мƻ���ռ�õ�����
        /// </summary>
        /// <param name="MListID"></param>
        /// <returns></returns>
        public decimal GetNotUseAmount(int MListID, int DepotID)
        {
            return dal.GetNotUseAmount(MListID, DepotID);
        }
        /// <summary>
        /// �����ĳ���ϵ�һЩ���������Ϊĳ�����ƻ�����ʹ�ã����������ƻ��������п���У����Ӹ�����
        /// </summary>
        /// <param name="ID">���ID</param>
        /// <param name="DemandID">���ϼƻ���ID</param>
        /// <param name="TaskID">�����ƻ���ID</param>
        /// <param name="Amount">�������</param>
        /// <param name="DepotID">�ֿ�</param>
        /// <param name="MListID">����</param>
        public void UpTaskUseRepertoryAmount(byte[] bb, int DepotID)
        {
            DataSet ds = BaseFile.ZipDt.Byte2Ds(bb);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Hownet.BLL.PlanUseRep bllPUR = new PlanUseRep();
                List<Hownet.Model.PlanUseRep> liPUR = bllPUR.DataTableToList(ds.Tables[0]);
                Hownet.Model.Repertory modRep;
                Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
                Hownet.Model.MaterielDemand modMD;
                for (int i = 0; i < liPUR.Count; i++)
                {
                    if (liPUR[i].A == 1)
                    {
                        modRep = GetModel(liPUR[i].RelatedID);
                        modMD = bllMD.GetModel(liPUR[i].DemandID);
                        modRep.Amount -= liPUR[i].Amount;//�ۼ���ǰ������
                        Update(modRep);
                        List<Hownet.Model.Repertory> lirep = GetModelList("(PlanID=" + liPUR[i].TaskID + ") And (MListID=" + liPUR[i].MListID + ") And (DepartmentID=" + DepotID + ")");
                        if (lirep.Count == 0)//�����Ƿ�����Ҫת��ļ�¼��û�о��Ա�����������¼
                        {
                            modRep = new Hownet.Model.Repertory();
                            Hownet.BLL.MaterielList bllML = new MaterielList();
                            Hownet.Model.MaterielList modML = bllML.GetModel(liPUR[i].MListID);
                            modRep.MListID = liPUR[i].MListID;
                            modRep.Amount = liPUR[i].Amount;
                            modRep.MeasureID = modML.MeasureID;
                            modRep.DepartmentID = DepotID;
                            modRep.MaterielID = modML.MaterielID;
                            modRep.ColorID = modML.ColorID;
                            modRep.ColorOneID = modML.ColorOneID;
                            modRep.ColorTwoID = modML.ColorTwoID;
                            modRep.SizeID = modML.SizeID;
                            modRep.BrandID = modML.BrandID;
                            modRep.CompanyID = 0;
                            modRep.PlanID = liPUR[i].TaskID;
                            Add(modRep);
                        }
                        else//�м�¼����ϸ�����
                        {
                            lirep[0].Amount += liPUR[i].Amount;
                            Update(lirep[0]);
                        }

                        bllMD.Update(modMD);
                    }
                }
            }
        }
        /// <summary>
        /// ��ȡĳ���ֿ���ĳ������û�б������ƻ�ռ�õ����������ڿ���̵�
        /// </summary>
        /// <param name="DepotID"></param>
        /// <param name="MTID"></param>
        /// <returns></returns>
        public DataSet GetInventory(int DepotID, int MTID)
        {
            return dal.GetInventory(DepotID, MTID);
        }
        /// <summary>
        /// �������е����ֵ���ϸ����
        /// </summary>
        /// <param name="DepotID"></param>
        /// <returns></returns>
        public DataSet GetStorageList(int DepotID)
        {
            return dal.GetStorageList(DepotID);
        }
        /// <summary>
        /// �����������ƻ�ʱ��ɾ�����еĿ����Ϣ
        /// </summary>
        /// <param name="PlanID"></param>
        /// <returns></returns>
        public void DelByPlanID(int PlanID)
        {
            dal.DelByPlanID(PlanID);
        }
        public DataSet GetMaterielInOrOut(DateTime dtOne, DateTime dtTwo, DateTime dtThree)
        {
            return dal.GetMaterielInOrOut(dtOne, dtTwo, dtThree);
        }
        public DataSet GetSumReport(DateTime dtOne, DateTime dtTwo, DateTime dtThree)
        {
            return dal.GetSumReport(dtOne, dtTwo, dtThree);
        }
        /// <summary>
        /// �ɹ��˻����
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="t">��Ϊ��⣬��Ϊ����</param>
        public void VerifyBack(int MainID, bool t)
        {
            try
            {
                Hownet.BLL.StockBack bllSB = new StockBack();
                Hownet.BLL.StockBackInfo bllSBI = new StockBackInfo();
                Hownet.Model.StockBack modSB = bllSB.GetModel(MainID);
                Hownet.Model.StockBackInfo modSBI = new Hownet.Model.StockBackInfo();
                List<Hownet.Model.StockBackInfo> li = bllSBI.DataTableToList(bllSBI.GetList("(MainID=" + MainID + ")").Tables[0]);
                if (li.Count > 0)
                {
                    Hownet.Model.Repertory modRep = new Hownet.Model.Repertory();
                    for (int i = 0; i < li.Count; i++)
                    {
                        if (li[i].DemandID > 0)
                        {
                            modRep = GetModel(li[i].DemandID);
                            modRep.Amount = li[i].Amount;
                            InOrOut(modRep, t);
                        }
                        if (li[i].StockInfoID > 0)
                        {
                            modSBI = bllSBI.GetModel(li[i].StockInfoID);
                            if (!t)
                            {
                                modSBI.NotAmount += li[i].Amount;
                                modSBI.NotPriceAmount += li[i].Amount;
                            }
                            else
                            {
                                modSBI.NotAmount -= li[i].Amount;
                                modSBI.NotPriceAmount -= li[i].Amount;
                            }
                            bllSBI.Update(modSBI);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// ��ȡ�ϲ���ƻ��������ϲ����ڿ���еĲ���
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetPPList(int MainID)
        {
            return dal.GetPPList(MainID);
        }
         /// <summary>
        /// ɾ���ϲ���ƻ��������ϲ����ڿ���еĲ���
        /// </summary>
        /// <param name="MainID"></param>
        public void DelPPList(int MainID)
        {
            dal.DelPPList(MainID);
        }
        /// ��÷�ҳ�����б�
        /// </summary>
        //public DataSet GetPageList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  ��Ա����
    }
}

