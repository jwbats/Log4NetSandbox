using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using log4net;
using log4net.Config;

namespace Log4NetSandbox
{
	public partial class Default : System.Web.UI.Page
	{

		public static readonly ILog logger = LogManager.GetLogger("FirstLogFileAppender");

		protected void Page_Load(object sender, EventArgs e)
		{
			XmlConfigurator.Configure();

			logger.Debug("..This is Debug Message...");

			logger.Error("..This is Error Message...");

			logger.Fatal("..This is Fatal Message...");

			logger.Info("..This is Information Message...");
		}
	}
}