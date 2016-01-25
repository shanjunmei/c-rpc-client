

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-5-11 上午11:14:17</date>
	/// <version></version>
	public class ExtendInfo
	{
		private string userId;

		private string email;

		private string userName;

		private string phone;

		// 用户在代理商系统中的唯一标识
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

		public virtual string getUserName()
		{
			return userName;
		}

		public virtual void setUserName(string userName)
		{
			this.userName = userName;
		}

		public virtual string getPhone()
		{
			return phone;
		}

		public virtual void setPhone(string phone)
		{
			this.phone = phone;
		}
	}
}
