using Sharpen;

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 保单查询返回信息
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-5-5 下午2:48:45</date>
	/// <version></version>
	public class InsureDetailResp
	{
		private com.hzins.channel.api.model.info.ApplicantInfo applicantInfo;

		private System.Collections.Generic.IList<com.hzins.channel.api.model.info.InsurantInfo
			> insurantInfos;

		private com.hzins.channel.api.model.info.PolicyDetailInfo policyDetailInfo;

		private string contact;

		private string contactMob;

		private string companyName;

		private string prodName;

		private string transNo;

		private int partnerId;

		private string insureNum;

		// 投保人信�?
		// 被保险人信息
		// 保单明细
		// 紧�?�联系人
		// 紧�?�联系人电话
		// 保险公司名称
		// 产品名称
		//流水�?
		//渠道�?
		//投保单号
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

		public virtual com.hzins.channel.api.model.info.PolicyDetailInfo getPolicyDetailInfo
			()
		{
			return policyDetailInfo;
		}

		public virtual void setPolicyDetailInfo(com.hzins.channel.api.model.info.PolicyDetailInfo
			 policyDetailInfo)
		{
			this.policyDetailInfo = policyDetailInfo;
		}

		public virtual string getContact()
		{
			return contact;
		}

		public virtual void setContact(string contact)
		{
			this.contact = contact;
		}

		public virtual string getContactMob()
		{
			return contactMob;
		}

		public virtual void setContactMob(string contactMob)
		{
			this.contactMob = contactMob;
		}

		public virtual string getCompanyName()
		{
			return companyName;
		}

		public virtual void setCompanyName(string companyName)
		{
			this.companyName = companyName;
		}

		public virtual string getProdName()
		{
			return prodName;
		}

		public virtual void setProdName(string prodName)
		{
			this.prodName = prodName;
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

		public virtual void setInsureNum(string insureNum)
		{
			this.insureNum = insureNum;
		}
	}
}
