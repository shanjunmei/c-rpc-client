

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 申请结算明细信息
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?6�?12�? 下午7:06:25</date>
	/// <version></version>
	public class SettlementBillDetailInfo
	{
		private int billId;

		private int year;

		private int month;

		private string range;

		private string createTime;

		private int userType;

		private double applyFee;

		private double deductTax;

		private double payFee;

		private int state;

		//申请服务费结算之后的settlementBill数据的Id
		//结算年份
		//结算月度
		//结算周期
		//申请结算时间
		//用户类型(0表示渠道�?1表示代理�?)
		//应付收入(税前)
		//代扣税款
		//应付收入(税后)
		//结算状�??(0未结算，1表示已结�?)
		public virtual int getYear()
		{
			return year;
		}

		public virtual void setYear(int year)
		{
			this.year = year;
		}

		public virtual int getMonth()
		{
			return month;
		}

		public virtual void setMonth(int month)
		{
			this.month = month;
		}

		public virtual string getRange()
		{
			return range;
		}

		public virtual void setRange(string range)
		{
			this.range = range;
		}

		public virtual string getCreateTime()
		{
			return createTime;
		}

		public virtual void setCreateTime(string createTime)
		{
			this.createTime = createTime;
		}

		public virtual double getApplyFee()
		{
			return applyFee;
		}

		public virtual void setApplyFee(double applyFee)
		{
			this.applyFee = applyFee;
		}

		public virtual double getDeductTax()
		{
			return deductTax;
		}

		public virtual void setDeductTax(double deductTax)
		{
			this.deductTax = deductTax;
		}

		public virtual double getPayFee()
		{
			return payFee;
		}

		public virtual void setPayFee(double payFee)
		{
			this.payFee = payFee;
		}

		public virtual int getUserType()
		{
			return userType;
		}

		public virtual void setUserType(int userType)
		{
			this.userType = userType;
		}

		public virtual int getState()
		{
			return state;
		}

		public virtual void setState(int state)
		{
			this.state = state;
		}

		public virtual int getBillId()
		{
			return billId;
		}

		public virtual void setBillId(int billId)
		{
			this.billId = billId;
		}
	}
}
