using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����Holidays ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class Holidays
	{
		public Holidays()
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
		/// �������ͣ�1Ϊ������٣�2Ϊ�����ż٣�3Ϊ�����࣬4Ϊ�����࣬5Ϊͨ��
		/// </summary>
		public int TypeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TimeOne
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TimeTwo
		{
			set;
			get;
		}
		/// <summary>
		/// Ϊ0ʱָ���й���
		/// </summary>
		public int EmployeeID
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
		public int MainID
		{
			set;
			get;
		}
		/// <summary>
		/// �ż��ڼ䣬�Ƿ񷢷Ź���
		/// </summary>
		public bool IsCaicMoney
		{
			set;
			get;
		}
		/// <summary>
		/// ���ڷ�����
		/// </summary>
		public int Times
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

