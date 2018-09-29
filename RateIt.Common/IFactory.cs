namespace RateIt.Common
{
	public interface IFactory<out T>
	{
		T Create();
	}
}