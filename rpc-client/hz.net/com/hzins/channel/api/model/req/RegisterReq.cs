using Sharpen;

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-5-8 上午11:32:45</date>
	/// <version/>
	[System.Serializable]
	public class RegisterReq
	{
		private const long serialVersionUID = 7431287304382522749L;

		private string transNo;

		private int partnerId;

		private int channelType;

		private int webType;

		private string userId;

		private string email;

		private string loginPassWord;

		private string contactName;

		private string contactNumber;

		private string sign;

		private int feetemplateId;

		private string expandEmployeeName;

		private int expandEmployeeId;

		private string companyCode;

		private string companyName;

		// 渠道类型 0：个�? 1：公�?  (必填)
		// 1:户外=1 2:旅行�? 3:签证机构 4:旅游网站 0:其他(必填)
		// 渠道在agent中唯�?的标示，存放到数据库的CardNumber字段
		// 邮箱
		// 登陆密码
		// 联系�? 必填
		// 联系电话 必填
		//数字签名
		//渠道服务费模板Id(非必�?)
		//拓展人员名字
		//拓展人员ID
		//公司代码
		//公司名称
		public virtual string getCompanyCode()
		{
			return companyCode;
		}

		public virtual void setCompanyCode(string companyCode)
		{
			this.companyCode = companyCode;
		}

		public virtual string getCompanyName()
		{
			return companyName;
		}

		public virtual void setCompanyName(string companyName)
		{
			this.companyName = companyName;
		}

		public virtual string getExpandEmployeeName()
		{
			return expandEmployeeName;
		}

		public virtual void setExpandEmployeeName(string expandEmployeeName)
		{
			this.expandEmployeeName = expandEmployeeName;
		}

		public virtual int getExpandEmployeeId()
		{
			return expandEmployeeId;
		}

		public virtual void setExpandEmployeeId(int expandEmployeeId)
		{
			this.expandEmployeeId = expandEmployeeId;
		}

		public virtual int getFeetemplateId()
		{
			return feetemplateId;
		}

		public virtual void setFeetemplateId(int feetemplateId)
		{
			this.feetemplateId = feetemplateId;
		}

		public virtual string getSign()
		{
			return sign;
		}

		public virtual void setSign(string sign)
		{
			this.sign = sign;
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

		public virtual int getChannelType()
		{
			return channelType;
		}

		public virtual void setChannelType(int channelType)
		{
			this.channelType = channelType;
		}

		public virtual int getWebType()
		{
			return webType;
		}

		public virtual void setWebType(int webType)
		{
			this.webType = webType;
		}

		public virtual string getUserId()
		{
			return userId;
		}

		public virtual void setUserId(string userId)
		{
			this.userId = userId;
		}

		public virtual string getEmail()
		{
			return email;
		}

		public virtual void setEmail(string email)
		{
			this.email = email;
		}

		public virtual string getLoginPassWord()
		{
			return loginPassWord;
		}

		public virtual void setLoginPassWord(string loginPassWord)
		{
			this.loginPassWord = loginPassWord;
		}

		public virtual string getContactName()
		{
			return contactName;
		}

		public virtual void setContactName(string contactName)
		{
			this.contactName = contactName;
		}

		public virtual string getContactNumber()
		{
			return contactNumber;
		}

		public virtual void setContactNumber(string contactNumber)
		{
			this.contactNumber = contactNumber;
		}
	}
}
