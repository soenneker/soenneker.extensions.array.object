using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

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
    public static Type[] ToTypes(this object[] objects)
    {
        int length = objects.Length;
        var parameterTypes = new Type[length];

        for (var i = 0; i < length; i++)
        {
            parameterTypes[i] = objects[i].GetType();
        }

        return parameterTypes;
    }
}