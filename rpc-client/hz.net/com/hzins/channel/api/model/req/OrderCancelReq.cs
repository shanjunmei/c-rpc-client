

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// �?保请求消�?
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-9 下午3:22:12</date>
	/// <version></version>
	public class OrderCancelReq
	{
		private string transNo;

		private int partnerId;

		private string sign;

		private string insureNo;

		private com.hzins.channel.api.model.info.ExtendInfo extendInfo;

		// 扩展信息
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

		public virtual string getInsureNo()
		{
			return insureNo;
		}

		public virtual void setInsureNo(string insureNo)
		{
			this.insureNo = insureNo;
		}

		public virtual com.hzins.channel.api.model.info.ExtendInfo getExtendInfo()
		{
			return extendInfo;
		}

		public virtual void setExtendInfo(com.hzins.channel.api.model.info.ExtendInfo extendInfo
			)
		{
			this.extendInfo = extendInfo;
		}
	}
}
