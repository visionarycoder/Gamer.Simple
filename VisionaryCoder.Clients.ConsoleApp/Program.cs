using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using vc;

using IHost host = Host.CreateDefaultBuilder(args)
	//.ConfigureContainer(container => { })
	//.ConfigureServices((_, services) =>
	//	{  
	//		services
	//			.AddTransient<ITransientOperation, DefaultOperation>()
	//			.AddScoped<IScopedOperation, DefaultOperation>()
	//			.AddSingleton<ISingletonOperation, DefaultOperation>()
	//			.AddTransient<OperationLogger>()
	//	}
	//)
	.Build();
await host.RunAsync();