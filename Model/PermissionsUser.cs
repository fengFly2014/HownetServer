using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����PermissionsUser ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class PermissionsUser
	{
		public PermissionsUser()
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
		public int ItemsID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string PermissionsPropertyID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserID
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

