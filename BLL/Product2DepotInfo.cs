using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���Product2DepotInfo ��ժҪ˵����
	/// </summary>
	public class Product2DepotInfo
	{
		private readonly Hownet.DAL.Product2DepotInfo dal=new Hownet.DAL.Product2DepotInfo();
		public Product2DepotInfo()
		{}
		#region  ��Ա����


        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Hownet.Model.Product2DepotInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������,����ԴΪDataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.Product2DepotInfo> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.Product2DepotInfo model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.Product2DepotInfo> li = DataTableToList(dt);
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
        public Hownet.Model.Product2DepotInfo GetModel(int ID)
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
        public List<Hownet.Model.Product2DepotInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.Product2DepotInfo> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.Product2DepotInfo> modelList = new List<Hownet.Model.Product2DepotInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.Product2DepotInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    try
                    {
                        model = new Hownet.Model.Product2DepotInfo();
                        if (dt.Rows[n]["ID"].ToString() != "")
                        {
                            model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                        }
                        if (dt.Rows[n]["MainID"].ToString() != "")
                        {
                            model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                        }
                        if (dt.Rows[n]["MaterielID"].ToString() != "")
                        {
                            model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                        }
                        if (dt.Rows[n]["ColorID"].ToString() != "")
                        {
                            model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                        }
                        if (dt.Rows[n]["ColorOneID"].ToString() != "")
                        {
                            model.ColorOneID = int.Parse(dt.Rows[n]["ColorOneID"].ToString());
                        }
                        if (dt.Rows[n]["ColorTwoID"].ToString() != "")
                        {
                            model.ColorTwoID = int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
                        }
                        if (dt.Rows[n]["SizeID"].ToString() != "")
                        {
                            model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
                        }
                        if (dt.Rows[n]["BrandID"].ToString() != "")
                        {
                            model.BrandID = int.Parse(dt.Rows[n]["BrandID"].ToString());
                        }
                        if (dt.Rows[n]["MListID"].ToString() != "")
                        {
                            model.MListID = int.Parse(dt.Rows[n]["MListID"].ToString());
                        }
                        model.Remark = dt.Rows[n]["Remark"].ToString();
                        if (dt.Rows[n]["TaskID"].ToString() != "")
                        {
                            model.TaskID = int.Parse(dt.Rows[n]["TaskID"].ToString());
                        }
                        if (dt.Rows[n]["DeparmentID"].ToString() != "")
                        {
                            model.DeparmentID = int.Parse(dt.Rows[n]["DeparmentID"].ToString());
                        }
                        if (dt.Rows[n]["Amount"].ToString() != "")
                        {
                            model.Amount = int.Parse(dt.Rows[n]["Amount"].ToString());
                        }
                        if (dt.Rows[n]["Price"] != null && dt.Rows[n]["Price"].ToString() != "")
                        {
                            model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
                        }
                        if (dt.Rows[n]["Money"] != null && dt.Rows[n]["Money"].ToString() != "")
                        {
                            model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                        }
                        if (dt.Rows[n]["Weight"] != null && dt.Rows[n]["Weight"].ToString() != "")
                        {
                            model.Weight = decimal.Parse(dt.Rows[n]["Weight"].ToString());
                        }
                        if (dt.Rows[n]["DepotInfoID"] != null && dt.Rows[n]["DepotInfoID"].ToString() != "")
                        {
                            model.DepotInfoID = int.Parse(dt.Rows[n]["DepotInfoID"].ToString());
                        }
                        model.A = int.Parse(dt.Rows[n]["A"].ToString());
                        modelList.Add(model);
                    }
                    catch (Exception ex)
                    {

                    }
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
        /// ɾ��һ������
        /// </summary>
        public void DeleteByMainID(int MainID)
        {
            dal.DeleteByMainID(MainID);
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

