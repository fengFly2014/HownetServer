using System;
namespace Hownet.Model
{
	/// <summary>
	/// ItemsText:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class ItemsText
	{
		public ItemsText()
		{}
		#region Model
		/// <summary>
		/// A�����ڱ�ʶ�Ƿ��޸�
		/// </summary>
		public int A
		{
			set;
			get;
		}
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
		public int ItemsID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ColumnsName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShowText
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsVisible
		{
			set;
			get;
		}
        public int Widths
        {
            set;
            get;
        }
		#endregion Model

	}
}

