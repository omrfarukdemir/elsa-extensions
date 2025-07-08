using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.MediaItems;

/// <summary>
/// Updates a media item specified by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.MediaItems",
    "Wordpress Media Items",
    "Uploads a media item (image, video, etc.).",
    DisplayName = "Upload Media Item")]
[UsedImplicitly]
public class UpdateMediaItem : WordPressActivity
{
    // Implementation for updating a media item
}
