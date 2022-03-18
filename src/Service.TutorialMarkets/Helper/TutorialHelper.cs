using Service.Education.Structure;

namespace Service.TutorialMarkets.Helper
{
	public static class TutorialHelper
	{
		public static readonly EducationTutorial Tutorial = EducationTutorial.FinanceMarkets;

		public static readonly EducationStructureTutorial StructureTutorial = EducationStructure.Tutorials[Tutorial];
	}
}