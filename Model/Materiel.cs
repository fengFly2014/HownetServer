using System;
namespace Hownet.Model
{
    /// <summary>
    /// Materiel:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public partial class Materiel
    {
        public Materiel()
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
        public string Name
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int TypeID
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
        public string Sn
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
        public int AttributeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int SecondMeasureID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Conversion
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
        /// 
        /// </summary>
        public bool IsUse
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Image
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Designers
        {
            set;
            get;
        }
        /// <summary>
        /// ����Ҫ�Ĺ��0Ϊ����Ҫ��1Ϊ��ɫ��2Ϊ���룬3Ϊ��ɫ�ͳ���
        /// </summary>
        public int SelectSpec
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string TiaoMaH
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ChengBengJ
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal LingShouJia
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal YiJiDaiLiJia
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ErJiDaiLiJia
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal SanJiDaiLiJia
        {
            set;
            get;
        }
        #endregion Model

    }
}

