using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����HadnBackPrice ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class HadnBackPrice
	{
		public HadnBackPrice()
		{}
		#region Model
		private int _id;
		private int _materielid;
		private int _workingid;
		private decimal _price;
		private DateTime _datetime;
		private int _isuse;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MaterielID
		{
			set{ _materielid=value;}
			get{return _materielid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WorkingID
		{
			set{ _workingid=value;}
			get{return _workingid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DateTime
		{
			set{ _datetime=value;}
			get{return _datetime;}
		}
		/// <summary>
		/// 1Ϊ����ʹ�ã�2Ϊδʹ�ã�3Ϊ�ѹ���
		/// </summary>
		public int IsUse
		{
			set{ _isuse=value;}
			get{return _isuse;}
		}
		#endregion Model

	}
}

