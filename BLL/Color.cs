using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���Color ��ժҪ˵����
	/// </summary>
	public class Color
	{
		private readonly Hownet.DAL.Color dal=new Hownet.DAL.Color();
		public Color()
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
		public int  Add(Hownet.Model.Color model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Color> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.Color model)
		{
			dal.Update(model);
		}
        public int  UpOrAdd(byte[] bb)
        {
            try
            {
                string strDS = BaseFile.ZipDt.DeCompressString(bb);
                string[] ssRow = strDS.Split('��');
                int _id=0;
                DataTable dt = GetList("(1=2)").Tables[0];
                int _a = 0;
                for (int j = 0; j < ssRow.Length; j++)
                {
                    if (ssRow[j] != string.Empty)
                    {
                        string[] ss = ssRow[j].Split('��');//�ֶηָ�
                        _a = Convert.ToInt32(ss[0]);
                        dt.Rows.Clear();
                        dt.Rows.Add(dt.NewRow());

                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            dt.Rows[0][i] = ss[i];
                        }
                        if (_a == 3)
                        {
                            _id = AddByDt(dt);
                        }
                        else if (_a == 2)
                        {
                            UpdateByDt(dt);
                        }
                        else if (_a == 4)
                        {
                            if (Convert.ToInt32(ss[1]) > 0)
                                Delete(Convert.ToInt32(ss[1]));
                        }
                    }
                }
                return _id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.Color> li=DataTableToList(dt);
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
		public Hownet.Model.Color GetModel(int ID)
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
		public List<Hownet.Model.Color> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.Color> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.Color> modelList = new List<Hownet.Model.Color>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.Color model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.Color();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.Name=dt.Rows[n]["Name"].ToString();
					model.Sn=dt.Rows[n]["Sn"].ToString();
					if(dt.Rows[n]["Value"].ToString()!="")
					{
						model.Value=int.Parse(dt.Rows[n]["Value"].ToString());
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
					if(dt.Rows[n]["ColorTypeID"].ToString()!="")
					{
						model.ColorTypeID=int.Parse(dt.Rows[n]["ColorTypeID"].ToString());
					}
                    model.Remark = dt.Rows[n]["Remark"].ToString();
					model.A=int.Parse(dt.Rows[n]["A"].ToString());
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
        /// ����ĳ����ɫ��ID
        /// </summary>
        /// <param name="CName"></param>
        /// <returns></returns>
        public int GetID(string CName)
        {
            return dal.GetID(CName);
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

