using EmpiresPuzzles.API.GraphQL.Queries;
using GraphQL;
using GraphQL.Types;

namespace EmpiresPuzzles.API.GraphQL
{
    public class RootSchema : Schema, ISchema
    {
        public RootSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<HeroQuery>();
        }
    }
}