using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����CustomerManagement ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class CustomerManagement
	{
		public CustomerManagement()
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
		public int CompanyID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DataTime
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
		/// 
		/// </summary>
		public string Question
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Answer
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

