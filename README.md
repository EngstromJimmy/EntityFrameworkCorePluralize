[https://img.shields.io/nuget/v/EntityFrameworkCore.Pluralize.svg?style=flat-square](https://www.nuget.org/packages/EntityFrameworkCore.Pluralize/)


# EntityFrameworkCorePluralize
Adds Singlarization and Pluralization to Entity Framework Core
 
I recently started working with .NET Core and I didn't like that Microsoft removed the automatic pluralization/singularization of classes and collection in Entity Framework Core.
They did however give us the opportunity to hook in our own.
This is talked about in this [StackOverflow post](https://stackoverflow.com/questions/39281647/entityframework-core-database-first-approach-pluralizing-table-names/47410837#47410837)

I choose to modify the one Microsoft provided in previous versions of Entity Framework found [here](https://github.com/Microsoft/referencesource/blob/master/System.Data.Entity.Design/System/Data/Entity/Design/PluralizationService/EnglishPluralizationService.cs).  

Usage:
1. Add the nuget package https://www.nuget.org/packages/EntityFrameworkCore.Pluralize/  
2. Add a class named [PluralizeDesignTimeServices.cs](https://gist.github.com/Apeoholic/bda9c9b1815321ff99d173ca0b99cebf#file-pluralizedesigntimeservices-cs)  
3. Run dotnet ef scaffold...... and everything will be named correctly =)  

If some translations are missing, please do a PR or contact me and I will add them.

