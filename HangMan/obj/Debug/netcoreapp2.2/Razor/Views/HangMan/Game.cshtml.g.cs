#pragma checksum "D:\Schoolstuff\Hangman\Hangman\hangman\Views\HangMan\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac495cac64e1b9fe011331af0471b390ed2abcfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HangMan_Game), @"mvc.1.0.view", @"/Views/HangMan/Game.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HangMan/Game.cshtml", typeof(AspNetCore.Views_HangMan_Game))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Schoolstuff\Hangman\Hangman\hangman\Views\HangMan\Game.cshtml"
using HangMan.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac495cac64e1b9fe011331af0471b390ed2abcfb", @"/Views/HangMan/Game.cshtml")]
    public class Views_HangMan_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 21, true);
            WriteLiteral("<h1></h1>\r\nWelcome!\r\n");
            EndContext();
#line 4 "D:\Schoolstuff\Hangman\Hangman\hangman\Views\HangMan\Game.cshtml"
 if(Model.GameState == 0){


#line default
#line hidden
            BeginContext(75, 14, true);
            WriteLiteral("    <ul>\r\n    ");
            EndContext();
            BeginContext(90, 14, false);
#line 7 "D:\Schoolstuff\Hangman\Hangman\hangman\Views\HangMan\Game.cshtml"
Write(Model.Unsolved);

#line default
#line hidden
            EndContext();
            BeginContext(104, 212, true);
            WriteLiteral("\r\n    </ul>\r\n    <Form action=\"Game\" method=\"POST\">\r\n    <label for=\"guess\">Guess (One letter)</label>\r\n    <input type=\"text\" name=\"guess\" maxlength=\"1\">\r\n    <button type=\"submit\">Guess!</button>\r\n    </Form>\r\n");
            EndContext();
#line 14 "D:\Schoolstuff\Hangman\Hangman\hangman\Views\HangMan\Game.cshtml"
}
else if(Model.GameState == 1){

#line default
#line hidden
            BeginContext(351, 62, true);
            WriteLiteral("    <ul>You lose. <a href=\"/HangMan/New\">Try again?</a></ul>\r\n");
            EndContext();
#line 17 "D:\Schoolstuff\Hangman\Hangman\hangman\Views\HangMan\Game.cshtml"
}
else{

#line default
#line hidden
            BeginContext(423, 67, true);
            WriteLiteral("    <ul>You won!</ul>\r\n    <a href=\"/HangMan/New\">Play again?</a>\r\n");
            EndContext();
#line 21 "D:\Schoolstuff\Hangman\Hangman\hangman\Views\HangMan\Game.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591