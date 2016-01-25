

namespace com.hzins.channel.api.model
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-28 上午9:35:07</date>
	/// <version></version>
	public class PrePayParam
	{
		private string payUrl;

		private int onliePaymnetId;

		private string bsId;

		private string price;

		private int partnerId;

		private int consumeType;

		private int companyId;

		private int productId;

		private string productName;

		private int bankId;

		private string notifyUrl;

		private string isNoDeal;

		private string deadline;

		private string sign;

		private string payOrderNumber;

		private string payToInsurer;

		private string ip;

		private string traceId;

		private string openId;

		private string descript;

		private string wxPayType;

		private string serviceNotifyUrl;

		public virtual string getServiceNotifyUrl()
		{
			return serviceNotifyUrl;
		}

		public virtual void setServiceNotifyUrl(string serviceNotifyUrl)
		{
			this.serviceNotifyUrl = serviceNotifyUrl;
		}

		public virtual string getTraceId()
		{
			return traceId;
		}

		public virtual void setTraceId(string traceId)
		{
			this.traceId = traceId;
		}

		public virtual string getOpenId()
		{
			return openId;
		}

		public virtual void setOpenId(string openId)
		{
			this.openId = openId;
		}

		public virtual string getDescript()
		{
			return descript;
		}

		public virtual void setDescript(string descript)
		{
			this.descript = descript;
		}

		public virtual string getWxPayType()
		{
			return wxPayType;
		}

		public virtual void setWxPayType(string wxPayType)
		{
			this.wxPayType = wxPayType;
		}

		public virtual string getIp()
		{
			return ip;
		}

		public virtual void setIp(string ip)
		{
			this.ip = ip;
		}

		public virtual string getPayUrl()
		{
			return payUrl;
		}

		public virtual void setPayUrl(string payUrl)
		{
			this.payUrl = payUrl;
		}

		public virtual int getOnliePaymnetId()
		{
			return onliePaymnetId;
		}

		public virtual void setOnliePaymnetId(int onliePaymnetId)
		{
			this.onliePaymnetId = onliePaymnetId;
		}

		public virtual string getBsId()
		{
			return bsId;
		}

		public virtual void setBsId(string bsId)
		{
			this.bsId = bsId;
		}

		public virtual string getPrice()
		{
			return price;
		}

		public virtual void setPrice(string price)
		{
			this.price = price;
		}

		public virtual int getPartnerId()
		{
			return partnerId;
		}

		public virtual void setPartnerId(int partnerId)
		{
			this.partnerId = partnerId;
		}

		public virtual int getConsumeType()
		{
			return consumeType;
		}

		public virtual void setConsumeType(int consumeType)
		{
			this.consumeType = consumeType;
		}

		public virtual int getCompanyId()
		{
			return companyId;
		}

		public virtual void setCompanyId(int companyId)
		{
			this.companyId = companyId;
		}

		public virtual int getProductId()
		{
			return productId;
		}

		public virtual void setProductId(int productId)
		{
			this.productId = productId;
		}

		public virtual string getProductName()
		{
			return productName;
		}

		public virtual void setProductName(string productName)
		{
			this.productName = productName;
		}

		public virtual int getBankId()
		{
			return bankId;
		}

		public virtual void setBankId(int bankId)
		{
			this.bankId = bankId;
		}

		public virtual string getNotifyUrl()
		{
			return notifyUrl;
		}

		public virtual void setNotifyUrl(string notifyUrl)
		{
			this.notifyUrl = notifyUrl;
		}

		public virtual string getIsNoDeal()
		{
			return isNoDeal;
		}

		public virtual void setIsNoDeal(string isNoDeal)
		{
			this.isNoDeal = isNoDeal;
		}

		public virtual string getDeadline()
		{
			return deadline;
		}

		public virtual void setDeadline(string deadline)
		{
			this.deadline = deadline;
		}

		public virtual string getSign()
		{
			return sign;
		}

		public virtual void setSign(string sign)
		{
			this.sign = sign;
		}

		public virtual string getPayOrderNumber()
		{
			return payOrderNumber;
		}

		public virtual void setPayOrderNumber(string payOrderNumber)
		{
			this.payOrderNumber = payOrderNumber;
		}

		public virtual string getPayToInsurer()
		{
			return payToInsurer;
		}

		public virtual void setPayToInsurer(string payToInsurer)
		{
			this.payToInsurer = payToInsurer;
		}
	}
}
