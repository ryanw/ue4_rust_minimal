// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.IO;

public class City : ModuleRules
{
	public City(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        PublicAdditionalLibraries.Add("advapi32.lib");
        PublicAdditionalLibraries.Add("credui.lib");
        PublicAdditionalLibraries.Add("kernel32.lib");
        PublicAdditionalLibraries.Add("secur32.lib");
        PublicAdditionalLibraries.Add("advapi32.lib");
        PublicAdditionalLibraries.Add("ws2_32.lib");
        PublicAdditionalLibraries.Add("userenv.lib");
        PublicAdditionalLibraries.Add("shell32.lib");
        PublicAdditionalLibraries.Add("msvcrt.lib");


        PrivateIncludePaths.Add(Path.GetFullPath(Path.Combine(ModuleDirectory, "..\\..\\rust_2_ue4\\include")));
        PublicAdditionalLibraries.Add(Path.GetFullPath(Path.Combine(ModuleDirectory, "..\\..\\rust_2_ue4\\target\\release\\rust_2_ue4.lib")));

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
