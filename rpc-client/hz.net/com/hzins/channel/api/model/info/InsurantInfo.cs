using Sharpen;

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 被保人信�?
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-2 下午5:51:54</date>
	/// <version></version>
	public class InsurantInfo
	{
		private string insurantId;

		private string cName;

		private string eName;

		private int cardType;

		private string cardCode;

		private int sex;

		private string birthday;

		private string fltNo;

		private string fltDate;

		private string city;

		private int tripPurposeId;

		private string destination;

		private string visaCity;

		private int relationId;

		private int count;

		private string jobInfo;

		private string mobile;

		private double singlePrice;

		private string country;

		// 被保人ID，由代理商传�?
		// 被保人姓�?
		// 被保人英文名，境外险必填
		// 被保人证件类�?
		// 证件号码
		// 性别 0�?1�?
		// 出生日期
		// 航班号，航意险必�?
		// 起飞时间，航意险必填
		// �?在地区代码，由慧择分配，特定产品必填
		// 出行目的，特定产品必�?
		// 出行目的地，特定产品必填
		// 签证办理城市，特定产品必�?
		// 被保人与投保人关�?
		// 购买份数
		// 职业信息
		// 手机号码
		// 结算价，即相应保险产品的保费
		//国籍
		public virtual string getCountry()
		{
			return country;
		}

		public virtual void setCountry(string country)
		{
			this.country = country;
		}

		public virtual double getSinglePrice()
		{
			return singlePrice;
		}

		public virtual void setSinglePrice(double singlePrice)
		{
			this.singlePrice = singlePrice;
		}

		public virtual string getInsurantId()
		{
			return insurantId;
		}

		public virtual void setInsurantId(string insurantId)
		{
			this.insurantId = insurantId;
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

		public virtual string getFltNo()
		{
			return fltNo;
		}

		public virtual void setFltNo(string fltNo)
		{
			this.fltNo = fltNo;
		}

		public virtual string getFltDate()
		{
			return fltDate;
		}

		public virtual void setFltDate(string fltDate)
		{
			this.fltDate = fltDate;
		}

		public virtual string getCity()
		{
			return city;
		}

		public virtual void setCity(string city)
		{
			this.city = city;
		}

		public virtual int getTripPurposeId()
		{
			return tripPurposeId;
		}

		public virtual void setTripPurposeId(int tripPurposeId)
		{
			this.tripPurposeId = tripPurposeId;
		}

		public virtual string getDestination()
		{
			return destination;
		}

		public virtual void setDestination(string destination)
		{
			this.destination = destination;
		}

		public virtual string getVisaCity()
		{
			return visaCity;
		}

		public virtual void setVisaCity(string visaCity)
		{
			this.visaCity = visaCity;
		}

		public virtual int getRelationId()
		{
			return relationId;
		}

		public virtual void setRelationId(int insurantRelation)
		{
			this.relationId = insurantRelation;
		}

		public virtual int getCount()
		{
			return count;
		}

		public virtual void setCount(int count)
		{
			this.count = count;
		}

		public virtual string getJobInfo()
		{
			return jobInfo;
		}

		public virtual void setJobInfo(string jobInfo)
		{
			this.jobInfo = jobInfo;
		}

		public virtual string getMobile()
		{
			return mobile;
		}

		public virtual void setMobile(string mobile)
		{
			this.mobile = mobile;
		}
	}
}
