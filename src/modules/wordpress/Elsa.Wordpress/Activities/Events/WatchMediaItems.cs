using Elsa.WordPress.Activities;
using Elsa.Workflows;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Events;

/// <summary>
/// Triggers when a new media item is added.
/// </summary>
[Activity(
    "Elsa.Wordpress.Events",
    "Wordpress Events",
    "Triggers when a new media item is added.",
    DisplayName = "Watch Media Item")]
[UsedImplicitly]
public class WatchMediaItems : WordpressTriggerActivity
{
    // Implementation for watching media items
    public override ValueTask<IEnumerable<object>> GetTriggerPayloadsAsync(TriggerIndexingContext context)
    {
        throw new NotImplementedException();
    }
}
