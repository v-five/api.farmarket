using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web;

namespace Farmarket
{
	public class Global : UmbracoApplication
	{
	    protected override void OnApplicationStarted(object sender, EventArgs e)
	    {
	        base.OnApplicationStarted(sender, e);
			RouteConfig.Register(GlobalConfiguration.Configuration);
	    }
	}
}