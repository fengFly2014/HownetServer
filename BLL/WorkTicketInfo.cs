using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���WorkTicketInfo ��ժҪ˵����
	/// </summary>
	public class WorkTicketInfo
	{
		private readonly Hownet.DAL.WorkTicketInfo dal=new Hownet.DAL.WorkTicketInfo();
		public WorkTicketInfo()
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
		public int  Add(Hownet.Model.WorkTicketInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.WorkTicketInfo> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.WorkTicketInfo model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.WorkTicketInfo> li=DataTableToList(dt);
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
		public Hownet.Model.WorkTicketInfo GetModel(int ID)
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
		public List<Hownet.Model.WorkTicketInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.WorkTicketInfo> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.WorkTicketInfo> modelList = new List<Hownet.Model.WorkTicketInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.WorkTicketInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.WorkTicketInfo();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					if(dt.Rows[n]["DateTime"].ToString()!="")
					{
						model.DateTime=DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
					}
					if(dt.Rows[n]["IsDel"].ToString()!="")
					{
						if((dt.Rows[n]["IsDel"].ToString()=="1")||(dt.Rows[n]["IsDel"].ToString().ToLower()=="true"))
						{
						model.IsDel=true;
						}
						else
						{
							model.IsDel=false;
						}
					}
					if(dt.Rows[n]["PWorkingInfoID"].ToString()!="")
					{
						model.PWorkingInfoID=int.Parse(dt.Rows[n]["PWorkingInfoID"].ToString());
					}
					if(dt.Rows[n]["EmployeeID"].ToString()!="")
					{
						model.EmployeeID=int.Parse(dt.Rows[n]["EmployeeID"].ToString());
					}
					if(dt.Rows[n]["BackID"].ToString()!="")
					{
						model.BackID=int.Parse(dt.Rows[n]["BackID"].ToString());
					}
					if(dt.Rows[n]["Amount"].ToString()!="")
					{
						model.Amount=int.Parse(dt.Rows[n]["Amount"].ToString());
					}
					if(dt.Rows[n]["NotAmount"].ToString()!="")
					{
						model.NotAmount=int.Parse(dt.Rows[n]["NotAmount"].ToString());
					}
                    if (dt.Rows[n]["TaskID"].ToString() != "")
                    {
                        model.TaskID = int.Parse(dt.Rows[n]["TaskID"].ToString());
                    }
                    if (dt.Rows[n]["WorkingID"].ToString() != "")
					{
                        model.WorkingID = int.Parse(dt.Rows[n]["WorkingID"].ToString());
					}
                    if (dt.Rows[n]["OutAmount"] != null && dt.Rows[n]["OutAmount"].ToString() != "")
                    {
                        model.OutAmount = int.Parse(dt.Rows[n]["OutAmount"].ToString());
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
        /// ��ò�������A�����б�
        /// </summary>
        public DataSet GetListNoA(string strWhere)
        {
            return dal.GetListNoA(strWhere);
        }
        public DataSet GetBoolAdd(int TaskID, int BoxNum, int WorkingID)
        {
            return dal.GetBoolAdd(TaskID, BoxNum, WorkingID);
        }
                /// <summary>
        /// ɾ��һ���Ѽ�¼������
        /// </summary>
        /// <param name="ID"></param>
        public void DelBar(int ID)
        {
            dal.DelBar(ID);
        }
        public bool CheckWorking(int TaskID, int PWIID, int CompanyID)
        {
            Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
            Hownet.BLL.Working bllW = new Working();
            Hownet.BLL.WorkTicket bllWT = new WorkTicket();
            Hownet.Model.ProductWorkingInfo modPWI = new Hownet.Model.ProductWorkingInfo();
            modPWI = bllPWI.GetModel(PWIID);
            if (!modPWI.IsSpecial)//�������⹤��
            {
                if (!dal.CheckWorking(TaskID, PWIID,modPWI.OneAmount))//�����ɹ�Ʊ��û���������
                {
                    Hownet.Model.WorkTicketInfo modWTI;
                    DataTable dtWT = new DataTable();
                    dtWT = bllWT.GetList("(TaskID=" + TaskID + ") And (OneAmount=" + modPWI.OneAmount + ")").Tables[0];
                    for (int i = 0; i < dtWT.Rows.Count; i++)
                    {
                        modWTI = new Hownet.Model.WorkTicketInfo();
                        modWTI.NotAmount = modWTI.Amount = int.Parse(dtWT.Rows[i]["Amount"].ToString());
                        modWTI.BackID = 0;
                        modWTI.DateTime = null;
                        modWTI.EmployeeID = 0;
                        modWTI.IsDel = false;
                        modWTI.MainID = int.Parse(dtWT.Rows[i]["ID"].ToString());

                        if (TaskID > 0)
                        {
                            modWTI.TaskID = TaskID;
                            modWTI.PWorkingInfoID = PWIID;
                        }
                        modWTI.WorkingID = modPWI.WorkingID;
                        Add(modWTI);
                    }
                }
                return true;
            }
            else
            {
                DataTable dtTem = bllPWI.GetList("(PWIID=" + modPWI.ID + ")").Tables[0];
                List<Hownet.Model.ProductWorkingInfo> li = bllPWI.DataTableToList(dtTem);//�����⹤��ʱ�������乹�ɵ���ͨ����
                if (li.Count == 0)
                    return false;
                for (int i = 0; i < li.Count; i++)
                {
                    if (dal.CheckWorking(TaskID, li[i].ID,  li[i].OneAmount))
                    {
                        return true;
                    }
                }
                Hownet.Model.WorkTicketInfo modWTI;
                DataTable dtWT = new DataTable();
                dtWT = bllWT.GetList("(TaskID=" + TaskID + ") And (OneAmount=" + li[0].OneAmount + ")").Tables[0];
                DataRow[] drs;
                bool t = false;
                for (int i = 0; i < dtWT.Rows.Count; i++)
                {
                    t = false;
                    modWTI = new Hownet.Model.WorkTicketInfo();
                    modWTI.NotAmount = modWTI.Amount = int.Parse(dtWT.Rows[i]["Amount"].ToString());
                    modWTI.BackID = 0;
                    modWTI.DateTime = null;
                    modWTI.EmployeeID = 0;
                    modWTI.IsDel = false;
                    modWTI.MainID = int.Parse(dtWT.Rows[i]["ID"].ToString());
                    if (TaskID > 0)
                        modWTI.TaskID = TaskID;
                    //if (CompanyID > 0)
                    //{
                        drs = dtTem.Select("(CompanyID=" + CompanyID + ") And (ColorID=" + dtWT.Rows[i]["ColorID"] + ") And (MaterielID="+dtWT.Rows[i]["SizeID"]+")");//ͬ�ͻ�ͬ��ɫͬ����
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=" + CompanyID + ") And (ColorID=0) And (MaterielID=" + dtWT.Rows[i]["SizeID"] + ")");//ͬ�ͻ�ͬ��������ɫ
                        }
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=" + CompanyID + ") And (ColorID=" + dtWT.Rows[i]["ColorID"] + ") And (MaterielID=0)");//ͬ�ͻ�ͬ��ɫ�޳���
                        }
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=0) And (ColorID=" + dtWT.Rows[i]["ColorID"] + ") And  (MaterielID=" + dtWT.Rows[i]["SizeID"] + ")");//�޿ͻ�ͬ��ɫͬ����
                        }
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=" + CompanyID + ") And (ColorID=0) And (MaterielID=0)");//���ͻ�
                        }
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=0) And (ColorID=" + dtWT.Rows[i]["ColorID"] + ") And (MaterielID=0)");//����ɫ
                        }
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=0) And (ColorID=0) And (MaterielID=" + dtWT.Rows[i]["SizeID"] + ")");//������
                        }
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=0) And (ColorID=0) And (MaterielID=0)");//�޿ͻ�����ɫ�޳���
                        }
                        if (drs.Length > 0)
                        {
                            modWTI.WorkingID = int.Parse(drs[0]["WorkingID"].ToString());
                            modWTI.PWorkingInfoID = int.Parse(drs[0]["ID"].ToString());
                        }
                        else
                        {
                            t = true;
                        }
                    //}
                    //else
                    //{
                    //    drs = dtTem.Select("(CompanyID=0) And (ColorID=" + dtWT.Rows[i]["ColorID"] + ")");
                    //    if (drs.Length == 0)
                    //    {
                    //        drs = dtTem.Select("(CompanyID=0) And (ColorID=0)");
                    //    }
                    //    if (drs.Length > 0)
                    //    {
                    //        modWTI.WorkingID = int.Parse(drs[0]["WorkingID"].ToString());
                    //        modWTI.PWorkingInfoID = int.Parse(drs[0]["ID"].ToString());
                    //    }
                    //    else
                    //    {
                    //        t = true;
                    //    }
                    //}

                    if (!t)
                        Add(modWTI);
                }
            }

            return true;
        }
        public DataSet GetTicketLine(int TaskID, int PWIID, int TaskDepID, int DPWID)
        {
            DataSet ds = new DataSet();
            Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
            Hownet.Model.ProductWorkingInfo modPWI = new Hownet.Model.ProductWorkingInfo();
            if (TaskDepID == 0)
                modPWI = bllPWI.GetModel(PWIID);
            else
                modPWI = bllPWI.GetModel(DPWID);
            if (!modPWI.IsSpecial)//�������⹤��
            {
                return dal.GetTicketLine(TaskID, PWIID, TaskDepID, DPWID);
            }
            else
            {
               return dal.GetSpecialTicketLine(TaskID, PWIID, TaskDepID, DPWID);
            }
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                ds.Tables.Clear();
                ds = dal.GetSpecialTicketLine(TaskID, PWIID,TaskDepID,DPWID);
            }
            return ds;
        }
        /// <summary>
        /// ������ʾ����ִ�����
        /// </summary>
        /// <param name="TaskID">������ID</param>
        /// <returns></returns>
        public DataSet GetWorkListByPW(int TaskID, int PWMID, int MaterielID,int TaskDepID)
        {
            try
            {
                Hownet.BLL.WorkTicket bllWT = new WorkTicket();
                Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
                DataSet ds = new DataSet();
                //if (TaskDepID == 0)
                    ds = dal.GetWorkListByPW(TaskID);
                //else
                    //ds = dal.GetDepWorkListByPW(TaskDepID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].Columns.Add("EmpDate", typeof(string));
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        if (ds.Tables[0].Rows[i]["DateTime"].ToString() != "" && (DateTime)(ds.Tables[0].Rows[i]["DateTime"]) != DateTime.Parse("1900-1-1"))
                        {
                            ds.Tables[0].Rows[i]["EmpDate"] = ds.Tables[0].Rows[i]["EmployeeName"].ToString() + "/" + ((DateTime)(ds.Tables[0].Rows[i]["DateTime"])).ToString();
                        }
                        else
                            ds.Tables[0].Rows[i]["EmpDate"] = " ";
                    }
                }
                DataTable dtPWI = new DataTable();
                if (TaskDepID == 0)
                {
                    dtPWI = bllPWI.GetProWorkListByPW(PWMID, MaterielID).Tables[0];
                }
                else
                {
                    Hownet.BLL.DepartmentTaskMain bllDTM = new DepartmentTaskMain();
                    Hownet.Model.DepartmentTaskMain modDtm = bllDTM.GetModel(TaskDepID);
                    dtPWI = bllPWI.GetProWorkListByPW(modDtm.PWID, MaterielID).Tables[0];
                }
                DataTable dt = bllWT.GetWorkList(TaskID, TaskDepID).Tables[0].Copy();
                if (dtPWI.Rows.Count > 0)
                {
                    for (int i = 0; i < dtPWI.Rows.Count; i++)
                    {
                        try
                        {
                            dt.Columns.Add(dtPWI.Rows[i]["WorkingName"].ToString(), typeof(string));
                            for (int j = 0; j < dt.Rows.Count; j++)
                            {
                                object box = dt.Rows[j]["���"];
                                object wor = dtPWI.Rows[i]["ID"];
                                DataRow[] drs = ds.Tables[0].Select("(MainID=" + dt.Rows[j]["ID"] + ") And (WorkingID=" + dtPWI.Rows[i]["WorkingID"] + ")");
                                if (drs.Length > 0)
                                {
                                    object obj = drs[0]["EmpDate"];
                                    dt.Rows[j][dtPWI.Rows[i]["WorkingName"].ToString()] = drs[0]["EmpDate"];
                                }
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                DataSet dsss = new DataSet();
                dsss.Tables.Add(dt);
                return dsss;
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        public void AddPayInfo(int MaterielID, int InfoID, string oderNum)
        {
            dal.AddPayInfo(MaterielID, InfoID, oderNum);
        }
        public DataSet GetWorkingByTicketID(int GroupBy, int TicketID)
        {
            return dal.GetWorkingByTicketID(GroupBy, TicketID);
        }
        public string CountAmount(int EmpID, DateTime dt,bool IsShowMoney)
        {
            return dal.CountAmount(EmpID, dt,IsShowMoney);
        }
        public string CountAmountByWorking(int EmpID, DateTime dt, bool IsShowMoney, int WorkingID)
        {
            return dal.CountAmountByWorking(EmpID, dt, IsShowMoney, WorkingID);
        }
        public DataSet GetKey(int TicketID, int WorkOrder, int SizeID, int ColorID)
        {
            return dal.GetKey(TicketID, WorkOrder, SizeID, ColorID);
        }
        public DateTime GetDateTime()
        {
            return dal.GetDateTime();
        }
        public string GetEmployee(int EmpID, int typeID, DateTime dt, bool IsShowMoney)
        {
            return dal.GetEmployee(EmpID, typeID, dt,IsShowMoney);
        }
        public DataSet GetEmployeeNum(int EmpID, int typeID)
        {
            return dal.GetEmployeeNum(EmpID, typeID);
        }
        public string GetEmpSum(int EmpID, DateTime dt1, DateTime dt2, bool IsShowMoney)
        {
            return dal.GetEmpSum(EmpID, dt1, dt2, IsShowMoney);
        }
                /// <summary>
        /// ����ȫΪһ�������ʱ������������¹�Ʊ��ϸ
        /// </summary>
        /// <param name="ID">��Ʊ��ϸ��ID��Ϊ����¼��</param>
        /// <param name="EmployeeID">����Ʊ��Ա��</param>
        /// <param name="dt">��������</param>
        /// <returns></returns>
        public void GetBarBack(int ID, int EmployeeID, DateTime dt, int BackID)
        {
            dal.GetBarBack(ID, EmployeeID, dt, BackID);
        }
        /// <summary>
        /// ��ȡ��ǰ�����ӡʱ�ĸ�����ϸ
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="GroupID"></param>
        /// <returns></returns>
        public DataSet GetFristReport(int TaskID, int GroupID)
        {
            return dal.GetFristReport(TaskID, GroupID);
        }
        public DataSet GetGroupColorSize(int TaskID, int ColorID, int SizeID, int ColorOneID, int ColorTwoID)
        {
            return dal.GetGroupColorSize(TaskID, ColorID, SizeID,ColorOneID,ColorTwoID);
        }
          /// <summary>
        /// ���ػ��ܵķ�ɫ��������
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <param name="MatID"></param>
        /// <param name="PWID"></param>
        /// <param name="ColorID"></param>
        /// <param name="SizeID"></param>
        /// <returns></returns>
        public DataSet GetSUMCS(DateTime dt1, DateTime dt2, int MatID, int PWID, int ColorID, int SizeID, int ColorOneID, int ColorTwoID)
        {
            return dal.GetSUMCS(dt1, dt2, MatID, PWID, ColorID, SizeID, ColorOneID, ColorTwoID);
        }
               /// <summary>
        /// ���ػ��ܵ�������
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <param name="MatID"></param>
        /// <param name="PWID"></param>
        /// <returns></returns>
        public DataSet GetSUMNotCS(DateTime dt1, DateTime dt2, int MatID, int PWID)
        {
            return dal.GetSUMNotCS(dt1, dt2, MatID, PWID);
        }
        public DataSet GetWorkFishByTaskID(int TaskID)
        {
            return dal.GetWorkFishByTaskID(TaskID);
        }
        public DataSet GetWorking(int MaterielID, int BrandID, int ColorID, int SizeID)
        {
            return dal.GetWorking(MaterielID,BrandID, ColorID, SizeID);
        }
        public bool CheckNotWork(int TaskID, int dtmID)
        {
            return dal.CheckNotWork(TaskID, dtmID);
        }
        public void DeleteTicket(int TaskID, int DTMID)
        {
            dal.DeleteTicket(TaskID, DTMID);
        }
                /// <summary>
        /// �޸�ĳ�ݻ���δ��ɹ�������
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="Amount"></param>
        public void UpNoWorkingAmount(int MainID, int Amount, int GroupBy)
        {
            dal.UpNoWorkingAmount(MainID, Amount,GroupBy);
        }
        public string UpWorkEmp(int MainID, string WorkingName,int EmpID)
        {
            string aaa = string.Empty;
            Hownet.BLL.Working bllW = new Working();
            
            DataTable dtW = bllW.GetList("(Name='" + WorkingName + "')").Tables[0];
            if (dtW.Rows.Count > 0)
            {
                DataTable dt = dal.GetList("(MainID=" + MainID + ") And (WorkingID=" + dtW.Rows[0]["ID"] + ")").Tables[0];
                if (dt.Rows.Count ==1)
                {
                    Hownet.Model.WorkTicketInfo modWTI = GetModel(Convert.ToInt32(dt.Rows[0]["ID"]));
                    modWTI.EmployeeID = EmpID;
                    modWTI.DateTime = DateTime.Now;
                    Update(modWTI);

                    Hownet.BLL.WorkTicket bllWT = new WorkTicket();
                    Hownet.BLL.ProductTaskMain bllPTM=new ProductTaskMain();
                    
                    Hownet.Model.WorkTicket modWT = bllWT.GetModel(modWTI.MainID);
                    Hownet.Model.ProductTaskMain modPTM=bllPTM.GetModel(modWT.TaskID);
                    Hownet.BLL.PayInfo bllPI = new PayInfo();
                    Hownet.Model.PayInfo modPI = new Hownet.Model.PayInfo();
                    modPI.A = 3;
                    modPI.Amount = modWTI.Amount;
                    modPI.BoxNum = modWT.BoxNum;
                    modPI.BreakID = 1;
                    modPI.ColorID = modWT.ColorID;
                    modPI.DateTime = DateTime.Now;
                    modPI.EmployeeID = EmpID;
                    modPI.ID = 0;
                    modPI.IsDay = false;
                    modPI.IsSum = false;
                    modPI.MaterielID = modPTM.MaterielID;
                    modPI.OderNum = modPTM.DateTime.ToString("yyyyMMdd") + modPTM.Num.ToString().PadLeft(3, '0');
                    modPI.Price = 0;
                    modPI.ProductWorkingID = modWTI.PWorkingInfoID;
                    modPI.SizeID = modWT.SizeID;
                    modPI.WorkingID = modWTI.WorkingID;
                    modPI.WorkticketInfoID = modWTI.ID;
                    bllPI.Add(modPI);
                    aaa = DateTime.Now.ToString();
                }
            }
            return aaa;
        }
        public void AddPayInfoByID(int WTIID)
        {
            dal.AddPayInfoByID(WTIID);
        }
        public int GetID(int TaskID, int BoxNum, string WorkingName,int SizeID)
        {
            return dal.GetID(TaskID, BoxNum, WorkingName,SizeID);
        }
        /// <summary>
        /// ���� ĳԱ��֮ǰ���һ��ˢ��ʱ��
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public DateTime GetLastDate(int EmployeeID)
        {
            return dal.GetLastDate(EmployeeID);
        }
        /// <summary>
        /// ����ĳ��ĳ��ɫ�������δ������������һ�������δ�������
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="ColorID"></param>
        /// <param name="SizeID"></param>
        /// <param name="TopID"></param>
        /// <param name="PWIID"></param>
        /// <returns></returns>
        public int GetNotAmountByOrders(int TaskID, int ColorID, int SizeID, int WorkingID)
        {
            return dal.GetNotAmountByOrders(TaskID, ColorID, SizeID, WorkingID);
        }
        /// <summary>
        /// ����ĳ���ĳ��ɫ�������δ������������һ�������δ�������
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="ColorID"></param>
        /// <param name="SizeID"></param>
        /// <param name="TopID"></param>
        /// <param name="PWIID"></param>
        /// <returns></returns>
        public int GetNotAmountByMateriel(DateTime dt1,DateTime dt2, int MaterielID, int ColorID, int SizeID, int WorkingID)
        {
            return dal.GetNotAmountByMateriel(dt1,dt2, MaterielID, ColorID, SizeID, WorkingID);
        }
        public DataSet GetStringWorkFishByTaskID(int TaskID)
        {
            return dal.GetStringWorkFishByTaskID(TaskID);
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

