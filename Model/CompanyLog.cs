using System;
namespace Hownet.Model
{
    /// <summary>
    /// ʵ����CompanyLog ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class CompanyLog
    {
        public CompanyLog()
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
        public decimal LastMoney
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ChangMoney
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
        public int TypeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int TableID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int NowMoneyTypeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal NowMoney
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal NowReta
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

