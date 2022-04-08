using System;
using System.Threading.Tasks;
using Service.Education.Structure;
using Service.TutorialMarkets.Grpc.Models.State;
using Service.TutorialMarkets.Grpc.Models.Task;
using Service.TutorialMarkets.Models;

namespace Service.TutorialMarkets.Services
{
	public interface ITaskProgressService
	{
		ValueTask<TestScoreGrpcResponse> SetTaskProgressAsync(string userId, EducationStructureUnit unit, EducationStructureTask task, bool isRetry, TimeSpan duration, int? progress = null);

		ValueTask<StateGrpcModel> GetUnitProgressAsync(string userId, int unit);

		ValueTask<TaskTypeProgressInfo> GetTotalProgressAsync(string userId, int? unit = null);
	}
}
