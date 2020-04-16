using EmpiresPuzzles.API.Models;
using GraphQL.Types;

namespace EmpiresPuzzles.API.GraphQL.Types
{
    public class HeroSpeedType : ObjectGraphType<HeroSpeed>
    {
        public HeroSpeedType()
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.Description);
        }
    }
}