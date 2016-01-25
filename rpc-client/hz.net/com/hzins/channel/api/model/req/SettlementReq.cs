using Sharpen;

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 服务费结算请求实�?
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?5�?11�? 下午3:38:53</date>
	/// <version/>
	public class SettlementReq
	{
		private string transNo;

		private int partnerId;

		private string sign;

		private string userId;

		private com.hzins.channel.api.model.info.FinancialInfo financialInfo;

		public virtual string getTransNo()
		{
			return transNo;
		}

		public virtual void setTransNo(string transNo)
		{
			this.transNo = transNo;
		}

		public virtual string getUserId()
		{
			return userId;
		}

		public virtual void setUserId(string userId)
		{
			this.userId = userId;
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

		public virtual com.hzins.channel.api.model.info.FinancialInfo getFinancialInfo()
		{
			return financialInfo;
		}

		public virtual void setFinancialInfo(com.hzins.channel.api.model.info.FinancialInfo
			 financialInfo)
		{
			this.financialInfo = financialInfo;
		}
	}
}
