using System;
namespace Hownet.Model
{
    /// <summary>
    /// MaterielList:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public partial class MaterielList
    {
        public MaterielList()
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
        public int SizeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int BrandID
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
        public int SpecID
        {
            set;
            get;
        }
        #endregion Model

    }
}

