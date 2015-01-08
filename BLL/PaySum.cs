using System;
using System.Data;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// ҵ���߼���PaySum ��ժҪ˵����
	/// </summary>
	public class PaySum
	{
		private readonly Hownet.DAL.PaySum dal=new Hownet.DAL.PaySum();
		public PaySum()
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
		public int  Add(Hownet.Model.PaySum model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(Hownet.Model.PaySum model)
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
		public Hownet.Model.PaySum GetModel(int ID)
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
		public DataSet GetAllList()
		{
			return GetList("");
		}
        /// <summary>
        /// ɾ��һ�ι��ʻ�������
        /// </summary>
        /// <param name="MainID"></param>
        public void DelPay(int MainID)
        {
            dal.DelPay(MainID);
        }
         /// <summary>
        /// ����������֮����¼�빤Ʊ���ֹ���¼����
        /// </summary>
        /// <param name="DateOne"></param>
        /// <param name="DateTwo"></param>
        /// <returns></returns>
        public DataSet SumAmount(DateTime DateOne, DateTime DateTwo)
        {
            return dal.SumAmount(DateOne, DateTwo);
        }
        public DataSet SumAmountByPW(DateTime DateOne, DateTime DateTwo, int EmployeeID, bool IsInfo, int MaterielID, int WorkingID, bool SumColor,int DepID)
        {
            return dal.SumAmountByPW(DateOne, DateTwo, EmployeeID, IsInfo, MaterielID, WorkingID, SumColor,DepID);
        }
        public DataSet GetSumAmountByPW(DateTime DateOne, DateTime DateTwo, bool SumColor)
        {
            return dal.GetSumAmountByPW(DateOne, DateTwo, SumColor);
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

