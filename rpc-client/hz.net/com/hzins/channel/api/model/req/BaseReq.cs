

namespace com.hzins.channel.api.model.req
{
    /// <summary>
    /// <p>
    /// 第三方请求基�?�?
    /// </p>
    /// </summary>
    /// <author>hz15031081</author>
    /// <date>2015-4-2 下午5:10:35</date>
    /// <version></version>
    public abstract class BaseReq
    {
        private string _transNo;

        private int _partnerId;

        private string _sign;

        private string _userId;


        public string transNo
        {
            set { _transNo = value; }
            get { return _transNo; }
        }

        public int partnerId
        {

            set { _partnerId = value; }
            get { return _partnerId; }
        }

        public string sign
        {
            set { _sign = value; }
            get { return _sign; }
        }

        public string userId
        {
            set { _userId = value; }
            get { return _userId; }
        }
    }
}
