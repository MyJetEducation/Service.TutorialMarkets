using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialMarkets.Grpc;

namespace Service.TutorialMarkets.Client
{
	[UsedImplicitly]
	public class TutorialMarketsClientFactory : GrpcClientFactory
	{
		public TutorialMarketsClientFactory(string grpcServiceUrl, ILogger logger) : base(grpcServiceUrl, logger)
		{
		}

		public IGrpcServiceProxy<ITutorialMarketsService> GetTutorialMarketsService() => CreateGrpcService<ITutorialMarketsService>();
	}
}