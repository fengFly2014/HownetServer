using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����AttendanceSum ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class AttendanceSum
	{
		public AttendanceSum()
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
		public int EmployeeID
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
		public int DayWorkMin
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DayWorkTime
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int BelateMin
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int LeaveEarlyMin
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int AbsenteeismMin
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Money
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int OvertimeMin
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OvertimeTime
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

