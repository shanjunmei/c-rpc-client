

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 第三方投保对接投保请求消�?
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-11-5 下午5:56:55</date>
	/// <version/>
	public class OrderApplyReq
	{
		private string transNo;

		private string caseCode;

		private int partnerId;

		private string sign;

		private com.hzins.channel.api.model.ApplicationData applicationData;

		private com.hzins.channel.api.model.info.ApplicantInfo applicantInfo;

		private System.Collections.Generic.IList<com.hzins.channel.api.model.info.InsurantInfo
			> insurantInfos;

		private com.hzins.channel.api.model.info.ExtendInfo extendInfo;

		private com.hzins.channel.api.model.info.HealthInfo healthInfo;

		private System.Collections.Generic.IList<com.hzins.channel.api.model.info.InsureBeneficiaryInfo
			> insureBenfInfos;

		private com.hzins.channel.api.model.info.CalculatePriceDataInfo calculatePriceDataInfo;

		// 交易流水号，每一单请求交易不能相�?
		// 方案代码，每�?款保险公司的方案代码都不相同，由慧择分配
		// 代理商编�?
		// 数字签名
		// 订单数据
		// 投保人信�?
		// 被保人信�?
		// 扩展信息
		//寿险健康险专用实�?
		//寿险投保受益人实体类
		//寿险健康险需加入的试算实体类
		public virtual com.hzins.channel.api.model.info.CalculatePriceDataInfo getCalculatePriceDataInfo
			()
		{
			return calculatePriceDataInfo;
		}

		public virtual void setCalculatePriceDataInfo(com.hzins.channel.api.model.info.CalculatePriceDataInfo
			 calculatePriceDataInfo)
		{
			this.calculatePriceDataInfo = calculatePriceDataInfo;
		}

		public virtual System.Collections.Generic.IList<com.hzins.channel.api.model.info.InsureBeneficiaryInfo
			> getInsureBenfInfos()
		{
			return insureBenfInfos;
		}

		public virtual void setInsureBenfInfos(System.Collections.Generic.IList<com.hzins.channel.api.model.info.InsureBeneficiaryInfo
			> insureBenfInfos)
		{
			this.insureBenfInfos = insureBenfInfos;
		}

		public virtual com.hzins.channel.api.model.info.HealthInfo getHealthInfo()
		{
			return healthInfo;
		}

		public virtual void setHealthInfo(com.hzins.channel.api.model.info.HealthInfo healthInfo
			)
		{
			this.healthInfo = healthInfo;
		}

		public virtual string getCaseCode()
		{
			return caseCode;
		}

		public virtual void setCaseCode(string caseCode)
		{
			this.caseCode = caseCode;
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

		public virtual string getSign()
		{
			return sign;
		}

		public virtual void setSign(string sign)
		{
			this.sign = sign;
		}

		public virtual com.hzins.channel.api.model.ApplicationData getApplicationData()
		{
			return applicationData;
		}

		public virtual void setApplicationData(com.hzins.channel.api.model.ApplicationData
			 applicationData)
		{
			this.applicationData = applicationData;
		}

		public virtual com.hzins.channel.api.model.info.ApplicantInfo getApplicantInfo()
		{
			return applicantInfo;
		}

		public virtual void setApplicantInfo(com.hzins.channel.api.model.info.ApplicantInfo
			 applicantInfo)
		{
			this.applicantInfo = applicantInfo;
		}

		public virtual System.Collections.Generic.IList<com.hzins.channel.api.model.info.InsurantInfo
			> getInsurantInfos()
		{
			return insurantInfos;
		}

		public virtual void setInsurantInfos(System.Collections.Generic.IList<com.hzins.channel.api.model.info.InsurantInfo
			> insurantInfos)
		{
			this.insurantInfos = insurantInfos;
		}

		public virtual com.hzins.channel.api.model.info.ExtendInfo getExtendInfo()
		{
			return extendInfo;
		}

		public virtual void setExtendInfo(com.hzins.channel.api.model.info.ExtendInfo extendInfo
			)
		{
			this.extendInfo = extendInfo;
		}
	}
}
