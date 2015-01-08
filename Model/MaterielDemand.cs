using System;
namespace Hownet.Model
{
    /// <summary>
    /// ʵ����MaterielDemand ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class MaterielDemand
    {
        public MaterielDemand()
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
        public int ProduceTaskID
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
        public int ColorID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int ColorOneID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int ColorTwoID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Amount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal NotAllotAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal stockAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal stockNotAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int SizeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int MeasureID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DepID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int MListID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int TableTypeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsEnd
        {
            set;
            get;
        }
        /// <summary>
        /// �ѱ�������
        /// </summary>
        public decimal RepertoryAmount
        {
            set;
            get;
        }
        /// <summary>
        /// ���깺δ�ɹ�����
        /// </summary>
        public decimal NeedAmount
        {
            set;
            get;
        }
        /// <summary>
        /// �Ѳɹ�δ�ջ�����
        /// </summary>
        public decimal HasStockAmount
        {
            set;
            get;
        }
        /// <summary>
        /// �ѳ�������
        /// </summary>
        public decimal OutAmount
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

