using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���AccessList ��ժҪ˵����
	/// </summary>
	public class AccessList
	{
		private readonly Hownet.DAL.AccessList dal=new Hownet.DAL.AccessList();
		public AccessList()
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
        public int Add(Hownet.Model.AccessList model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������,����ԴΪDataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.AccessList> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.AccessList model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.AccessList> li = DataTableToList(dt);
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
        public Hownet.Model.AccessList GetModel(int ID)
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
        public List<Hownet.Model.AccessList> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.AccessList> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.AccessList> modelList = new List<Hownet.Model.AccessList>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.AccessList model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.AccessList();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    if (dt.Rows[n]["AccessID"].ToString() != "")
                    {
                        model.AccessID = int.Parse(dt.Rows[n]["AccessID"].ToString());
                    }
                    else
                    {
                        model.AccessID = 0;
                    }
                    if (dt.Rows[n]["EmployeeID"].ToString() != "")
                    {
                        model.EmployeeID = int.Parse(dt.Rows[n]["EmployeeID"].ToString());
                    }
                    else
                    {
                        model.EmployeeID = 0;
                    }
                    model.PassWord = dt.Rows[n]["PassWord"].ToString();
                    model.Remark = dt.Rows[n]["Remark"].ToString();
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
        /// ����ĳһ�����µĿɿ���Ա��
        /// </summary>
        /// <param name="AccessID"></param>
        /// <returns></returns>
        public DataSet GetListByAccessID(int AccessID)
        {
            return dal.GetListByAccessID(AccessID);
        }
        /// <summary>
        /// �ж�ĳ���Ƿ���Դ�ĳ�Ž�
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="NID"></param>
        /// <returns></returns>
        public bool CheckIsCanOpenDoor(int EmployeeID, int NID)
        {
            return dal.CheckIsCanOpenDoor(EmployeeID, NID);
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

