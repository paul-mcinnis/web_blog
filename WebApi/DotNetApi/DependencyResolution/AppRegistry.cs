using DotNetApi.Services;
using Lamar;
namespace DotNetApi.DependencyResolution
{
    public class AppRegistry : ServiceRegistry
    {
        public AppRegistry()
        {
            For<IArticleService>().Use<ArticleService>();
        }
    }
}
