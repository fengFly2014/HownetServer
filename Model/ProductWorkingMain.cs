using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����ProductWorkingMain ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class ProductWorkingMain
	{
		public ProductWorkingMain()
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
		public int MaterielID
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
		public int TaskID
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
		public string Ver
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
		public int FillMan
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
		public int VerifyMan
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsDefault
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsEnd
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsUse
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

