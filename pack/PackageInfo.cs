using System;

[AttributeUsage(AttributeTargets.Assembly)]
internal sealed class NugetTargetFrameworkAttribute : Attribute {
    public NugetTargetFrameworkAttribute(string monkier) {
        Monkier = monkier;
    }

    public string Monkier { get; private set; }
    public string Version { get; set; }
}

[AttributeUsage(AttributeTargets.Assembly)]
internal sealed class NugetPackageAttribute : Attribute {

    public NugetPackageAttribute(string name, string version) {
        Name = name;
        Version = version;
    }

    public string Name { get; private set; }
    public string Version { get; private set; }
}

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
internal sealed class NugetDependencyAttribute : Attribute {

    public NugetDependencyAttribute(string package, string version) {
        Package = package;
        Version = version;
    }

    public string Package { get; private set; }
    public string Version { get; private set; }
}

[AttributeUsage(AttributeTargets.Assembly)]
internal sealed class NugetBuildAssemblyAttribute : Attribute {

    public NugetBuildAssemblyAttribute() {
    }

    public string Directory { get; set; }
}
