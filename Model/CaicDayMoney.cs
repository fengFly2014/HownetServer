using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����CaicDayMoney ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class CaicDayMoney
	{
		public CaicDayMoney()
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
		public decimal DayMoney
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal NightMoney
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal LateAtNightMoney
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
		/// ͨ������
		/// </summary>
		public decimal TXBT
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

