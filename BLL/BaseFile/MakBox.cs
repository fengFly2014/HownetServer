using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Hownet.BLL.BaseFile
{
    public class MakBox
    {
        //public DataTable MakBoxOne(int TaskID, int PjAmount, int WAmount, int TableTypeID)
        //{

        //    int BoxNum = 1;
        //    int z = 0;
        //    int j = 0;
        //    Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
        //    Hownet.BLL.AmountInfo bllPTI = new AmountInfo();
        //    Hownet.Model.ProductTaskMain modPTM = bllPTM.GetModel(TaskID);
        //    DataSet dsPt = bllPTI.GetBox(TaskID, TableTypeID);
        //    // DataSet dsColor = bllPT.GetColor("(ProduceTaskID='" + TaskID + "')");
        //    //  DataSet dsSize = bllPT.GetSize("(ProduceTaskID='" + TaskID + "')");
        //    DataTable dtBox = new DataTable();
        //    dtBox.Columns.Add("ColorID", typeof(int));
        //    dtBox.Columns.Add("SizeID", typeof(int));
        //    dtBox.Columns.Add("ColorOneID", typeof(int));
        //    dtBox.Columns.Add("ColorTwoID", typeof(int));
        //    dtBox.Columns.Add("Amount", typeof(int));
        //    dtBox.Columns.Add("BoxNum", typeof(int));
        //    dtBox.Columns.Add("ColorName", typeof(string));
        //    dtBox.Columns.Add("SizeName", typeof(string));
        //    dtBox.Columns.Add("MListID", typeof(int));

        //    if (modPTM.PWorkingID != 0)
        //    {
        //        for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
        //        {
        //            //ĳ��������β��������ֱ��ȡ������
        //            if (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) < WAmount)
        //            {
        //                dtBox.Rows.Add(int.Parse(dsPt.Tables[0].DefaultView[r]["ColorID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["SizeID"].ToString()),
        //                    int.Parse(dsPt.Tables[0].DefaultView[r]["ColorOneID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["ColorTwoID"].ToString()),
        //                    int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()), BoxNum, dsPt.Tables[0].DefaultView[r]["ColorName"].ToString(),
        //                    dsPt.Tables[0].DefaultView[r]["SizeName"].ToString(), dsPt.Tables[0].DefaultView[r]["MListID"]);
        //                BoxNum++;
        //            }
        //            else
        //            {
        //                int x = int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) % PjAmount;
        //                if (x <= (WAmount - PjAmount))
        //                {
        //                    z = 3;
        //                }
        //                if (x == 0)
        //                {
        //                    z = 1;
        //                }
        //                if (x > (WAmount - PjAmount))
        //                {
        //                    z = 2;
        //                }
        //                switch (z)
        //                {
        //                    case 1:
        //                        {

        //                            for (j = BoxNum; j < (BoxNum + (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / PjAmount)); j++)
        //                            {
        //                                dtBox.Rows.Add(int.Parse(dsPt.Tables[0].DefaultView[r]["ColorID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["SizeID"].ToString()),
        //                                     int.Parse(dsPt.Tables[0].DefaultView[r]["ColorOneID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["ColorTwoID"].ToString()), PjAmount,
        //                                    j, dsPt.Tables[0].DefaultView[r]["ColorName"].ToString(), dsPt.Tables[0].DefaultView[r]["SizeName"].ToString(), dsPt.Tables[0].DefaultView[r]["MListID"]);
        //                            }
        //                            BoxNum = j;
        //                            break;
        //                        }
        //                    case 2:
        //                        {

        //                            for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / PjAmount); j++)
        //                            {
        //                                dtBox.Rows.Add(int.Parse(dsPt.Tables[0].DefaultView[r]["ColorID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["SizeID"].ToString()),
        //                                     int.Parse(dsPt.Tables[0].DefaultView[r]["ColorOneID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["ColorTwoID"].ToString()), PjAmount,
        //                                    j, dsPt.Tables[0].DefaultView[r]["ColorName"].ToString(), dsPt.Tables[0].DefaultView[r]["SizeName"].ToString(), dsPt.Tables[0].DefaultView[r]["MListID"]);
        //                            }

        //                            dtBox.Rows.Add(int.Parse(dsPt.Tables[0].DefaultView[r]["ColorID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["SizeID"].ToString()),
        //                                 int.Parse(dsPt.Tables[0].DefaultView[r]["ColorOneID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["ColorTwoID"].ToString()), x,
        //                                j, dsPt.Tables[0].DefaultView[r]["ColorName"].ToString(), dsPt.Tables[0].DefaultView[r]["SizeName"].ToString(), dsPt.Tables[0].DefaultView[r]["MListID"]);
        //                            BoxNum = j + 1;
        //                            break;
        //                        }
        //                    case 3:
        //                        {

        //                            for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / PjAmount) - 1; j++)
        //                            {
        //                                dtBox.Rows.Add(int.Parse(dsPt.Tables[0].DefaultView[r]["ColorID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["SizeID"].ToString()),
        //                                     int.Parse(dsPt.Tables[0].DefaultView[r]["ColorOneID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["ColorTwoID"].ToString()), PjAmount,
        //                                    j, dsPt.Tables[0].DefaultView[r]["ColorName"].ToString(), dsPt.Tables[0].DefaultView[r]["SizeName"].ToString(), dsPt.Tables[0].DefaultView[r]["MListID"]);
        //                            }
        //                            dtBox.Rows.Add(int.Parse(dsPt.Tables[0].DefaultView[r]["ColorID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["SizeID"].ToString()),
        //                                 int.Parse(dsPt.Tables[0].DefaultView[r]["ColorOneID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["ColorTwoID"].ToString()), (PjAmount + x),
        //                                j, dsPt.Tables[0].DefaultView[r]["ColorName"].ToString(), dsPt.Tables[0].DefaultView[r]["SizeName"].ToString(), dsPt.Tables[0].DefaultView[r]["MListID"]);
        //                            BoxNum = j + 1;
        //                            break;
        //                        }
        //                }
        //            }
        //        }
        //    }
        //    return dtBox;
        //}
        //public void MakBoxThree(int ProductWorkID, int TaskID, int PjAmount, int WAmount, int MaterielID, int BrandID, int TableTypeID)
        //{
        //    DataTable Main = MakBoxOne(TaskID, PjAmount, WAmount, TableTypeID);
        //    Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
        //    Hownet.BLL.WorkTicket bllWT = new WorkTicket();
        //    Hownet.BLL.WorkTicketInfo bllWkInfo = new WorkTicketInfo();
        //    Hownet.Model.WorkTicket modWK = new Hownet.Model.WorkTicket();
        //    Hownet.Model.WorkTicketInfo modWKI = new Hownet.Model.WorkTicketInfo();
        //    bool t = false;
        //    DataSet dsPw = bllPWI.GetBoxWork(ProductWorkID);
        //    DataTable dtSpecial = bllPWI.GetList("(PWMID=" + ProductWorkID + ")").Tables[0];//������⹤����ϸ��
        //    if (dtSpecial.Rows.Count == 0)
        //    {
        //        #region û�����⹤��
        //        for (int r = 0; r < Main.Rows.Count; r++)
        //        {
        //            modWK.ColorID = int.Parse(Main.DefaultView[r]["ColorID"].ToString());
        //            modWK.SizeID = int.Parse(Main.DefaultView[r]["SizeID"].ToString());
        //            modWK.ColorOneID = int.Parse(Main.DefaultView[r]["ColorOneID"].ToString());
        //            modWK.ColorTwoID = int.Parse(Main.DefaultView[r]["ColorTwoID"].ToString());
        //            modWK.BoxNum = int.Parse(Main.DefaultView[r]["BoxNum"].ToString());
        //            modWK.Amount = int.Parse(Main.DefaultView[r]["Amount"].ToString());
        //            modWK.MListID = int.Parse(Main.DefaultView[r]["MListID"].ToString());
        //            modWK.TaskID = TaskID;
        //            int mainID = bllWT.Add(modWK);
        //            for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
        //            {
        //                modWKI.EmployeeID = 0;
        //                modWKI.PWorkingInfoID = int.Parse(dsPw.Tables[0].DefaultView[c]["ID"].ToString());
        //                modWKI.WorkingID = int.Parse(dsPw.Tables[0].DefaultView[c]["WorkingID"].ToString());
        //                modWKI.MainID = mainID;
        //                modWKI.Amount = modWKI.NotAmount = modWK.Amount;
        //                modWKI.TaskID = TaskID;
        //                bllWkInfo.Add(modWKI);
        //            }
        //        }
        //    }
        //        #endregion
        //    #region ���⹤��
        //    else
        //    {
        //        for (int r = 0; r < Main.Rows.Count; r++)
        //        {
        //            modWK.ColorID = int.Parse(Main.DefaultView[r]["ColorID"].ToString());
        //            modWK.SizeID = int.Parse(Main.DefaultView[r]["SizeID"].ToString());
        //            modWK.ColorOneID = 0;
        //            modWK.ColorTwoID = 0;
        //            modWK.BoxNum = int.Parse(Main.DefaultView[r]["BoxNum"].ToString());
        //            modWK.Amount = int.Parse(Main.DefaultView[r]["Amount"].ToString());
        //            modWK.MListID = int.Parse(Main.DefaultView[r]["MListID"].ToString());
        //            modWK.TaskID = TaskID;
        //            int mainID = bllWT.Add(modWK);
        //            for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
        //            {
        //                t = false;
        //                modWKI.EmployeeID = 0;
        //                int w = int.Parse(dsPw.Tables[0].DefaultView[c]["WorkingID"].ToString());
        //                modWKI.WorkingID = w;
        //                modWKI.PWorkingInfoID = int.Parse(dsPw.Tables[0].DefaultView[c]["ID"].ToString());
        //                if ((bool.Parse(dsPw.Tables[0].DefaultView[c]["IsSpecial"].ToString())))//�ж�ĳ�������Ƿ������⹤��
        //                {
        //                    DataRow[] drs = dtSpecial.Select("(SpecialWork=" + w + ") and (ColorID=" + modWK.ColorID + ")");
        //                    if (drs.Length > 0)//�����⹤���б��У��Ƿ��е�ǰ��ɫ��¼
        //                    {
        //                        modWKI.WorkingID = int.Parse(drs[0]["WorkingID"].ToString());
        //                        modWKI.PWorkingInfoID = int.Parse(drs[0]["ID"].ToString());
        //                    }
        //                    else
        //                    {
        //                        drs = dtSpecial.Select("(SpecialWork=" + w + ") and (ColorID=0)");//�Ƿ���ͨ����ɫ����
        //                        if (drs.Length > 0)
        //                        {
        //                            modWKI.WorkingID = int.Parse(drs[0]["WorkingID"].ToString());
        //                            modWKI.PWorkingInfoID = int.Parse(drs[0]["ID"].ToString());
        //                        }
        //                        else
        //                        {
        //                            t = true;
        //                        }
        //                    }
        //                }
        //                modWKI.MainID = mainID;
        //                modWKI.Amount = modWKI.NotAmount = modWK.Amount;
        //                modWKI.TaskID = TaskID;
        //                if (!t)
        //                    bllWkInfo.Add(modWKI);//�����⹤�����ͨ��������Ӽ�¼���������
        //            }
        //        }
        //    }
        //    #endregion
        //}
        //public void MakBoxOneID(int TaskID, int PjAmount, int WAmount, int TableTypeID, int BrandID)
        //{

        //    int BoxNum = 1;
        //    int z = 0;
        //    int j = 0;
        //    Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
        //    Hownet.BLL.WorkTicket bllWT = new WorkTicket();
        //    Hownet.BLL.AmountInfo bllPTI = new AmountInfo();
        //    Hownet.Model.ProductTaskMain modPTM = bllPTM.GetModel(TaskID);
        //    DataSet dsPt = bllPTI.GetBoxID(TaskID, TableTypeID, 0);
        //    // DataSet dsColor = bllPT.GetColor("(ProduceTaskID='" + TaskID + "')");
        //    //  DataSet dsSize = bllPT.GetSize("(ProduceTaskID='" + TaskID + "')");
        //    DataTable dtBox = bllWT.GetListNoA("(ID=0)").Tables[0];
        //    //dtBox.Columns.Add("ColorID", typeof(int));
        //    //dtBox.Columns.Add("SizeID", typeof(int));
        //    //dtBox.Columns.Add("ColorOneID", typeof(int));
        //    //dtBox.Columns.Add("ColorTwoID", typeof(int));
        //    //dtBox.Columns.Add("Amount", typeof(int));
        //    //dtBox.Columns.Add("BoxNum", typeof(int));
        //    //dtBox.Columns.Add("MListID", typeof(int));
        //    if (modPTM.PWorkingID != 0)
        //    {
        //        for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
        //        {
        //            //ĳ��������β��������ֱ��ȡ������
        //            if (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) < WAmount)
        //            {
        //                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
        //                    dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"],
        //                    dsPt.Tables[0].DefaultView[r]["Amount"], BoxNum, TaskID, 0, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID);
        //                BoxNum++;
        //            }
        //            else
        //            {
        //                int x = int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) % PjAmount;
        //                if (x <= (WAmount - PjAmount))
        //                {
        //                    z = 3;
        //                }
        //                if (x == 0)
        //                {
        //                    z = 1;
        //                }
        //                if (x > (WAmount - PjAmount))
        //                {
        //                    z = 2;
        //                }
        //                switch (z)
        //                {
        //                    case 1:
        //                        {

        //                            for (j = BoxNum; j < (BoxNum + (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / PjAmount)); j++)
        //                            {

        //                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
        //                                   dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], PjAmount,
        //                                    j, TaskID, 0, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID);
        //                            }
        //                            BoxNum = j;
        //                            break;
        //                        }
        //                    case 2:
        //                        {

        //                            for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / PjAmount); j++)
        //                            {
        //                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"], dsPt.Tables[0].DefaultView[r]["ColorTwoID"],
        //                                    dsPt.Tables[0].DefaultView[r]["SizeID"], PjAmount, j, TaskID, 0, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID);
        //                            }

        //                            dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
        //                                dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], x, j, TaskID, 0, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID);
        //                            BoxNum = j + 1;
        //                            break;
        //                        }
        //                    case 3:
        //                        {

        //                            for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / PjAmount) - 1; j++)
        //                            {
        //                                //  A,ID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID
        //                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
        //                                   dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], PjAmount, j, TaskID, 0, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID);
        //                            }
        //                            dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
        //                                dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], (PjAmount + x),
        //                                j, TaskID, 0, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID);
        //                            BoxNum = j + 1;
        //                            break;
        //                        }
        //                }
        //            }
        //        }
        //    }
        //    DAL.BaseFile.MakeBox.AddWorkTicket(dtBox);
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ProductWorkID">���������й��յ�ID</param>
        /// <param name="TaskID">��������ID</param>
        /// <param name="PjAmount">ƽ��������</param>
        /// <param name="WAmount">β������</param>
        /// <param name="MaterielID">���</param>
        /// <param name="BrandID">�̱�</param>
        /// <param name="TableTypeID">��������</param>
        public void MakBoxThreeID(int ProductWorkID, int TaskID, int PjAmount, int WAmount, int MaterielID, int BrandID, int TableTypeID)
        {
            try
            {
                //MakBoxOneID(TaskID, PjAmount, WAmount, TableTypeID,BrandID);
                #region WorkTicket��
                int BoxNum = 1;
                int z = 0;
                int j = 0;
                int _PJAmount = 0;
                int _WAmount = 0;
                //  int CompanyID = 0;
                Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
                Hownet.BLL.WorkTicket bllWT = new WorkTicket();
                Hownet.BLL.AmountInfo bllPTI = new AmountInfo();
                Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
                Hownet.Model.ProductTaskMain modPTM = bllPTM.GetModel(TaskID);
                DataSet dsPt = bllPTI.GetBoxID(TaskID, TableTypeID);
                DataTable dtBox = bllWT.GetListNoA("(ID=0)").Tables[0];
                DataTable dtPWIAmount = bllPWI.GetOneAmount(modPTM.PWorkingID).Tables[0];
                if (modPTM.PWorkingID != 0)
                {
                    for (int g = 0; g < dtPWIAmount.Rows.Count; g++)
                    {
                        #region ��������
                        if (Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]) == 0)
                        {
                            _PJAmount = PjAmount;
                            _WAmount = WAmount;
                            for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
                            {
                                //ĳ��������β��������ֱ��ȡ������
                                if (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) < _WAmount)
                                {
                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                        dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"],
                                        dsPt.Tables[0].DefaultView[r]["Amount"], BoxNum, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, 0);
                                    BoxNum++;
                                }
                                else
                                {
                                    int x = int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) % _PJAmount;
                                    if (x <= (_WAmount - _PJAmount))
                                    {
                                        z = 3;
                                    }
                                    if (x == 0)
                                    {
                                        z = 1;
                                    }
                                    if (x > (_WAmount - _PJAmount))
                                    {
                                        z = 2;
                                    }
                                    switch (z)
                                    {
                                        case 1:
                                            {

                                                for (j = BoxNum; j < (BoxNum + (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount)); j++)
                                                {

                                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                       dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount,
                                                        j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, 0);
                                                }
                                                BoxNum = j;
                                                break;
                                            }
                                        case 2:
                                            {

                                                for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount); j++)
                                                {
                                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"], dsPt.Tables[0].DefaultView[r]["ColorTwoID"],
                                                        dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount, j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, 0);
                                                }

                                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                    dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], x, j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, 0);
                                                BoxNum = j + 1;
                                                break;
                                            }
                                        case 3:
                                            {

                                                for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount) - 1; j++)
                                                {
                                                    //  A,ID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID
                                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                       dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount, j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, 0);
                                                }
                                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                    dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], (_PJAmount + x),
                                                    j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, 0);
                                                BoxNum = j + 1;
                                                break;
                                            }
                                    }
                                }
                            }
                        }
                        #endregion
                        #region ��Ԥ����������
                        if (Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]) > 0)
                        {
                            _PJAmount = Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]);
                            _WAmount = Convert.ToInt32(_PJAmount * 1.5);
                            for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
                            {
                                //ĳ��������β��������ֱ��ȡ������
                                if (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) < _WAmount)
                                {
                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                        dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"],
                                        dsPt.Tables[0].DefaultView[r]["Amount"], BoxNum, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, _PJAmount);
                                    BoxNum++;
                                }
                                else
                                {
                                    int x = int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) % _PJAmount;
                                    if (x <= (_WAmount - _PJAmount))
                                    {
                                        z = 3;
                                    }
                                    if (x == 0)
                                    {
                                        z = 1;
                                    }
                                    if (x > (_WAmount - _PJAmount))
                                    {
                                        z = 2;
                                    }
                                    switch (z)
                                    {
                                        case 1:
                                            {

                                                for (j = BoxNum; j < (BoxNum + (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount)); j++)
                                                {

                                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                       dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount,
                                                        j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, _PJAmount);
                                                }
                                                BoxNum = j;
                                                break;
                                            }
                                        case 2:
                                            {

                                                for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount); j++)
                                                {
                                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"], dsPt.Tables[0].DefaultView[r]["ColorTwoID"],
                                                        dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount, j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, _PJAmount);
                                                }

                                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                    dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], x, j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, _PJAmount);
                                                BoxNum = j + 1;
                                                break;
                                            }
                                        case 3:
                                            {

                                                for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount) - 1; j++)
                                                {
                                                    //  A,ID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID
                                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                       dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount, j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, _PJAmount);
                                                }
                                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                    dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], (_PJAmount + x),
                                                    j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, _PJAmount);
                                                BoxNum = j + 1;
                                                break;
                                            }
                                    }
                                }
                            }
                        }
                        #endregion
                        #region ��ɫ����������Ϊһ��
                        if (Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]) == -1)
                        {
                            for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
                            {
                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                    dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"],
                                    dsPt.Tables[0].DefaultView[r]["Amount"], BoxNum, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, -1);
                                BoxNum++;
                            }
                        }
                        #endregion
                    }
                }
                DAL.BaseFile.MakeBox.AddWorkTicket(dtBox);
                #endregion

                Hownet.BLL.WorkTicketInfo bllWkInfo = new WorkTicketInfo();
                Hownet.Model.WorkTicketInfo modWKI = new Hownet.Model.WorkTicketInfo();
                bool t = false;
                DataTable Main = new DataTable();
                DataTable dtInfo = bllWkInfo.GetListNoA("(ID=0)").Tables[0];
                DataSet dsPw = new DataSet();
                DataTable dtSpecial = new DataTable();
                for (int g = 0; g < dtPWIAmount.Rows.Count; g++)
                {
                    Main = bllWT.GetIDList(TaskID, Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"])).Tables[0];
                    dsPw = bllPWI.GetBoxWorkID(ProductWorkID, Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]));
                    dtSpecial = bllPWI.GetSpecialWork(ProductWorkID, Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"])).Tables[0];//������⹤����ϸ��
                    DateTime dtNull = DateTime.Parse("1900-1-1");
                    if (dtSpecial.Rows.Count == 0)
                    {
                        #region û�����⹤��
                        for (int r = 0; r < Main.Rows.Count; r++)
                        {
                            for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
                            {
                                dtInfo.Rows.Add(0, Main.Rows[r]["ID"], DBNull.Value, 0, dsPw.Tables[0].DefaultView[c]["ID"], 0, 0, Main.Rows[r]["Amount"], Main.Rows[r]["Amount"], TaskID, dsPw.Tables[0].DefaultView[c]["WorkingID"], Main.Rows[r]["Amount"]);
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
                            for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
                            {
                                t = false;
                                modWKI.EmployeeID = 0;
                                int w = int.Parse(dsPw.Tables[0].DefaultView[c]["WorkingID"].ToString());
                                modWKI.WorkingID = w;
                                modWKI.PWorkingInfoID = int.Parse(dsPw.Tables[0].DefaultView[c]["ID"].ToString());
                                if ((bool.Parse(dsPw.Tables[0].DefaultView[c]["IsSpecial"].ToString())))//�ж�ĳ�������Ƿ������⹤��
                                {
                                    //if (modPTM.CompanyID > 0)
                                    //{
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
                                if (!t)
                                    dtInfo.Rows.Add(0, Main.Rows[r]["ID"], DBNull.Value, 0, modWKI.PWorkingInfoID, 0, 0, Main.Rows[r]["Amount"], Main.Rows[r]["Amount"], TaskID, modWKI.WorkingID, Main.Rows[r]["Amount"]);
                            }
                        }
                    #endregion
                    }
                }
                DAL.BaseFile.MakeBox.AddWorkTicketInfo(dtInfo);
            }
            catch (Exception ex)
            {
            }
        }
        public void MakClothing(int TaskID)
        {
            Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
            Hownet.Model.ProductTaskMain modPTM = bllPTM.GetModel(TaskID);
            Hownet.BLL.WorkTicket bllWT = new WorkTicket();
            Hownet.BLL.WorkTicketInfo bllWkInfo = new WorkTicketInfo();
            Hownet.Model.WorkTicketInfo modWKI = new Hownet.Model.WorkTicketInfo();
            Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
            bool t = false;
            DataTable Main = new DataTable();
            DataTable dtInfo = bllWkInfo.GetListNoA("(ID=0)").Tables[0];
            DataSet dsPw = new DataSet();
            DataTable dtSpecial = new DataTable();

            Main = bllWT.GetIDList(TaskID, 0).Tables[0];
            dsPw = bllPWI.GetBoxWorkID(modPTM.PWorkingID, 0);
            dtSpecial = bllPWI.GetSpecialWork(modPTM.PWorkingID, 0).Tables[0];//������⹤����ϸ��
            DateTime dtNull = DateTime.Parse("1900-1-1");
            try
            {
                if (dtSpecial.Rows.Count == 0)
                {
                    #region û�����⹤��
                    for (int r = 0; r < Main.Rows.Count; r++)
                    {
                        for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
                        {
                            dtInfo.Rows.Add(0, Main.Rows[r]["ID"], DBNull.Value, 0, dsPw.Tables[0].DefaultView[c]["ID"], 0, 0, Main.Rows[r]["Amount"], Main.Rows[r]["Amount"], TaskID, dsPw.Tables[0].DefaultView[c]["WorkingID"], Main.Rows[r]["Amount"]);
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
                        for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
                        {
                            t = false;
                            modWKI.EmployeeID = 0;
                            int w = int.Parse(dsPw.Tables[0].DefaultView[c]["WorkingID"].ToString());
                            modWKI.WorkingID = w;
                            modWKI.PWorkingInfoID = int.Parse(dsPw.Tables[0].DefaultView[c]["ID"].ToString());
                            if ((bool.Parse(dsPw.Tables[0].DefaultView[c]["IsSpecial"].ToString())))//�ж�ĳ�������Ƿ������⹤��
                            {
                                //if (modPTM.CompanyID > 0)
                                //{
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
                            if (!t)
                                dtInfo.Rows.Add(0, Main.Rows[r]["ID"], DBNull.Value, 0, modWKI.PWorkingInfoID, 0, 0, Main.Rows[r]["Amount"], Main.Rows[r]["Amount"], TaskID, modWKI.WorkingID, Main.Rows[r]["Amount"]);
                        }
                    }
                #endregion
                }

                DAL.BaseFile.MakeBox.AddWorkTicketInfo(dtInfo);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
