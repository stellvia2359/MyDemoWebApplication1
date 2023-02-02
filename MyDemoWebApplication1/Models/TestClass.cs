namespace MyDemoWebApplication1.Models
{
    public static class TestStaticClass
    {
        private static IConfiguration Configuration;

        public static void Initialize(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public static void Method1()
        {
            var t = Configuration.GetSection("Test").GetChildren();
        }
    }
}
