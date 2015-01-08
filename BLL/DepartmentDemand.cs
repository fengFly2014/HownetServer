using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// ҵ���߼���DepartmentDemand ��ժҪ˵����
    /// </summary>
    public class DepartmentDemand
    {
        private readonly Hownet.DAL.DepartmentDemand dal = new Hownet.DAL.DepartmentDemand();
        public DepartmentDemand()
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
        public int Add(Hownet.Model.DepartmentDemand model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(Hownet.Model.DepartmentDemand model)
        {
            dal.Update(model);
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
        public Hownet.Model.DepartmentDemand GetModel(int ID)
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
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.DepartmentDemand> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<Hownet.Model.DepartmentDemand> modelList = new List<Hownet.Model.DepartmentDemand>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.DepartmentDemand model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.DepartmentDemand();
                    if (ds.Tables[0].Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(ds.Tables[0].Rows[n]["ID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["DepID"].ToString() != "")
                    {
                        model.DepID = int.Parse(ds.Tables[0].Rows[n]["DepID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["ColorOneID"].ToString() != "")
                    {
                        model.ColorOneID = int.Parse(ds.Tables[0].Rows[n]["ColorOneID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["DepartmentTaskID"].ToString() != "")
                    {
                        model.DepartmentTaskID = int.Parse(ds.Tables[0].Rows[n]["DepartmentTaskID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(ds.Tables[0].Rows[n]["MaterielID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["ColorID"].ToString() != "")
                    {
                        model.ColorID = int.Parse(ds.Tables[0].Rows[n]["ColorID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["ColorTwoID"].ToString() != "")
                    {
                        model.ColorTwoID = int.Parse(ds.Tables[0].Rows[n]["ColorTwoID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["Amount"].ToString() != "")
                    {
                        model.Amount = decimal.Parse(ds.Tables[0].Rows[n]["Amount"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["NotAmount"].ToString() != "")
                    {
                        model.NotAmount = decimal.Parse(ds.Tables[0].Rows[n]["NotAmount"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["SizeID"].ToString() != "")
                    {
                        model.SizeID = int.Parse(ds.Tables[0].Rows[n]["SizeID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(ds.Tables[0].Rows[n]["MeasureID"].ToString());
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
        /// ĳ���������Ӧ��������
        /// </summary>
        /// <param name="DepotID"></param>
        /// <param name="DepTaskID"></param>
        /// <returns></returns>
        public DataSet GetPeiLiao(int DepotID, int DepTaskID)
        {
            DataSet ds=dal.GetPeiLiao(DepotID, DepTaskID);
            ds.Tables[0].Columns.Add("NowAmount", typeof(decimal));
            ds.Tables[0].Columns.Add("ReturnAmount", typeof(decimal));
            return ds;
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="t">��Ϊ������ϣ���Ϊ����</param>
        public void Update(Hownet.Model.DepartmentDemand model, bool t)
        {
            dal.Update(model, t);
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

