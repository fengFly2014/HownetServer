using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����ChinaZone ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ChinaZone
	{
		public ChinaZone()
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
		public string ParentID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int OrderNum
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string InfoNum
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
		public int A
		{
		set;
		get;
		}
		#endregion Model

	}
}

