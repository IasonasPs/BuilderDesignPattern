using FluentBuilderInheritance.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance.Builders
{
    public class TenantBuilder
    {
        protected readonly Tenant _tenant;

        public TenantBuilder()
        {
            _tenant = new Tenant();
        }

        public TenantBuilder WithId(string id)
        {
            _tenant.Id = id;
            return this;
        }
        public TenantBuilder WithBaseUrl(string baseUrl) 
        {
            _tenant.BaseUrl = new Uri(baseUrl);
            return this;
        }

        public Tenant Build() 
        {
            return _tenant;
        }
    }
}
