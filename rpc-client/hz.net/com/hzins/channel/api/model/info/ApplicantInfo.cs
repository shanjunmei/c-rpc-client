

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 投保人信息
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-2 下午5:46:53</date>
	/// <version></version>
	public class ApplicantInfo
	{
		private string cName;

		private string eName;

		private int cardType;

		private string cardCode;

		private int sex;

		private string birthday;

		private string mobile;

		private string email;

		private string jobInfo;

		private string country;

		// 投保人姓名
		// 投保人英文名，境外险必填
		// 投保人证件类型
		// 证件号码
		// 性别 0女 1男
		// 出生日期
		// 手机号码
		// 电子邮箱
		// 职业信息
		//国籍
		public virtual string getCountry()
		{
			return country;
		}

		public virtual void setCountry(string country)
		{
			this.country = country;
		}

		public virtual string getcName()
		{
			return cName;
		}

		public virtual void setcName(string cName)
		{
			this.cName = cName;
		}

		public virtual string geteName()
		{
			return eName;
		}

		public virtual void seteName(string eName)
		{
			this.eName = eName;
		}

		public virtual int getCardType()
		{
			return cardType;
		}

		public virtual void setCardType(int cardType)
		{
			this.cardType = cardType;
		}

		public virtual string getCardCode()
		{
			return cardCode;
		}

		public virtual void setCardCode(string cardCode)
		{
			this.cardCode = cardCode;
		}

		public virtual int getSex()
		{
			return sex;
		}

		public virtual void setSex(int sex)
		{
			this.sex = sex;
		}

		public virtual string getBirthday()
		{
			return birthday;
		}

		public virtual void setBirthday(string birthday)
		{
			this.birthday = birthday;
		}

		public virtual string getMobile()
		{
			return mobile;
		}

		public virtual void setMobile(string mobile)
		{
			this.mobile = mobile;
		}

		public virtual string getEmail()
		{
			return email;
		}

		public virtual void setEmail(string email)
		{
			this.email = email;
		}

		public virtual string getJobInfo()
		{
			return jobInfo;
		}

		public virtual void setJobInfo(string jobInfo)
		{
			this.jobInfo = jobInfo;
		}
	}
}
