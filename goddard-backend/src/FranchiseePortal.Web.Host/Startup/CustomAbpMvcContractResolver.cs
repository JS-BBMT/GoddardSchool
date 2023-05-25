using System.Reflection;
using Abp.Dependency;
using Abp.Json;
using FranchiseePortal.FeaturesWebApiClient.Model;
using FranchiseePortal.LeadsWebApiClient.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FranchiseePortal.Web.Startup {
    public class CustomAbpMvcContractResolver : AbpMvcContractResolver {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            if (property.DeclaringType == typeof(Feature) && property.PropertyName == "alternateId") {
                property.ShouldSerialize = _ => true;
            }

            if (property.DeclaringType == typeof(SchoolFeature) && property.PropertyName == "alternateId") {
                property.ShouldSerialize = _ => true;
            }

            if (property.DeclaringType == typeof(LeadDto) && property.PropertyName == "primaryPhone")
            {
                property.ShouldSerialize = _ => true;
            }

            return property;
        }

        public CustomAbpMvcContractResolver(IIocResolver iocResolver) : base(iocResolver) {
        }
    }
}
