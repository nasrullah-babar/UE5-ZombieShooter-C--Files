// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FPSSurvival : ModuleRules
{
	public FPSSurvival(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput", "HeadMountedDisplay", "Niagara", "AIModule", "NavigationSystem", "GameplayTasks" });
	}
}
