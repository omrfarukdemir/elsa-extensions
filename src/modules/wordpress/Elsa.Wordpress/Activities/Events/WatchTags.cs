using Elsa.WordPress.Activities;
using Elsa.Workflows;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Events;

/// <summary>
/// Triggers when a new user is added.
/// </summary>
[Activity(
    "Elsa.Wordpress.Events",
    "Wordpress Events",
    "Triggers when a new tag is added.",
    DisplayName = "Watch Tag")]
[UsedImplicitly]
public class WatchTags : WordpressTriggerActivity
{
    // Implementation for watching tags
    public override ValueTask<IEnumerable<object>> GetTriggerPayloadsAsync(TriggerIndexingContext context)
    {
        throw new NotImplementedException();
    }
}