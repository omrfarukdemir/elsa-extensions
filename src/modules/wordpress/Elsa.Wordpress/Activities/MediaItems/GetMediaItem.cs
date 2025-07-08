using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.MediaItems;

/// <summary>
/// Retrieves information about a media item by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.MediaItems",
    "Wordpress Media Items",
    "Retrieves information about a media item by its ID.",
    DisplayName = "Get Media Item")]
[UsedImplicitly]
public class GetMediaItem : WordPressActivity
{
    // Implementation for getting a media item
}