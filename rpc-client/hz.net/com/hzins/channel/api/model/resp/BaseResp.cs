

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 返回基础�?
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-2 下午5:10:35</date>
	/// <version></version>
	public abstract class BaseResp
	{
		private string transNo;

		private int partnerId;

		// 交易流水号，每一单请求交易不能相�?
		// 代理商编�?
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
	}
}
