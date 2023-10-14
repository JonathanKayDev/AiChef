using AiChef.Shared;

namespace AiChef.Server.Services
{
    public interface IOpenAIAPI
    {
        Task<List<RecipeIdea>> CreateRecipeIdeas(string mealtime, List<string> ingredients);
        Task<Recipe> CreateRecipe(string title, List<string> ingredients);

        Task<RecipeImage> CreateRecipeImage(string title);
    }
}
