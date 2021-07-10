using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentShikimori.Data;

namespace FluentShikimori.Requests
{
	public class GetAnimesFluentRequest : FluentRequest<IReadOnlyCollection<AnimeEntry>>
	{
		public GetAnimesFluentRequest(string requestPath, 
									  Func<string, IReadOnlyDictionary<string, object>, Task<IReadOnlyCollection<AnimeEntry>?>> execute)
			: base(requestPath, execute)
		{ }
		
		public GetAnimesFluentRequest WithIds(IEnumerable<long> ids) 
			=> With("ids", ids);

		public GetAnimesFluentRequest WithPage(int page)
			=> With("page", page);
		
		public GetAnimesFluentRequest WithLimit(int limit)
			=> With("limit", limit);

		private GetAnimesFluentRequest With(string name, object value)
		{
			Parameters[name] = value;
			return this;
		}
	}
}