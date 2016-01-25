

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-5-5 下午7:57:02</date>
	/// <version/>
	public class OrderDetailReq
	{
		private string transNo;

		private int partnerId;

		private string insureNum;

		private string sign;

		private string userId;

		private string idCard;

		private string email;

		private int pageNum;

		private int pageSize;

		// 投保人证件号
		// 投保人邮�?
		// 当前�?
		// 每页显示数据
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

		public virtual string getInsureNum()
		{
			return insureNum;
		}

		public virtual string getIdCard()
		{
			return idCard;
		}

		public virtual void setIdCard(string idCard)
		{
			this.idCard = idCard;
		}

		public virtual string getEmail()
		{
			return email;
		}

		public virtual void setEmail(string email)
		{
			this.email = email;
		}

		public virtual void setInsureNum(string insureNum)
		{
			this.insureNum = insureNum;
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
	}
}
