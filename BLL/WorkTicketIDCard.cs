using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���WorkTicketIDCard ��ժҪ˵����
	/// </summary>
	public class WorkTicketIDCard
	{
		private readonly Hownet.DAL.WorkTicketIDCard dal=new Hownet.DAL.WorkTicketIDCard();
		public WorkTicketIDCard()
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
		public int  Add(Hownet.Model.WorkTicketIDCard model)
		{
			return dal.Add(model);
		}
        /// <summary>
        /// ����һ������,����ԴΪDataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.WorkTicketIDCard> li = DataTableToList(dt);
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
		public void Update(Hownet.Model.WorkTicketIDCard model)
		{
			dal.Update(model);
		}

        /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.WorkTicketIDCard> li = DataTableToList(dt);
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
		public Hownet.Model.WorkTicketIDCard GetModel(int ID)
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
		public List<Hownet.Model.WorkTicketIDCard> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.WorkTicketIDCard> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.WorkTicketIDCard> modelList = new List<Hownet.Model.WorkTicketIDCard>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.WorkTicketIDCard model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.WorkTicketIDCard();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["TicketID"].ToString() != "")
                    {
                        model.TicketID = int.Parse(dt.Rows[n]["TicketID"].ToString());
                    }
                    model.IDCardNo =Convert.ToInt64( dt.Rows[n]["IDCardNo"]);//.ToString().Trim();
                    if (dt.Rows[n]["IsEnd"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsEnd"].ToString() == "1") || (dt.Rows[n]["IsEnd"].ToString().ToLower() == "true"))
                        {
                            model.IsEnd = true;
                        }
                        else
                        {
                            model.IsEnd = false;
                        }
                    }
                    if (dt.Rows[n]["GroupBy"].ToString() != "")
                    {
                        model.GroupBy = int.Parse(dt.Rows[n]["GroupBy"].ToString());
                    }
                    if (dt.Rows[n]["TaskID"].ToString() != "")
                    {
                        model.TaskID = int.Parse(dt.Rows[n]["TaskID"].ToString());
                    }
                    if (dt.Rows[n]["FishWork"].ToString() != "")
                    {
                        if ((dt.Rows[n]["FishWork"].ToString() == "1") || (dt.Rows[n]["FishWork"].ToString().ToLower() == "true"))
                        {
                            model.FishWork = true;
                        }
                        else
                        {
                            model.FishWork = false;
                        }
                    }
                    model.Num = dt.Rows[n]["Num"].ToString();
                    model.MaterielName = dt.Rows[n]["MaterielName"].ToString();
                    model.ColorName = dt.Rows[n]["ColorName"].ToString();
                    model.SizeName = dt.Rows[n]["SizeName"].ToString();
                    if (dt.Rows[n]["ColorID"].ToString() != "")
                    {
                        model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                    }
                    if (dt.Rows[n]["SizeID"].ToString() != "")
                    {
                        model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
                    }
                    if (dt.Rows[n]["BoxNum"].ToString() != "")
                    {
                        model.BoxNum = int.Parse(dt.Rows[n]["BoxNum"].ToString());
                    }
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    model.ColorOneName = dt.Rows[n]["ColorOneName"].ToString();
                    model.ColorTwoName = dt.Rows[n]["ColorTwoName"].ToString();
                    if (dt.Rows[n]["ColorOneID"].ToString() != "")
                    {
                        model.ColorOneID = int.Parse(dt.Rows[n]["ColorOneID"].ToString());
                    }
                    if (dt.Rows[n]["ColorTwoID"].ToString() != "")
                    {
                        model.ColorTwoID = int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
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
        public DataSet GetView(int TaskID, int OneAmount)
        {
            Hownet.BLL.WorkTicket bllWT = new WorkTicket();
            Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
            DataTable dt = bllWT.GetView(TaskID,OneAmount).Tables[0];
            DataTable dtPwi = new DataTable();
            dtPwi = bllPWI.GetGroup(TaskID,OneAmount).Tables[0];
            DataTable dtInfo = dal.GetList("(TaskID=" + TaskID + ")").Tables[0];
            if (dtPwi.Rows.Count > 0)
            {
                for (int i = 0; i < dtPwi.Rows.Count; i++)
                {
                    dt.Columns.Add(dtPwi.Rows[i]["GroupBy"].ToString(), typeof(int));
                }
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dtPwi.Rows.Count; j++)
                {
                    DataRow[] drs = dtInfo.Select("(TicketID=" + dt.Rows[i]["ID"] + ") and (GroupBy=" + dtPwi.Rows[j]["GroupBy"] + ")");
                    if (drs.Length > 0)
                        dt.Rows[i][dtPwi.Rows[j]["GroupBy"].ToString()] = drs[0]["IDCardNo"];
                }
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt.Copy());
            return ds;
        }
        /// <summary>
        /// ��Ϊ��ʹ��δ�ջأ���Ϊδʹ��
        /// </summary>
        /// <param name="CardID"></param>
        /// <returns>��Ϊ��ʹ��δ�ջأ���Ϊδʹ��</returns>
        public DataSet CheckCard(int CardID,int TaskID)
        {
            return dal.CheckCard(CardID,TaskID);
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByID(int ID)
        {
            dal.Update(ID);
        }
        public DataSet GetListByCardID(int CardID)
        {
            return dal.GetListByCardID(CardID);
        }
        public void UpdateFishWork(int ID)
        {
            dal.UpdateFishWork(ID);
        }
        public DataSet GetAllListByCardID(int CardID)
        {
            return dal.GetAllListByCardID(CardID);
        }
        public DataSet GetAllListByTicketID(int TicketID, int GroupBy)
        {
            return dal.GetAllListByTicketID(TicketID, GroupBy);
        }
        public DataSet GetdtMain()
        {
            DataTable dtMain = new DataTable();
            dtMain.TableName = "dtMain";
            dtMain.Columns.Add("ID", typeof(int));//��Ʊ������ID
            dtMain.Columns.Add("CardID", typeof(int));//��ͷ����
            dtMain.Columns.Add("No", typeof(int));//������
            dtMain.Columns.Add("Date", typeof(DateTime));//ʱ��
            dtMain.Columns.Add("TicketID", typeof(int));//��Ʊ����ID
            dtMain.Columns.Add("WorkingID", typeof(int));//�ȼ�¼�Ĺ���ID
            dtMain.Columns.Add("InfoID", typeof(int));//��Ʊ��ϸ��ID��ָ��ǰ������Ҫ��¼��ID
            dtMain.Columns.Add("MaterielID", typeof(int));//���
            dtMain.Columns.Add("OderNum", typeof(string));//���
            dtMain.Columns.Add("GroupBy", typeof(int));//���ŷ���
            dtMain.Columns.Add("MaterielName", typeof(string));//���
            dtMain.Columns.Add("SizeName", typeof(string));//����
            dtMain.Columns.Add("ColorName", typeof(string));//��ɫ
            dtMain.Columns.Add("Amount", typeof(int));//����
            dtMain.Columns.Add("EmployeeID", typeof(int));//Ա��ID
            dtMain.Columns.Add("EmployeeName", typeof(string));
            dtMain.Columns.Add("IsEnd", typeof(bool));//��ǰδ��ɹ����Ƿ�Ϊ�������һ��
            dtMain.Columns.Add("WorkingName", typeof(string));//�ȼ�¼�Ĺ���������WorkingID���������Ա��ˢ����¼֮�󣬸���Ϊ��һ���ȼ�¼�Ĺ���
            dtMain.Columns.Add("WorkTypeID", typeof(int));//�������������
            dtMain.Columns.Add("TaskNum", typeof(string));
            dtMain.Columns.Add("MacAddress", typeof(string));
            dtMain.Columns.Add("WorkingList", typeof(int));
            dtMain.Columns.Add("EmpSN", typeof(string));
            DataSet ds = new DataSet();
            ds.DataSetName = "ds";
            ds.Tables.Add(dtMain);
            return ds;
        }
        public DataSet GetEmpWork(int EmployeeID)
        {
            return dal.GetEmpWork(EmployeeID);
        }
        public DataSet GetPaddtMain()
        {
            DataTable dtMain = new DataTable();
            dtMain.TableName = "dtMain";
            dtMain.Columns.Add("ID", typeof(int));//��Ʊ������ID
            dtMain.Columns.Add("CardID", typeof(int));//��ͷ����
            dtMain.Columns.Add("No", typeof(int));//������
            dtMain.Columns.Add("Date", typeof(DateTime));//ʱ��
            dtMain.Columns.Add("TicketID", typeof(int));//��Ʊ����ID
            dtMain.Columns.Add("WorkingID", typeof(int));//�ȼ�¼�Ĺ���ID
            dtMain.Columns.Add("InfoID", typeof(int));//��Ʊ��ϸ��ID��ָ��ǰ������Ҫ��¼��ID
            dtMain.Columns.Add("MaterielID", typeof(int));//���
            dtMain.Columns.Add("OderNum", typeof(string));//���
            dtMain.Columns.Add("GroupBy", typeof(int));//���ŷ���
            dtMain.Columns.Add("MaterielName", typeof(string));//���
            dtMain.Columns.Add("SizeName", typeof(string));//����
            dtMain.Columns.Add("ColorName", typeof(string));//��ɫ
            dtMain.Columns.Add("Amount", typeof(int));//����
            dtMain.Columns.Add("EmployeeID", typeof(int));//Ա��ID
            dtMain.Columns.Add("EmployeeName", typeof(string));
            dtMain.Columns.Add("IsEnd", typeof(bool));//��ǰδ��ɹ����Ƿ�Ϊ�������һ��
            dtMain.Columns.Add("WorkingName", typeof(string));//�ȼ�¼�Ĺ���������WorkingID���������Ա��ˢ����¼֮�󣬸���Ϊ��һ���ȼ�¼�Ĺ���
            dtMain.Columns.Add("WorkTypeID", typeof(int));//�������������
            dtMain.Columns.Add("TaskNum", typeof(string));
            dtMain.Columns.Add("MacAddress", typeof(string));
            DataSet ds = new DataSet();
            ds.DataSetName = "ds";
            ds.Tables.Add(dtMain);
            return ds;
        }
        public int UpIDCardNo(int TicketID, int GroupBy, int IDCardNo, int TaskID)
        {
            return dal.UpIDCardNo(TicketID, GroupBy, IDCardNo, TaskID);
        }
        public DataSet PrintLable(int TaskID, int TicketID, int GroupBy, int ColorID, int SizeID,int OneAmount)
        {
            return dal.PrintLable(TaskID, TicketID, GroupBy, ColorID, SizeID,OneAmount);
        }
        public void DelMore()
        {
            dal.DelMore();
        }
        public DataSet GetWorkOverList(int CardID)
        {
            return dal.GetWorkOverList(CardID);
        }
        public DataSet GetWorkOverListByTicketID(int TicketID)
        {
            return dal.GetWorkOverListByTicketID(TicketID);
        }
        public int GetID(int CardID)
        {
            return dal.GetID(CardID);
        }
         /// <summary>
        /// ����ƽ����ʾ�Ĺ���������
        /// </summary>
        /// <param name="CardID"></param>
        /// <returns></returns>
        public DataSet GetListForPad(int CardID)
        {
            return dal.GetListForPad(CardID);
        }
        public int GetCountRows()
        {
            return dal.GetCountRows();
        }
        public DataSet PrintQR(int TaskID)
        {
            return dal.PrintQR(TaskID);
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

