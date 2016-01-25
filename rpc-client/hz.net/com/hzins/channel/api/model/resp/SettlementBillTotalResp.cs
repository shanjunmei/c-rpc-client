using Sharpen;

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 结算申请返回
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?6�?12�? 下午7:12:25</date>
	/// <version></version>
	public class SettlementBillTotalResp
	{
		private string transNo;

		private int partnerId;

		private double payed;

		private double unPayed;

		private double allowPayed;

		//已结�?
		//未结�?
		//当前可结�?(不会根据时间条件查询)
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

		public virtual double getPayed()
		{
			return payed;
		}

		public virtual void setPayed(double payed)
		{
			this.payed = payed;
		}

		public virtual double getUnPayed()
		{
			return unPayed;
		}

		public virtual void setUnPayed(double unPayed)
		{
			this.unPayed = unPayed;
		}

		public virtual double getAllowPayed()
		{
			return allowPayed;
		}

		public virtual void setAllowPayed(double allowPayed)
		{
			this.allowPayed = allowPayed;
		}
	}
}
