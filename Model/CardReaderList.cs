using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����CardReaderList ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class CardReaderList
	{
		public CardReaderList()
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
		/// ������
		/// </summary>
		public int NID
		{
			set;
			get;
		}
		/// <summary>
		/// λ�ã����ţ�
		/// </summary>
		public int Location
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
		/// 1Ϊ���ڣ�2Ϊ��Ʒ��⣬3Ϊ���ͣ�4Ϊ�Ͳ�
		/// </summary>
		public int TypeID
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

