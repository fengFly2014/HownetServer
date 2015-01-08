using System;
namespace Hownet.Model
{
    /// <summary>
    /// Pay:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public partial class Pay
    {
        public Pay()
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
        /// ���
        /// </summary>
        public decimal? Remain
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
        /// �¼Ƽ�����
        /// </summary>
        public decimal? Month
        {
            set;
            get;
        }
        /// <summary>
        /// Ԥ֧��
        /// </summary>
        public decimal? Payment
        {
            set;
            get;
        }
        /// <summary>
        /// ��ʳ��
        /// </summary>
        public decimal? BoardWages
        {
            set;
            get;
        }
        /// <summary>
        /// ����
        /// </summary>
        public decimal? Repair
        {
            set;
            get;
        }
        /// <summary>
        /// ���½��
        /// </summary>
        public decimal? LastRemain
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
        /// ʵ������
        /// </summary>
        public decimal? Fact
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsEnd
        {
            set;
            get;
        }
        /// <summary>
        /// ȫ�ڽ�
        /// </summary>
        public decimal? FullAttendance
        {
            set;
            get;
        }
        /// <summary>
        /// ����
        /// </summary>
        public decimal? Fine
        {
            set;
            get;
        }
        /// <summary>
        /// Ѻ��
        /// </summary>
        public decimal? Deposit
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Add1
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Add2
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Add3
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Add4
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Add5
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Jian1
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Jian2
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Jian3
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Jian4
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Jian5
        {
            set;
            get;
        }
        /// <summary>
        /// �����˱��׺���ܹ���
        /// </summary>
        public decimal ActualMonth
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool NotFact
        {
            set;
            get;
        }
        #endregion Model

    }
}

