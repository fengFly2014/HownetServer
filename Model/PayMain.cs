using System;
namespace Hownet.Model
{
    /// <summary>
    /// PayMain:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public partial class PayMain
    {
        public PayMain()
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
        public DateTime DateTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime BegingDate
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime EndDate
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Indexs
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
        public DateTime VerifyDateTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int CaicType
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Posting
        {
            set;
            get;
        }
        #endregion Model

    }
}

