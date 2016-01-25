

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 支付接口请求对象
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-27 上午11:26:02</date>
	/// <version></version>
	public class PrePayReq
	{
		private string transNo;

		private int partnerId;

		private string userId;

		private string caseCode;

		private string sign;

		private string orderNum;

		private int onliePaymnetId;

		private int bankId;

		private string pageNoticeUrl;

		private string price;

		// 交易流水号，每一单请求交易不能相�?
		// 代理商编�?
		//商户Id
		// 方案代码
		// 数字签名
		// 投保单号
		// 在线支付网关标识�?1：支付宝�?3：银联；12：易宝在线；13：易宝无卡支付；14：财付�?�；15：手机支付；16：银�?(B2B)�?21：微信支�?
		// 银行标识，当值大�?0时，会直接跳转到相应的银行页�?
		// 页面返回地址
		// 支付金额（单位：元）
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

		public virtual string getCaseCode()
		{
			return caseCode;
		}

		public virtual void setCaseCode(string caseCode)
		{
			this.caseCode = caseCode;
		}

		public virtual string getSign()
		{
			return sign;
		}

		public virtual void setSign(string sign)
		{
			this.sign = sign;
		}

		public virtual string getOrderNum()
		{
			return orderNum;
		}

		public virtual void setOrderNum(string orderNum)
		{
			this.orderNum = orderNum;
		}

		public virtual int getOnliePaymnetId()
		{
			return onliePaymnetId;
		}

		public virtual void setOnliePaymnetId(int onliePaymnetId)
		{
			this.onliePaymnetId = onliePaymnetId;
		}

		public virtual int getBankId()
		{
			return bankId;
		}

		public virtual void setBankId(int bankId)
		{
			this.bankId = bankId;
		}

		public virtual string getPageNoticeUrl()
		{
			return pageNoticeUrl;
		}

		public virtual void setPageNoticeUrl(string pageNoticeUrl)
		{
			this.pageNoticeUrl = pageNoticeUrl;
		}

		public virtual string getPrice()
		{
			return price;
		}

		public virtual void setPrice(string price)
		{
			this.price = price;
		}

		public virtual string getUserId()
		{
			return userId;
		}

		public virtual void setUserId(string userId)
		{
			this.userId = userId;
		}
	}
}
