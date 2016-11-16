using System;

[assembly: NugetPackage("$(NuspecId)", "$(NuspecVersion)", "$(TargetFramework)")]
[assembly: NugetDependency("%(NugetDependency.Identity)", "%(Version)")]

[AttributeUsage(AttributeTargets.Assembly)]
internal sealed class NugetPackageAttribute : Attribute {

    internal NugetPackageAttribute(string name, string version, string targetFramework) {
        Name = name;
        Version = version;
        TargetFramework = targetFramework;
    }

    internal string Name { get; private set; }
    internal string Version { get; private set; }
    internal string TargetFramework { get; private set; }
}

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
internal sealed class NugetDependencyAttribute : Attribute {

    internal NugetDependencyAttribute(string package, string version) {
        Package = package;
        Version = version;
    }

    internal string Package { get; private set; }
    internal string Version { get; private set; }
}