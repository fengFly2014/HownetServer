using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类MaterielCaiPian 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class MaterielCaiPian
	{
		public MaterielCaiPian()
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
		public int CaiPianID
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
		public int UseMaterielID
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

