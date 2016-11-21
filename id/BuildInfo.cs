using System;

[AttributeUsage(AttributeTargets.Assembly)]
internal class EnlistmentUrlAttribute : Attribute {
    public EnlistmentUrlAttribute(string url) { Url = url; }
    public string Url { get; set; }
}
[AttributeUsage(AttributeTargets.Assembly)]
internal class EnlistmentBranchAttribute : Attribute {
    public EnlistmentBranchAttribute(string branch) { Branch = branch; }
    public string Branch { get; set; }
}
[AttributeUsage(AttributeTargets.Assembly)]
internal class EnlistmentRevisionAttribute : Attribute {
    public EnlistmentRevisionAttribute(string revision) { Revision = revision; }
    public string Revision { get; set; }
}

internal static class BuildVersion {
    internal const string Number = "0";
    internal const string MajorVersion = "0";
    internal const string MinorVersion = "0";
}
