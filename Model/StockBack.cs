using System;
namespace Hownet.Model
{
    /// <summary>
    /// ʵ����StockBack ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class StockBack
    {
        public StockBack()
        { }
        #region Model
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DataTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Num
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int CompanyID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Money
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsVerify
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int VerifyMan
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime VerifyDate
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DepotID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal LastMoney
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal BackMoney
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FillDate
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int FillMan
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int UpData
        {
            set;
            get;
        }
        /// <summary>
        /// 1Ϊ�ɹ���⣬-1Ϊ�˻�
        /// </summary>
        public int State
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime BackDate
        {
            set;
            get;
        }
        public int TaskID
        {
            set;
            get;
        }
        public string StockRemark
        {
            set;
            get;
        }
        public int DeparmentType
        {
            set;
            get;
        }
        public decimal Weight
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int OtherTypeID
        {
            set;
            get;
        }
        public int A
        {
            set;
            get;
        }
        #endregion Model

    }
}

