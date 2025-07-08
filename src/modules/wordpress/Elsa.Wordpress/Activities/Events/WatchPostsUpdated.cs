using Elsa.WordPress.Activities;
using Elsa.Workflows;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Events;

/// <summary>
/// Triggers when a post is updated.
/// </summary>
[Activity(
    "Elsa.Wordpress.Events",
    "Wordpress Events",
    "Triggers when a post is updated.",
    DisplayName = "Watch Post Updated")]
[UsedImplicitly]
public class WatchPostsUpdated : WordpressTriggerActivity
{
    // Implementation for watching updated posts
    public override ValueTask<IEnumerable<object>> GetTriggerPayloadsAsync(TriggerIndexingContext context)
    {
        throw new NotImplementedException();
    }
}