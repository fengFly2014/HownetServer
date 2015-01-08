using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// ҵ���߼���Company ��ժҪ˵����
    /// </summary>
    public class Company
    {
        private readonly Hownet.DAL.Company dal = new Hownet.DAL.Company();
        public Company()
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
        public int Add(Hownet.Model.Company model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������,����ԴΪDataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.Company> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.Company model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.Company> li = DataTableToList(dt);
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
        public Hownet.Model.Company GetModel(int ID)
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
        public List<Hownet.Model.Company> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.Company> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.Company> modelList = new List<Hownet.Model.Company>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.Company model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.Company();
                    try
                    {
                        if (dt.Rows[n]["ID"].ToString() != "")
                        {
                            model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                        }
                        else
                        {
                            model.ID = 0;
                        }
                        model.Name = dt.Rows[n]["Name"].ToString();
                        model.Sn = dt.Rows[n]["Sn"].ToString();
                        model.LinkMan = dt.Rows[n]["LinkMan"].ToString();
                        model.Mabile = dt.Rows[n]["Mabile"].ToString();
                        model.Phone = dt.Rows[n]["Phone"].ToString();
                        model.Fax = dt.Rows[n]["Fax"].ToString();
                        model.Email = dt.Rows[n]["Email"].ToString();
                        model.Country = dt.Rows[n]["Country"].ToString();
                        model.Province = dt.Rows[n]["Province"].ToString();
                        model.City = dt.Rows[n]["City"].ToString();
                        model.Address = dt.Rows[n]["Address"].ToString();
                        model.Remark = dt.Rows[n]["Remark"].ToString();
                        if (dt.Rows[n]["TypeID"].ToString() != "")
                        {
                            model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                        }
                        else
                        {
                            model.TypeID = 0;
                        }
                        if (dt.Rows[n]["IsEnd"].ToString() != "")
                        {
                            model.IsEnd = int.Parse(dt.Rows[n]["IsEnd"].ToString());
                        }
                        else
                        {
                            model.IsEnd = 0;
                        }
                        if (dt.Rows[n]["IsUse"].ToString() != "")
                        {
                            if ((dt.Rows[n]["IsUse"].ToString() == "1") || (dt.Rows[n]["IsUse"].ToString().ToLower() == "true"))
                            {
                                model.IsUse = true;
                            }
                            else
                            {
                                model.IsUse = false;
                            }
                        }
                        if (dt.Rows[n]["LoanMoney"].ToString() != "")
                        {
                            model.LoanMoney = decimal.Parse(dt.Rows[n]["LoanMoney"].ToString());
                        }
                        else
                        {
                            model.LoanMoney = 0;
                        }
                        if (dt.Rows[n]["LoanDate"].ToString() != "")
                        {
                            model.LoanDate = DateTime.Parse(dt.Rows[n]["LoanDate"].ToString());
                        }
                        else
                        {
                            model.LoanDate = DateTime.Parse("1900-1-1");
                        }
                        if (dt.Rows[n]["LastMoney"].ToString() != "")
                        {
                            model.LastMoney = decimal.Parse(dt.Rows[n]["LastMoney"].ToString());
                        }
                        else
                        {
                            model.LastMoney = 0;
                        }
                        if (dt.Rows[n]["UserID"].ToString() != "")
                        {
                            model.UserID = int.Parse(dt.Rows[n]["UserID"].ToString());
                        }
                        else
                        {
                            model.UserID = 0;
                        }
                        model.BankName = dt.Rows[n]["BankName"].ToString();
                        model.BankNO = dt.Rows[n]["BankNO"].ToString();
                        model.BankUserName = dt.Rows[n]["BankUserName"].ToString();
                        if (dt.Rows[n]["MaxMoney"].ToString() != "")
                        {
                            model.MaxMoney = decimal.Parse(dt.Rows[n]["MaxMoney"].ToString());
                        }
                        model.County = dt.Rows[n]["County"].ToString();
                        if (dt.Rows[n]["Weight"] != null && dt.Rows[n]["Weight"].ToString() != "")
                        {
                            model.Weight = decimal.Parse(dt.Rows[n]["Weight"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
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
        public void UpLastMoney(int CompanyID, decimal Money)
        {
            dal.UpLastMoney(CompanyID, Money);
        }
        public DataSet GetListByUserID(int UserID, string strWhere)
        {
            return dal.GetListByUserID(UserID, strWhere);
        }
        public DataSet GetExpressReport()
        {
            return dal.GetExpressReport();
        }
        public void InKJKM()
        {
            List<Hownet.Model.Company> li = DataTableToList(GetAllList().Tables[0]);
            Hownet.BLL.Bas_KJKM bllKJ = new Bas_KJKM();
            Hownet.BLL.CompanyLog bllCL = new CompanyLog();
            Hownet.Model.Bas_KJKM modKJ;

            for (int i = 0; i < li.Count; i++)
            {
                if (bllKJ.GetList("(CompanyID=" + li[i].ID + ")").Tables[0].Rows.Count == 0)
                {
                    modKJ = new Hownet.Model.Bas_KJKM();
                    modKJ.A = 0;
                    modKJ.CompanyID = li[i].ID;
                    modKJ.ID = 0;
                    modKJ.Money = bllCL.GetLastMoney(li[i].ID);
                    modKJ.Name = li[i].Name;
                    modKJ.Num = string.Empty;
                    if (li[i].TypeID == 1)//�ͻ�
                    {
                        modKJ.Num = bllKJ.GetMaxNum(1122).ToString();
                        modKJ.ParentID = 1122;
                    }
                    else if (li[i].TypeID == 2 || li[i].TypeID == 3)
                    {
                        modKJ.Num = bllKJ.GetMaxNum(2202).ToString();
                        modKJ.ParentID = 2202;
                    }
                    if (modKJ.Num != string.Empty)
                    {
                        modKJ.Orders = bllKJ.GetMaxOrders()+1;
                        modKJ.Remark = string.Empty;
                        bllKJ.Add(modKJ);
                    }
                }
            }
        }
        public DataSet GetJGCandDep()
        {
            DataTable dt = new DataTable();
            dt.TableName = "dt";
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("IsJGC", typeof(bool));
            dt.Rows.Add(0, "", false);
            DataTable dtCom = GetList("TypeID=3").Tables[0];
            for (int i = 0; i < dtCom.Rows.Count; i++)
            {
                dt.Rows.Add(Convert.ToInt32(dtCom.Rows[i]["ID"]) * -1, dtCom.Rows[i]["Name"], true);
            }
            Hownet.BLL.Deparment bllDep=new Deparment();
            DataTable dtDep = bllDep.GetTypeList("����").Tables[0];
            for (int i = 0; i < dtDep.Rows.Count; i++)
            {
                dt.Rows.Add(dtDep.Rows[i]["ID"], dtDep.Rows[i]["Name"], false);
            }
            DataSet ds = new DataSet();
            ds.DataSetName = "ds";
            ds.Tables.Add(dt);
            return ds;
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

