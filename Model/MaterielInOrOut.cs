using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����MaterielInOrOut ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class MaterielInOrOut
	{
		public MaterielInOrOut()
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
		public decimal Amount
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int MListID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int MaterielID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ColorID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ColorOneID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ColorTwoID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SizeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int BrandID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int TableTypeID
		{
			set;
			get;
		}
		/// <summary>
		/// ���Ϊ1������Ϊ-1
		/// </summary>
		public int PorN
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
		public int A
		{
		set;
		get;
		}
		#endregion Model

	}
}

