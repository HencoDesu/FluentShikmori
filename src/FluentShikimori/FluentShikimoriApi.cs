using System.Net.Http;
using FluentShikimori.Categories;
using FluentShikimori.Categories.Abstractions;

namespace FluentShikimori
{
	public class FluentShikimoriApi : IFluentShikimoriApi
	{
		public const string SHIKIMORI_URL = "https://shikimori.one";
		public const string API_URL = SHIKIMORI_URL + "/api";
		
		public FluentShikimoriApi(HttpClient httpClient)
		{
			Animes = new AnimesCategory(httpClient, API_URL);
			Characters = new CharacterCategory(httpClient, API_URL);
			Mangas = new MangasCategory(httpClient, API_URL);
			People = new PeopleCategory(httpClient, API_URL);
			Ranobe = new RanobeCategory(httpClient, API_URL);
		}

		public IAnimes Animes { get; }
		public ICharacters Characters { get; }
		public IMangas Mangas { get; }
		public IPeople People { get; }
		public IRanobe Ranobe { get; }
	}
}