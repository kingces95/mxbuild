using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("$(AssemblyName)")]
[assembly: AssemblyConfiguration("$(Configuration)")]

// type conflicts with the imported type; happens when IVT is used
#pragma warning disable 0436
[assembly: AssemblyVersion(BuildVersion.MajorVersion + "." + BuildVersion.MinorVersion + "." + BuildVersion.Number)]
[assembly: EnlistmentUrl("$(EnlistmentUrl)")]
[assembly: EnlistmentBranch("$(EnslitmentBranch)")]
[assembly: EnlistmentRevision("$(EnlistmentRevision)")]
#pragma warning restore 0436

[assembly: ComVisible(false)]
