

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-5-20 上午9:42:21</date>
	/// <version></version>
	public class RegisterResp
	{
		private string transNo;

		private int partnerId;

		private string usreId;

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

		public virtual string getUsreId()
		{
			return usreId;
		}

		public virtual void setUsreId(string usreId)
		{
			this.usreId = usreId;
		}
	}
}
