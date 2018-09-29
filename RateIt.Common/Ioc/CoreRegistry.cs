namespace RateIt.Common.Ioc
{
    public class CommonRegistry : StructureMap.Registry
    {
        public CommonRegistry()
        {
	        For(typeof(IFactory<>)).Use(typeof(Factory<>)).Singleton();
        }
    }
}
