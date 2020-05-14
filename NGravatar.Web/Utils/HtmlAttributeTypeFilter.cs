using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace NGravatar.Web.Utils
{
    internal class HtmlAttributeTypeFilter
    {

        public IDictionary<string, object> FilterToDictionary(object htmlAttributes)
        {
            if (null == htmlAttributes) return null;

            var collection = htmlAttributes as IEnumerable<KeyValuePair<string, object>>;
            return (collection ?? new RouteValueDictionary(htmlAttributes))
                .ToDictionary(
                    pair => pair.Key,
                    pair => pair.Value
                );
        }
    }
}
