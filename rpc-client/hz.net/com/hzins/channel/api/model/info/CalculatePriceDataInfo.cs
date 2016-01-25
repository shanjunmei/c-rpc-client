using Sharpen;

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 寿险健康险需加入的试算实体类
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-11-7 下午7:58:39</date>
	/// <version></version>
	public class CalculatePriceDataInfo
	{
		private string optionValue;

		private int paymentLimit;

		private int insurancePeriod;

		private int insuranceUnit;

		private double insuranceAmount;

		//保证项目选项�?(暂时不传)
		//缴费期限 �?次�?�缴或�?�趸�? �?0
		//保障期限
		//保障期限单位 1为年 2为岁
		//保险金额
		public virtual string getOptionValue()
		{
			return optionValue;
		}

		public virtual void setOptionValue(string optionValue)
		{
			this.optionValue = optionValue;
		}

		public virtual int getPaymentLimit()
		{
			return paymentLimit;
		}

		public virtual void setPaymentLimit(int paymentLimit)
		{
			this.paymentLimit = paymentLimit;
		}

		public virtual int getInsurancePeriod()
		{
			return insurancePeriod;
		}

		public virtual void setInsurancePeriod(int insurancePeriod)
		{
			this.insurancePeriod = insurancePeriod;
		}

		public virtual int getInsuranceUnit()
		{
			return insuranceUnit;
		}

		public virtual void setInsuranceUnit(int insuranceUnit)
		{
			this.insuranceUnit = insuranceUnit;
		}

		public virtual double getInsuranceAmount()
		{
			return insuranceAmount;
		}

		public virtual void setInsuranceAmount(double insuranceAmount)
		{
			this.insuranceAmount = insuranceAmount;
		}
	}
}
