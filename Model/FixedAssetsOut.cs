using System;
namespace Hownet.Model
{
	/// <summary>
	/// FixedAssetsOut:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class FixedAssetsOut
	{
		public FixedAssetsOut()
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
		/// �ʲ�ID
		/// </summary>
		public int FAID
		{
			set;
			get;
		}
		/// <summary>
		/// �������
		/// </summary>
		public DateTime OutDate
		{
			set;
			get;
		}
		/// <summary>
		/// Ԥ�ƹ黹����
		/// </summary>
		public DateTime ExpectedBackDate
		{
			set;
			get;
		}
		/// <summary>
		/// ʵ�ʹ黹����
		/// </summary>
		public DateTime ActualBackDate
		{
			set;
			get;
		}
		/// <summary>
		/// ���ò���
		/// </summary>
		public int OutDeparmentID
		{
			set;
			get;
		}
		/// <summary>
		/// ������
		/// </summary>
		public int OutUserID
		{
			set;
			get;
		}
		/// <summary>
		/// ��׼��
		/// </summary>
		public int VerifyManID
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
		#endregion Model

	}
}

