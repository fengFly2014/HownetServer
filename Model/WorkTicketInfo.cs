using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����WorkTicketInfo ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class WorkTicketInfo
	{
		public WorkTicketInfo()
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
		public DateTime? DateTime
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsDel
		{
			set;
			get;
		}
		/// <summary>
		/// ���յ���ϸID
		/// </summary>
		public int PWorkingInfoID
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
		public int BackID
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
		/// 
		/// </summary>
		public int NotAmount
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int TaskID
		{
			set;
			get;
		}
        public int WorkingID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int OutAmount
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

