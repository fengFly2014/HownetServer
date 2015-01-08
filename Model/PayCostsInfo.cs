﻿using System;
namespace Hownet.Model
{
    /// <summary>
    /// 实体类PayCostsInfo 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class PayCostsInfo
    {
        public PayCostsInfo()
        { }
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
        public int MainID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int EmployeeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Money
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
        public bool IsDeposit
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

