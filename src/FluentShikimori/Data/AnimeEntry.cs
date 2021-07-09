using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FluentShikimori.Data
{
	public class AnimeEntry : BaseEntry
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		
		[JsonProperty("image")]
		public Dictionary<ImageLink, string> Images { get; set; }
		
		[JsonProperty("status")]
		public AnimeStatus Status { get; set; }
		
		[JsonProperty("episodes")]
		public int Episodes { get; set; }

		[JsonProperty("episodes_aired")]
		public int AiredEpisodes { get; set; }

		[JsonProperty("next_episode_at")]
		public DateTime? NextEpisodeTime { get; set; }
	}
}