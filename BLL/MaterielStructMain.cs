using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// ҵ���߼���MaterielStructMain ��ժҪ˵����
    /// </summary>
    public class MaterielStructMain
    {
        private readonly Hownet.DAL.MaterielStructMain dal = new Hownet.DAL.MaterielStructMain();
        public MaterielStructMain()
        { }
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
        public bool Exists(int MainID)
        {
            return dal.Exists(MainID);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Hownet.Model.MaterielStructMain model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������,����ԴΪDataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.MaterielStructMain> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.MaterielStructMain model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.MaterielStructMain> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                dal.Update(li[0]);
            }
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int MainID)
        {

            dal.Delete(MainID);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Hownet.Model.MaterielStructMain GetModel(int MainID)
        {

            return dal.GetModel(MainID);
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
        public List<Hownet.Model.MaterielStructMain> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Hownet.Model.MaterielStructMain> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.MaterielStructMain> modelList = new List<Hownet.Model.MaterielStructMain>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.MaterielStructMain model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.MaterielStructMain();
                    if (dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    else
                    {
                        model.MainID = 0;
                    }
                    model.Ver = dt.Rows[n]["Ver"].ToString();
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    else
                    {
                        model.MaterielID = 0;
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    else
                    {
                        model.DateTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    else
                    {
                        model.CompanyID = 0;
                    }
                    if (dt.Rows[n]["TaskID"].ToString() != "")
                    {
                        model.TaskID = int.Parse(dt.Rows[n]["TaskID"].ToString());
                    }
                    else
                    {
                        model.TaskID = 0;
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["IsDefault"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsDefault"].ToString() == "1") || (dt.Rows[n]["IsDefault"].ToString().ToLower() == "true"))
                        {
                            model.IsDefault = true;
                        }
                        else
                        {
                            model.IsDefault = false;
                        }
                    }
                    if (dt.Rows[n]["IsVerify"].ToString() != "")
                    {
                        model.IsVerify = int.Parse(dt.Rows[n]["IsVerify"].ToString());
                    }
                    else
                    {
                        model.IsVerify = 0;
                    }
                    if (dt.Rows[n]["VerifyManID"].ToString() != "")
                    {
                        model.VerifyManID = int.Parse(dt.Rows[n]["VerifyManID"].ToString());
                    }
                    else
                    {
                        model.VerifyManID = 0;
                    }
                    if (dt.Rows[n]["VerifyDateTime"].ToString() != "")
                    {
                        model.VerifyDateTime = DateTime.Parse(dt.Rows[n]["VerifyDateTime"].ToString());
                    }
                    else
                    {
                        model.VerifyDateTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["Executant"].ToString() != "")
                    {
                        model.Executant = int.Parse(dt.Rows[n]["Executant"].ToString());
                    }
                    else
                    {
                        model.Executant = 0;
                    }
                    if (dt.Rows[n]["Money"] != null && dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    if (dt.Rows[n]["WorkingMoney"] != null && dt.Rows[n]["WorkingMoney"].ToString() != "")
                    {
                        model.WorkingMoney = decimal.Parse(dt.Rows[n]["WorkingMoney"].ToString());
                    }
                    if (dt.Rows[n]["OutPrice"] != null && dt.Rows[n]["OutPrice"].ToString() != "")
                    {
                        model.OutPrice = decimal.Parse(dt.Rows[n]["OutPrice"].ToString());
                    }
                    if (dt.Rows[n]["MaterielPro"] != null && dt.Rows[n]["MaterielPro"].ToString() != "")
                    {
                        model.MaterielPro = decimal.Parse(dt.Rows[n]["MaterielPro"].ToString());
                    }
                    if (dt.Rows[n]["GrossProfit"] != null && dt.Rows[n]["GrossProfit"].ToString() != "")
                    {
                        model.GrossProfit = decimal.Parse(dt.Rows[n]["GrossProfit"].ToString());
                    }
                    if (dt.Rows[n]["GrossPro"] != null && dt.Rows[n]["GrossPro"].ToString() != "")
                    {
                        model.GrossPro = decimal.Parse(dt.Rows[n]["GrossPro"].ToString());
                    }
                    if (dt.Rows[n]["CMT"] != null && dt.Rows[n]["CMT"].ToString() != "")
                    {
                        model.CMT = decimal.Parse(dt.Rows[n]["CMT"].ToString());
                    }
                    model.BySizeName = dt.Rows[n]["BySizeName"].ToString();
                    model.ExSize = dt.Rows[n]["ExSize"].ToString();
                    model.MaterielLoss = dt.Rows[n]["MaterielLoss"].ToString();
                    model.PackLoss = dt.Rows[n]["PackLoss"].ToString();
                    if (dt.Rows[n]["FillManID"] != null && dt.Rows[n]["FillManID"].ToString() != "")
                    {
                        model.FillManID = int.Parse(dt.Rows[n]["FillManID"].ToString());
                    }
                    model.FillManName = dt.Rows[n]["FillManName"].ToString();
                    model.VerifyManName = dt.Rows[n]["VerifyManName"].ToString();
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
        /// ����ĳ��ŵ����Ͻṹ��IsDefaultΪ��
        /// </summary>
        /// <param name="MaterielID">���ID</param>
        public void UpDefault(int MaterielID)
        {
            dal.UpDefault(MaterielID);
        }
        /// <summary>
        /// ����ĳ��ŵ�Ĭ�����Ͻṹ�����
        /// </summary>
        /// <param name="MaterielID">���</param>
        /// <returns></returns>
        public int GetIsDefaultID(int MaterielID)
        {
            return dal.GetIsDefaultID(MaterielID);
        }
                 /// <summary>
        /// Ҫ������ID����ĳ���Ͻṹ
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetBomListByMainID(int MainID)
        {
            return dal.GetBomListByMainID(MainID);
        }
          /// <summary>
        /// ����ĳ���ϵ���һ���ṹ(һ��ֻ���ڰ��Ʒ��ֻ��һ���汾��)
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetBomListByMateriel(int MaterielID)
        {
            return dal.GetBomListByMateriel(MaterielID);
        }
         /// <summary>
        /// ����ĳ�������������Ͻṹ
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetDemandList(int MainID)
        {
            return dal.GetDemandList(MainID);
        }
         /// <summary>
        /// ����ĳ���ϵ���һ���ṹ*��ָ���Ʒ
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetDemandChildMateriel(int MaterielID)
        {
            return dal.GetDemandChildMateriel(MaterielID);
        }
        /// <summary>
        /// �ж�ĳBOMID�Ƿ���ʹ��
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool CheckBomID(int ID)
        {
            return dal.CheckBomID(ID);
        }
        /// <summary>
        /// �ж�ĳ���Ʒ����ӹ������Ƿ���ʹ��
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool CheckWuliao(int ID)
        {
            return dal.CheckWuliao(ID);
        }
        /// <summary>
        /// ����·���ĳ��ŵ������Ͻṹ ID�б�
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetIDList(int MaterielID)
        {
            return dal.GetIDList(MaterielID);
        }
        public DataSet GetInfoIDList()
        {
            return dal.GetInfoIDList();
        }
        public int CountUse(int MainID)
        {
            return dal.CountUse(MainID);
        }
        public DataSet GetBrandList(int BrandID)
        {
            return dal.GetBrandList(BrandID);
        }
        /// <summary>
        /// ��ӡ������ʱ�����BOM��
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetPrintList(int MainID)
        {
            return dal.GetPrintList(MainID);
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

