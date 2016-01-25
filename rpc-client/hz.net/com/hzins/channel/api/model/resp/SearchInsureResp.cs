using Sharpen;

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 查询保单列表
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-5-22 下午3:28:04</date>
	/// <version></version>
	public class SearchInsureResp
	{
		private int partnerId;

		private string transNo;

		private System.Collections.Generic.IList<com.hzins.channel.api.model.info.OrderDetailInfo
			> orderDetailInfos;

		//代理商编�?
		//交易流水号，每一单请求交易不能相�?
		//保单列表
		public virtual int getPartnerId()
		{
			return partnerId;
		}

		public virtual void setPartnerId(int partnerId)
		{
			this.partnerId = partnerId;
		}

		public virtual string getTransNo()
		{
			return transNo;
		}

		public virtual void setTransNo(string transNo)
		{
			this.transNo = transNo;
		}

		public virtual System.Collections.Generic.IList<com.hzins.channel.api.model.info.OrderDetailInfo
			> getOrderDetailInfos()
		{
			return orderDetailInfos;
		}

		public virtual void setOrderDetailInfos(System.Collections.Generic.IList<com.hzins.channel.api.model.info.OrderDetailInfo
			> orderDetailInfos)
		{
			this.orderDetailInfos = orderDetailInfos;
		}
	}
}
