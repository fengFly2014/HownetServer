using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����PermissionsProperty ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class PermissionsProperty
	{
		public PermissionsProperty()
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
		public string Name
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

