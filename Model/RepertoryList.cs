using System;
namespace Hownet.Model
{
    /// <summary>
    /// RepertoryList:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public partial class RepertoryList
    {
        public RepertoryList()
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
        public decimal Amount
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
        public string Remark
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal NotAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int StockListID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int BatchNumber
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsEnd
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int SpecID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string SpecName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DepotInfoID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string DepotInfoName
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
        public int PlanID
        {
            set;
            get;
        }
        public string QRID
        {
            set;
            get;
        }
        #endregion Model

    }
}

