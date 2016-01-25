

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-15 下午7:25:50</date>
	/// <version></version>
	public class OrderCancelResp
	{
		private string transNo;

		private int partnerId;

		private string insureNo;

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

		public virtual string getInsureNo()
		{
			return insureNo;
		}

		public virtual void setInsureNo(string insureNo)
		{
			this.insureNo = insureNo;
		}
	}
}
