using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���OtherType ��ժҪ˵����
	/// </summary>
	public class OtherType
	{
		private readonly Hownet.DAL.OtherType dal=new Hownet.DAL.OtherType();
		public OtherType()
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
		public bool Exists(int OtherTypeID)
		{
			return dal.Exists(OtherTypeID);
		}

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Hownet.Model.OtherType model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������,����ԴΪDataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.OtherType> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.OtherType model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.OtherType> li = DataTableToList(dt);
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
        public Hownet.Model.OtherType GetModel(int ID)
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
        public List<Hownet.Model.OtherType> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.OtherType> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.OtherType> modelList = new List<Hownet.Model.OtherType>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.OtherType model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.OtherType();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    model.Name = dt.Rows[n]["Name"].ToString();
                    if (dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
                    model.Value = dt.Rows[n]["Value"].ToString();
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
        /// �����ض������µ�������
        /// </summary>
        /// <param name="TypeName">������</param>
        /// <returns></returns>
        public DataSet GetTypeList(string TypeName)
        {
            return dal.GetTypeList(TypeName);
        }
        /// <summary>
        /// Ϊ�б���� ���� ѡ��
        /// </summary>
        /// <param name="dt"></param>
        public DataTable AddEditAndAdd(DataTable dt)
        {
            DataRow dr = dt.NewRow();
            dr["ID"] = -1;
            dr["Name"] = "����";
            dr["TypeID"] = 0;
            dt.Rows.Add(dr);
            return dt;
        }
        /// <summary>
        /// ����һ���͵�ID���������򷵻�0
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public int GetID(string TypeName)
        {
            return dal.GetID(TypeName);
        }
        public DataSet GetWorkTime()
        {
            return dal.GetWorkTime();
        }
        /// <summary>
        /// ��ȡĳһ��ֵΪ���ֵ���
        /// </summary>
        /// <param name="TypeName"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetNumValue()
        {
            return dal.GetNumValue();
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

