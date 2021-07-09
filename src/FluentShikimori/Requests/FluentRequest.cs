using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace FluentShikimori.Requests
{
	public class FluentRequest<TResult>
	{
		private readonly string _requestPath;
		private readonly Func<string, IReadOnlyDictionary<string, object>, Task<TResult>> _execute;
		private readonly Dictionary<string, object> _parameters = new();

		public FluentRequest(string requestPath, 
							 Func<string, IReadOnlyDictionary<string, object>, Task<TResult>> execute)
		{
			_execute = execute;
			_requestPath = requestPath;
		}
		
		public FluentRequest<TResult> WithParameter(string parameterName, 
													object parameterValue)
		{
			_parameters[parameterName] = parameterValue;
			return this;
		}

		public Task<TResult> ExecuteAsync() 
			=> _execute(_requestPath, _parameters);

		public TaskAwaiter<TResult> GetAwaiter()
			=> ExecuteAsync().GetAwaiter();
	}
}