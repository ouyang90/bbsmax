﻿//
// 请注意：bbsmax 不是一个免费产品，源代码仅限用于学习，禁止用于商业站点或者其他商业用途
// 如果您要将bbsmax用于商业用途，需要从官方购买商业授权，得到授权后可以基于源代码二次开发
//
// 版权所有 厦门麦斯网络科技有限公司
// 公司网站 www.bbsmax.com
//

/*
 * ������: ���
 * ����ʱ��: 2008-5-26 10:44
 * ��Ȩ����: MaxLab.
 */

using System;

namespace MaxLabs.bbsMax.Ubb
{
	/// <summary>
	/// [code]hahahahha[/code]
	/// </summary>
	public class CODE : UbbTagHandler
	{
		public override string UbbTagName {
			get { return "code"; }
		}
		
		public override string HtmlTagName {
			get { return "dl"; }
		}
		
		public override UbbTagHandler GetInstance {
			get { return this; }
		}

        public override string BuildHtml(UbbParser parser, string param, string content)
		{
			if (!parser.EncodeHtml)
				content = System.Web.HttpUtility.HtmlEncode(content);
			return string.Format(
				@"
<!--ubb-begin-->
<div class=""maxcode-code"">
<p>���� <a class=""maxcode-code-copy"" href=""javascript:;"" onclick=""ubbCopy(this)"">����</a> - <a class=""maxcode-code-run"" href=""javascript:;"" onclick=""ubbRun(this)"">����</a></p>
<pre><code>{0}</code></pre>
</div>
<!--ubb-end-->",
				content.TrimStart('\r','\n')
			);
		}
	}
}