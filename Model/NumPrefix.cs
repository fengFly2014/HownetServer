using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����NumPrefix ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class NumPrefix
	{
		public NumPrefix()
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
		public string FormName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Prefix
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int Length
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
		public int FormID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int Rules
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

