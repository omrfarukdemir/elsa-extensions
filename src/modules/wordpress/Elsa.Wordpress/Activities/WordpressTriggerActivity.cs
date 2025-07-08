using Elsa.Workflows;

namespace Elsa.WordPress.Activities;

/// <summary>
/// Base class for Wordpress event trigger activities.
/// </summary>
public abstract class WordpressTriggerActivity : WordPressActivity, ITrigger
{
    /// <summary>
    /// Returns the payloads to index.
    /// </summary>
    /// <param name="context">The trigger indexing context.</param>
    public abstract ValueTask<IEnumerable<object>> GetTriggerPayloadsAsync(TriggerIndexingContext context);
}