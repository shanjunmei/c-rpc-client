using Sharpen;

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 结算前每月汇总查询请求参�?
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?6�?12�? 下午6:58:30</date>
	/// <version></version>
	public class IncomeDetailReq
	{
		private string transNo;

		private int partnerId;

		private System.Collections.Generic.IList<string> userIds;

		private int year;

		private int month;

		private string sign;

		//流水号，每次请求不相�?
		//代理商ID
		//渠道唯一的标�?
		//年份
		//月份
		//签名
		public virtual string getTransNo()
		{
			return transNo;
		}

		public virtual void setTransNo(string transNo)
		{
			this.transNo = transNo;
		}

		public virtual int getPartnerId()
		{
			return partnerId;
		}

		public virtual void setPartnerId(int partnerId)
		{
			this.partnerId = partnerId;
		}

		public virtual string getSign()
		{
			return sign;
		}

		public virtual void setSign(string sign)
		{
			this.sign = sign;
		}

		public virtual System.Collections.Generic.IList<string> getUserIds()
		{
			return userIds;
		}

		public virtual void setUserIds(System.Collections.Generic.IList<string> userIds)
		{
			this.userIds = userIds;
		}

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
	}
}
