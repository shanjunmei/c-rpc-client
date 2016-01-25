using Sharpen;

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 产品详情请求信息
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?5�?21�? 下午3:47:29</date>
	/// <version></version>
	public class ProductDetailReq : com.hzins.channel.api.model.req.BaseReq
	{
		private int productId;

		private int planId;

		//产品ID
		//产品计划Id
		public virtual int getProductId()
		{
			return productId;
		}

		public virtual void setProductId(int productId)
		{
			this.productId = productId;
		}

		public virtual int getPlanId()
		{
			return planId;
		}

		public virtual void setPlanId(int planId)
		{
			this.planId = planId;
		}
	}
}
