using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.AspNet.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMonger.Site.Classes
{
    [HtmlTargetElement("span")]
    public class SpanTagHelper : TagHelper
    {
        private const string InsertBreaksAfterAttributeName = "insert-breaks-after";

        [HtmlAttributeName(InsertBreaksAfterAttributeName)]
        public int InsertBreaksAfter { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string content = output.Content.GetContent();
            StringBuilder newContent = new StringBuilder();
            int index = 0;
            for(int i = 0; i < content.Length; i++)
            {
                if (InsertBreaksAfter == index++)
                {
                    newContent.Append("<br/>");
                    index = 0;
                }
                newContent.Append(content[i]);
            }

            output.Content.SetContent(newContent.ToString());
            base.Process(context, output);
        }
    }
}
