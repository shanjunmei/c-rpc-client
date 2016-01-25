using Sharpen;

namespace com.hzins.channel.api.model.common
{
	/// <summary>
	/// <p>
	/// 统一返回对象
	/// </p>
	/// </summary>
	/// <author>李淼�?</author>
	/// <date>2016�?1�?7�? 上午11:50:55</date>
	/// <version/>
	public class CommonResult<T>
	{
		private int respCode;

		private string respMsg;

		private T data;

		public CommonResult()
		{
		}

		public virtual int getRespCode()
		{
			return respCode;
		}

		public virtual void setRespCode(int respCode)
		{
			this.respCode = respCode;
		}

		public virtual string getRespMsg()
		{
			return respMsg;
		}

		public virtual void setRespMsg(string respMsg)
		{
			this.respMsg = respMsg;
		}

		public virtual T getData()
		{
			return data;
		}

		public virtual void setData(T data)
		{
			this.data = data;
		}
	}
}
