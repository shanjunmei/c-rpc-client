

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 保单详情查询 保单明细（不包含保险人和被保险人�?
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-5-5 下午3:25:54</date>
	/// <version></version>
	public class PolicyDetailInfo
	{
		private int totalNum;

		private string deallineText;

		private double buySinglePrice;

		private double settlementPrice;

		private string insureProject;

		// 总份�?
		//生效时间区间
		// 支付�?
		// 结算�?
		//保障项目
		public virtual int getTotalNum()
		{
			return totalNum;
		}

		public virtual void setTotalNum(int totalNum)
		{
			this.totalNum = totalNum;
		}

		public virtual string getDeallineText()
		{
			return deallineText;
		}

		public virtual void setDeallineText(string deallineText)
		{
			this.deallineText = deallineText;
		}

		public virtual double getBuySinglePrice()
		{
			return buySinglePrice;
		}

		public virtual void setBuySinglePrice(double buySinglePrice)
		{
			this.buySinglePrice = buySinglePrice;
		}

		public virtual double getSettlementPrice()
		{
			return settlementPrice;
		}

		public virtual void setSettlementPrice(double settlementPrice)
		{
			this.settlementPrice = settlementPrice;
		}

		public virtual string getInsureProject()
		{
			return insureProject;
		}

		public virtual void setInsureProject(string insureProject)
		{
			this.insureProject = insureProject;
		}
	}
}
