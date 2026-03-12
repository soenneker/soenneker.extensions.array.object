using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Soenneker.Extensions.Spans.Readonly.Objects;

namespace Soenneker.Extensions.Array.Object;

/// <summary>
/// A collection of helpful object[] extension methods
/// </summary>
public static class ObjectArrayExtension
{
    /// <summary>
    /// Converts an array of objects to an array of their corresponding types.
    /// </summary>
    /// <param name="objects">The array of objects to convert.</param>
    /// <returns>An array of Type objects representing the types of the input objects.</returns>
    [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Type[] ToTypes(this object[] objects) => ((ReadOnlySpan<object>) objects).ToTypes();
}