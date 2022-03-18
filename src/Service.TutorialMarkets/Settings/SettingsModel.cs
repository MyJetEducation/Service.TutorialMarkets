using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.TutorialMarkets.Settings
{
	public class SettingsModel
	{
		[YamlProperty("TutorialMarkets.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("TutorialMarkets.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("TutorialMarkets.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("TutorialMarkets.EducationProgressServiceUrl")]
		public string EducationProgressServiceUrl { get; set; }

		[YamlProperty("TutorialMarkets.EducationRetryServiceUrl")]
		public string EducationRetryServiceUrl { get; set; }

		[YamlProperty("TutorialMarkets.UserRewardServiceUrl")]
		public string UserRewardServiceUrl { get; set; }

		[YamlProperty("TutorialMarkets.UserProgressServiceUrl")]
		public string UserProgressServiceUrl { get; set; }
	}
}