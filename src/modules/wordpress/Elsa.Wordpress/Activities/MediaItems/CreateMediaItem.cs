using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.MediaItems;

/// <summary>
/// Uploads a media item (image, video, etc.).
/// </summary>
[Activity(
    "Elsa.Wordpress.MediaItems",
    "Wordpress Media Items",
    "Uploads a media item (image, video, etc.).",
    DisplayName = "Create Media Item")]
[UsedImplicitly]
public class CreateMediaItem : WordPressActivity
{
    // Implementation for creating a media item
}
