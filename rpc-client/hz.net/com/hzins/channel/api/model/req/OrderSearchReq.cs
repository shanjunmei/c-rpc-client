

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-7-24 下午7:57:02</date>
	/// <version/>
	public class OrderSearchReq
	{
		private int partnerId;

		private string transNo;

		private string sign;

		private int pageNum;

		private int pageSize;

		private string startTime;

		private string endTime;

		private string applicant;

		private string insurant;

		private string idCard;

		private string userId;

		private System.Collections.Generic.IList<string> insureNums;

		// 代理商编�?
		// 交易流水号，每一单请求交易不能相�?
		// 数字签名
		// 当前�?
		// 每页显示数据
		//投保�?始时�?
		//投保结束时间
		//投保人姓�?
		//被保险人姓名
		//投保人证件号�?
		//userId
		// 多个投保单号
		public virtual System.Collections.Generic.IList<string> getInsureNums()
		{
			return insureNums;
		}

		public virtual void setInsureNums(System.Collections.Generic.IList<string> insureNums
			)
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

		public virtual string getIdCard()
		{
			return idCard;
		}

		public virtual void setIdCard(string idCard)
		{
			this.idCard = idCard;
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

		public virtual int getPartnerId()
		{
			return partnerId;
		}

		public virtual void setPartnerId(int partnerId)
		{
			this.partnerId = partnerId;
		}

		public virtual string getTransNo()
		{
			return transNo;
		}

		public virtual void setTransNo(string transNo)
		{
			this.transNo = transNo;
		}

		public virtual string getSign()
		{
			return sign;
		}

		public virtual void setSign(string sign)
		{
			this.sign = sign;
		}
	}
}
