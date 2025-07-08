using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.MediaItems;

/// <summary>
/// Searches for specific media items.
/// </summary>
[Activity(
    "Elsa.Wordpress.MediaItems",
    "Wordpress Media Items",
    "Searches for specific media items.",
    DisplayName = "Search Media Item")]
[UsedImplicitly]
public class SearchMediaItems : WordPressActivity
{
    // Implementation for searching media items
}