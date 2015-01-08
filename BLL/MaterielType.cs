using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���MaterielType ��ժҪ˵����
	/// </summary>
	public class MaterielType
	{
		private readonly Hownet.DAL.MaterielType dal=new Hownet.DAL.MaterielType();
		public MaterielType()
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
		public int  Add(Hownet.Model.MaterielType model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������,����ԴΪDataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.MaterielType> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.MaterielType model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.MaterielType> li=DataTableToList(dt);
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
		public Hownet.Model.MaterielType GetModel(int ID)
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
		public List<Hownet.Model.MaterielType> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Hownet.Model.MaterielType> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.MaterielType> modelList = new List<Hownet.Model.MaterielType>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.MaterielType model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.MaterielType();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["ParentID"].ToString()!="")
					{
						model.ParentID=int.Parse(dt.Rows[n]["ParentID"].ToString());
					}
					model.Name=dt.Rows[n]["Name"].ToString();
					model.Sn=dt.Rows[n]["Sn"].ToString();
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
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["AttributeID"].ToString()!="")
					{
						model.AttributeID=int.Parse(dt.Rows[n]["AttributeID"].ToString());
					}
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
        public DataSet GetTree()
        {
            return dal.GetTree();
        }
        public DataSet GetFinishedTree()
        {
            return dal.GetFinishedTree();
        }
        public void AddBase()
        {
            List<Hownet.Model.MaterielType> li = DataTableToList(dal.GetList("(ID=0)").Tables[0]);
            Hownet.Model.MaterielType modMT = new Hownet.Model.MaterielType();
            modMT.ParentID=0;
            modMT.Name="ԭ����";
            modMT.Sn="01";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=1;
            modMT.Remark = "";
            Add(modMT);

            modMT.ParentID=0;
            modMT.Name="���Ʒ";
            modMT.Sn="02";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=2;
            modMT.Remark = "";
            Add(modMT);

            modMT.ParentID=0;
            modMT.Name="��ӹ�";
            modMT.Sn="03";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=3;
            modMT.Remark = "";
            Add(modMT);

            modMT.ParentID=0;
            modMT.Name="��Ʒ";
            modMT.Sn="04";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=4;
            modMT.Remark = "";
            Add(modMT);
            
            modMT.ParentID=0;
            modMT.Name="�̱�";
            modMT.Sn="05";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=5;
            modMT.Remark = "";
            Add(modMT);
            
            modMT.ParentID=1;
            modMT.Name="�ֹ�";
            modMT.Sn="0101";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=1;
            modMT.Remark = "";
            Add(modMT);
            
            modMT.ParentID=1;
            modMT.Name="͸������";
            modMT.Sn="0102";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=1;
            modMT.Remark = "";
            Add(modMT);
            
            modMT.ParentID=2;
            modMT.Name="����";
            modMT.Sn="0201";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=2;
            modMT.Remark = "";
            Add(modMT);

            modMT.ParentID=2;
            modMT.Name="��Ʒ���";
            modMT.Sn="0202";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=2;
            modMT.Remark = "";
            Add(modMT);
            
            modMT.ParentID=1;
            modMT.Name="����";
            modMT.Sn="0103";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=1;
            modMT.Remark = "";
            Add(modMT);
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

