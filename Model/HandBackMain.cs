using System;
namespace Hownet.Model
{
	/// <summary>
	/// ʵ����HandBackMain ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class HandBackMain
	{
		public HandBackMain()
		{}
		#region Model
		private int _mainid;
		private DateTime _datetime;
		private int _num;
		private int _employeeid;
		private string _remark;
		private int _isverify;
		private int _verifymanid;
		private DateTime _verifydatetime;
		private int _isend;
		/// <summary>
		/// 
		/// </summary>
		public int MainID
		{
			set{ _mainid=value;}
			get{return _mainid;}
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
		/// 
		/// </summary>
		public int Num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EmployeeID
		{
			set{ _employeeid=value;}
			get{return _employeeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// �Ƿ���ˣ�1Ϊδ��ˣ�2Ϊ����У�3Ϊ����ˣ�4Ϊ���δͨ��
		/// </summary>
		public int IsVerify
		{
			set{ _isverify=value;}
			get{return _isverify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int VerifyManID
		{
			set{ _verifymanid=value;}
			get{return _verifymanid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime VerifyDateTime
		{
			set{ _verifydatetime=value;}
			get{return _verifydatetime;}
		}
		/// <summary>
		/// 1Ϊ�ѻ��ܣ�2Ϊ���ܺ��е�������
		/// </summary>
		public int IsEnd
		{
			set{ _isend=value;}
			get{return _isend;}
		}
		#endregion Model

	}
}

