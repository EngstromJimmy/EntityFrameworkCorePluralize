using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Entity.Design.PluralizationServices;

public class EnglishPluralizer : IPluralizer
{
    EnglishPluralizationService pluralizationService = new EnglishPluralizationService();
    public string Pluralize(string name)
    {

        return pluralizationService.Pluralize(name);
    }

    public string Singularize(string name)
    {
        return pluralizationService.Singularize(name);
    }
}