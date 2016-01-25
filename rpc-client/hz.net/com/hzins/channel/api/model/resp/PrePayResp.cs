using Sharpen;

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
	public class PrePayResp
	{
		private string transNo;

		private string orderNum;

		private com.hzins.channel.api.model.PrePayParam prePayParam;

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

		public virtual com.hzins.channel.api.model.PrePayParam getPrePayParam()
		{
			return prePayParam;
		}

		public virtual void setPrePayParam(com.hzins.channel.api.model.PrePayParam prePayParam
			)
		{
			this.prePayParam = prePayParam;
		}
	}
}
