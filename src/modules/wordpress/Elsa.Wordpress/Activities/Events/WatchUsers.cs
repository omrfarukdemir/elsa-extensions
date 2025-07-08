using Elsa.Workflows;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.WordPress.Activities.Events;

/// <summary>
/// Triggers when a new user is added.
/// </summary>
[Activity(
    "Elsa.Wordpress.Events",
    "Wordpress Events",
    "Triggers when a new user is added.",
    DisplayName = "Watch User")]
[UsedImplicitly]
public class WatchUsers : WordpressTriggerActivity
{
    // Implementation for watching users
    public override ValueTask<IEnumerable<object>> GetTriggerPayloadsAsync(TriggerIndexingContext context)
    {
        throw new NotImplementedException();
    }
}