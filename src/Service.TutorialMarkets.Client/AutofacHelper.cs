using Autofac;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialMarkets.Grpc;

// ReSharper disable UnusedMember.Global

namespace Service.TutorialMarkets.Client
{
	public static class AutofacHelper
	{
		public static void RegisterTutorialMarketsClient(this ContainerBuilder builder, string grpcServiceUrl, ILogger logger)
		{
			var factory = new TutorialMarketsClientFactory(grpcServiceUrl, logger);

			builder.RegisterInstance(factory.GetTutorialMarketsService()).As<IGrpcServiceProxy<ITutorialMarketsService>>().SingleInstance();
		}
	}
}
