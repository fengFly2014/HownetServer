using System;
namespace Hownet.Model
{
    /// <summary>
    /// ʵ����OrderingList ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class OrderingList
    {
        public OrderingList()
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
        /// Ա��ID
        /// </summary>
        public int EmployeeID
        {
            set;
            get;
        }
        /// <summary>
        /// �����ľͲ����ڣ���Ͳ�����
        /// </summary>
        public DateTime DateTime
        {
            set;
            get;
        }
        /// <summary>
        /// ����
        /// </summary>
        public int OrderOne
        {
            set;
            get;
        }
        /// <summary>
        /// �Ͳ�
        /// </summary>
        public int DinOne
        {
            set;
            get;
        }
        /// <summary>
        /// ����ˢ��ʱ��
        /// </summary>
        public DateTime OrderOneTime
        {
            set;
            get;
        }
        /// <summary>
        /// �Ͳ�ˢ��ʱ��
        /// </summary>
        public DateTime DiningOneTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int OrderTwo
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DinTwo
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OrdeTwoTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DiningTwoTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int OrderThree
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DinThree
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OrdeThreeTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DiningThreeTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int OrderCount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DinCount
        {
            set;
            get;
        }
        public decimal Money
        {
            set;
            get;
        }
        public bool IsSum
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

