using UnrealBuildTool;

public class Paranoid02Target : TargetRules
{
	public Paranoid02Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Paranoid02");
	}
}
