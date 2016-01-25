

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 寿险健康险专用实体（旅意险不考虑�?
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-11-5 下午5:57:15</date>
	/// <version/>
	public class HealthInfo
	{
		private string insurePassword;

		private string backPayAccount;

		private string backPayName;

		private int backPayBank;

		private string backPayBankName;

		private double insuredYearlyIncome;

		private int renewalPayBank;

		private string renewalPayBankName;

		private string renewalPayName;

		private string renewalPayAccount;

		private int notifyAnswerId;

		//保单密码
		// 持卡人卡�?
		// 持卡人姓�?
		// 赎回银行ID
		// 赎回银行名称
		// 年收�?
		//续期缴费银行
		//续期缴费银行名称
		//续期缴费户名
		//续期缴费账号
		//健康告知ID
		public virtual string getInsurePassword()
		{
			return insurePassword;
		}

		public virtual void setInsurePassword(string insurePassword)
		{
			this.insurePassword = insurePassword;
		}

		public virtual string getBackPayAccount()
		{
			return backPayAccount;
		}

		public virtual void setBackPayAccount(string backPayAccount)
		{
			this.backPayAccount = backPayAccount;
		}

		public virtual string getBackPayName()
		{
			return backPayName;
		}

		public virtual void setBackPayName(string backPayName)
		{
			this.backPayName = backPayName;
		}

		public virtual int getBackPayBank()
		{
			return backPayBank;
		}

		public virtual void setBackPayBank(int backPayBank)
		{
			this.backPayBank = backPayBank;
		}

		public virtual string getBackPayBankName()
		{
			return backPayBankName;
		}

		public virtual void setBackPayBankName(string backPayBankName)
		{
			this.backPayBankName = backPayBankName;
		}

		public virtual double getInsuredYearlyIncome()
		{
			return insuredYearlyIncome;
		}

		public virtual void setInsuredYearlyIncome(double insuredYearlyIncome)
		{
			this.insuredYearlyIncome = insuredYearlyIncome;
		}

		public virtual int getRenewalPayBank()
		{
			return renewalPayBank;
		}

		public virtual void setRenewalPayBank(int renewalPayBank)
		{
			this.renewalPayBank = renewalPayBank;
		}

		public virtual string getRenewalPayBankName()
		{
			return renewalPayBankName;
		}

		public virtual void setRenewalPayBankName(string renewalPayBankName)
		{
			this.renewalPayBankName = renewalPayBankName;
		}

		public virtual string getRenewalPayName()
		{
			return renewalPayName;
		}

		public virtual void setRenewalPayName(string renewalPayName)
		{
			this.renewalPayName = renewalPayName;
		}

		public virtual string getRenewalPayAccount()
		{
			return renewalPayAccount;
		}

		public virtual void setRenewalPayAccount(string renewalPayAccount)
		{
			this.renewalPayAccount = renewalPayAccount;
		}

		public virtual int getNotifyAnswerId()
		{
			return notifyAnswerId;
		}

		public virtual void setNotifyAnswerId(int notifyAnswerId)
		{
			this.notifyAnswerId = notifyAnswerId;
		}
	}
}
