namespace PointsBet_Backend_Online_Code_Test
{
    public class StringFormatter
    {

        /// <summary>
        /// This method is used to convert an array of strings into a single comma-separated string, 
        /// with each item optionally wrapped in a specified quote character.
        /// </summary>
        /// <param name="items"">
        /// An array of strings to be converted. e.g. new[] { "A", "B", "C" }.
        /// </param>
        /// <param name="quote">
        /// The quote character to wrap each item. e.g. "'" or "\""
        /// </param>
        /// <returns>
        /// A single string with items separated by commas and wrapped in quotes. e.g. "'A', 'B', 'C'".
        /// </returns>
        public static string ToCommaSeparatedList(string[] items, string quote = "")
        {
            // Handle null or empty input
            if (items == null || items.Length == 0)
                return string.Empty;

            // Filter out null or empty items
            var filteredItems = items.Where(item => !string.IsNullOrEmpty(item)).ToArray();

            // Use LINQ to project each item with quotes and join them with commas
            return string.Join(", ", filteredItems.Select(item => $"{quote}{item}{quote}"));
        }

    }
}