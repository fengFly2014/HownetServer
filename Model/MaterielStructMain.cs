using System;
namespace Hownet.Model
{
    /// <summary>
    /// MaterielStructMain:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public partial class MaterielStructMain
    {
        public MaterielStructMain()
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
        public int MainID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Ver
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
        public int TaskID
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
        public bool IsDefault
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
        public int VerifyManID
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
        public int Executant
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
        public decimal WorkingMoney
        {
            set;
            get;
        }
        /// <summary>
        /// ������
        /// </summary>
        public decimal OutPrice
        {
            set;
            get;
        }
        /// <summary>
        /// ���ϱ�
        /// </summary>
        public decimal MaterielPro
        {
            set;
            get;
        }
        /// <summary>
        /// ë����
        /// </summary>
        public decimal GrossProfit
        {
            set;
            get;
        }
        /// <summary>
        /// ë����
        /// </summary>
        public decimal GrossPro
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal CMT
        {
            set;
            get;
        }
        /// <summary>
        /// ��������ʹ�õĳ���
        /// </summary>
        public string BySizeName
        {
            set;
            get;
        }
        /// <summary>
        /// �ÿ�ʽ���еĳ���
        /// </summary>
        public string ExSize
        {
            set;
            get;
        }
        /// <summary>
        /// ���������
        /// </summary>
        public string MaterielLoss
        {
            set;
            get;
        }
        /// <summary>
        /// ��װ�������
        /// </summary>
        public string PackLoss
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int FillManID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string FillManName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string VerifyManName
        {
            set;
            get;
        }
        #endregion Model

    }
}

