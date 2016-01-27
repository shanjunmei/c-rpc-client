

namespace com.hzins.channel.api.model.common
{
    /// <summary>
    /// <p>
    /// 统一返回对象
    /// </p>
    /// </summary>
    /// <author>李淼淼</author>
    /// <date>2016-01-07 上午11:50:55</date>
    /// <version/>
    public class CommonResult<T>
    {
        private int _respCode;

        private string _respMsg;

        private T _data;

        public int respCode
        {
            set { _respCode = value; }
            get { return _respCode; }
        }

        public string respMsg
        {
            set { _respMsg = value; }
            get { return _respMsg; }
        }

        public T data
        {
            set { _data = value; }
            get { return _data; }
        }

    }
}
