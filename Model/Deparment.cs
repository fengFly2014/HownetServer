using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����Deparment ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
    [Serializable]
    public class Deparment
    {
        public Deparment()
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
        public string Name
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
        public string Sn
        {
            set;
            get;
        }
        public int IsEnd
        {
            set;
            get;
        }
        public int TypeID
        {
            set;
            get;
        }
        public int ParentID
        {
            set;
            get;
        }
        public int CountEmployee
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

