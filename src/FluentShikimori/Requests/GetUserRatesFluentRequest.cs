using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentShikimori.Data;

namespace FluentShikimori.Requests
{
	public class GetUserRatesFluentRequest : FluentRequest<IReadOnlyCollection<UserRate>>
	{
		public GetUserRatesFluentRequest(string requestPath, 
										 Func<string, IReadOnlyDictionary<string, object>, Task<IReadOnlyCollection<UserRate>?>> execute) 
			: base(requestPath, execute)
		{ }
		
		public GetUserRatesFluentRequest WithUserId(long userId) 
			=> With("user_id", userId);

		public GetUserRatesFluentRequest WithTargetId(long targetId)
			=> With("target_id", targetId);
		
		public GetUserRatesFluentRequest WithTargetType(DataType targetType)
			=> With("target_type", targetType);
		
		public GetUserRatesFluentRequest WithStatus(RateStatus status)
			=> With("status", status);
		
		public GetUserRatesFluentRequest WithPage(int page)
			=> With("page", page);
		
		public GetUserRatesFluentRequest WithLimit(int limit)
			=> With("limit", limit);

		private GetUserRatesFluentRequest With(string name, object value)
		{
			Parameters[name] = value;
			return this;
		}
	}
}