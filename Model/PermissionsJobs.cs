using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����PermissionsJobs ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class PermissionsJobs
	{
		public PermissionsJobs()
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
		public int PermissionsPropertyID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int JobsID
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

