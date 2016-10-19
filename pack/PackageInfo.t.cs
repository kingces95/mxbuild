using System;

[assembly: NugetTargetFrameworkMoniker("$(TargetFramework)")]
[assembly: NugetDependency("%(NugetDependency.Identity)", "%(Version)")]

[AttributeUsage(AttributeTargets.Assembly)]
internal class NugetTargetFrameworkMonikerAttribute : Attribute {

    public NugetTargetFrameworkMonikerAttribute(string targetFramework) {
        TargetFramework = targetFramework;
    }

    public string TargetFramework { get; private set; }
}

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
internal class NugetDependencyAttribute : Attribute {

    internal NugetDependencyAttribute(string package, string version) {
        Package = package;
        Version = version;
    }

    public string Package { get; private set; }
    public string Version { get; private set; }
}