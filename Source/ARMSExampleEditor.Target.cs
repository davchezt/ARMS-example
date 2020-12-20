// Copyright � 2020 Raiza Rhamdan

using UnrealBuildTool;
using System.Collections.Generic;

public class ARMSExampleEditorTarget : TargetRules
{
	public ARMSExampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ARMSExample" } );
	}
}
