

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
        public string transNo { get; set; }

        public int partnerId { get; set; }

        public string sign { get; set; }

        public string userId { get; set; }

    }
}
