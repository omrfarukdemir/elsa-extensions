using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Tags;

/// <summary>
/// Searches for specific tags.
/// </summary>
[Activity(
    "Elsa.Wordpress.Tags",
    "Wordpress Tags",
    "Searches for specific tags.",
    DisplayName = "Search Tag")]
[UsedImplicitly]
public class SearchTags : WordPressActivity
{
    // Implementation for searching tags
}
