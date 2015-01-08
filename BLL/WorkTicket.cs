using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���WorkTicket ��ժҪ˵����
	/// </summary>
	public class WorkTicket
	{
		private readonly Hownet.DAL.WorkTicket dal=new Hownet.DAL.WorkTicket();
		public WorkTicket()
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
		public int  Add(Hownet.Model.WorkTicket model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.WorkTicket> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.WorkTicket model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.WorkTicket> li=DataTableToList(dt);
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
		public Hownet.Model.WorkTicket GetModel(int ID)
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
		public List<Hownet.Model.WorkTicket> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.WorkTicket> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.WorkTicket> modelList = new List<Hownet.Model.WorkTicket>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.WorkTicket model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.WorkTicket();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["ColorID"].ToString()!="")
					{
						model.ColorID=int.Parse(dt.Rows[n]["ColorID"].ToString());
					}
					if(dt.Rows[n]["ColorOneID"].ToString()!="")
					{
						model.ColorOneID=int.Parse(dt.Rows[n]["ColorOneID"].ToString());
					}
					if(dt.Rows[n]["ColorTwoID"].ToString()!="")
					{
						model.ColorTwoID=int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
					}
					if(dt.Rows[n]["SizeID"].ToString()!="")
					{
						model.SizeID=int.Parse(dt.Rows[n]["SizeID"].ToString());
					}
					if(dt.Rows[n]["Amount"].ToString()!="")
					{
						model.Amount=int.Parse(dt.Rows[n]["Amount"].ToString());
					}
					if(dt.Rows[n]["BoxNum"].ToString()!="")
					{
						model.BoxNum=int.Parse(dt.Rows[n]["BoxNum"].ToString());
					}
					if(dt.Rows[n]["TaskID"].ToString()!="")
					{
						model.TaskID=int.Parse(dt.Rows[n]["TaskID"].ToString());
					}
					if(dt.Rows[n]["DepartmentID"].ToString()!="")
					{
						model.DepartmentID=int.Parse(dt.Rows[n]["DepartmentID"].ToString());
					}
					if(dt.Rows[n]["P2DInfoID"].ToString()!="")
					{
						model.P2DInfoID=int.Parse(dt.Rows[n]["P2DInfoID"].ToString());
					}
					if(dt.Rows[n]["EligibleAmount"].ToString()!="")
					{
						model.EligibleAmount=int.Parse(dt.Rows[n]["EligibleAmount"].ToString());
					}
					if(dt.Rows[n]["InferiorAmount"].ToString()!="")
					{
						model.InferiorAmount=int.Parse(dt.Rows[n]["InferiorAmount"].ToString());
					}
					if(dt.Rows[n]["P2DDepartmentID"].ToString()!="")
					{
						model.P2DDepartmentID=int.Parse(dt.Rows[n]["P2DDepartmentID"].ToString());
					}
					if(dt.Rows[n]["MListID"].ToString()!="")
					{
						model.MListID=int.Parse(dt.Rows[n]["MListID"].ToString());
					}
					if(dt.Rows[n]["BrandID"].ToString()!="")
					{
						model.BrandID=int.Parse(dt.Rows[n]["BrandID"].ToString());
					}
                    if (dt.Rows[n]["OneAmount"].ToString() != "")
                    {
                        model.OneAmount = int.Parse(dt.Rows[n]["OneAmount"].ToString());
                    }
                    else
                    {
                        model.OneAmount = 0;
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
        /// ��ò�������A�������б�
        /// </summary>
        public DataSet GetListNoA(string strWhere)
        {
            return dal.GetListNoA(strWhere);
        }
        public void Save(byte[] bb, int ProductWorkID, int TaskID)
        {
            DataTable Main = Hownet.BLL.BaseFile.ZipDt.Byte2Ds(bb).Tables[0];
            Main.Columns.Add("OneAmount", typeof(int));
            for (int i = 0; i < Main.Rows.Count; i++)
            {
                Main.Rows[i]["OneAmount"] = 0;
            }
            Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
            Hownet.BLL.WorkTicket bllWT = new WorkTicket();
            Hownet.BLL.WorkTicketInfo bllWkInfo = new WorkTicketInfo();
            Hownet.Model.WorkTicket modWK = new Hownet.Model.WorkTicket();
            Hownet.Model.WorkTicketInfo modWKI = new Hownet.Model.WorkTicketInfo();
            Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
            Hownet.Model.ProductTaskMain modPTM = bllPTM.GetModel(TaskID);
            Hownet.BLL.AmountInfo bllPTI = new AmountInfo();
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
            Hownet.BLL.Materiel bllMat = new Materiel();
            Hownet.Model.Materiel modMat = bllMat.GetModel(modPTM.MaterielID);
            DataTable dtInfo = bllWkInfo.GetListNoA("(ID=0)").Tables[0];
            //DataSet dsPt = bllPTI.GetBoxID(TaskID, 1);

            //DataTable dtPWIAmount = bllPWI.GetOneAmount(ProductWorkID).Tables[0];
            //int _PJAmount = 0, _WAmount = 0;
            ////dtTem.Columns.Add("ColorID", typeof(string));
            ////   dtTem.Columns.Add("SizeID", typeof(string));
            ////   dtTem.Columns.Add("Amount", typeof(string));
            ////   dtTem.Columns.Add("BoxNum", typeof(string));
            //int BoxNum = Main.Rows.Count + 1;
            //int z = 0;
            //int j = 0;
            //for (int g = 0; g < dtPWIAmount.Rows.Count; g++)
            //{
            //    #region ��Ԥ����������
            //    if (Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]) > 0)
            //    {
            //        _PJAmount = Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]);
            //        _WAmount = Convert.ToInt32(_PJAmount * 1.5);
            //        for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
            //        {
            //            //ĳ��������β��������ֱ��ȡ������
            //            if (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) < _WAmount)
            //            {
            //                Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["SizeID"],
            //                    dsPt.Tables[0].DefaultView[r]["Amount"], BoxNum, _PJAmount);
            //                BoxNum++;
            //            }
            //            else
            //            {
            //                int x = int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) % _PJAmount;
            //                if (x <= (_WAmount - _PJAmount))
            //                {
            //                    z = 3;
            //                }
            //                if (x == 0)
            //                {
            //                    z = 1;
            //                }
            //                if (x > (_WAmount - _PJAmount))
            //                {
            //                    z = 2;
            //                }
            //                switch (z)
            //                {
            //                    case 1:
            //                        {

            //                            for (j = BoxNum; j < (BoxNum + (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount)); j++)
            //                            {

            //                                Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount,
            //                                    j, _PJAmount);
            //                            }
            //                            BoxNum = j;
            //                            break;
            //                        }
            //                    case 2:
            //                        {

            //                            for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount); j++)
            //                            {
            //                                Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"],
            //                                    dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount, j, _PJAmount);
            //                            }

            //                            Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["SizeID"], x, j, _PJAmount);
            //                            BoxNum = j + 1;
            //                            break;
            //                        }
            //                    case 3:
            //                        {

            //                            for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount) - 1; j++)
            //                            {
            //                                //  A,ID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID
            //                                Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount, j, _PJAmount);
            //                            }
            //                            Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["SizeID"], (_PJAmount + x),
            //                                j, _PJAmount);
            //                            BoxNum = j + 1;
            //                            break;
            //                        }
            //                }
            //            }
            //        }
            //    }
            //    #endregion
            //    #region ��ɫ����������Ϊһ��
            //    if (Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]) == -1)
            //    {
            //        for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
            //        {
            //            Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["SizeID"],
            //                dsPt.Tables[0].DefaultView[r]["Amount"], BoxNum, -1);
            //            BoxNum++;
            //        }
            //    }
            //    #endregion
            //}
            try
            {
                bool t = false;
                DataSet dsPw = bllPWI.GetBoxWork(ProductWorkID);
                DataTable dtSpecial = bllPWI.GetList("(MainID=" + ProductWorkID * -1 + ")").Tables[0];//������⹤����ϸ��
                DataRow[] ddrs;
                if (dtSpecial.Rows.Count == 0)
                {

                    #region û�����⹤��
                    for (int r = 0; r < Main.Rows.Count; r++)
                    {
                        modML = new Hownet.Model.MaterielList();
                        modML.ColorID = modWK.ColorID = int.Parse(Main.DefaultView[r]["ColorID"].ToString());
                        modML.SizeID = modWK.SizeID = int.Parse(Main.DefaultView[r]["SizeID"].ToString());
                        modML.ColorOneID = modWK.ColorOneID = Convert.ToInt32(Main.DefaultView[r]["ColorOneID"]);
                        modML.ColorTwoID = modWK.ColorTwoID = Convert.ToInt32(Main.DefaultView[r]["ColorTwoID"]);
                        modWK.BoxNum = int.Parse(Main.DefaultView[r]["BoxNum"].ToString());
                        modWK.Amount = int.Parse(Main.DefaultView[r]["Amount"].ToString());
                        modML.MaterielID = modPTM.MaterielID;
                        modML.BrandID = modPTM.BrandID;
                        modML.MeasureID = modMat.MeasureID;
                        modWK.MListID = bllML.GetID(modML);
                        modWK.TaskID = TaskID;
                        modWK.DepartmentID = modPTM.DeparmentID;
                        modWK.OneAmount = Convert.ToInt32(Main.DefaultView[r]["OneAmount"]);
                        int mainID = bllWT.Add(modWK);
                        ddrs = dsPw.Tables[0].Select("(OneAmount=" + modWK.OneAmount + ")");
                        for (int c = 0; c < ddrs.Length; c++)
                        {
                            modWKI.EmployeeID = 0;
                            modWKI.PWorkingInfoID = int.Parse(ddrs[c]["ID"].ToString());
                            modWKI.WorkingID = int.Parse(ddrs[c]["WorkingID"].ToString());
                            modWKI.MainID = mainID;
                            modWKI.OutAmount = modWKI.Amount = modWKI.NotAmount = modWK.Amount;
                            modWKI.TaskID = TaskID;

                            //bllWkInfo.Add(modWKI);
                            dtInfo.Rows.Add(0, modWKI.MainID,modWKI.DateTime, modWKI.IsDel, modWKI.PWorkingInfoID, modWKI.EmployeeID, modWKI.BackID, modWKI.Amount, modWKI.NotAmount, modWKI.TaskID, modWKI.WorkingID, modWKI.OutAmount);
                        }
                    }

                }
                    #endregion
                #region ���⹤��
                else
                {
                    DataRow[] drs;
                    for (int r = 0; r < Main.Rows.Count; r++)
                    {
                        modML = new Hownet.Model.MaterielList();
                        modML.ColorID = modWK.ColorID = int.Parse(Main.DefaultView[r]["ColorID"].ToString());
                        modML.SizeID = modWK.SizeID = int.Parse(Main.DefaultView[r]["SizeID"].ToString());
                        modML.ColorOneID = modWK.ColorOneID = Convert.ToInt32(Main.DefaultView[r]["ColorOneID"]);
                        modML.ColorTwoID = modWK.ColorTwoID = Convert.ToInt32(Main.DefaultView[r]["ColorTwoID"]);
                        modWK.BoxNum = int.Parse(Main.DefaultView[r]["BoxNum"].ToString());
                        modWK.Amount = int.Parse(Main.DefaultView[r]["Amount"].ToString());
                        modML.MaterielID = modPTM.MaterielID;
                        modML.BrandID = modPTM.BrandID;
                        modML.MeasureID = modMat.MeasureID;
                        modWK.MListID = bllML.GetID(modML);
                        modWK.TaskID = TaskID;
                        modWK.DepartmentID = modPTM.DeparmentID;
                        modWK.OneAmount = Convert.ToInt32(Main.DefaultView[r]["OneAmount"]);
                        int mainID = bllWT.Add(modWK);
                        for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
                        {
                            t = false;
                            modWKI.EmployeeID = 0;
                            int w = int.Parse(dsPw.Tables[0].DefaultView[c]["WorkingID"].ToString());
                            modWKI.WorkingID = w;
                            modWKI.PWorkingInfoID = int.Parse(dsPw.Tables[0].DefaultView[c]["ID"].ToString());
                            if ((bool.Parse(dsPw.Tables[0].DefaultView[c]["IsSpecial"].ToString())))//�ж�ĳ�������Ƿ������⹤��
                            {

                                //���ض��ͻ����ض����롢�ض���ɫ�����⹤��
                                drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=" + Main.Rows[r]["ColorID"] + ") And (MaterielID=" + Main.Rows[r]["SizeID"] + ")");
                                if (drs.Length == 0)
                                {
                                    //���ض����롢�ض���ɫ�����⹤��
                                    drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=0) and (ColorID=" + Main.Rows[r]["ColorID"] + ") And (MaterielID=" + Main.Rows[r]["SizeID"] + ")");
                                    if (drs.Length == 0)
                                    {
                                        //���ض����롢�ض��ͻ������⹤��
                                        drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=0) And (MaterielID=" + Main.Rows[r]["SizeID"] + ")");
                                        if (drs.Length == 0)
                                        {
                                            //���ض��ͻ����ض���ɫ�����⹤��
                                            drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=" + Main.Rows[r]["ColorID"] + ") And (MaterielID=0)");
                                            if (drs.Length == 0)
                                            {
                                                //ֻ���ض���ɫ�����⹤��
                                                drs = dtSpecial.Select("(SpecialWork=" + w + ") and (MaterielID=0) And (CompanyID=0) and (ColorID=" + Main.Rows[r]["ColorID"] + ")");
                                                if (drs.Length == 0)
                                                {
                                                    //��ֻ�ض��ͻ������⹤��
                                                    drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=0) and (MaterielID=0)");
                                                    if (drs.Length == 0)
                                                    {
                                                        //��ֻ�ض���������⹤��
                                                        drs = dtSpecial.Select("(SpecialWork=" + w + ") and (MaterielID=" + Main.Rows[r]["SizeID"] + ") and (ColorID=0) and (CompanyID=0)");
                                                        if (drs.Length == 0)
                                                        {
                                                            //������ɫ���ͻ������⹤��
                                                            drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=0) and (ColorID=0)");
                                                            if (drs.Length == 0)
                                                            {
                                                                t = true;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (drs.Length > 0)
                                {
                                    modWKI.WorkingID = int.Parse(drs[0]["WorkingID"].ToString());
                                    modWKI.PWorkingInfoID = int.Parse(drs[0]["ID"].ToString());
                                    if (modWKI.WorkingID == 0)
                                        t = true;
                                }
                            }
                            modWKI.MainID = mainID;
                            modWKI.OutAmount = modWKI.Amount = modWKI.NotAmount = modWK.Amount;
                            modWKI.TaskID = TaskID;
                            if (!t)
                                //bllWkInfo.Add(modWKI);//�����⹤�����ͨ��������Ӽ�¼���������
                                dtInfo.Rows.Add(0, modWKI.MainID,modWKI.DateTime, modWKI.IsDel, modWKI.PWorkingInfoID, modWKI.EmployeeID, modWKI.BackID, modWKI.Amount, modWKI.NotAmount, modWKI.TaskID, modWKI.WorkingID, modWKI.OutAmount);
                        }
                    }
                }

                #endregion
                DAL.BaseFile.MakeBox.AddWorkTicketInfo(dtInfo);
            }
            catch (Exception ex)
            {
            }
        }
        public DataSet GetView(int TaskID,int OneAmount)
        {
            return dal.GetView(TaskID,OneAmount);
        }
             /// <summary>
        /// ������ʾ����������
        /// </summary>
        /// <param name="TaskID">����ID</param>
        /// <returns></returns>
        public DataSet GetWorkList(int TaskID,int TaskDepID)
        {
            return dal.GetWorkList(TaskID,TaskDepID);
        }
        public DataSet GetReport(int TaskID, int TaskDepID)
        {
            return dal.GetReport(TaskID,TaskDepID);
        }
        public DataSet GetGroupReport(int GroupBy, int TaskID)
        {
            return dal.GetGroupReport(GroupBy, TaskID);
        }
        /// <summary>
        /// ���ֻ��IDֵ���б�
        /// </summary>
        public DataSet GetIDList(int TaskID,int OneAmount)
        {
            return dal.GetIDList(TaskID, OneAmount);
        }
        public DataSet GetInDepotList(int ID)
        {
            return dal.GetInDepotList(ID);
        }
        /// <summary>
        /// ��ȡ��������
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetOneAmount(int TaskID)
        {
            return dal.GetOneAmount(TaskID);
        }
        public DataSet GetBoxInfo(int ID,int GroupBy)
        {
            return dal.GetBoxInfo(ID,GroupBy);
        }
        public DataSet GetTickInfo(int TicketID)
        {
            return dal.GetTickInfo(TicketID);
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

