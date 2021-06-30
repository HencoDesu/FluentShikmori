using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace FluentShikimori.Requests
{
	public interface IFluentRequest<TResult>
	{
		IFluentRequest<TResult> WithParameter(string parameterName, object parameterValue);
		Task<TResult> ExecuteAsync();
		TaskAwaiter<TResult> GetAwaiter();
	}
}