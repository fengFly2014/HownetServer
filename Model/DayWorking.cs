using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����DayWorking ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class DayWorking
	{
		public DayWorking()
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
		public DateTime DateTime
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int FillMan
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int VerifyMan
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime VerifyDate
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int UpData
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int Num
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
		public DateTime FillDate
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
        public int IsEnd
        {
            set;
            get;
        }
        public int IsVerify
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

