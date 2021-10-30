using UnrealBuildTool;

public class SoulConcertTarget : TargetRules
{
	public SoulConcertTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SoulConcert");
	}
}
