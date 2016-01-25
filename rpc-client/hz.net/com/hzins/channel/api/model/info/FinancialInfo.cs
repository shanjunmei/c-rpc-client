

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// api服务费提现财务信息实�?
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-6-3 下午5:24:47</date>
	/// <version></version>
	public class FinancialInfo
	{
		private int accountType;

		private string bankName;

		private string accountName;

		private string bankAccount;

		private string aliPayAccount;

		private short sex;

		private string cardnumber;

		private string provinces;

		private string city;

		private string unit;

		private string address;

		private string zipcode;

		private string bankProvince;

		private string bankCity;

		private string bankBranchName;

		//账户类型�?0银行�?1支付�?,2未设置，3会员�?10其它
		//�?户行
		//户名
		//银行账号
		//支付宝账�?
		//性别
		//身份证号�?
		//户籍�?在地省份
		//户籍�?在地城市
		//工作单位
		//通讯地址
		//邮政编码
		//�?户行�?在省
		//�?户行�?在城�?
		//�?户行分行支行
		public virtual int getAccountType()
		{
			return accountType;
		}

		public virtual void setAccountType(int accountType)
		{
			this.accountType = accountType;
		}

		public virtual string getBankName()
		{
			return bankName;
		}

		public virtual void setBankName(string bankName)
		{
			this.bankName = bankName;
		}

		public virtual string getAccountName()
		{
			return accountName;
		}

		public virtual void setAccountName(string accountName)
		{
			this.accountName = accountName;
		}

		public virtual string getBankAccount()
		{
			return bankAccount;
		}

		public virtual void setBankAccount(string bankAccount)
		{
			this.bankAccount = bankAccount;
		}

		public virtual string getAliPayAccount()
		{
			return aliPayAccount;
		}

		public virtual void setAliPayAccount(string aliPayAccount)
		{
			this.aliPayAccount = aliPayAccount;
		}

		public virtual short getSex()
		{
			return sex;
		}

		public virtual void setSex(short sex)
		{
			this.sex = sex;
		}

		public virtual string getCardnumber()
		{
			return cardnumber;
		}

		public virtual void setCardnumber(string cardnumber)
		{
			this.cardnumber = cardnumber;
		}

		public virtual string getProvinces()
		{
			return provinces;
		}

		public virtual void setProvinces(string provinces)
		{
			this.provinces = provinces;
		}

		public virtual string getCity()
		{
			return city;
		}

		public virtual void setCity(string city)
		{
			this.city = city;
		}

		public virtual string getUnit()
		{
			return unit;
		}

		public virtual void setUnit(string unit)
		{
			this.unit = unit;
		}

		public virtual string getAddress()
		{
			return address;
		}

		public virtual void setAddress(string address)
		{
			this.address = address;
		}

		public virtual string getZipcode()
		{
			return zipcode;
		}

		public virtual void setZipcode(string zipcode)
		{
			this.zipcode = zipcode;
		}

		public virtual string getBankProvince()
		{
			return bankProvince;
		}

		public virtual void setBankProvince(string bankProvince)
		{
			this.bankProvince = bankProvince;
		}

		public virtual string getBankCity()
		{
			return bankCity;
		}

		public virtual void setBankCity(string bankCity)
		{
			this.bankCity = bankCity;
		}

		public virtual string getBankBranchName()
		{
			return bankBranchName;
		}

		public virtual void setBankBranchName(string bankBranchName)
		{
			this.bankBranchName = bankBranchName;
		}
	}
}
