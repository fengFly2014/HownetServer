using System;
namespace Hownet.Model
{
    /// <summary>
    /// HandBackInfo:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public partial class HandBackInfo
    {
        public HandBackInfo()
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
        public int InfoID
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
        /// 
        /// </summary>
        public int MaterielID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int WorkingID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Amount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Price
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
        public int PriceID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int EmployeeID
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
        #endregion Model

    }
}

