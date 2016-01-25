

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 保单下载
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?5�?11�? 下午3:38:53</date>
	/// <version/>
	public class InsureDownloadResp
	{
		public string fileName;

		public long fileSize;

		public string contentType;

		public string data;

		public string transNo;

		// 文件�?
		// 文件大小
		// 类型
		// 文件�?
		//流水�?
		public virtual string getTransNo()
		{
			return transNo;
		}

		public virtual void setTransNo(string transNo)
		{
			this.transNo = transNo;
		}

		public virtual string getFileName()
		{
			return fileName;
		}

		public virtual void setFileName(string fileName)
		{
			this.fileName = fileName;
		}

		public virtual long getFileSize()
		{
			return fileSize;
		}

		public virtual void setFileSize(long fileSize)
		{
			this.fileSize = fileSize;
		}

		public virtual string getContentType()
		{
			return contentType;
		}

		public virtual void setContentType(string contentType)
		{
			this.contentType = contentType;
		}

		public virtual string getData()
		{
			return data;
		}

		public virtual void setData(string data)
		{
			this.data = data;
		}
	}
}
