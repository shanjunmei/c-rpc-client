

namespace com.hzins.channel.api.model
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-2 下午5:43:13</date>
	/// <version></version>
	public class ApplicationData
	{
		private string applicationDate;

		private string startDate;

		private string endDate;

		private double singlePrice;

		// 投保时间
		// 起保日期，保单的生效时间
		// 终保日期，保单的失效时间
		// 结算价，即相应保险产品的保费
		public virtual string getApplicationDate()
		{
			return applicationDate;
		}

		public virtual void setApplicationDate(string applicationDate)
		{
			this.applicationDate = applicationDate;
		}

		public virtual string getStartDate()
		{
			return startDate;
		}

		public virtual void setStartDate(string startDate)
		{
			this.startDate = startDate;
		}

		public virtual string getEndDate()
		{
			return endDate;
		}

		public virtual void setEndDate(string endDate)
		{
			this.endDate = endDate;
		}

		public virtual double getSinglePrice()
		{
			return singlePrice;
		}

		public virtual void setSinglePrice(double singlePrice)
		{
			this.singlePrice = singlePrice;
		}
	}
}
