using AiChef.Shared;

namespace AiChef.Server.Services
{
    public interface IOpenAIAPI
    {
        Task<List<RecipeIdea>> CreateRecipeIdeas(string mealtime, List<string> ingredients);

    }
}
