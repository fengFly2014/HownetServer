using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����PlanUseRep ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class PlanUseRep
	{
		public PlanUseRep()
		{}
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
		/// ��ر���ϸID����TypeID���,��TypeIDΪ�ɹ���ʱ���˴�Ϊ�깺��ID
		/// </summary>
		public int RelatedID
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
		/// ���ϼ����ID
		/// </summary>
		public int DemandID
		{
			set;
			get;
		}
		/// <summary>
		/// 1Ϊʹ�ÿ��������2Ϊʹ�òɹ�����
		/// </summary>
		public int TypeID
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
		/// �ƻ���ID
		/// </summary>
		public int TaskID
		{
			set;
			get;
		}
		/// <summary>
		/// �빺����ϸID
		/// </summary>
		public int StockInfoID
		{
			set;
			get;
		}
        public decimal NotAmount
        {
            set;
            get;
        }
        public int IsEnd
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

