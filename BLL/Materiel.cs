using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���Materiel ��ժҪ˵����
	/// </summary>
	public class Materiel
	{
		private readonly Hownet.DAL.Materiel dal=new Hownet.DAL.Materiel();
		public Materiel()
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
		public int  Add(Hownet.Model.Materiel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Materiel> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.Materiel model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
            List<Hownet.Model.Materiel> li = DataTableToList(dt);
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
		public Hownet.Model.Materiel GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}


		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
            if (GetHDID.LinesCount == -1)
            {
                GetHDID.CheckReg();
            }
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
		public List<Hownet.Model.Materiel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.Materiel> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.Materiel> modelList = new List<Hownet.Model.Materiel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.Materiel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.Materiel();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.Name=dt.Rows[n]["Name"].ToString();
					if(dt.Rows[n]["TypeID"].ToString()!="")
					{
						model.TypeID=int.Parse(dt.Rows[n]["TypeID"].ToString());
					}
					if(dt.Rows[n]["MeasureID"].ToString()!="")
					{
						model.MeasureID=int.Parse(dt.Rows[n]["MeasureID"].ToString());
					}
					model.Sn=dt.Rows[n]["Sn"].ToString();
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["AttributeID"].ToString()!="")
					{
						model.AttributeID=int.Parse(dt.Rows[n]["AttributeID"].ToString());
					}
					if(dt.Rows[n]["SecondMeasureID"].ToString()!="")
					{
						model.SecondMeasureID=int.Parse(dt.Rows[n]["SecondMeasureID"].ToString());
					}
					if(dt.Rows[n]["Conversion"].ToString()!="")
					{
						model.Conversion=decimal.Parse(dt.Rows[n]["Conversion"].ToString());
					}
					if(dt.Rows[n]["IsEnd"].ToString()!="")
					{
						model.IsEnd=int.Parse(dt.Rows[n]["IsEnd"].ToString());
					}
					if(dt.Rows[n]["IsUse"].ToString()!="")
					{
						if((dt.Rows[n]["IsUse"].ToString()=="1")||(dt.Rows[n]["IsUse"].ToString().ToLower()=="true"))
						{
						model.IsUse=true;
						}
						else
						{
							model.IsUse=false;
						}
					}
                    if (dt.Rows[n]["Designers"].ToString() != "")
                    {
                        model.Designers = int.Parse(dt.Rows[n]["Designers"].ToString());
                    }
                    else
                    {
                        model.Designers = 0;
                    }
					model.Image=dt.Rows[n]["Image"].ToString();
                    if (dt.Rows[n]["SelectSpec"].ToString() != "")
                    {
                        model.SelectSpec = int.Parse(dt.Rows[n]["SelectSpec"].ToString());
                    }
                    model.TiaoMaH = dt.Rows[n]["TiaoMaH"].ToString();
                    if (dt.Rows[n]["ChengBengJ"] != null && dt.Rows[n]["ChengBengJ"].ToString() != "")
                    {
                        model.ChengBengJ = decimal.Parse(dt.Rows[n]["ChengBengJ"].ToString());
                    }
                    if (dt.Rows[n]["LingShouJia"] != null && dt.Rows[n]["LingShouJia"].ToString() != "")
                    {
                        model.LingShouJia = decimal.Parse(dt.Rows[n]["LingShouJia"].ToString());
                    }
                    if (dt.Rows[n]["YiJiDaiLiJia"] != null && dt.Rows[n]["YiJiDaiLiJia"].ToString() != "")
                    {
                        model.YiJiDaiLiJia = decimal.Parse(dt.Rows[n]["YiJiDaiLiJia"].ToString());
                    }
                    if (dt.Rows[n]["ErJiDaiLiJia"] != null && dt.Rows[n]["ErJiDaiLiJia"].ToString() != "")
                    {
                        model.ErJiDaiLiJia = decimal.Parse(dt.Rows[n]["ErJiDaiLiJia"].ToString());
                    }
                    if (dt.Rows[n]["SanJiDaiLiJia"] != null && dt.Rows[n]["SanJiDaiLiJia"].ToString() != "")
                    {
                        model.SanJiDaiLiJia = decimal.Parse(dt.Rows[n]["SanJiDaiLiJia"].ToString());
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
        /// ����BOM����������������б�
        /// </summary>
        /// <returns></returns>
        /// <param name="AttributeID"></param>
        /// <param name="IsEnd">-1Ϊȫ����0Ϊʹ���У�1Ϊͣ��</param>
        public DataSet GetLaftTree(int AttributeID, int IsEnd)
        {
            return dal.GetLaftTree(AttributeID, IsEnd);
        }
        public DataSet GetByTypeName(string TypeName)
        {
            return dal.GetByTypeName(TypeName);
        }
        public DataSet GetListAndMeasure()
        {
            return dal.GetListAndMeasure();
        }
        public string GetMTName(int ID)
        {
            return dal.GetMTName(ID);
        }
        /// <summary>
        /// ��ȡ�����������е�����
        /// </summary>
        /// <returns></returns>
        public DataSet GetTogethers()
        {
            return dal.GetTogethers();
        }
        /// <summary>
        /// ������������ʾ���б�
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetLookupList(string strWhere)
        {
            return dal.GetLookupList(strWhere);
        }
        //public DataSet GetTem()
        //{
        //    return dal.GetTem();
        //}
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

