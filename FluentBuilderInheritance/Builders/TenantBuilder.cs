using FluentBuilderInheritance.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance.Builders
{
    public class TenantBuilder<TBuilder>  where TBuilder : TenantBuilder<TBuilder>
    {
        protected readonly Tenant _tenant;

        public TenantBuilder()
        {
            _tenant = new Tenant();
        }

        public TBuilder WithId(string id)
        {
            _tenant.Id = id;
            return (TBuilder)this;
        }
        public TBuilder WithBaseUrl(string baseUrl) 
        {
            _tenant.BaseUrl = new Uri(baseUrl);
            return (TBuilder)this;
        }

        public Tenant Build() 
        {
            return _tenant;
        }
    }
}

//* we Make an explicit cast in the methods in order to turn TenantBuilder<TBuilder> to TBuilder
//*
//*
