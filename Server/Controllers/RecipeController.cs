using AiChef.Server.Data;
using AiChef.Server.Services;
using AiChef.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AiChef.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    { 
        private readonly IOpenAIAPI _openAIservice;

        public RecipeController(IOpenAIAPI openAIservice)
        {
            _openAIservice = openAIservice;
        }


        [HttpPost, Route("GetRecipeIdeas")]
        public async Task<ActionResult<List<RecipeIdea>>> GetRecipeIdeas(RecipeParams recipeParams)
        {
            string mealtime = recipeParams.MealTime;
            List<string> ingredients = recipeParams.Ingredients
                                                    .Where(i => !string.IsNullOrEmpty(i.Description))
                                                    .Select(i => i.Description!)
                                                    .ToList();

            if (string.IsNullOrEmpty(mealtime))
            {
                mealtime = "Breakfast";
            }

            var ideas = await _openAIservice.CreateRecipeIdeas(mealtime, ingredients);

            return ideas;
            //return SampleData.RecipeIdeas;
        }
        
    
    }
}
