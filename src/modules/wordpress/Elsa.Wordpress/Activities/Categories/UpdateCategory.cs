using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Categories;

/// <summary>
/// Updates a category specified by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Categories",
    "Wordpress Categories",
    "Updates a category specified by its ID.",
    DisplayName = "Update Category")]
[UsedImplicitly]
public class UpdateCategory : WordPressActivity
{
    // Implementation for updating a category
}