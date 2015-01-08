using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// ҵ���߼���CompanyLog ��ժҪ˵����
    /// </summary>
    public class CompanyLog
    {
        private readonly Hownet.DAL.CompanyLog dal = new Hownet.DAL.CompanyLog();
        public CompanyLog()
        { }
        #region  ��Ա����
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
        public int Add(Hownet.Model.CompanyLog model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������,����ԴΪDataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.CompanyLog> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                Hownet.BLL.Bas_KJKM bllKJ = new Bas_KJKM();
                List<Hownet.Model.Bas_KJKM> liKJ = bllKJ.DataTableToList(bllKJ.GetList("(CompanyID=" + li[0].CompanyID + ")").Tables[0]);
                if (liKJ.Count > 0)
                {
                    if (li[0].TypeID == (int)Enums.MoneyTableType.BackMoney)
                    {
                        liKJ[0].Money -= li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(1122);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.OutMoney)
                    {
                        liKJ[0].Money -= li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(2202);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.Back)
                    {
                        liKJ[0].Money += li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(2202);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.Sell)
                    {
                        liKJ[0].Money += li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(1122);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.SellBack)
                    {
                        liKJ[0].Money -= li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(1122);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.StockBackSupp)
                    {
                        liKJ[0].Money -= li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(2202);
                    }
                }
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
        public void Update(Hownet.Model.CompanyLog model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.CompanyLog> li = DataTableToList(dt);
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
        public Hownet.Model.CompanyLog GetModel(int ID)
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
        public List<Hownet.Model.CompanyLog> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.CompanyLog> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.CompanyLog> modelList = new List<Hownet.Model.CompanyLog>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.CompanyLog model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.CompanyLog();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    if (dt.Rows[n]["LastMoney"].ToString() != "")
                    {
                        model.LastMoney = decimal.Parse(dt.Rows[n]["LastMoney"].ToString());
                    }
                    if (dt.Rows[n]["ChangMoney"].ToString() != "")
                    {
                        model.ChangMoney = decimal.Parse(dt.Rows[n]["ChangMoney"].ToString());
                    }
                    if (dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    if (dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
                    if (dt.Rows[n]["TableID"].ToString() != "")
                    {
                        model.TableID = int.Parse(dt.Rows[n]["TableID"].ToString());
                    }
                    if (dt.Rows[n]["NowMoneyTypeID"].ToString() != "")
                    {
                        model.NowMoneyTypeID = int.Parse(dt.Rows[n]["NowMoneyTypeID"].ToString());
                    }
                    if (dt.Rows[n]["NowMoney"].ToString() != "")
                    {
                        model.NowMoney = decimal.Parse(dt.Rows[n]["NowMoney"].ToString());
                    }
                    if (dt.Rows[n]["NowReta"].ToString() != "")
                    {
                        model.NowReta = decimal.Parse(dt.Rows[n]["NowReta"].ToString());
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
        /// �ж��Ƿ�����޸��ڳ����
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public bool CheckCanEditLoan(int CompanyID)
        {
            return dal.CheckCanEditLoan(CompanyID);
        }
                /// <summary>
        /// ����������ⵥʱ��ǰ����⵽����֮�仹����
        /// </summary>
        /// <param name="CompanyID">�ͻ���</param>
        /// <returns></returns>
        public DataSet GetBackMoney(int CompanyID)
        {
            return dal.GetBackMoney(CompanyID);
        }
        /// <summary>
        /// ����������ⵥʱ��ǰ��������
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public decimal GetBackLastMoney(int CompanyID)
        {
            return dal.GetBackLastMoney(CompanyID);
        }
            /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void DeleteLog(int CompanyID, int TypeID, int TableID)
        {
             
                List<Hownet.Model.CompanyLog> li = DataTableToList(GetList(" (CompanyID=" + CompanyID + ") And (TypeID=" + TypeID + ") And (TableID=" + TableID + ") ").Tables[0]);
                dal.DeleteLog(CompanyID, TypeID, TableID);
try
            {
              
                Hownet.BLL.Bas_KJKM bllKJ = new Bas_KJKM();
                List<Hownet.Model.Bas_KJKM> liKJ = bllKJ.DataTableToList(bllKJ.GetList("(CompanyID=" + li[0].CompanyID + ")").Tables[0]);
                if (liKJ.Count > 0)
                {
                    if (li[0].TypeID == (int)Enums.MoneyTableType.BackMoney)
                    {
                        liKJ[0].Money += li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(1122);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.OutMoney)
                    {
                        liKJ[0].Money += li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(2202);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.Back)
                    {
                        liKJ[0].Money -= li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(2202);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.Sell)
                    {
                        liKJ[0].Money -= li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(1122);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.SellBack)
                    {
                        liKJ[0].Money += li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(1122);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.StockBackSupp)
                    {
                        liKJ[0].Money += li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(2202);
                    }
                }
               
            }
            catch (Exception ex)
            {
            }
        }
                /// <summary>
        /// �����������۵�ʱ��ǰ�ο���������֮�仹����
        /// </summary>
        /// <param name="CompanyID">�ͻ���</param>
        /// <returns></returns>
        public DataSet GetBackSellMoney(int CompanyID)
        {
            return dal.GetBackSellMoney(CompanyID);
        }
        /// <summary>
        /// ��������������ʱ��ǰ��������
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public DataSet GetSellLastMoney(int CompanyID)
        {
            return dal.GetSellLastMoney(CompanyID);
        }
        /// ��ȡ�������б�
        /// </summary>
        /// <param name="TypeID">���ͣ�trueΪ�ͻ���falseΪ��Ӧ��</param>
        /// <returns></returns>
        public DataSet GetFinanceList(int TypeID,DateTime dtOne,DateTime dtTwo)
        {
            Hownet.BLL.Company bllCom = new Company();
            DataTable dt = new DataTable();
            dt.TableName = "Main";
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("CompanyID", typeof(int));
            dt.Columns.Add("CompanyName", typeof(string));
            dt.Columns.Add("DateTime", typeof(string));
            dt.Columns.Add("Remark", typeof(string));
            dt.Columns.Add("Debit", typeof(decimal));//�跽���
            dt.Columns.Add("Lenders", typeof(decimal));//�������
            dt.Columns.Add("Money", typeof(decimal));
            dt.Columns.Add("Indexs", typeof(string));
            dt.Columns.Add("Whys", typeof(int));
            DataTable dtList = new DataTable();
            //if (TypeID == 1)
            //    //dtList = GetList("(TypeID=4) Or (TypeID=5) Or (TypeID=3) Or (TypeID=-1) ORDER BY ID").Tables[0];
            //    dtList = GetList(" (Select TypeID from Company where (id=CompanyLog.CompanyID))=" + TypeID + ")").Tables[0];
            //else if (TypeID == 2)
            //    //dtList = GetList("(TypeID=1) OR (TypeID=6) Or (TypeID=2)  or (TypeID=-2) ORDER BY ID").Tables[0];
            //    dtList = GetList(" (Select TypeID from Company where (id=CompanyLog.CompanyID))=" + TypeID + ")").Tables[0];
            //else if (TypeID == 3)

            dtList = GetList(" ((Select TypeID from Company where (id=CompanyLog.CompanyID))=" + TypeID + ") And (DateTime>=CONVERT(DATETIME, '" + dtOne + "', 102)) And (DateTime<CONVERT(DATETIME, '" + dtTwo + "', 102)) ORDER BY ID").Tables[0];
                if (dtList.Rows.Count > 0)
                {
                    for (int i = 0; i < dtList.Rows.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dr["ID"] = dtList.DefaultView[i]["ID"];
                        dr["CompanyID"] = dtList.DefaultView[i]["CompanyID"];
                        if (dr["CompanyID"].ToString() != "0")
                            dr["CompanyName"] = bllCom.GetModel(int.Parse(dtList.DefaultView[i]["CompanyID"].ToString())).Name;
                        else
                            dr["CompanyName"] = "";
                        dr["Money"] = dtList.DefaultView[i]["Money"];
                        dr["Whys"] = dtList.DefaultView[i]["TypeID"];
                        int k = int.Parse(dtList.DefaultView[i]["TypeID"].ToString());
                        //if (dtList.DefaultView[i]["Indexs"].ToString() != "0") 
                        //{
                        dr["DateTime"] = ((DateTime)(dtList.DefaultView[i]["DateTime"])).ToLongDateString();
                        dr["Indexs"] = dtList.DefaultView[i]["TableID"];
                        switch (k)
                        {
                            case 3:
                                {
                                    dr["Remark"] = "���۳���";
                                    dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 4:
                                {
                                    dr["Remark"] = "�ջ���";
                                    dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 5:
                                {
                                    dr["Remark"] = "�����˻�";
                                    dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 1:
                                {
                                    dr["Remark"] = "���ϲɹ����";
                                    dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 2:
                                {
                                    dr["Remark"] = "�����Ͽ�";
                                    dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 6:
                                {
                                    dr["Remark"] = "�ɹ��˻�";
                                    dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case -1:
                                {
                                    dr["Remark"] = "�ڳ����";
                                    dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                    dr["Indexs"] = string.Empty;
                                    break;
                                }
                            case -2:
                                {
                                    dr["Remark"] = "�ڳ����";
                                    dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                    dr["Indexs"] = string.Empty;
                                    break;
                                }
                            case -3:
                                {
                                    dr["Remark"] = "�ڳ����";
                                    dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                    dr["Indexs"] = string.Empty;
                                    break;
                                }
                            case 7:
                                {
                                    dr["Remark"] = "�ӹ�������";
                                    dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 8:
                                {
                                    dr["Remark"] = "�ӹ�������Ʒ";
                                    dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 9:
                                {
                                    dr["Remark"] = "���ӹ�������";
                                    dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            //}
                        }

                        dt.Rows.Add(dr);
                    }
                }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            if (TypeID==1)
            {
                try
                {
                    DataTable dtt = dal.GetSellOne(dtOne,dtTwo).Tables[0].Copy();
                    dtt.TableName = "Sell";
                    ds.Tables.Add(dtt);
                    ds.Relations.Add("��ϸ", ds.Tables["Main"].Columns["ID"], ds.Tables["Sell"].Columns["ID"]);
                }
                catch //(Exception ex)
                {
                }
               
            }
            else if (TypeID == 2)
            {
                try
                {
                    DataTable dtt = dal.GetStockBack(dtOne, dtTwo).Tables[0].Copy();
                    dtt.TableName = "Sell";
                    ds.Tables.Add(dtt);
                    ds.Relations.Add("��ϸ", ds.Tables["Main"].Columns["ID"], ds.Tables["Sell"].Columns["ID"]);
                }
                catch (Exception ex)
                {
                }
            }
            else if (TypeID == 3)
            {
                //DataTable dtt = dal.GetProcessing(dtOne, dtTwo).Tables[0].Copy();
                //dtt.TableName = "Sell";
                //ds.Tables.Add(dtt);
                //ds.Relations.Add("��ϸ", ds.Tables["Main"].Columns["ID"], ds.Tables["Sell"].Columns["ID"]);
            }

            return ds;
        }
        public void DeleteByCompanyID(int CompanyID)
        {
            dal.DeleteByCompanyID(CompanyID);
        }
        public DataSet GetCompanyMoney(int TypeID)
        {
            return dal.GetCompanyMoney(TypeID);
        }
        /// ��ȡ�������б�
        /// </summary>
        /// <param name="TypeID">���ͣ�trueΪ�ͻ���falseΪ��Ӧ��</param>
        /// <returns></returns>
        public DataSet GetCompanyMoneyList(bool TypeID, int CompanyID,DateTime dtOne,DateTime dtTwo)
        {
            Hownet.BLL.Company bllCom = new Company();
            DataTable dt = new DataTable();
            dt.TableName = "Main";
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("CompanyID", typeof(int));
            dt.Columns.Add("CompanyName", typeof(string));
            dt.Columns.Add("DateTime", typeof(string));
            dt.Columns.Add("Remark", typeof(string));
            dt.Columns.Add("Debit", typeof(decimal));//�跽���
            dt.Columns.Add("Lenders", typeof(decimal));//�������
            dt.Columns.Add("Money", typeof(decimal));
            dt.Columns.Add("Indexs", typeof(string));
            dt.Columns.Add("Whys", typeof(int));
            DataTable dtList = new DataTable();
            //if (TypeID)
            //    dtList = GetList("(CompanyID=" + CompanyID + ") And ( (TypeID=4) Or (TypeID=5) Or (TypeID=3) Or (TypeID=-1)) ORDER BY ID").Tables[0];
            //else
            //    dtList = GetList("(CompanyID=" + CompanyID + ") And ((TypeID=1) OR (TypeID=6) Or (TypeID=2)  or (TypeID=-2)) ORDER BY ID").Tables[0];
            dtList = GetList(" (CompanyID=" + CompanyID + ") And (DateTime>=CONVERT(DATETIME, '" + dtOne + "', 102)) And (DateTime<CONVERT(DATETIME, '" + dtTwo + "', 102))  ORDER BY ID").Tables[0];
            if (dtList.Rows.Count > 0)
            {
                for (int i = 0; i < dtList.Rows.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["ID"] = dtList.DefaultView[i]["ID"];
                    dr["CompanyID"] = dtList.DefaultView[i]["CompanyID"];
                    dr["CompanyName"] = bllCom.GetModel(int.Parse(dtList.DefaultView[i]["CompanyID"].ToString())).Name;
                    dr["Money"] = dtList.DefaultView[i]["Money"];
                    dr["Whys"] = dtList.DefaultView[i]["TypeID"];
                    int k = int.Parse(dtList.DefaultView[i]["TypeID"].ToString());
                    //if (dtList.DefaultView[i]["Indexs"].ToString() != "0") 
                    //{
                    dr["DateTime"] = ((DateTime)(dtList.DefaultView[i]["DateTime"])).ToLongDateString();
                    dr["Indexs"] = dtList.DefaultView[i]["TableID"];
                    switch (k)
                    {
                        case 3:
                            {
                                dr["Remark"] = "���۳���";
                                dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 4:
                            {
                                dr["Remark"] = "�ջ���";
                                dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 5:
                            {
                                dr["Remark"] = "�����˻�";
                                dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 1:
                            {
                                dr["Remark"] = "���ϲɹ����";
                                dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 2:
                            {
                                dr["Remark"] = "�����Ͽ�";
                                dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 6:
                            {
                                dr["Remark"] = "�ɹ��˻�";
                                dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case -1:
                            {
                                dr["Remark"] = "�ڳ����";
                                dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                dr["Indexs"] = string.Empty;
                                break;
                            }
                        case -2:
                            {
                                dr["Remark"] = "�ڳ����";
                                dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                dr["Indexs"] = string.Empty;
                                break;
                            }
                        case -3:
                            {
                                dr["Remark"] = "�ڳ����";
                                dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                dr["Indexs"] = string.Empty;
                                break;
                            }
                        case 7:
                            {
                                dr["Remark"] = "�ӹ�������";
                                dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 8:
                            {
                                dr["Remark"] = "�ӹ�������Ʒ";
                                dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 9:
                            {
                                dr["Remark"] = "���ӹ�������";
                                dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                    }

                    dt.Rows.Add(dr);
                }
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            //DataTable dtt = dal.GetSellOne(TypeID).Tables[0].Copy();
            //dtt.TableName = "Sell";
            //ds.Tables.Add(dtt);
            //ds.Relations.Add("��ϸ", ds.Tables["Main"].Columns["ID"], ds.Tables["Sell"].Columns["ID"]);
            return ds;
        }
        /// <summary>
        /// �Ƿ�������󵥾�
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <param name="TableID"></param>
        /// <returns></returns>
        public int CanUnVerify(int CompanyID, int TypeID, int TableID)
        {
            return dal.CanUnVerify(CompanyID, TypeID, TableID);
        }
           /// <summary>
        /// ���ؼӹ�������ʱ�����ش�ǰǷ��
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public decimal GetProcessingBackLastMoney(int CompanyID)
        {
            return dal.GetProcessingBackLastMoney(CompanyID);
        }
        /// <summary>
        /// �����������ϵ�ʱ���ڼ丶�������
        /// </summary>
        /// <param name="CompanyID">�ͻ���</param>
        /// <returns></returns>
        public DataSet GetProcessingBackMoney(int CompanyID)
        {
            return dal.GetProcessingBackMoney(CompanyID);
        }
            /// <summary>
        /// ����������ӹ��ջ���ʱ���ϴ�Ƿ�ӹ�������
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public DataSet GetProcess2DepotLastMoney(int CompanyID)
        {
            return dal.GetProcess2DepotLastMoney(CompanyID);
        }
        /// <summary>
        /// ��������ӹ��ջ���ʱ���ڼ仹����
        /// </summary>
        /// <param name="CompanyID">�ͻ���</param>
        /// <returns></returns>
        public DataSet GetProcess2DepotBackSellMoney(int CompanyID)
        {
            return dal.GetProcess2DepotBackSellMoney(CompanyID);
        }
        public decimal GetLastMoney(int CompanyID)
        {
            return dal.GetLastMoney(CompanyID);
        }
        public DataSet GetInOutList(int TypeID, DateTime dt1, DateTime dt2)
        {
            return dal.GetInOutList(TypeID, dt1, dt2);
        }
        public DataSet GetLastMoneyList(int TypeID)
        {
            return new DataSet();
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

