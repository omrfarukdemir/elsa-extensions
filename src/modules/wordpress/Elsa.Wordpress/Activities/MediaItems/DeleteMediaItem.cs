using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.MediaItems;

/// <summary>
/// Deletes a media item specified by its ID.
/// </summary>
[Activity(
    "Elsa.Wordpress.MediaItems",
    "Wordpress Media Items",
    "Deletes a media item specified by its ID.",
    DisplayName = "Delete Media Item")]
[UsedImplicitly]
public class DeleteMediaItem : WordPressActivity
{
    // Implementation for deleting a media item
}
