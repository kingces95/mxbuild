using System;

[AttributeUsage(AttributeTargets.Assembly)]
internal sealed class NugetPackageAttribute : Attribute {

    internal NugetPackageAttribute(string name, string version) {
        Name = name;
        Version = version;
    }

    internal string Name { get; private set; }
    internal string Version { get; private set; }
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