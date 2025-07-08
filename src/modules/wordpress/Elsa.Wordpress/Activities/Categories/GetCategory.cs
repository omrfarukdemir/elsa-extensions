using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Categories;

/// <summary>
/// Retrieves information about a category by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Categories",
    "Wordpress Categories",
    "etrieves information about a category by its ID.",
    DisplayName = "Get Category")]
[UsedImplicitly]
public class GetCategory : WordPressActivity
{
    // Implementation for getting a category
}
