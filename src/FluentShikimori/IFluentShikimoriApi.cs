using FluentShikimori.Categories.Abstractions;

namespace FluentShikimori
{
	/// <summary>
	/// Provides fluent interfaces for shikimori api
	/// </summary>
	public interface IFluentShikimoriApi
	{
		/// <inheritdoc cref="IAnimes"/>
		IAnimes Animes { get; }
		
		/// <inheritdoc cref="ICharacters"/>
		ICharacters Characters { get; }
		
		/// <inheritdoc cref="IMangas"/>
		IMangas Mangas { get; }
		
		/// <inheritdoc cref="IPeople"/>
		IPeople People { get; }
		
		/// <inheritdoc cref="IRanobe"/>
		IRanobe Ranobe { get; }
	}
}