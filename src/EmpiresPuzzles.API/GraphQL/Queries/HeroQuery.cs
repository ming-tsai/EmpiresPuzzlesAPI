using System.Collections.Generic;
using System.Linq;
using EmpiresPuzzles.API.GraphQL.Types;
using EmpiresPuzzles.API.Interfaces;
using EmpiresPuzzles.API.Models;
using GraphQL.Types;

namespace EmpiresPuzzles.API.GraphQL.Queries
{
    public class HeroQuery : ObjectGraphType
    {
        public HeroQuery(IHeroService heroService)
        {
            Field<HeroType>(
                "hero",
                arguments: new QueryArguments(
                new QueryArgument<StringGraphType> { Name = "name", Description = "The name of hero" }),
                resolve: context =>
                {
                    var name = context.GetArgument<string>("name");
                    return heroService.GetBy(name);
            });

            Field<ListGraphType<HeroType>>(
                "heroes",
                resolve: context =>
                {
                    return heroService.GetAll().ToList();
                }
            );
        }
    }
}