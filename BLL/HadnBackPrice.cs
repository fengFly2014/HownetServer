using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���HadnBackPrice ��ժҪ˵����
	/// </summary>
	public class HadnBackPrice
	{
		private readonly Hownet.DAL.HadnBackPrice dal=new Hownet.DAL.HadnBackPrice();
		public HadnBackPrice()
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
		public int  Add(Hownet.Model.HadnBackPrice model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(Hownet.Model.HadnBackPrice model)
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
		public Hownet.Model.HadnBackPrice GetModel(int ID)
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
		public List<Hownet.Model.HadnBackPrice> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<Hownet.Model.HadnBackPrice> modelList = new List<Hownet.Model.HadnBackPrice>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.HadnBackPrice model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.HadnBackPrice();
					if(ds.Tables[0].Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(ds.Tables[0].Rows[n]["ID"].ToString());
					}
					if(ds.Tables[0].Rows[n]["MaterielID"].ToString()!="")
					{
						model.MaterielID=int.Parse(ds.Tables[0].Rows[n]["MaterielID"].ToString());
					}
					if(ds.Tables[0].Rows[n]["WorkingID"].ToString()!="")
					{
						model.WorkingID=int.Parse(ds.Tables[0].Rows[n]["WorkingID"].ToString());
					}
					if(ds.Tables[0].Rows[n]["Price"].ToString()!="")
					{
						model.Price=decimal.Parse(ds.Tables[0].Rows[n]["Price"].ToString());
					}
					if(ds.Tables[0].Rows[n]["DateTime"].ToString()!="")
					{
						model.DateTime=DateTime.Parse(ds.Tables[0].Rows[n]["DateTime"].ToString());
					}
					if(ds.Tables[0].Rows[n]["IsUse"].ToString()!="")
					{
						model.IsUse=int.Parse(ds.Tables[0].Rows[n]["IsUse"].ToString());
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
        /// ���س�Ʒ���
        /// </summary>
        /// <returns></returns>
        public DataSet GetMateriel()
        {
            return dal.GetMateriel();
        }
         /// <summary>
        /// �ж�ĳ�����Ƿ��ѻ���
        /// </summary>
        /// <param name="priceID"></param>
        /// <returns></returns>
        public bool CheckPriceUsed(int priceID)
        {
            return dal.CheckPriceUsed(priceID);
        }
        /// <summary>
        /// ����ĳ��������������е����ڹ���
        /// </summary>
        /// <param name="WorkID"></param>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetOtherPrice(int WorkID, int MaterielID)
        {
            return dal.GetOtherPrice(WorkID, MaterielID);
        }
        /// <summary>
        /// �ж�ĳ�����Ƿ���ʹ��
        /// </summary>
        /// <param name="priceID"></param>
        /// <returns></returns>
        public bool CheckUse(int priceID)
        {
            return dal.CheckUse(priceID);
        }
        public void Save(DataTable dt)
        {
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.HadnBackPrice model;
                for (int n = 0; n < rowsCount; n++)
                {
                    string a = dt.Rows[n]["A"].ToString();
                    if (a != "1")
                    {
                        model = new Hownet.Model.HadnBackPrice();
                        if (dt.Rows[n]["MaterielID"].ToString() != "")
                            model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                        if (dt.Rows[n]["WorkingID"].ToString() != "")
                            model.WorkingID = int.Parse(dt.Rows[n]["WorkingID"].ToString());
                        if (dt.Rows[n]["Price"].ToString() != "")
                            model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
                        else
                            model.Price = 0;
                        if (dt.Rows[n]["DateTime"].ToString() != "")
                            model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                        if (dt.Rows[n]["IsUse"].ToString() != "")
                            model.IsUse = int.Parse(dt.Rows[n]["IsUse"].ToString());
                        if (a == "3")
                            Add(model);
                        else if (a == "2")
                        {
                            if (dt.Rows[n]["ID"].ToString() != "")
                            {
                                model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                                Update(model);
                                dal.UpBackPrice(model.ID);
                            }
                        }
                    }
                }
            }
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

