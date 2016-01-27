

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
        private int respCode { get; set; }

        private string respMsg{get;set;}

        private T data { get; set; }

       


    }
}
