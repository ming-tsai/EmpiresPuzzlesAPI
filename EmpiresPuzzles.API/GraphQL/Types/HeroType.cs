using EmpiresPuzzles.API.Models;
using GraphQL.Types;

namespace EmpiresPuzzles.API.GraphQL.Types
{
    public class HeroType : ObjectGraphType<Hero>
    {
        public HeroType()
        {
            Field(x=> x.Id, type: typeof(IdGraphType));
            Field(x=> x.Color);
            Field(x=> x.Name);
            Field(x=> x.TeamCost);
            Field(x=> x.Stars);
            Field(x=> x.SpeedId);
            Field(x=> x.MaxPower);
            Field(x=> x.MaxAttack);
            Field(x=> x.MaxDefense);
            Field(x=> x.MaxHealth);
            Field(x=> x.MaxLevel);
            Field(x=> x.FandomWikiURI);
        }
    }
}