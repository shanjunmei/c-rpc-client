

namespace com.hzins.channel.api.model
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-11-4 下午12:48:04</date>
	/// <version></version>
	public class PlanDetail
	{
		internal string name;

		internal string text;

		public virtual string getName()
		{
			return name;
		}

		public virtual void setName(string name)
		{
			this.name = name;
		}

		public virtual string getText()
		{
			return text;
		}

		public virtual void setText(string text)
		{
			this.text = text;
		}
	}
}
