using System;
namespace Hownet.Model
{
    /// <summary>
    /// MoneyInOrOut:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public partial class MoneyInOrOut
    {
        public MoneyInOrOut()
        { }
        #region Model
        /// <summary>
        /// A�����ڱ�ʶ�Ƿ��޸�
        /// </summary>
        public int A
        {
            set;
            get;
        }
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
        public int Num
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
        public int CompanyID
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
        public string Remark
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
        /// ��ƿ�Ŀ 
        /// </summary>
        public int KJKMID
        {
            set;
            get;
        }
        /// <summary>
        /// ������
        /// </summary>
        public decimal Fees
        {
            set;
            get;
        }
        #endregion Model

    }
}

