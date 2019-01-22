using Ninject.Modules;
using Ninject;

namespace Scraper
{
	public class NinjectContainer : NinjectModule
	{
		public override void Load()
		{
			Bind<IPokemonScrapper>().To<PokemonScrapper>();
			Bind<IRepository>().To<Repository>();
		}
	}
}
