using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Candy_SUT21.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Address { get; set; }
        public string LinkText { get; set; }


        //override process [tab] [tab]
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto" + Address);
            output.Content.SetContent(LinkText);
        }

        //Registrera sedan i _ViewImports
    }
}
