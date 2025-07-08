using Elsa.WordPress.Activities;
using Elsa.Workflows;

namespace Elsa.Wordpress.Activities.Comments;

/// <summary>
/// Triggers when a new comment is added.
/// </summary>
public class WatchComments : WordpressTriggerActivity
{
    // Implementation for watching comments
    public override ValueTask<IEnumerable<object>> GetTriggerPayloadsAsync(TriggerIndexingContext context)
    {
        throw new NotImplementedException();
    }
}
