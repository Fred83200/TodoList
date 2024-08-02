using CookieCookbook.App;
using CookieCookbook.DataAccess;
using CookieCookbook.FileAccess;
using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository  = Format == FileFormat.Json ? new StringsJsonRepository() : new StringsTextualRepository();
const string Filename = "recipes";
var fileMetadata = new FileMetadata(Filename, Format);

var ingredientsRegist = new IngredientsRegister();

var cookiesRecipesApp = new CookiesRecipesApp(
    new RecipesRepository(stringsRepository, ingredientsRegist),
    new RecipesConsolUserInteraction(ingredientsRegist));

cookiesRecipesApp.Run(fileMetadata.ToPath());