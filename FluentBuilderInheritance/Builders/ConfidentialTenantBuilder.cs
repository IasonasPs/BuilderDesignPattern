 using FluentBuilderInheritance.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance.Builders
{
    //public class ConfidentialTenantBuilder :  TenantBuilder<ConfidentialTenantBuilder>
    //{

    //    public ConfidentialTenantBuilder WithSecret(string secret) 
    //    {
    //        _tenant.Secret = secret;
    //        return this;
    //    }
    //}

    public class ConfidentialTenantBuilder<tBuilder> : TenantBuilder<tBuilder>
        where tBuilder : ConfidentialTenantBuilder<tBuilder>
    {
        public tBuilder WithSecret(string secret)
        {
            _tenant.Secret = secret;
            return (tBuilder)this;
        }
    }
}
