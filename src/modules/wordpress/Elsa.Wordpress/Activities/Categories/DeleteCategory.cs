using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Categories;

/// <summary>
/// Deletes a category specified by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.Categories",
    "Wordpress Categories",
    " Deletes a category specified by its ID.",
    DisplayName = "Delete Category")]
[UsedImplicitly]
public class DeleteCategory : WordPressActivity
{
    // Implementation for deleting a category
}
