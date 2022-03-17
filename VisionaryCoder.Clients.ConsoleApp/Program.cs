using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VisionaryCoder.Components;
using VisionaryCoder.Components.Accessor.Game.Interface;
using VisionaryCoder.Components.Accessor.Player.Interface;
using VisionaryCoder.Components.Accessor.Player.Service;
using VisionaryCoder.Resource.DataSource;

using IHost host = Host.CreateDefaultBuilder(args)
	.ConfigureServices((_, services) =>
		{
			services
				.AddDbContext<GamerDbContext>()


				.AddTransient<IGameDefinitionAccess, GameDefinitionAccess>()
				.AddTransient<IBoardGamePlayerAccess, BoardGamePlayerAccess>()
				;
		}
	)
	.Build();
await host.RunAsync();