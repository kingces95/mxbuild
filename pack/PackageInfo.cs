using System;

[AttributeUsage(AttributeTargets.Assembly)]
internal class NugetTargetFrameworkMonikerAttribute : Attribute {

    public NugetTargetFrameworkMonikerAttribute(string targetFramework) {
        TargetFramework = targetFramework;
    }

    public string TargetFramework { get; private set; }
}

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
internal class NugetReferenceAttribute : Attribute {

    internal NugetReferenceAttribute(string package, string version, string targetFramework, string assembly) {
        TargetFramework = targetFramework;
        Package = package;
        Version = version;
        Assembly = assembly;
    }

    public string Assembly { get; private set; }
    public string Package { get; private set; }
    public string Version { get; private set; }
    public string TargetFramework { get; private set; }
}