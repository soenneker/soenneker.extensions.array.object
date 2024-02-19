using System;

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
    public static Type[] ToTypes(this object[] objects)
    {
        ReadOnlySpan<object> span = objects;

        var parameterTypes = new Type[span.Length];

        for (var i = 0; i < span.Length; i++)
        {
            parameterTypes[i] = span[i].GetType();
        }

        return parameterTypes;
    }
}