// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Placid : ModuleRules
{
	public Placid(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Placid",
			"Placid/Variant_Platforming",
			"Placid/Variant_Platforming/Animation",
			"Placid/Variant_Combat",
			"Placid/Variant_Combat/AI",
			"Placid/Variant_Combat/Animation",
			"Placid/Variant_Combat/Gameplay",
			"Placid/Variant_Combat/Interfaces",
			"Placid/Variant_Combat/UI",
			"Placid/Variant_SideScrolling",
			"Placid/Variant_SideScrolling/AI",
			"Placid/Variant_SideScrolling/Gameplay",
			"Placid/Variant_SideScrolling/Interfaces",
			"Placid/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
