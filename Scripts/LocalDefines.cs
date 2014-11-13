using Mophi;

namespace MathFactory
{
	public static class LocalDefines
	{
		public static string XML_PATH = @".\XML\";
		public const string BASEDB = @"Data Source=.\FactoryDB.mophi; Pooling=true; FailIfMissing=false";
	}

	public class _QuestionType : TypeNameContainer<_QuestionType>
	{
		public const int Unknown = 0;
		public const int SingleSelect = 1;
		public const int MultiSelect = 2;
		public const int YesOrNo = 3;
		public const int TextAnswer = 4;
		public const int Rate = 5;
		public const int Percentage = 6;
		public const int Mix = 0x7FFFFFFF;

		public static bool Initialize()
		{
			bool result = false;

			result &= RegisterType("Unknown", Unknown, "Unknown");
			result &= RegisterType("SingleSelect", SingleSelect, "SingleSelect");
			result &= RegisterType("MultiSelect", MultiSelect, "MultiSelect");
			result &= RegisterType("YesOrNo", YesOrNo, "YesOrNo");
			result &= RegisterType("TextAnswer", TextAnswer, "TextAnswer");
			result &= RegisterType("Rate", Rate, "Rate");
			result &= RegisterType("Percentage", Percentage, "Percentage");
			result &= RegisterType("Mix", Mix, "Mix");

			return result;
		}
	}
}
