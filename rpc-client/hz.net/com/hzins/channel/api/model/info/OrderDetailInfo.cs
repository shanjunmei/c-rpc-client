using Sharpen;

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 投保单信�?
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-5-5 下午8:14:55</date>
	/// <version/>
	public class OrderDetailInfo
	{
		private string insureNum;

		private int payState;

		private int issueState;

		private int effectiveState;

		private string insureTime;

		private int totalNum;

		private double price;

		private string productName;

		private string planName;

		private string startDate;

		private string endDate;

		private string deadline;

		private string companyName;

		private string applicant;

		private string insurant;

		// 保单类型�?2待完成，3未支付，4已支�?
		// (1 未支�?;10 未出�?;20 已出�?;30 延时出单;40 取消出单)
		// 生效�?(1 未生�?;2 已生�?;3 已�??�? 21 �?保中)
		// 投保时间
		// 总份�?
		// 价格
		// 起保时间
		// 截止时间
		// 保险期限
		// 保险公司名称
		// 投保人姓�?
		// 被保险人姓名
		public virtual int getIssueState()
		{
			return issueState;
		}

		public virtual void setIssueState(int issueState)
		{
			this.issueState = issueState;
		}

		public virtual int getEffectiveState()
		{
			return effectiveState;
		}

		public virtual void setEffectiveState(int effectiveState)
		{
			this.effectiveState = effectiveState;
		}

		public virtual string getInsureNum()
		{
			return insureNum;
		}

		public virtual void setInsureNum(string insureNum)
		{
			this.insureNum = insureNum;
		}

		public virtual int getPayState()
		{
			return payState;
		}

		public virtual void setPayState(int payState)
		{
			this.payState = payState;
		}

		public virtual string getInsureTime()
		{
			return insureTime;
		}

		public virtual void setInsureTime(string insureTime)
		{
			this.insureTime = insureTime;
		}

		public virtual int getTotalNum()
		{
			return totalNum;
		}

		public virtual void setTotalNum(int totalNum)
		{
			this.totalNum = totalNum;
		}

		public virtual string getProductName()
		{
			return productName;
		}

		public virtual void setProductName(string productName)
		{
			this.productName = productName;
		}

		public virtual string getPlanName()
		{
			return planName;
		}

		public virtual void setPlanName(string planName)
		{
			this.planName = planName;
		}

		public virtual string getStartDate()
		{
			return startDate;
		}

		public virtual void setStartDate(string startDate)
		{
			this.startDate = startDate;
		}

		public virtual string getEndDate()
		{
			return endDate;
		}

		public virtual void setEndDate(string endDate)
		{
			this.endDate = endDate;
		}

		public virtual string getDeadline()
		{
			return deadline;
		}

		public virtual void setDeadline(string deadline)
		{
			this.deadline = deadline;
		}

		public virtual string getCompanyName()
		{
			return companyName;
		}

		public virtual void setCompanyName(string companyName)
		{
			this.companyName = companyName;
		}

		public virtual string getApplicant()
		{
			return applicant;
		}

		public virtual void setApplicant(string applicant)
		{
			this.applicant = applicant;
		}

		public virtual string getInsurant()
		{
			return insurant;
		}

		public virtual void setInsurant(string insurant)
		{
			this.insurant = insurant;
		}

		public virtual double getPrice()
		{
			return price;
		}

		public virtual void setPrice(double price)
		{
			this.price = price;
		}
	}
}
