

namespace com.hzins.channel.api.model.resp
{
	public class ProductDetailResp : com.hzins.channel.api.model.resp.BaseResp
	{
		private string productName;

		private string planName;

		private int productId;

		private int planId;

		private System.Collections.Generic.IList<com.hzins.channel.api.model.PlanDetail> 
			planDetails;

		private double price;

		//    private String introduction;
		//    private List<Map<String, String>> planParams;
		public virtual System.Collections.Generic.IList<com.hzins.channel.api.model.PlanDetail
			> getPlanDetails()
		{
			return planDetails;
		}

		public virtual void setPlanDetails(System.Collections.Generic.IList<com.hzins.channel.api.model.PlanDetail
			> planDetails)
		{
			this.planDetails = planDetails;
		}

		public virtual string getPlanName()
		{
			return planName;
		}

		public virtual void setPlanName(string planName)
		{
			this.planName = planName;
		}

		public virtual int getPlanId()
		{
			return planId;
		}

		public virtual void setPlanId(int planId)
		{
			this.planId = planId;
		}

		public virtual double getPrice()
		{
			return price;
		}

		public virtual void setPrice(double price)
		{
			this.price = price;
		}

		public virtual string getProductName()
		{
			return productName;
		}

		public virtual void setProductName(string productName)
		{
			this.productName = productName;
		}

		public virtual int getProductId()
		{
			return productId;
		}

		public virtual void setProductId(int productId)
		{
			this.productId = productId;
		}
	}
}
