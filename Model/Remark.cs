using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����Remark ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class Remark
	{
		public Remark()
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
		public int TableTypeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remarks
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

