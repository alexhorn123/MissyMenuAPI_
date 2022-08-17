using MissyMenuApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace MissyMenuApi.Services;

public class RecipesService
{
    private readonly IMongoCollection<Recipe> _recipesCollection;

    public RecipesService(
        IOptions<MissyMenuDatabaseSettings> missyMenuDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            missyMenuDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            missyMenuDatabaseSettings.Value.DatabaseName);

        _recipesCollection = mongoDatabase.GetCollection<Recipe>(
            missyMenuDatabaseSettings.Value.RecipesCollectionName);
    }

    public async Task<List<Recipes>> GetAsync() =>
        await _recipesCollection.Find(_ => true).ToListAsync();

    public async Task<Recipes?> GetAsync(string id) =>
        await _recipesCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Recipe newRecipe) =>
        await _recipesCollection.InsertOneAsync(newRecipe);

    public async Task UpdateAsync(string id, Recipe updatedRecipe) =>
        await _recipesCollection.ReplaceOneAsync(x => x.Id == id, updatedRecipe);

    public async Task RemoveAsync(string id) =>
        await _recipesCollection.DeleteOneAsync(x => x.Id == id);
}