using System;
using System.Threading.Tasks;
using Service.TutorialMarkets.Grpc;
using Service.TutorialMarkets.Grpc.Models.State;
using Service.TutorialMarkets.Mappers;
using Service.TutorialMarkets.Models;
using Service.UserReward.Grpc;
using Service.UserReward.Grpc.Models;

namespace Service.TutorialMarkets.Services
{
	public partial class TutorialMarketsService : ITutorialMarketsService
	{
		private readonly ITaskProgressService _taskProgressService;
		private readonly IUserRewardService _userRewardService;

		public TutorialMarketsService(ITaskProgressService taskProgressService, IUserRewardService userRewardService)
		{
			_taskProgressService = taskProgressService;
			_userRewardService = userRewardService;
		}

		public async ValueTask<FinishStateGrpcResponse> GetFinishStateAsync(GetFinishStateGrpcRequest request)
		{
			string userId = request.UserId;
			int? unit = request.Unit;

			TaskTypeProgressInfo typeProgressInfo = await _taskProgressService.GetTotalProgressAsync(userId, unit);

			UserAchievementsGrpcResponse achievements = await _userRewardService.GetUserNewAchievementsAsync(new GetUserAchievementsGrpcRequest
			{
				UserId = userId,
				Unit = unit
			});

			return typeProgressInfo.ToGrpcModel(achievements?.Items);
		}
	}
}
