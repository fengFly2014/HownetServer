using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// ҵ���߼���OrderingList ��ժҪ˵����
    /// </summary>
    public class OrderingList
    {
        private readonly Hownet.DAL.OrderingList dal = new Hownet.DAL.OrderingList();
        public OrderingList()
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
        public int Add(Hownet.Model.OrderingList model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������,����ԴΪDataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.OrderingList> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.OrderingList model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.OrderingList> li = DataTableToList(dt);
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
        public Hownet.Model.OrderingList GetModel(int ID)
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
        public List<Hownet.Model.OrderingList> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.OrderingList> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.OrderingList> modelList = new List<Hownet.Model.OrderingList>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.OrderingList model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.OrderingList();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    if (dt.Rows[n]["EmployeeID"].ToString() != "")
                    {
                        model.EmployeeID = int.Parse(dt.Rows[n]["EmployeeID"].ToString());
                    }
                    else
                    {
                        model.EmployeeID = 0;
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    else
                    {
                        model.DateTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["OrderOne"].ToString() != "")
                    {
                        model.OrderOne = int.Parse(dt.Rows[n]["OrderOne"].ToString());
                    }
                    else
                    {
                        model.OrderOne = 0;
                    }
                    if (dt.Rows[n]["DinOne"].ToString() != "")
                    {
                        model.DinOne = int.Parse(dt.Rows[n]["DinOne"].ToString());
                    }
                    else
                    {
                        model.DinOne = 0;
                    }
                    if (dt.Rows[n]["OrderOneTime"].ToString() != "")
                    {
                        model.OrderOneTime = DateTime.Parse(dt.Rows[n]["OrderOneTime"].ToString());
                    }
                    else
                    {
                        model.OrderOneTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["DiningOneTime"].ToString() != "")
                    {
                        model.DiningOneTime = DateTime.Parse(dt.Rows[n]["DiningOneTime"].ToString());
                    }
                    else
                    {
                        model.DiningOneTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["OrderTwo"].ToString() != "")
                    {
                        model.OrderTwo = int.Parse(dt.Rows[n]["OrderTwo"].ToString());
                    }
                    else
                    {
                        model.OrderTwo = 0;
                    }
                    if (dt.Rows[n]["DinTwo"].ToString() != "")
                    {
                        model.DinTwo = int.Parse(dt.Rows[n]["DinTwo"].ToString());
                    }
                    else
                    {
                        model.DinTwo = 0;
                    }
                    if (dt.Rows[n]["OrdeTwoTime"].ToString() != "")
                    {
                        model.OrdeTwoTime = DateTime.Parse(dt.Rows[n]["OrdeTwoTime"].ToString());
                    }
                    else
                    {
                        model.OrdeTwoTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["DiningTwoTime"].ToString() != "")
                    {
                        model.DiningTwoTime = DateTime.Parse(dt.Rows[n]["DiningTwoTime"].ToString());
                    }
                    else
                    {
                        model.DiningTwoTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["OrderThree"].ToString() != "")
                    {
                        model.OrderThree = int.Parse(dt.Rows[n]["OrderThree"].ToString());
                    }
                    else
                    {
                        model.OrderThree = 0;
                    }
                    if (dt.Rows[n]["DinThree"].ToString() != "")
                    {
                        model.DinThree = int.Parse(dt.Rows[n]["DinThree"].ToString());
                    }
                    else
                    {
                        model.DinThree = 0;
                    }
                    if (dt.Rows[n]["OrdeThreeTime"].ToString() != "")
                    {
                        model.OrdeThreeTime = DateTime.Parse(dt.Rows[n]["OrdeThreeTime"].ToString());
                    }
                    else
                    {
                        model.OrdeThreeTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["DiningThreeTime"].ToString() != "")
                    {
                        model.DiningThreeTime = DateTime.Parse(dt.Rows[n]["DiningThreeTime"].ToString());
                    }
                    else
                    {
                        model.DiningThreeTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["OrderCount"].ToString() != "")
                    {
                        model.OrderCount = int.Parse(dt.Rows[n]["OrderCount"].ToString());
                    }
                    else
                    {
                        model.OrderCount = 0;
                    }
                    if (dt.Rows[n]["DinCount"].ToString() != "")
                    {
                        model.DinCount = int.Parse(dt.Rows[n]["DinCount"].ToString());
                    }
                    else
                    {
                        model.DinCount = 0;
                    }
                    if (dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    else
                    {
                        model.Money = 0;
                    }
                    if (dt.Rows[n]["IsSum"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsSum"].ToString() == "1") || (dt.Rows[n]["IsSum"].ToString().ToLower() == "true"))
                        {
                            model.IsSum = true;
                        }
                        else
                        {
                            model.IsSum = false;
                        }
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
        public DataSet GetOderList(DateTime dt1, DateTime dt2, int DepID, int EmpID)
        {
            DataSet ds = dal.GetOderList(dt1, dt2, DepID, EmpID);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToDateTime(ds.Tables[0].Rows[i]["OrderOneTime"]) == DateTime.Parse("1900-1-1"))
                {
                    ds.Tables[0].Rows[i]["OrderOneTime"] = DBNull.Value;
                }
                if (Convert.ToDateTime(ds.Tables[0].Rows[i]["DiningOneTime"]) == DateTime.Parse("1900-1-1"))
                {
                    ds.Tables[0].Rows[i]["DiningOneTime"] = DBNull.Value;
                }
                if (Convert.ToDateTime(ds.Tables[0].Rows[i]["OrdeTwoTime"]) == DateTime.Parse("1900-1-1"))
                {
                    ds.Tables[0].Rows[i]["OrdeTwoTime"] = DBNull.Value;
                }
                if (Convert.ToDateTime(ds.Tables[0].Rows[i]["DiningTwoTime"]) == DateTime.Parse("1900-1-1"))
                {
                    ds.Tables[0].Rows[i]["DiningTwoTime"] = DBNull.Value;
                }
                if (Convert.ToDateTime(ds.Tables[0].Rows[i]["OrdeThreeTime"]) == DateTime.Parse("1900-1-1"))
                {
                    ds.Tables[0].Rows[i]["OrdeThreeTime"] = DBNull.Value;
                }
                if (Convert.ToDateTime(ds.Tables[0].Rows[i]["DiningThreeTime"]) == DateTime.Parse("1900-1-1"))
                {
                    ds.Tables[0].Rows[i]["DiningThreeTime"] = DBNull.Value;
                }
            }
            return ds;
        }
        /// <summary>
        /// ��ȡĳ��ʱ��Ķ����Ͳ�����
        /// </summary>
        /// <param name="dt1">��ʼ����</param>
        /// <param name="dt2">��������</param>
        /// <param name="EmpID">Ա��ID</param>
        /// <returns></returns>
        public DataSet GetOrderCount(DateTime dt1, DateTime dt2, int EmpID)
        {
            return dal.GetOrderCount(dt1, dt2, EmpID);
        }
        public void CaicMoney(DateTime date)
        {
            DataTable dt = dal.GetIDList(date).Tables[0];
            if (dt.Rows.Count > 0)
            {
                Hownet.BLL.OtherType bllOT = new OtherType();
                List<Hownet.Model.OtherType> list = bllOT.DataTableToList(bllOT.GetTypeList("��ʳ�۷�").Tables[0]);
                decimal ZhaoCan, WuCan, WanCan, NotEat, NotOrder;
                bool IsCaic = false;
                bool IsCaicDay = false;
                bool IsDay = false;
                ZhaoCan = WuCan = WanCan = NotEat = NotOrder = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Name == "���")
                        ZhaoCan = Convert.ToDecimal(list[i].Value);
                    else if (list[i].Name == "���")
                        WuCan = Convert.ToDecimal(list[i].Value);
                    else if (list[i].Name == "���")
                        WanCan = Convert.ToDecimal(list[i].Value);
                    else if (list[i].Name == "���ͺ�δ��")
                        NotEat = Convert.ToDecimal(list[i].Value);
                    else if (list[i].Name == "δ���ͳԷ�")
                        NotOrder = Convert.ToDecimal(list[i].Value);
                    else if(list[i].Name == "����Ҫ�۷�")
                        IsCaic = (list[i].Value == "1");
                    else if (list[i].Name == "��ʱ���������ͷ�")
                        IsCaicDay = (list[i].Value == "1");
                }

                if (NotEat > 0 || NotOrder > 0)
                {
                    Hownet.BLL.MiniEmp bllME = new MiniEmp();
                    DataTable dtt = bllME.GetDayList().Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        IsDay = false;
                        if (IsCaicDay)//���������˼�ʱ���������ͷѣ����ҵ�ǰԱ��Ϊ��ʱ��ʱ��IsDayΪ��
                        {
                            if (dtt.Select("(ID=" + dt.Rows[i]["EmployeeID"] + ")").Length > 0)
                                IsDay = true;
                        }
                        UpMoney(Convert.ToInt32(dt.Rows[i]["ID"]), ZhaoCan, WuCan, WanCan, NotEat, NotOrder, IsCaic, IsDay);
                    }
                }
                else
                {
                    dal.CaicMoneyNotEat(ZhaoCan, WuCan, WanCan, IsCaicDay, date);
                }
            }
        }
        /// <summary>
        /// �����ʳ��
        /// </summary>
        /// <param name="ID">�Ʋͱ�ID</param>
        /// <param name="ZhaoCan">��ͷ���</param>
        /// <param name="WuCan">��ͷ���</param>
        /// <param name="WanCan">��ͷ���</param>
        /// <param name="NotEat">�ж�δ�Կ۷�</param>
        /// <param name="NotOrder">�г�δ���۷�</param>
        /// <param name="IsCaic">Ϊ��ʱ��۷������Ͳ�</param>
        /// <param name="IsDay">Ϊ��ʱ��ʱԱ�����������Ͳ�</param>
        public void UpMoney(int ID, decimal ZhaoCan, decimal WuCan, decimal WanCan, decimal NotEat, decimal NotOrder, bool IsCaic, bool IsDay)
        {
            Hownet.Model.OrderingList modOL = GetModel(ID);

            modOL.Money = 0;
            if (modOL.OrderOne != modOL.DinOne)
            {
                if (IsCaic)
                {
                    if (modOL.OrderOne == 1)
                        modOL.Money += NotEat;
                    else if (modOL.DinOne == 1)
                        modOL.Money += NotOrder;
                }
                else
                {

                    modOL.Money += ZhaoCan;
                }
            }
            if (modOL.OrderOne == 1 && modOL.DinOne == 1)
            {
                if (!IsDay)
                    modOL.Money += ZhaoCan;
            }
            if (modOL.OrderTwo != modOL.DinTwo)
            {
                if (IsCaic)
                {
                    if (modOL.OrderTwo == 1)
                        modOL.Money += NotEat;
                    else if (modOL.DinTwo == 1)
                        modOL.Money += NotOrder;
                }
                else
                {
                    modOL.Money += WuCan;
                }
            }
            if (modOL.OrderTwo == 1 && modOL.DinTwo == 1)
            {
                if (!IsDay)
                    modOL.Money += WuCan;
            }
            if (modOL.OrderThree != modOL.DinThree)
            {
                if (IsCaic)
                {
                    if (modOL.OrderThree == 1)
                        modOL.Money += NotEat;
                    else if (modOL.DinThree == 1)
                        modOL.Money += NotOrder;
                }
                else
                {
                    modOL.Money += WanCan;
                }
            }
            if (modOL.OrderThree == 1 && modOL.DinThree == 1)
            {
                if (!IsDay)
                    modOL.Money += WanCan;
            }
            Update(modOL);
        }
        public decimal GetMoney(int EmployeeID, DateTime dtOne, DateTime dtTwo, int AllowedCount, decimal ErrorMoney,decimal ZhaoCan,decimal WuCan,decimal WanCan)
        {
            return dal.GetMoney(EmployeeID, dtOne, dtTwo, AllowedCount, ErrorMoney, ZhaoCan, WuCan, WanCan);
        }
        public void UpIsSum(int IsSum, DateTime dtOne, DateTime dtTwo)
        {
            dal.UpIsSum(IsSum, dtOne, dtTwo);
        }
        /// <summary>
        /// ����ֻ�趩�͵Ļ�ʳ��
        /// </summary>
        /// <param name="date"></param>
        public void CaicMoneyNoEat(DateTime date)
        {
             DataTable dt = dal.GetIDList(date).Tables[0];
             if (dt.Rows.Count > 0)
             {
                 Hownet.BLL.OtherType bllOT = new OtherType();
                 List<Hownet.Model.OtherType> list = bllOT.DataTableToList(bllOT.GetTypeList("��ʳ�۷�").Tables[0]);
                 decimal ZhaoCan, WuCan, WanCan, NotEat, NotOrder;
                 bool IsCaic = false;
                 bool IsCaicDay = false;
                 bool IsDay = false;
                 ZhaoCan = WuCan = WanCan = NotEat = NotOrder = 0;
                 for (int i = 0; i < list.Count; i++)
                 {
                     if (list[i].Name == "���")
                         ZhaoCan = Convert.ToDecimal(list[i].Value);
                     if (list[i].Name == "���")
                         WuCan = Convert.ToDecimal(list[i].Value);
                     else if (list[i].Name == "���")
                         WanCan = Convert.ToDecimal(list[i].Value);
                     //else if (list[i].Name == "���ͺ�δ��")
                     //    NotEat = Convert.ToDecimal(list[i].Value);
                     //else if (list[i].Name == "δ���ͳԷ�")
                     //    NotOrder = Convert.ToDecimal(list[i].Value);
                     //else if (list[i].Name == "����Ҫ�۷�")
                     //    IsCaic = (list[i].Value == "1");
                     else if (list[i].Name == "��ʱ���������ͷ�")
                         IsCaicDay = (list[i].Value == "1");
                 }
                 dal.CaicMoneyNotEat(ZhaoCan, WuCan, WanCan, IsDay, date);
             }
        }
         /// <summary>
        /// ��ȡĳ��ĳ�͵Ķ�������������Ķ���������
        /// </summary>
        /// <param name="date"></param>
        /// <param name="CanBie"></param>
        /// <returns></returns>
        public DataSet GetTabeList(DateTime date, string CanBie)
        {
            return dal.GetTabeList(date, CanBie);
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

