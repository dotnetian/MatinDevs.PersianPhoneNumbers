namespace MatinDevs.PersianPhoneNumbers;

/// <summary>
/// Represents a Persian phone number.
/// </summary>
/// <remarks>
/// This class provides functionality to work with Persian phone numbers,
/// converting them to English digits and validating the format.
/// </remarks>
public sealed class PersianPhone
{
    /// <summary>
    /// Gets the value of the Persian phone number in English digits.
    /// </summary>
    public string Value { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PersianPhone"/> class.
    /// </summary>
    /// <param name="phoneNumber">The input Persian phone number.</param>
    /// <exception cref="ArgumentException">Thrown when the input phone number has an invalid format.</exception>
    /// <remarks>
    /// This constructor takes a Persian phone number, converts it to English digits,
    /// and validates its format. If the format is invalid, an ArgumentException is thrown.
    /// </remarks>
    public PersianPhone (string phoneNumber)
    {
        // Convert Persian digits to English digits
        string englishPhoneNumber = ConvertToEnglish (phoneNumber);

        // Validate the format of the phone number
        Value = englishPhoneNumber.IsPersianPhoneValid () ? englishPhoneNumber : throw new ArgumentException ("Invalid phone number format.");
    }

    /// <summary>
    /// Converts Persian digits in the given phone number to English digits.
    /// </summary>
    /// <param name="phoneNumber">The input Persian phone number.</param>
    /// <returns>The phone number with Persian digits replaced by their English counterparts.</returns>
    /// <remarks>
    /// This method replaces Persian digits with their corresponding English digits in the provided phone number.
    /// </remarks>
    private static string ConvertToEnglish (string phoneNumber)
    {
        return phoneNumber.Replace ('۰', '0')
                          .Replace ('۱', '1')
                          .Replace ('۲', '2')
                          .Replace ('۳', '3')
                          .Replace ('۴', '4')
                          .Replace ('۵', '5')
                          .Replace ('۶', '6')
                          .Replace ('۷', '7')
                          .Replace ('۸', '8')
                          .Replace ('۹', '9');
    }

    /// <summary>
    /// Implicitly converts a string to a PersianPhone object.
    /// </summary>
    /// <param name="phoneNumber">The input string representing a Persian phone number.</param>
    /// <returns>A new instance of the <see cref="PersianPhone"/> class.</returns>
    /// <remarks>
    /// This conversion allows using a string directly where a PersianPhone object is expected.
    /// </remarks>
    public static implicit operator PersianPhone (string phoneNumber) => new PersianPhone (phoneNumber);

    /// <summary>
    /// Returns the string representation of the Persian phone number.
    /// </summary>
    /// <returns>The Persian phone number in English digits.</returns>
    /// <remarks>
    /// This method overrides the ToString() method to provide the string representation of the Persian phone number.
    /// </remarks>
    public override string ToString () => Value;
}

/// <summary>
/// Represents validation methods for persian phone numbers.
/// </summary>
public static class PersianPhoneValidator
{
    /// <summary>
    /// Validates the format of the phone number.
    /// </summary>
    /// <param name="phoneNumber">The input phone number in English digits.</param>
    /// <returns>True if the format is valid; otherwise, false.</returns>
    /// <remarks>
    /// This method checks if the provided phone number starts with "09" and has a length of 11 digits,
    /// indicating a valid Persian mobile phone number format.
    /// </remarks>
    public static bool IsPersianPhoneValid (this string phoneNumber)
    {
        return phoneNumber.StartsWith ("09") && phoneNumber.Length == 11;
    }
}