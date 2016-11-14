using System;

[AttributeUsage(AttributeTargets.Assembly)]
internal sealed class NugetTargetFrameworkMonikerAttribute : Attribute {

    internal NugetTargetFrameworkMonikerAttribute(string targetFramework) {
        TargetFramework = targetFramework;
    }

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