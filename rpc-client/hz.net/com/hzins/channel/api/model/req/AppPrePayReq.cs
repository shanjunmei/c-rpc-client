

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
	public class AppPrePayReq
	{
		private string transNo;

		private int partnerId;

		private string userId;

		private string sign;

		private string orderNum;

		private int payGatewayId;

		private int bankId;

		private int appTypeId;

		private string ip;

		// 交易流水号，每一单请求交易不能相�?
		// 代理商编�?
		//商户Id
		// 数字签名
		// 投保单号
		//  1 支付�?,21 微信充�??
		//银行编号，目前只支持微信和支付宝支付，暂时此字段不对外开�?
		//安卓3 ios 6
		//IP地址
		public virtual int getAppTypeId()
		{
			return appTypeId;
		}

		public virtual void setAppTypeId(int appTypeId)
		{
			this.appTypeId = appTypeId;
		}

		public virtual string getIp()
		{
			return ip;
		}

		public virtual void setIp(string ip)
		{
			this.ip = ip;
		}

		public virtual int getBankId()
		{
			return bankId;
		}

		public virtual void setBankId(int bankId)
		{
			this.bankId = bankId;
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

		public virtual string getUserId()
		{
			return userId;
		}

		public virtual void setUserId(string userId)
		{
			this.userId = userId;
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

		public virtual int getPayGatewayId()
		{
			return payGatewayId;
		}

		public virtual void setPayGatewayId(int payGatewayId)
		{
			this.payGatewayId = payGatewayId;
		}
	}
}
