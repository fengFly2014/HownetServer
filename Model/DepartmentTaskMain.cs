using System;
namespace Hownet.Model
{
    /// <summary>
    /// ʵ����DepartmentTaskMain ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class DepartmentTaskMain
    {
        public DepartmentTaskMain()
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
        public int DepartmentID
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
        public DateTime DateTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime LastDate
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
        public int Num
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
        public int PWID
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

