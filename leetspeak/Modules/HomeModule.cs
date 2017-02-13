using Nancy;
using System.Collections.Generic;
using LeetSpeakTranslator.Objects;

namespace LeetSpeakTranslator
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["index.cshtml"];
            };

            Post["/translate"] = _ =>
            {
                LeetSpeak newPhrase = new LeetSpeak(Request.Form["phrase"]);
                return View["translated.cshtml", newPhrase.Translate(newPhrase.GetPhrase())];
            };

        }
    }
}
