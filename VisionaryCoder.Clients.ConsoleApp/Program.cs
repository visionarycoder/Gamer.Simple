using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VisionaryCoder.Components.Accessor.GameDefinition.Interface;
using VisionaryCoder.Components.Accessor.Player.Interface;
using VisionaryCoder.Components.Accessor.Player.Service;
using VisionaryCoder.Resource.DataSource;

using IHost host = Host.CreateDefaultBuilder(args)
	.ConfigureServices((_, services) =>
		{
			services
				.AddDbContext<GamerDbContext>()


				.AddTransient<IGameDefinitionAccess, GameDefinitionAccess>()
				.AddTransient<IPlayerAccess, PlayerAccess>()
				;
		}
	)
	.Build();
await host.RunAsync();