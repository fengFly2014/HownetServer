using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����SamplesAmount ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class SamplesAmount
	{
		public SamplesAmount()
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
		public int MainTableTypeID
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
		public int SizeID
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
		/// �Ӱ���ͣ�1��Ӱ���k��2�����a�k��3��yԇ��
		/// </summary>
		public int SamplesID
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
		public int A
		{
		set;
		get;
		}
		#endregion Model

	}
}

