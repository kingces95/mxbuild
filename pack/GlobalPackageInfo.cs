using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyDescription("$(NuspecDescription)")]
[assembly: AssemblyCompany("$(NuspecOwners)")]
[assembly: AssemblyProduct("$(NuspecId)")]
[assembly: AssemblyCopyright("$(NuspecCopyright)")]
[assembly: AssemblyTrademark("")]

// type conflicts with the imported type; happens when IVT is used
#pragma warning disable 0436
[assembly: NugetPackage("$(NuspecId)", "$(NuspecVersion)")]
[assembly: NugetDependency("%(Name)", "%(Version)")] // %(NugetReference.Identity)
[assembly: NugetTargetFramework("$(NugetTargetFrameworkMoniker)", Version = "$(NugetTargetFrameworkVersion)")]

#if NUGET_BUILD_ASSEMBLY
[assembly: NugetBuildAssembly(Directory = "$(NugetBuildAssemblySubDirName)")]
#endif
#pragma warning restore 0436
