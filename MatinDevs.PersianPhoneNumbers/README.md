# Persian Phone Numbers for .NET

The `MatinDevs.PersianPhoneNumbers` library provides a C# class, `PersianPhone`, designed to handle Persian phone numbers. This class facilitates the conversion of Persian digits to English equivalents, validation of phone number formats according to Persian mobile phone standards, and implicit conversion from a string to a `PersianPhone` object.

## Usage

To use the `PersianPhone` class, simply instantiate it with a Persian phone number:

```csharp
string persianNumber = "۰۹۱۲۳۴۵۶۷۸۹";
PersianPhone phone = new PersianPhone(persianNumber);

Console.WriteLine(phone.Value); // Output: 09123456789
```

The `Value` property of the `PersianPhone` object contains the converted phone number in English digits.

## Installation

This library can be easily installed via NuGet. Add the following package reference to your project file:

```xml
<PackageReference Include="MatinDevs.PersianPhoneNumbers" Version="1.0.0" />
```

## License

This library is licensed under the MIT License.

## Links

- [GitHub Repository](https://github.com/itsMatinDevs/MatinDevs.PersianPhoneNumbers)