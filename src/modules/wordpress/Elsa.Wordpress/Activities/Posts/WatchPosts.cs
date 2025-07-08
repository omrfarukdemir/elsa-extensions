using Elsa.WordPress.Activities;
using Elsa.Workflows;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Posts;

/// <summary>
/// Triggers when a new post is added.
/// </summary>
[Activity(
    "Elsa.Wordpress.Posts",
    "Wordpress Posts",
    "Triggers when a new post is added.",
    DisplayName = "Created Post")]
[UsedImplicitly]
public class WatchPosts : WordpressTriggerActivity
{
    // Implementation for watching posts
    public override ValueTask<IEnumerable<object>> GetTriggerPayloadsAsync(TriggerIndexingContext context)
    {
        throw new NotImplementedException();
    }
}