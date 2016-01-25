using Sharpen;

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 产品详情返回实体
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?5�?21�? 下午5:16:15</date>
	/// <version></version>
	public class ProductInfo
	{
		private int prodId;

		private string name;

		private string caseCode;

		private string companyName;

		private int planId;

		private string planName;

		public virtual int getProdId()
		{
			return prodId;
		}

		public virtual void setProdId(int prodId)
		{
			this.prodId = prodId;
		}

		public virtual string getName()
		{
			return name;
		}

		public virtual void setName(string name)
		{
			this.name = name;
		}

		public virtual string getCaseCode()
		{
			return caseCode;
		}

		public virtual void setCaseCode(string caseCode)
		{
			this.caseCode = caseCode;
		}

		public virtual string getCompanyName()
		{
			return companyName;
		}

		public virtual void setCompanyName(string companyName)
		{
			this.companyName = companyName;
		}

		public virtual int getPlanId()
		{
			return planId;
		}

		public virtual void setPlanId(int planId)
		{
			this.planId = planId;
		}

		public virtual string getPlanName()
		{
			return planName;
		}

		public virtual void setPlanName(string planName)
		{
			this.planName = planName;
		}
	}
}
