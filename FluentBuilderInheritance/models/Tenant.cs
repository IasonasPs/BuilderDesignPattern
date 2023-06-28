using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance.models
{
    public class Tenant
    {
        public string Id { get; set; }
        public Uri BaseUrl { get; set; }
        public string Secret { get; set; }
        public string QaCloudId { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} , BaseUrl:{BaseUrl} , Secret:{Secret}";
        }
    }
}
