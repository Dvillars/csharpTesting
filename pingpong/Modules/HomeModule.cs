using Nancy;
using System.Collections.Generic;
using PingPongModule.Objects;

namespace PingPongModule
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["index.cshtml"];
            };

            Post["/max-number"] = _ =>
            {
                PingPong newPingPong = new PingPong(Request.Form["number"]);
                return View["pingpong.cshtml", newPingPong];
            };
        }
    }
}
