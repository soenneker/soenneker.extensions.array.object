[![](https://img.shields.io/nuget/v/soenneker.extensions.array.object.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.array.object/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.array.object/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.array.object/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.array.object.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.array.object/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.array.object/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.array.object/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Array.Object

A collection of helpful object[] extension methods.

## Installation

```bash
dotnet add package Soenneker.Extensions.Array.Object
```

## Quick start

```csharp
using Soenneker.Extensions.Array.Object;

// Given an existing object[] named objects:
var result = objects.ToTypes();
```

## Common operations

- `ToTypes()` - Converts an array of objects to an array of their corresponding types. Returns an array of Type objects representing the types of the input objects.
