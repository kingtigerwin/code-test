# String Formatter Library

A .NET library that provides string formatting utilities, specifically for creating comma-separated lists with optional quote wrapping.

## Features

- Convert arrays of strings into comma-separated lists
- Optional quote wrapping for each item
- Handles null and empty values gracefully
- Built for .NET 8.0

## Installation

The project is built using .NET 8.0. To build and run the project, ensure you have the [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed.

Clone the repository:
```bash
git clone https://github.com/kingtigerwin/code-test.git
cd code-test
```

## Usage

The library provides a `StringFormatter` class with a static method `ToCommaSeparatedList`:

```csharp
using PointsBet_Backend_Online_Code_Test;

// Basic usage without quotes
string[] items = new[] { "A", "B", "C" };
string result = StringFormatter.ToCommaSeparatedList(items);
// Result: "A, B, C"

// With quote wrapping
string resultWithQuotes = StringFormatter.ToCommaSeparatedList(items, "'");
// Result: "'A', 'B', 'C'"
```

### Features
- Handles null or empty arrays (returns empty string)
- Filters out null or empty items from the input array
- Supports custom quote characters

## Testing

The project includes a comprehensive test suite using xUnit. To run the tests:

```bash
cd CodeTest.Tests
dotnet test
```

### Test Coverage
- Basic comma separation
- Quote wrapping
- Null input handling
- Empty array handling
- Single item formatting
- Multiple items formatting
- Null/empty item filtering

## Project Structure

- `CodeTest/` - Main library project
  - `StringFormatter.cs` - Core formatting functionality
- `CodeTest.Tests/` - Test project
  - `StringFormatterTests.cs` - Comprehensive test suite

## Dependencies

- .NET 8.0
- xUnit (for testing)

## License

This project is proprietary software. All rights reserved.
