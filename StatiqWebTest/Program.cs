using Statiq.App;
using Statiq.Common;
using Statiq.Web;

await Bootstrapper
    .Factory
    .CreateWeb(args)
    .DeployToGitHubPagesBranch(
        "renegarciadieguez",
        "StatiqWebTest",
        Config.FromSetting<string>("GITHUB_TOKEN"),
        "gh-pages"
    )
    .RunAsync();
