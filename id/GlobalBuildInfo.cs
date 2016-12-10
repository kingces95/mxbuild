using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("$(AssemblyName)")]
[assembly: AssemblyConfiguration("$(Configuration)")]
[assembly: AssemblyVersion(BuildVersion.MajorVersion + "." + BuildVersion.MinorVersion + "." + BuildVersion.Number)]

// type conflicts with the imported type; happens when IVT is used
#pragma warning disable 0436
[assembly: EnlistmentUrl("$(EnlistmentUrl)")]
[assembly: EnlistmentBranch("$(EnslitmentBranch)")]
[assembly: EnlistmentRevision("$(EnlistmentRevision)")]
#pragma warning restore 0436

[assembly: ComVisible(false)]
