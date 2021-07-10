using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace FluentShikimori.Requests
{
	public class FluentRequest<TResult>
	{
		private readonly string _requestPath;
		private readonly Func<string, IReadOnlyDictionary<string, object>, Task<TResult?>> _execute;
		
		protected readonly Dictionary<string, object> Parameters = new();

		public FluentRequest(string requestPath, 
							 Func<string, IReadOnlyDictionary<string, object>, Task<TResult?>> execute)
		{
			_execute = execute;
			_requestPath = requestPath;
		}
		
		public FluentRequest<TResult> WithParameter(string parameterName, 
													object parameterValue)
		{
			Parameters[parameterName] = parameterValue;
			return this;
		}

		public Task<TResult?> ExecuteAsync() 
			=> _execute(_requestPath, Parameters);

		public TaskAwaiter<TResult?> GetAwaiter()
			=> ExecuteAsync().GetAwaiter();
	}
}