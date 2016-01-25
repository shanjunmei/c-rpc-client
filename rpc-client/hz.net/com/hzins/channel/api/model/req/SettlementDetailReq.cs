

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 服务费明细请求信�?
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?6�?12�? 下午3:41:09</date>
	/// <version></version>
	public class SettlementDetailReq
	{
		private string transNo;

		private int partnerId;

		private string userId;

		private string insureNums;

		private string startTime;

		private string endTime;

		private int pageNum;

		private int pageSize;

		private string sign;

		//流水号，每次请求不相�?
		//代理商编�?
		//渠道唯一的标�?
		//投保单号(多个以英文�?�号隔开)
		//查询�?始时�?
		//查询结束时间
		//查询页数
		//每页数量
		//签名
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

		public virtual string getStartTime()
		{
			return startTime;
		}

		public virtual void setStartTime(string startTime)
		{
			this.startTime = startTime;
		}

		public virtual string getEndTime()
		{
			return endTime;
		}

		public virtual void setEndTime(string endTime)
		{
			this.endTime = endTime;
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

		public virtual string getSign()
		{
			return sign;
		}

		public virtual void setSign(string sign)
		{
			this.sign = sign;
		}

		public virtual string getInsureNums()
		{
			return insureNums;
		}

		public virtual void setInsureNums(string insureNums)
		{
			this.insureNums = insureNums;
		}

		public virtual string getUserId()
		{
			return userId;
		}

		public virtual void setUserId(string userId)
		{
			this.userId = userId;
		}
	}
}
