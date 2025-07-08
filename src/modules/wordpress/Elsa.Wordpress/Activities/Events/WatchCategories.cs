
using Elsa.Workflows;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.WordPress.Activities.Events;

/// <summary>
/// Triggers when a new category is added.
/// </summary>
[Activity(
    "Elsa.Wordpress.Events",
    "Wordpress Events",
    "Triggers when a new category is added.",
    DisplayName = "Watch Category")]
[UsedImplicitly]
public class WatchCategories : WordpressTriggerActivity
{
    // Implementation for watching categories
    public override ValueTask<IEnumerable<object>> GetTriggerPayloadsAsync(TriggerIndexingContext context)
    {
        throw new NotImplementedException();
    }
}
