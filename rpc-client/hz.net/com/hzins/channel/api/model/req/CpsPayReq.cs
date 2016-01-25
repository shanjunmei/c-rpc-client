using Sharpen;

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-30 下午2:20:46</date>
	/// <version></version>
	public class CpsPayReq
	{
		private string transNo;

		private string orderNum;

		private int partnerId;

		private string userId;

		private string sign;

		private int platformType;

		private string backUrl;

		//请求流水�?
		//投保单号，不是订单号
		//渠道id
		//渠道唯一标示
		//加密�?
		//普�?�类型，0为Pc.1为H5
		//支付成功之后返回链接(如果是cps支付，需填写，用户能有更好的体验)
		public virtual string getBackUrl()
		{
			return backUrl;
		}

		public virtual void setBackUrl(string backUrl)
		{
			this.backUrl = backUrl;
		}

		public virtual string getTransNo()
		{
			return transNo;
		}

		public virtual void setTransNo(string transNo)
		{
			this.transNo = transNo;
		}

		public virtual string getOrderNum()
		{
			return orderNum;
		}

		public virtual void setOrderNum(string orderNum)
		{
			this.orderNum = orderNum;
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

		public virtual string getUserId()
		{
			return userId;
		}

		public virtual void setUserId(string userId)
		{
			this.userId = userId;
		}

		public virtual int getPlatformType()
		{
			return platformType;
		}

		public virtual void setPlatformType(int platformType)
		{
			this.platformType = platformType;
		}
	}
}
