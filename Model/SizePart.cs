using System;
namespace Hownet.Model
{
    /// <summary>
    /// ʵ����SizePart ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class SizePart
    {
        public SizePart()
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
        public string EnName
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
        /// �������
        /// </summary>
        public string Tolerance
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

