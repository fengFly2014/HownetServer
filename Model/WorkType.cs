using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����WorkType ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class WorkType
	{
		public WorkType()
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
		public string Name
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
		public int IsEnd
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
		public string Sn
		{
			set;
			get;
		}
        public int Deposit
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

