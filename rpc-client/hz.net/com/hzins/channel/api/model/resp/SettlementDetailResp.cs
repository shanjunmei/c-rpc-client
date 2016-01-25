using Sharpen;

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 服务费明细返回实�?
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?6�?12�? 上午9:40:12</date>
	/// <version></version>
	public class SettlementDetailResp
	{
		private string transNo;

		private int partnerId;

		private int pageNum;

		private int pageSize;

		private int total;

		private System.Collections.Generic.IList<com.hzins.channel.api.model.info.SettlementDetailInfo
			> settlementDetailList;

		//流水�?
		//代理商编�?
		//    private int pageIndex;
		//服务费明细信�?
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

		public virtual System.Collections.Generic.IList<com.hzins.channel.api.model.info.SettlementDetailInfo
			> getSettlementDetailList()
		{
			return settlementDetailList;
		}

		public virtual void setSettlementDetailList(System.Collections.Generic.IList<com.hzins.channel.api.model.info.SettlementDetailInfo
			> settlementDetailList)
		{
			this.settlementDetailList = settlementDetailList;
		}

		public virtual int getPageNum()
		{
			return pageNum;
		}

		public virtual void setPageNum(int pageNum)
		{
			this.pageNum = pageNum;
		}

		public virtual int getPageSize()
		{
			return pageSize;
		}

		public virtual void setPageSize(int pageSize)
		{
			this.pageSize = pageSize;
		}

		public virtual int getTotal()
		{
			return total;
		}

		public virtual void setTotal(int total)
		{
			this.total = total;
		}
		//    public int getPageIndex() {
		//        return pageIndex;
		//    }
		//
		//
		//    
		//    public void setPageIndex(int pageIndex) {
		//        this.pageIndex = pageIndex;
		//    }
	}
}
