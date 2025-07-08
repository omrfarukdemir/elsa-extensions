using Elsa.WordPress.Activities;
using Elsa.Workflows;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Posts;

/// <summary>
/// Triggers when a post is updated.
/// </summary>
[Activity(
    "Elsa.Wordpress.Posts",
    "Wordpress Posts",
    "Triggers when a post is updated.",
    DisplayName = "Updated Post")]
[UsedImplicitly]
public class WatchPostsUpdated : WordpressTriggerActivity
{
    // Implementation for watching updated posts
    public override ValueTask<IEnumerable<object>> GetTriggerPayloadsAsync(TriggerIndexingContext context)
    {
        throw new NotImplementedException();
    }
}