#pragma warning disable 1591
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace PortableCongress
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class FavoriteBillView : PortableRazor.ViewBase
{

#line hidden

#line 3 "FavoriteBillView.cshtml"
public PortableCongress.Bill Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("\n");

WriteLiteral("<html>\n<head>\n\t<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"jquery.mobile-1.4.0.min.css\"");

WriteLiteral(" />\n\t<script");

WriteLiteral(" src=\"jquery-1.10.2.min.js\"");

WriteLiteral("></script>\n\t<script");

WriteLiteral(" src=\"jquery.mobile-1.4.0.min.js\"");

WriteLiteral("></script>\n</head>\n<body>\n\t<style>\n\t\tiframe {\n\t\t    min-width: 100%; \n\t\t    width" +
": 100px;\n\t\t    *width: 100%; \n\t\t}\n\t</style>\n\t<div");

WriteLiteral(" data-role=\"header\"");

WriteLiteral(" style=\"overflow:hidden;\"");

WriteLiteral(" data-position=\"fixed\"");

WriteLiteral(">\n    \t<h1>Bill Details</h1>\n    </div>\n\n    <div");

WriteLiteral(" data-role=\"header\"");

WriteLiteral(" style=\"overflow:hidden;\"");

WriteLiteral(" data-position=\"fixed\"");

WriteLiteral(">\n");

WriteLiteral("\t\t");


#line 24 "FavoriteBillView.cshtml"
Write(Html.ActionLink("Back", "ShowFavoriteBills", null, new { 
			@class="ui-btn-left ui-btn ui-icon-back ui-btn-icon-notext ui-shadow ui-corner-all",
			data_icon = "arrow-l", 
			data_role="button", 
			data_mini="true", 
			data_inline="true", 
			data_transition="slide"}));


#line default
#line hidden
WriteLiteral("\n    \t<h1>Bill Details</h1>\n");

WriteLiteral("    \t");


#line 32 "FavoriteBillView.cshtml"
Write(Html.ActionLink("Delete", "RemoveFavoriteBill", new {id = @Model.Id}, new { 
			@class="ui-btn-right ui-btn ui-btn-icon-notext ui-shadow ui-corner-all",
			data_role="button", 
			data_mini="true", 
			data_inline="true"}));


#line default
#line hidden
WriteLiteral("\n    </div>\t\n\t\t\n    <div");

WriteLiteral(" style=\"margin-left:10px\"");

WriteLiteral(" data-mini=\"true\"");

WriteLiteral(" data-inset=\"false\"");

WriteLiteral(">\n\t\t<p>");


#line 40 "FavoriteBillView.cshtml"
Write(Model.Title);


#line default
#line hidden
WriteLiteral("</p>\n\t</div>\n\n\t<iframe");

WriteLiteral(" scrolling=\"no\"");

WriteAttribute ("src", " src=\"", "\""

#line 43 "FavoriteBillView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.ThomasLink

#line default
#line hidden
, false)
);
WriteLiteral("></iframe>\n</body>\n</html>");

}
}
}
#pragma warning restore 1591
