using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Categories;

/// <summary>
/// Creates a new category.
/// </summary>
[Activity(
    "Elsa.Wordpress.Categories",
    "Wordpress Categories",
    "Creates a new category.",
    DisplayName = "Create Category")]
[UsedImplicitly]
public class CreateCategory : WordPressActivity
{
    // Implementation for creating a category
}