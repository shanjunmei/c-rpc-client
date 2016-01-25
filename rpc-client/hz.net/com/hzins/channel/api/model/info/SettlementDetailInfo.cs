

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 服务费明细信�?
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?6�?12�? 下午3:49:50</date>
	/// <version></version>
	public class SettlementDetailInfo
	{
		private string email;

		private string payDateTime;

		private string insureNum;

		private string productName;

		private double originalPrice;

		private double price;

		private double income;

		public virtual string getEmail()
		{
			return email;
		}

		public virtual void setEmail(string email)
		{
			this.email = email;
		}

		public virtual string getInsureNum()
		{
			return insureNum;
		}

		public virtual void setInsureNum(string insureNum)
		{
			this.insureNum = insureNum;
		}

		public virtual string getProductName()
		{
			return productName;
		}

		public virtual void setProductName(string productName)
		{
			this.productName = productName;
		}

		public virtual double getOriginalPrice()
		{
			return originalPrice;
		}

		public virtual void setOriginalPrice(double originalPrice)
		{
			this.originalPrice = originalPrice;
		}

		public virtual double getPrice()
		{
			return price;
		}

		public virtual void setPrice(double price)
		{
			this.price = price;
		}

		public virtual double getIncome()
		{
			return income;
		}

		public virtual void setIncome(double income)
		{
			this.income = income;
		}

		public virtual string getPayDateTime()
		{
			return payDateTime;
		}

		public virtual void setPayDateTime(string payDateTime)
		{
			this.payDateTime = payDateTime;
		}
	}
}
