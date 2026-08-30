[![](https://img.shields.io/nuget/v/soenneker.extensions.array.object.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.array.object/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.array.object/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.array.object/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.array.object.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.array.object/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.array.object/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.array.object/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Array.Object

Returns the runtime `Type` of each element in an `object[]` while preserving array order.

## Installation

```bash
dotnet add package Soenneker.Extensions.Array.Object
```

## Usage

```csharp
using Soenneker.Extensions.Array.Object;

object[] values = ["hello", 42, DateTimeOffset.UtcNow];

Type[] types = values.ToTypes();

// types[0] == typeof(string)
// types[1] == typeof(int)
// types[2] == typeof(DateTimeOffset)
```

`ToTypes()` returns the actual runtime type from `GetType()`, not a variable's declared type. Value types stored in the array are boxed and still produce their underlying value type. Derived instances produce the derived type.

The returned `Type[]` is newly allocated for a non-empty input and has the same length and ordering as the source. An empty array produces an empty result.

Every element must be non-null; a null element causes `NullReferenceException` because null has no runtime type. If null is valid in the source data, filter it or choose an explicit placeholder type before calling this method.

Runtime types are useful for reflection dispatch, but exact types may not match an API that expects an interface, base class, or nullable wrapper. Perform assignability checks when using the result for method or constructor selection.
