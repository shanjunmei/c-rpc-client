using Sharpen;

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 结算申请请求信息
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?6�?12�? 下午6:58:30</date>
	/// <version></version>
	public class SettlementBillDetailReq
	{
		private string transNo;

		private int billId;

		private int partnerId;

		private string userId;

		private string startTime;

		private string endTime;

		private string sign;

		//流水号，每次请求不相�?
		//申请服务费结算之后的settlementBill数据的Id
		//代理商ID
		//渠道唯一的标�?
		//查询的申请结算开始时�?
		//查询的申请结算结束时�?
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

		public virtual string getSign()
		{
			return sign;
		}

		public virtual void setSign(string sign)
		{
			this.sign = sign;
		}

		public virtual string getUserId()
		{
			return userId;
		}

		public virtual void setUserId(string userId)
		{
			this.userId = userId;
		}

		public virtual int getBillId()
		{
			return billId;
		}

		public virtual void setBillId(int billId)
		{
			this.billId = billId;
		}
	}
}
