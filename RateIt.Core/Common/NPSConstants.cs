namespace RateIt.Core.Common
{
	public static class NPSConstants
	{
		public static NPSRespondentType GetRespondentType(int rating)
		{
			if (rating <= 6)
				return NPSRespondentType.Detractor;

			return rating >= 9 ? NPSRespondentType.Promoter : NPSRespondentType.Passive;
		}
	}
}