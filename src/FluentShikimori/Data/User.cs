using Newtonsoft.Json;

namespace FluentShikimori.Data
{
	public class User : BaseEntry
	{
		[JsonProperty("nickname")]
		public string? Nickname { get; set; }

		[JsonProperty("avatar")]
		public string? Avatar { get; set; }
	}
}