using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���Deparment ��ժҪ˵����
	/// </summary>
	public class Deparment
	{
		private readonly Hownet.DAL.Deparment dal=new Hownet.DAL.Deparment();
		public Deparment()
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
		public int  Add(Hownet.Model.Deparment model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Deparment> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.Deparment model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.Deparment> li=DataTableToList(dt);
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
		public Hownet.Model.Deparment GetModel(int ID)
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
		public List<Hownet.Model.Deparment> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.Deparment> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.Deparment> modelList = new List<Hownet.Model.Deparment>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.Deparment model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.Deparment();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    model.Name = dt.Rows[n]["Name"].ToString();
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    model.Sn = dt.Rows[n]["Sn"].ToString();
                    if (dt.Rows[n]["IsEnd"].ToString() != "")
                    {
                        model.IsEnd = int.Parse(dt.Rows[n]["IsEnd"].ToString());
                    }
                    else
                    {
                        model.IsEnd = 0;
                    }
                    if (dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
                    else
                    {
                        model.TypeID = 0;
                    }
                    if (dt.Rows[n]["ParentID"].ToString() != "")
                    {
                        model.ParentID = int.Parse(dt.Rows[n]["ParentID"].ToString());
                    }
                    else
                    {
                        model.ParentID = 0;
                    }
                    if (dt.Rows[n]["CountEmployee"].ToString() != "")
                    {
                        model.CountEmployee = int.Parse(dt.Rows[n]["CountEmployee"].ToString());
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
        /// ���������Ͳ��Ҳ����б�
        /// </summary>
        /// <param name="DepartmentTypeName">��������</param>
        /// <returns></returns>
        public DataSet GetTypeList(string DepartmentTypeName)
        {
            return dal.GetTypeList(DepartmentTypeName);
        }
        /// <summary>
        /// ���������Ͳ��Ҳ����б�
        /// </summary>
        /// <param name="DepartmentTypeName">��������</param>
        /// <returns></returns>
        public DataSet GetTypeLists(string DepartmentTypeName)
        {
            return dal.GetTypeLists(DepartmentTypeName);
        }
        /// <summary>
        /// ��ȡĳһ���Ͳ��ŵ��������ţ���ָʳ�õ����ż����᷿���
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public DataSet GetInfoListByTypeName(string TypeName)
        {
            return dal.GetInfoListByTypeName(TypeName);
        }
         /// <summary>
        /// ĳ�����������ѷ��������
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="EmpID"></param>
        /// <returns></returns>
        public DataSet GetIsUse(int ID)
        {
            return dal.GetIsUse(ID);
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

