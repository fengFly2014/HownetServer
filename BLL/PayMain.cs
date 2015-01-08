using System;
using System.Data;

using Hownet.Model;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���PayMain ��ժҪ˵����
	/// </summary>
	public class PayMain
	{
		private readonly Hownet.DAL.PayMain dal=new Hownet.DAL.PayMain();
		public PayMain()
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
        public int Add(Hownet.Model.PayMain model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// ����һ������,����ԴΪDataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.PayMain> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.PayMain model)
        {
            dal.Update(model);
        }
                /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.PayMain> li = DataTableToList(dt);
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
        public Hownet.Model.PayMain GetModel(int ID)
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
		public List<Hownet.Model.PayMain> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.PayMain> modelList = new List<Hownet.Model.PayMain>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.PayMain model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.PayMain();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["DateTime"].ToString()!="")
					{
						model.DateTime=DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
					}
					if(dt.Rows[n]["BegingDate"].ToString()!="")
					{
						model.BegingDate=DateTime.Parse(dt.Rows[n]["BegingDate"].ToString());
					}
					if(dt.Rows[n]["EndDate"].ToString()!="")
					{
						model.EndDate=DateTime.Parse(dt.Rows[n]["EndDate"].ToString());
					}
					if(dt.Rows[n]["Indexs"].ToString()!="")
					{
						model.Indexs=int.Parse(dt.Rows[n]["Indexs"].ToString());
					}
					if(dt.Rows[n]["IsVerify"].ToString()!="")
					{
						model.IsVerify=int.Parse(dt.Rows[n]["IsVerify"].ToString());
					}
					if(dt.Rows[n]["VerifyMan"].ToString()!="")
					{
						model.VerifyMan=int.Parse(dt.Rows[n]["VerifyMan"].ToString());
					}
					if(dt.Rows[n]["VerifyDateTime"].ToString()!="")
					{
						model.VerifyDateTime=DateTime.Parse(dt.Rows[n]["VerifyDateTime"].ToString());
					}
                    if (dt.Rows[n]["CaicType"].ToString() != "")
                    {
                        model.CaicType = int.Parse(dt.Rows[n]["CaicType"].ToString());
                    }
                    else
                    {
                        model.CaicType = 0;
                    }
                    if (dt.Rows[n]["Posting"] != null && dt.Rows[n]["Posting"].ToString() != "")
                    {
                        model.Posting = int.Parse(dt.Rows[n]["Posting"].ToString());
                    }
					modelList.Add(model);
				}
			}
			return modelList;
		}
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.PayMain> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<Hownet.Model.PayMain> modelList = new List<Hownet.Model.PayMain>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.PayMain model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.PayMain();
                    if (ds.Tables[0].Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(ds.Tables[0].Rows[n]["ID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(ds.Tables[0].Rows[n]["DateTime"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["BegingDate"].ToString() != "")
                    {
                        model.BegingDate = DateTime.Parse(ds.Tables[0].Rows[n]["BegingDate"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["EndDate"].ToString() != "")
                    {
                        model.EndDate = DateTime.Parse(ds.Tables[0].Rows[n]["EndDate"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["Indexs"].ToString() != "")
                    {
                        model.Indexs = int.Parse(ds.Tables[0].Rows[n]["Indexs"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["IsVerify"].ToString() != "")
                    {
                        model.IsVerify = int.Parse(ds.Tables[0].Rows[n]["IsVerify"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["VerifyMan"].ToString() != "")
                    {
                        model.VerifyMan = int.Parse(ds.Tables[0].Rows[n]["VerifyMan"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["VerifyDateTime"].ToString() != "")
                    {
                        model.VerifyDateTime = DateTime.Parse(ds.Tables[0].Rows[n]["VerifyDateTime"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["CaicType"].ToString() != "")
                    {
                        model.CaicType = int.Parse(ds.Tables[0].Rows[n]["CaicType"].ToString());
                    }
                    else
                    {
                        model.CaicType = 0;
                    }
                    if (ds.Tables[0].Rows[n]["Posting"] != null && ds.Tables[0].Rows[n]["Posting"].ToString() != "")
                    {
                        model.Posting = int.Parse(ds.Tables[0].Rows[n]["Posting"].ToString());
                    }
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
        /// �ж��Ƿ���������
        /// </summary>
        /// <returns></returns>
        public bool NoEnd()
        {
            return dal.NoEnd();
        }
         /// <summary>
        /// ȡ�ñ����һ��IDֵ
        /// </summary>
        /// <returns></returns>
        public int GetLastID()
        {
            return dal.GetLastID();
        }
        /// <summary>
        /// ȡ���¼���ʱ���˹��ʼ���ϸ
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public DataSet GetTemPay(DateTime BeginDate, DateTime EndDate)
        {
            DataSet ds = dal.GetTemPay(BeginDate, EndDate);
            Hownet.Model.Pay modP = new Hownet.Model.Pay();
            ds.Tables[0].Columns.Add("OneDate", typeof(string));
            ds.Tables[0].Columns.Add("TwoDate", typeof(string));
            ds.Tables[0].Columns.Add("NowMoney", typeof(decimal));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["OneDate"] = BeginDate.ToString("yyyy��MM��dd��");
                ds.Tables[0].Rows[i]["TwoDate"] = EndDate.ToString("yyyy��MM��dd��");
                if (ds.Tables[0].Rows[i]["Month"].ToString() != "")
                    modP.Month = decimal.Parse(ds.Tables[0].Rows[i]["Month"].ToString());
                else
                    modP.Month = 0;
                if (ds.Tables[0].Rows[i]["Payment"].ToString() != "")
                    modP.Payment = decimal.Parse(ds.Tables[0].Rows[i]["Payment"].ToString());
                else
                    modP.Payment = 0;
                if (ds.Tables[0].Rows[i]["BoardWages"].ToString() != "")
                    modP.BoardWages = decimal.Parse(ds.Tables[0].Rows[i]["BoardWages"].ToString());
                else
                    modP.BoardWages = 0;
                if (ds.Tables[0].Rows[i]["Repair"].ToString() != "")
                    modP.Repair = decimal.Parse(ds.Tables[0].Rows[i]["Repair"].ToString());
                else
                    modP.Repair = 0;
                ds.Tables[0].Rows[i]["NowMoney"] = modP.Month  + modP.Repair - modP.BoardWages - modP.Payment;
            }
            return ds;
        }
        public DataSet GetTemPayByPW(DateTime BeginDate, DateTime EndDate,int EmployeeID)
        {
            try
            {
                Hownet.BLL.OtherType bllOT = new OtherType();
                List<Hownet.Model.OtherType> list = bllOT.DataTableToList(bllOT.GetTypeList("��ʳ�۷�").Tables[0]);
                DataTable dtPaySet = bllOT.GetNumValue().Tables[0];
                
                decimal ZhaoCan, WuCan, WanCan, Month;
                ZhaoCan = WuCan = WanCan = Month= 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Name == "���")
                        ZhaoCan = Convert.ToDecimal(list[i].Value);
                    else if (list[i].Name == "���")
                        WuCan = Convert.ToDecimal(list[i].Value);
                    else if (list[i].Name == "���")
                        WanCan = Convert.ToDecimal(list[i].Value);
                }

                DataSet ds = dal.GetTemPayByPW(BeginDate, EndDate, EmployeeID);
                Hownet.BLL.MiniEmp bllME = new MiniEmp();
                DataTable dtEMP = bllME.GetWorkList().Tables[0];
                Hownet.Model.Pay modP = new Hownet.Model.Pay();
                Hownet.BLL.PayCosts bllPC = new PayCosts();
                Hownet.BLL.SysTem bllST = new SysTem();
                Hownet.BLL.OrderingList bllOL = new OrderingList();
                Hownet.Model.SysTem modST = bllST.GetModel(bllST.GetMaxId() - 1);
                DataTable dtPC = bllPC.GetListByDay(BeginDate, EndDate, EmployeeID).Tables[0];
                ds.Tables[0].Columns.Add("OneDate", typeof(string));
                ds.Tables[0].Columns.Add("TwoDate", typeof(string));
                ds.Tables[0].Columns.Add("NowMoney", typeof(decimal));
                ds.Tables[0].Columns.Add("FullAttendance", typeof(decimal));
                ds.Tables[0].Columns.Add("Fine", typeof(decimal));
                ds.Tables[0].Columns.Add("Deposit", typeof(decimal));
                ds.Tables[0].Columns.Add("Add1", typeof(decimal));
                ds.Tables[0].Columns.Add("Add2", typeof(decimal));
                ds.Tables[0].Columns.Add("Add3", typeof(decimal));
                ds.Tables[0].Columns.Add("Add4", typeof(decimal));
                ds.Tables[0].Columns.Add("Add5", typeof(decimal));
                ds.Tables[0].Columns.Add("Jian1", typeof(decimal));
                ds.Tables[0].Columns.Add("Jian2", typeof(decimal));
                ds.Tables[0].Columns.Add("Jian3", typeof(decimal));
                ds.Tables[0].Columns.Add("Jian4", typeof(decimal));
                ds.Tables[0].Columns.Add("Jian5", typeof(decimal));
                ds.Tables[0].Columns.Add("ActualMonth", typeof(decimal));
                ds.Tables[0].Columns.Add("NotFact", typeof(bool));
                ds.Tables["Info"].Columns.Add("Money", typeof(decimal));
                decimal price = 0;
                decimal amount = 0;
                for (int i = 0; i < ds.Tables["Info"].Rows.Count; i++)
                {
                    price = 0;
                    amount = 0;
                    if (ds.Tables["Info"].Rows[i]["Amount"].ToString() != "")
                        amount = decimal.Parse(ds.Tables["Info"].Rows[i]["Amount"].ToString());
                    if (ds.Tables["Info"].Rows[i]["Price"].ToString() != "")
                        price = decimal.Parse(ds.Tables["Info"].Rows[i]["Price"].ToString());
                    ds.Tables["Info"].Rows[i]["Money"] = (price * amount).ToString("N4");
                }
                ds.Tables["NoDefault"].Columns.Add("Money", typeof(decimal));
                
                if ((modST.DoubleNotDefaultWTNum > 0))
                {
                    for (int i = 0; i < ds.Tables["NoDefault"].Rows.Count; i++)
                    {
                        price = 0;
                        amount = 0;
                        if (ds.Tables["NoDefault"].Rows[i]["Amount"].ToString() != "")
                            amount = decimal.Parse(ds.Tables["NoDefault"].Rows[i]["Amount"].ToString());
                        if (ds.Tables["NoDefault"].Rows[i]["Price"].ToString() != "")
                            price = decimal.Parse(ds.Tables["NoDefault"].Rows[i]["Price"].ToString());
                        ds.Tables["NoDefault"].Rows[i]["Money"] = (price * amount).ToString("N4");
                    }
                }
                else
                {
                    ds.Tables["NoDefault"].Rows.Clear();
                }
                int AllowedCount = 0;
                decimal ErrorMoney = 0;
                if (modST.AutoCaicBoardWages)
                {
                   // bllOL.CaicMoney(EndDate.AddDays(1));
                    AllowedCount = Convert.ToInt32(bllOT.GetList("(Name='����Υ�����')").Tables[0].Rows[0]["Value"]);
                    ErrorMoney = Convert.ToDecimal(bllOT.GetList("(Name='���ͺ�δ��')").Tables[0].Rows[0]["Value"]);
                }
                DataRow[] drs;
                DataRow[] ddrs;
                DataRow[] drMEs;
                try
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ds.Tables[0].Rows[i]["OneDate"] = BeginDate.ToString("yyyy��MM��dd��");
                        ds.Tables[0].Rows[i]["TwoDate"] = EndDate.ToString("yyyy��MM��dd��");
                        if (ds.Tables[0].Rows[i]["Month"].ToString() != "")
                            modP.Month = decimal.Parse(ds.Tables[0].Rows[i]["Month"].ToString());
                        else
                            modP.Month = 0;
                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=62) ");
                        drMEs = dtEMP.Select("(ID=" + ds.Tables[0].Rows[i]["EmployeeID"] + ")");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Payment"] = drs[0]["Money"];
                            modP.Payment = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Payment = 0;
                        if (modST.AutoCaicBoardWages)
                        {
                            modP.BoardWages = bllOL.GetMoney(Convert.ToInt32(ds.Tables[0].Rows[i]["EmployeeID"]), BeginDate, EndDate.AddDays(1), AllowedCount, ErrorMoney,ZhaoCan, WuCan, WanCan);
                            ds.Tables[0].Rows[i]["BoardWages"] = modP.BoardWages;
                        }
                        else
                        {
                            if (drMEs.Length > 0)
                            {
                                modP.BoardWages = Convert.ToDecimal(drMEs[0]["BoardWages"]);// bllME.GetModel(Convert.ToInt32(ds.Tables[0].Rows[i]["EmployeeID"])).BoardWages;
                                ds.Tables[0].Rows[i]["BoardWages"] = modP.BoardWages;
                            }
                            if (modP.BoardWages == 0)
                            {
                                drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=61)");
                                if (drs.Length > 0)
                                {
                                    ds.Tables[0].Rows[i]["BoardWages"] = drs[0]["Money"];
                                    modP.BoardWages = decimal.Parse(drs[0]["Money"].ToString());
                                }
                                else
                                    modP.BoardWages = 0;
                            }
                        }
                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=60)");//���㲹��
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Repair"] = drs[0]["Money"];
                            modP.Repair = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Repair = 0;
                        if (modST.DoubleNotDefaultWTNum > 0)
                        {
                            ddrs = ds.Tables["NoDefault"].Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"] + ")");//�����Ĭ�Ϲ��ֵĲ���
                            if (ddrs.Length > 0)
                            {
                                for (int m = 0; m < ddrs.Length; m++)
                                {
                                    modP.Repair += Convert.ToDecimal(ddrs[m]["Money"]) * modST.DoubleNotDefaultWTNum;
                                }
                                ds.Tables[0].Rows[i]["Repair"] = modP.Repair;
                            }
                        }
                        if (dtPaySet.Rows.Count > 0)//�й����������
                        {
                            if (drMEs.Length > 0)
                            {
                                if (Convert.ToBoolean(drMEs[0]["IsCaicTiCheng"]))
                                {
                                    Month = Convert.ToDecimal(ds.Tables[0].Rows[i]["Month"]);
                                    if (Month > Convert.ToInt32(dtPaySet.Rows[0][0]))//���������ɣ�ֱ�����
                                    {
                                        modP.Repair += Month * Convert.ToDecimal(dtPaySet.Rows[0][1]);
                                        ds.Tables[0].Rows[i]["Repair"] = modP.Repair;
                                    }
                                    else if (Month > Convert.ToInt32(dtPaySet.Rows[dtPaySet.Rows.Count - 1][0]))//С�������ɶ�ȵ��ִ��������ɶ�ȣ�Ȼ��Ӵ���С�Ƚϣ�
                                    {
                                        for (int j = 0; j < dtPaySet.Rows.Count; j++)
                                        {
                                            if (Month > Convert.ToDecimal(dtPaySet.Rows[j][0]))
                                            {
                                                modP.Repair += Month * Convert.ToDecimal(dtPaySet.Rows[j][1]);
                                                ds.Tables[0].Rows[i]["Repair"] = modP.Repair;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=91)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["FullAttendance"] = drs[0]["Money"];
                            modP.FullAttendance = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.FullAttendance = 0;

                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=92)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Fine"] = drs[0]["Money"];
                            modP.Fine = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Fine = 0;


                        //drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=92)");
                        //if (drs.Length > 0)
                        //{
                        //    ds.Tables[0].Rows[i]["Fine"] = drs[0]["Money"];
                        //    modP.Deposit = decimal.Parse(drs[0]["Money"].ToString());
                        //}
                        //else
                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=109)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Deposit"] = drs[0]["Money"];
                            modP.Deposit = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Deposit = 0;
                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=7)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Add1"] = drs[0]["Money"];
                            modP.Add1 = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Add1 = 0;

                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=8)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Add2"] = drs[0]["Money"];
                            modP.Add2 = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Add2 = 0;
                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=9)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Add3"] = drs[0]["Money"];
                            modP.Add3 = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Add3 = 0;
                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=10)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Add4"] = drs[0]["Money"];
                            modP.Add4 = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Add4 = 0;
                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=11)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Add5"] = drs[0]["Money"];
                            modP.Add5 = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Add5 = 0;

                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=12)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Jian1"] = drs[0]["Money"];
                            modP.Jian1 = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Jian1 = 0;

                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=13)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Jian2"] = drs[0]["Money"];
                            modP.Jian2 = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Jian2 = 0;
                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=14)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Jian3"] = drs[0]["Money"];
                            modP.Jian3 = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Jian3 = 0;
                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=15)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Jian4"] = drs[0]["Money"];
                            modP.Jian4 = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Jian4 = 0;
                        drs = dtPC.Select("(EmployeeID=" + ds.Tables[0].Rows[i]["EmployeeID"].ToString() + ") and (TypeID=16)");
                        if (drs.Length > 0)
                        {
                            ds.Tables[0].Rows[i]["Jian5"] = drs[0]["Money"];
                            modP.Jian5 = decimal.Parse(drs[0]["Money"].ToString());
                        }
                        else
                            modP.Jian5 = 0;
                        ds.Tables[0].Rows[i]["ActualMonth"] = ds.Tables[0].Rows[i]["Month"];
                        ds.Tables[0].Rows[i]["NotFact"] = false;
                       // ds.Tables[0].Rows[i]["NowMoney"] = modP.Month + modP.Repair - modP.BoardWages - modP.Payment + modP.FullAttendance - modP.Fine - modP.Deposit;
                    }
                }
                catch (Exception ex)
                {

                }

                return ds;
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        /// <summary>
        /// ͳ��û�й��۵Ŀ��
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public SqlDataReader NoPrice(DateTime BeginDate, DateTime EndDate)
        {
            return dal.NoPrice(BeginDate, EndDate);
        }
        /// <summary>
        /// �ι��ʻ������������
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="MainID"></param>
        public void PayDateSum(DateTime BeginDate, DateTime EndDate, int MainID)
        {
            dal.PaySum(BeginDate, EndDate, MainID);
        }
        public void PaySums( int MainID)
        {
            DataTable dtMain = GetList("(ID=" + MainID + ")").Tables[0];
            if (dtMain.Rows.Count == 0)
            {
                return;
            }

            //Hownet.DAL.PaySum dalPS = new Hownet.DAL.PaySum();
            //DataTable dt = dal.GetInfo(Convert.ToDateTime(dtMain.Rows[0]["BegingDate"]), Convert.ToDateTime(dtMain.Rows[0]["EndDate"])).Tables[0];
            dal.AddPS(Convert.ToDateTime(dtMain.Rows[0]["BegingDate"]), Convert.ToDateTime(dtMain.Rows[0]["EndDate"]), MainID);
            //int rowsCount = dt.Rows.Count;
            //if (rowsCount > 0)
            //{
            //    Hownet.Model.PaySum model;
            //    for (int n = 0; n < rowsCount; n++)
            //    {
            //        model = new Hownet.Model.PaySum();
            //        if (dt.Rows[n]["MaterielID"].ToString() != "")
            //        {
            //            model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
            //        }
            //        if (dt.Rows[n]["WorkingID"].ToString() != "")
            //        {
            //            model.WorkingID = int.Parse(dt.Rows[n]["WorkingID"].ToString());
            //        }
            //        if (dt.Rows[n]["Amount"].ToString() != "")
            //        {
            //            model.Amount = int.Parse(dt.Rows[n]["Amount"].ToString());
            //        }
            //        if (dt.Rows[n]["Price"].ToString() != "")
            //        {
            //            model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
            //        }
            //        if (dt.Rows[n]["EmployeeID"].ToString() != "")
            //        {
            //            model.EmployeeID = int.Parse(dt.Rows[n]["EmployeeID"].ToString());
            //        }
            //        model.PayMainID = MainID;
            //        dalPS.Add(model);
            //    }
            //}
        }
        /// <summary>
        /// ��ͳ�Ƴ��Ĺ��ʽ����뵽�����ܱ�
        /// </summary>
        /// <param name="MainID"></param>
        public void PayMoney(byte[] bb, int MainID)
        {
            DataTable dt = Hownet.BLL.BaseFile.ZipDt.Byte2Ds(bb).Tables[0];
            //dal.PayMoney(MainID);
            Hownet.BLL.Pay bllP = new Pay();
            Hownet.Model.Pay modP;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                modP = new Hownet.Model.Pay();
                modP.MainID = MainID;
                modP.EmployeeID = int.Parse(dt.Rows[i]["EmployeeID"].ToString());
                if (dt.Rows[i]["BoardWages"].ToString() != "")
                    modP.BoardWages = decimal.Parse(dt.Rows[i]["BoardWages"].ToString());
                //else
                //    modP.BoardWages = 0;
                if (dt.Rows[i]["Repair"].ToString() != "")
                    modP.Repair = decimal.Parse(dt.Rows[i]["Repair"].ToString());
                //else
                //    modP.Repair = DBNull.Value;
                if (dt.Rows[i]["Payment"].ToString() != "")
                    modP.Payment = decimal.Parse(dt.Rows[i]["Payment"].ToString());
                //else
                //    modP.Payment = DBNull.Value;
                if (dt.Rows[i]["Month"].ToString() != "")
                    modP.Month = decimal.Parse(dt.Rows[i]["Month"].ToString());
                //else
                //    modP.Month = 0;
                if (dt.Rows[i]["LastRemain"].ToString() != "")
                    modP.LastRemain = decimal.Parse(dt.Rows[i]["LastRemain"].ToString());
                //else
                //    modP.LastRemain = 0;
                object obj = dt.Rows[i]["Remain"];
                if (dt.Rows[i]["Remain"].ToString() != "")
                    modP.Remain = decimal.Parse(dt.Rows[i]["Remain"].ToString());
                if (dt.Rows[i]["Fact"].ToString() != "")
                    modP.Fact = decimal.Parse(dt.Rows[i]["Fact"].ToString());
                modP.IsEnd = false;
                int a = int.Parse(dt.Rows[i]["A"].ToString());
                if (a == 3)
                    bllP.Add(modP);
                else if (a == 2)
                {
                    modP.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                    bllP.Update(modP);
                }

            }
        }
        /// <summary>
        ///  ���¹������
        /// </summary>
        /// <param name="MainID"></param>
        public void UpPay(int MainID)
        {
            dal.UpPay(MainID);
        }
        /// <summary>
        /// �������
        /// </summary>
        /// <param name="model"></param>
        public void UpLock(Hownet.Model.PayMain model)
        {
            dal.UpLock(model);
        }
        /// <summary>
        /// �������б�
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetPayLine(int MainID)
        {
            return dal.GetPayLine(MainID);
        }
        /// <summary>
        /// ���ع��ʱ���ϸ������
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetPayPrice(int MainID)
        {
            return dal.GetPayPrice(MainID);
        }
         /// <summary>
        /// ����ͳ��������ϸ��
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetPayAmount(int MainID)
        {
            return dal.GetPayAmount(MainID);
        }
        public DataSet GetIDList()
        {
            return dal.GetIDList();
        }
        /// <summary>
        /// ����ֶ������Ƿ��ѻ���
        /// </summary>
        /// <param name="dateOne">��ʼ����</param>
        /// <param name="dateTwo">��ֹ����</param>
        /// <param name="TypeID">0Ϊδ���ܣ�1Ϊ�ѻ���</param>
        public void UpHandIsEnd(DateTime dateOne, DateTime dateTwo, int TypeID)
        {
            dal.UpHandIsEnd(dateOne, dateTwo, TypeID);
        }
        public DataSet GetMoneyList(DateTime dtOne, DateTime dtTwo)
        {
            return dal.GetMoneyList(dtOne, dtTwo);
        }
        public decimal GetCut(int EmployeeID, DateTime dtOne, DateTime dtTwo)
        {
            return dal.GetCut(EmployeeID, dtOne, dtTwo);
        }
           /// <summary>
        /// ��������Ա���ļƼ������ܽ��
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public DataSet GetTemPayByPWAll(DateTime BeginDate, DateTime EndDate)
        {
            return dal.GetTemPayByPWAll(BeginDate, EndDate);
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

