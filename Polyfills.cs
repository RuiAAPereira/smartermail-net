#if NETSTANDARD2_0
// Required to support C# 9 record types and init-only setters on netstandard2.0
namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
}
#endif
