using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using FranchiseePortal.Queries.Container;
using System;

namespace FranchiseePortal.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}