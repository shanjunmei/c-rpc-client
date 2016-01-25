

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 支付接口返回参数
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-27 上午11:26:31</date>
	/// <version></version>
	public class AppPrePayResp
	{
		private string transNo;

		private string orderNum;

		private string gatewayData;

		//投保单号
		//调用支付的参数串
		public virtual string getTransNo()
		{
			return transNo;
		}

		public virtual void setTransNo(string transNo)
		{
			this.transNo = transNo;
		}

		public virtual string getOrderNum()
		{
			return orderNum;
		}

		public virtual void setOrderNum(string orderNum)
		{
			this.orderNum = orderNum;
		}

		public virtual string getGatewayData()
		{
			return gatewayData;
		}

		public virtual void setGatewayData(string gatewayData)
		{
			this.gatewayData = gatewayData;
		}
	}
}
