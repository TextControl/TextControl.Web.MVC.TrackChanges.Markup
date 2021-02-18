using System.Web;
using System.Web.Mvc;

namespace tx_trackchanges_markup {
	public class FilterConfig {
		public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
			filters.Add(new HandleErrorAttribute());
		}
	}
}
