using System;
namespace Hownet.Model
{
	/// <summary>
	/// FixedAssetsGroup:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class FixedAssetsGroup
	{
		public FixedAssetsGroup()
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
		public string Name
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
		public string Remark
		{
			set;
			get;
		}
		#endregion Model

	}
}

