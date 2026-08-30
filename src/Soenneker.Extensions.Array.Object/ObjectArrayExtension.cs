using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Soenneker.Extensions.Spans.Readonly.Objects;

namespace Soenneker.Extensions.Array.Object;

/// <summary>
/// Provides extensions for arrays of objects.
/// </summary>
public static class ObjectArrayExtension
{
    /// <summary>
    /// Returns the runtime type of each non-null object in the same order.
    /// </summary>
    /// <param name="objects">The array of objects to convert.</param>
    /// <returns>A newly allocated array containing each element's runtime type, or an empty array when <paramref name="objects"/> is empty.</returns>
    /// <exception cref="NullReferenceException">An element in <paramref name="objects"/> is <see langword="null"/>.</exception>
    [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Type[] ToTypes(this object[] objects) => ((ReadOnlySpan<object>) objects).ToTypes();
}
