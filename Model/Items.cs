using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����Items ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class Items
	{
		public Items()
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
		public string Text
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ParentID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string FormName
		{
			set;
			get;
		}
		/// <summary>
		/// �Ƿ�����һ��
		/// </summary>
		public int IsModule
		{
			set;
			get;
		}
		/// <summary>
		/// �㼶��
		/// </summary>
		public int Level
		{
			set;
			get;
		}
		/// <summary>
		/// ����
		/// </summary>
		public int Orders
		{
			set;
			get;
		}
		/// <summary>
		/// �Ƿ���ʾ
		/// </summary>
		public int IsBar
		{
			set;
			get;
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Parameter
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

