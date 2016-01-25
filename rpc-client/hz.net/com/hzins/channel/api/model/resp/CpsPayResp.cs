

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 异步投保 在线CPS页面支付
	/// 返回的实体（含支付链接）
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-4-29 下午2:23:58</date>
	/// <version></version>
	[System.Serializable]
	public class CpsPayResp
	{
		/// <date>2015-4-29 下午2:32:45</date>
		/// <version></version>
		private const long serialVersionUID = -710272183659427282L;

		private string transNo;

		private string insureNum;

		private string paymentUrl;

		public virtual string getInsureNum()
		{
			return insureNum;
		}

		public virtual void setInsureNum(string insureNum)
		{
			this.insureNum = insureNum;
		}

		public virtual string getPaymentUrl()
		{
			return paymentUrl;
		}

		public virtual void setPaymentUrl(string paymentUrl)
		{
			this.paymentUrl = paymentUrl;
		}

		public virtual string getTransNo()
		{
			return transNo;
		}

		public virtual void setTransNo(string transNo)
		{
			this.transNo = transNo;
		}
	}
}
