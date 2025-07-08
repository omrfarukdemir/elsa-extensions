using Elsa.WordPress.Activities;
using Elsa.Workflows.Attributes;
using JetBrains.Annotations;

namespace Elsa.Wordpress.Activities.Users;

/// <summary>
/// Searches for specific users.
/// </summary>
[Activity(
    "Elsa.Wordpress.Users",
    "Wordpress Users",
    "Searches for specific users.",
    DisplayName = "Search User")]
[UsedImplicitly]
public class SearchUsers : WordPressActivity
{
    // Implementation for searching users
}
