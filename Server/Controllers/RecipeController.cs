using AiChef.Server.Data;
using AiChef.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AiChef.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpPost, Route("GetRecipeIdeas")]
        public async Task<ActionResult<List<RecipeIdea>>> GetRecipeIdeas(RecipeParams recipeParams)
        {
            return SampleData.RecipeIdeas;
        }
        
    }
}
