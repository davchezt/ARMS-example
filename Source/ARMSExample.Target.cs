// Copyright � 2020 Raiza Rhamdan

using UnrealBuildTool;
using System.Collections.Generic;

public class ARMSExampleTarget : TargetRules
{
	public ARMSExampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ARMSExample" } );
	}
}
