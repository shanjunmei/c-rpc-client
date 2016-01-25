using Sharpen;

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 第三方请求基�?�?
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-2 下午5:10:35</date>
	/// <version></version>
	public abstract class BaseReq
	{
		private string transNo;

		private int partnerId;

		private string sign;

		private string userId;

		// 交易流水号，每一单请求交易不能相�?
		// 代理商编�?
		// 数字签名
		//如果是代理商模式，需要传此ID（代理商下级用户Id�?
		public virtual string getUserId()
		{
			return userId;
		}

		public virtual void setUserId(string userId)
		{
			this.userId = userId;
		}

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
	}
}
