using Elsa.WordPress.Activities;
using Elsa.Workflows;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Events;

/// <summary>
/// Triggers when a new comment is added.
/// </summary>
[Activity(
    "Elsa.Wordpress.Events",
    "Wordpress Events",
    "Triggers when a new comment is added.",
    DisplayName = "Created Media Item")]
[UsedImplicitly]
public class WatchComments : WordpressTriggerActivity
{
    // Implementation for watching comments
    public override ValueTask<IEnumerable<object>> GetTriggerPayloadsAsync(TriggerIndexingContext context)
    {
        throw new NotImplementedException();
    }
}