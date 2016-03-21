namespace BrightStarDb_App1
{
    public class DependencyResolver
    {
        public static DbContext Resolve<T>()
        {
            return new DbContext(@"type=embedded;storesdirectory=c:\db;storename=app1");
        }
    }
}