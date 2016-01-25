

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 保单下载
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?5�?11�? 下午3:38:53</date>
	/// <version/>
	public class InsureDownloadReq
	{
		private string transNo;

		private string insureNum;

		private int partnerId;

		private string sign;

		public virtual string getTransNo()
		{
			return transNo;
		}

		public virtual void setTransNo(string transNo)
		{
			this.transNo = transNo;
		}

		public virtual string getInsureNum()
		{
			return insureNum;
		}

		public virtual void setInsureNum(string insureNum)
		{
			this.insureNum = insureNum;
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
