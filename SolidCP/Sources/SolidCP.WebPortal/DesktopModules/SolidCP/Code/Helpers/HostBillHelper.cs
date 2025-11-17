using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidCP.Portal.Code.Helpers
{
	public class HostBillHelper
	{
		public static void SetHostBillIntegration(bool enabled, string id, string key, string url)
		{
			if (!enabled)
			{
				url = id = key = null;
            }
            ES.Services.System.SetHostBillIntegration(new EnterpriseServer.HostBillServerInfo()
			{
				Id = id,
				Key = key,
				Url = url
			});
		}

		public static EnterpriseServer.HostBillServerInfo GetHostBillIntegration() => ES.Services.System.GetHostBillIntegration();
	}
}