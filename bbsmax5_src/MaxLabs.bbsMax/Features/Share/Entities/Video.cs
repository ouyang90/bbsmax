﻿//
// 请注意：bbsmax 不是一个免费产品，源代码仅限用于学习，禁止用于商业站点或者其他商业用途
// 如果您要将bbsmax用于商业用途，需要从官方购买商业授权，得到授权后可以基于源代码二次开发
//
// 版权所有 厦门麦斯网络科技有限公司
// 公司网站 www.bbsmax.com
//

using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using MaxLabs.bbsMax.DataAccess;
using System.Collections;

namespace MaxLabs.bbsMax.Entities 
{
    /// <summary>
    /// 视频信息
    /// </summary>
    public class Video
    {

        public Video()
        { }


        /// <summary>
        /// 视频网页地址
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// 视频标志
        /// </summary>
        public string VideoID { get; set; }

        /// <summary>
        /// 网址域名（用来标志是哪个网站的视频）
        /// </summary>
        public string Domain { get; set; }

        public string ImgUrl { get; set; }

    }

}