using Elsa.WordPress.Activities;
using Elsa.Workflows;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.MediaItems;

/// <summary>
/// Triggers when a new media item is added.
/// </summary>
[Activity(
    "Elsa.Wordpress.MediaItems",
    "Wordpress Media Items",
    "Triggers when a new media item is added.",
    DisplayName = "Created Media Item")]
[UsedImplicitly]
public class WatchMediaItems : WordpressTriggerActivity
{
    // Implementation for watching media items
    public override ValueTask<IEnumerable<object>> GetTriggerPayloadsAsync(TriggerIndexingContext context)
    {
        throw new NotImplementedException();
    }
}
