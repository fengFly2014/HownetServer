using System;
namespace Hownet.Model
{
    /// <summary>
    /// VouchersInfo:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public partial class VouchersInfo
    {
        public VouchersInfo()
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
        public int MainID
        {
            set;
            get;
        }
        /// <summary>
        /// ժҪ
        /// </summary>
        public string Summary
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int AccountsOne
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int AccountsTwo
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal DebitMoney
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal CreditMoney
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsPosting
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string AOne
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ATwo
        {
            set;
            get;
        }
        #endregion Model

    }
}

