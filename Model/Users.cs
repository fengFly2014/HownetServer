using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����Users ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class Users
	{
		public Users()
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
		/// ��¼��
		/// </summary>
		public string Name
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] Password
		{
			set;
			get;
		}
		/// <summary>
		/// ��ʵ����
		/// </summary>
		public string TrueName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int EmployeeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int DepartmentID
		{
			set;
			get;
		}
		/// <summary>
		/// ״̬
		/// </summary>
		public int State
		{
			set;
			get;
		}
        /// <summary>
        /// ְλ
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

