using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����DayWorkingInfo ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
    [Serializable]
    public class DayWorkingInfo
    {
        public DayWorkingInfo()
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
        public int MainID
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
        public string Remark
        {
            set;
            get;
        }
        public int EmployeeID
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

