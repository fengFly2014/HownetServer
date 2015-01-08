using System;
namespace Hownet.Model
{
	/// <summary>
	/// FixedAssets:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class FixedAssets
	{
		public FixedAssets()
		{}
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
		/// �ʲ�����
		/// </summary>
		public string Sn
		{
			set;
			get;
		}
		/// <summary>
		/// ��Ƭ����
		/// </summary>
		public string Barcode
		{
			set;
			get;
		}
		/// <summary>
		/// �ʲ�����
		/// </summary>
		public string Name
		{
			set;
			get;
		}
		/// <summary>
		/// �ʲ�����
		/// </summary>
		public int FATypeID
		{
			set;
			get;
		}
		/// <summary>
		/// �ͺŹ��
		/// </summary>
		public string Spec
		{
			set;
			get;
		}
		/// <summary>
		/// ���칤��
		/// </summary>
		public int CompanyID
		{
			set;
			get;
		}
		/// <summary>
		/// �������
		/// </summary>
		public string GBCode
		{
			set;
			get;
		}
		/// <summary>
		/// ��ϸ����
		/// </summary>
		public string More
		{
			set;
			get;
		}
		/// <summary>
		/// ��������
		/// </summary>
		public DateTime DateOfOut
		{
			set;
			get;
		}
		/// <summary>
		/// ʹ�ò���
		/// </summary>
		public int UseDeparmentID
		{
			set;
			get;
		}
		/// <summary>
		/// ʹ��״̬
		/// </summary>
		public int UseTypeID
		{
			set;
			get;
		}
		/// <summary>
		/// ��ŵص�
		/// </summary>
		public string StoreAccess
		{
			set;
			get;
		}
		/// <summary>
		/// ������Ա
		/// </summary>
		public int Custodian
		{
			set;
			get;
		}
		/// <summary>
		/// ����
		/// </summary>
		public decimal Amount
		{
			set;
			get;
		}
		/// <summary>
		/// ��λ
		/// </summary>
		public int MeasureID
		{
			set;
			get;
		}
		/// <summary>
		/// ����
		/// </summary>
		public decimal Price
		{
			set;
			get;
		}
		/// <summary>
		/// ���ӷ�ʽ
		/// </summary>
		public int AddTypeID
		{
			set;
			get;
		}
		/// <summary>
		/// ԭֵ
		/// </summary>
		public decimal OldMoney
		{
			set;
			get;
		}
		/// <summary>
		/// ��ֵ
		/// </summary>
		public decimal NowMoney
		{
			set;
			get;
		}
		/// <summary>
		/// �۾ɷ���
		/// </summary>
		public int Depreciation
		{
			set;
			get;
		}
		/// <summary>
		/// ��ֵ��
		/// </summary>
		public decimal ResidualValue
		{
			set;
			get;
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime UseDate
		{
			set;
			get;
		}
		/// <summary>
		/// ά�޼����
		/// </summary>
		public int Interval
		{
			set;
			get;
		}
		/// <summary>
		/// �۾�����
		/// </summary>
		public int DepreciationYear
		{
			set;
			get;
		}
		/// <summary>
		/// �۾�����
		/// </summary>
		public int DepreciationMonth
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
		/// �Ƿ񱻽����ά����
		/// </summary>
		public bool IsOut
		{
			set;
			get;
		}
		#endregion Model

	}
}

