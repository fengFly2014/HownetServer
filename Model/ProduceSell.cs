using System;
namespace Hownet.Model
{
    /// <summary>
    /// ʵ����ProduceSell ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class ProduceSell
    {
        public ProduceSell()
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
        public int CompanyID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Depot
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
        public int Num
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
        public int FillMan
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
        /// 1Ϊ���ۣ�2Ϊ�˻�
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
        public int BackMoneyTypeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime LastDate
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

