

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-13 下午4:36:22</date>
	/// <version></version>
	public class OrderInfo
	{
		private string insureNum;

		private string policyNum;

		private string cName;

		private string cardCode;

		// 惠择投保单号
		// 保险公司保单�?
		// 被保人姓�?
		// 被保人证件号�?
		public virtual string getInsureNum()
		{
			return insureNum;
		}

		public virtual void setInsureNum(string insureNum)
		{
			this.insureNum = insureNum;
		}

		public virtual string getPolicyNum()
		{
			return policyNum;
		}

		public virtual void setPolicyNum(string policyNum)
		{
			this.policyNum = policyNum;
		}

		public virtual string getcName()
		{
			return cName;
		}

		public virtual void setcName(string cName)
		{
			this.cName = cName;
		}

		public virtual string getCardCode()
		{
			return cardCode;
		}

		public virtual void setCardCode(string cardCode)
		{
			this.cardCode = cardCode;
		}
	}
}
