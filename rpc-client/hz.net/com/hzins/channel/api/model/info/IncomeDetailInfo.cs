using Sharpen;

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 服务费按月汇总详细信�?
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-2 下午5:51:54</date>
	/// <version></version>
	public class IncomeDetailInfo
	{
		private int settlementState;

		private int month;

		private string userId;

		private int year;

		private double totalIncome;

		private double premium;

		//0为未结算�?1为结算中�?2为已经结�?
		//总计服务�?(Income+Award)
		//总计保费
		public virtual int getSettlementState()
		{
			return settlementState;
		}

		public virtual void setSettlementState(int settlementState)
		{
			this.settlementState = settlementState;
		}

		public virtual int getMonth()
		{
			return month;
		}

		public virtual void setMonth(int month)
		{
			this.month = month;
		}

		public virtual string getUserId()
		{
			return userId;
		}

		public virtual void setUserId(string userId)
		{
			this.userId = userId;
		}

		public virtual int getYear()
		{
			return year;
		}

		public virtual void setYear(int year)
		{
			this.year = year;
		}

		public virtual double getTotalIncome()
		{
			return totalIncome;
		}

		public virtual void setTotalIncome(double totalIncome)
		{
			this.totalIncome = totalIncome;
		}

		public virtual double getPremium()
		{
			return premium;
		}

		public virtual void setPremium(double premium)
		{
			this.premium = premium;
		}
	}
}
