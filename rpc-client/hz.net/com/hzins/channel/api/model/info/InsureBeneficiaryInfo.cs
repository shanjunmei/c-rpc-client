

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 寿险投保受益人实体类
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-11-5 下午1:46:08</date>
	/// <version/>
	public class InsureBeneficiaryInfo
	{
		private string birthdate;

		private string cardNumber;

		private int cardTypeId;

		private string cName;

		private int relationId;

		private short serial;

		private bool sex;

		private double proportion;

		//受益人生�?
		//证件号码
		//证件类型
		//受益人名�?
		//与被保人关系
		//受益人顺�?
		//受益人比�?
		public virtual string getBirthdate()
		{
			return birthdate;
		}

		public virtual void setBirthdate(string birthdate)
		{
			this.birthdate = birthdate;
		}

		public virtual string getCardNumber()
		{
			return cardNumber;
		}

		public virtual void setCardNumber(string cardNumber)
		{
			this.cardNumber = cardNumber;
		}

		public virtual int getCardTypeId()
		{
			return cardTypeId;
		}

		public virtual void setCardTypeId(int cardTypeId)
		{
			this.cardTypeId = cardTypeId;
		}

		public virtual string getcName()
		{
			return cName;
		}

		public virtual void setcName(string cName)
		{
			this.cName = cName;
		}

		public virtual int getRelationId()
		{
			return relationId;
		}

		public virtual void setRelationId(int relationId)
		{
			this.relationId = relationId;
		}

		public virtual short getSerial()
		{
			return serial;
		}

		public virtual void setSerial(short serial)
		{
			this.serial = serial;
		}

		public virtual bool isSex()
		{
			return sex;
		}

		public virtual void setSex(bool sex)
		{
			this.sex = sex;
		}

		public virtual double getProportion()
		{
			return proportion;
		}

		public virtual void setProportion(double proportion)
		{
			this.proportion = proportion;
		}
	}
}
