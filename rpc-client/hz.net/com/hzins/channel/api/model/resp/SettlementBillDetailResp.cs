

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
	public class SettlementBillDetailResp
	{
		private string transNo;

		private int partnerId;

		private System.Collections.Generic.IList<com.hzins.channel.api.model.info.SettlementBillDetailInfo
			> settlementBillDetails;

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

		public virtual System.Collections.Generic.IList<com.hzins.channel.api.model.info.SettlementBillDetailInfo
			> getSettlementBillDetails()
		{
			return settlementBillDetails;
		}

		public virtual void setSettlementBillDetails(System.Collections.Generic.IList<com.hzins.channel.api.model.info.SettlementBillDetailInfo
			> settlementBillDetails)
		{
			this.settlementBillDetails = settlementBillDetails;
		}
	}
}
