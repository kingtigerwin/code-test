namespace PointsBet_Backend_Online_Code_Test.Tests
{
    public class StringFormatterTests
    {
        [Fact]
        public void ToCommaSeparatedList_ShouldJoinItemsWithCommas()
        {
            var items = new[] { "a", "b", "c" };
            var result = StringFormatter.ToCommaSeparatedList(items);

            Assert.Equal("a, b, c", result);
        }

        [Fact]
        public void ToCommaSeparatedList_ShouldWrapItemsWithQuotes()
        {
            var items = new[] { "a", "b" };
            var result = StringFormatter.ToCommaSeparatedList(items, "\"");

            Assert.Equal("\"a\", \"b\"", result);
        }

        [Fact]
        public void ToCommaSeparatedList_ShouldHandleNullOrEmptyItems()
        {
            var items = new[] { "", null, "x" };
            var result = StringFormatter.ToCommaSeparatedList(items, "'");

            Assert.Equal("'x'", result);
        }

        [Fact]
        public void ToCommaSeparatedList_ShouldReturnEmptyString_WhenNullInput()
        {
            string[]? items = null;
            var result = StringFormatter.ToCommaSeparatedList(items);

            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ToCommaSeparatedList_ShouldReturnEmptyStringDueToNullOrEmptyItems()
        {
            // Arrange
            string[] nullItems = null;
            var emptyItems = new string[0];

            // Act
            var nullItemsResult = StringFormatter.ToCommaSeparatedList(nullItems, "'");
            var emptyItemsResult = StringFormatter.ToCommaSeparatedList(emptyItems, "'");

            // Assert
            Assert.Equal(string.Empty, nullItemsResult);
            Assert.Equal(string.Empty, emptyItemsResult);
        }

        [Fact]
        public void ToCommaSeparatedList_ShouldReturnOriginalItemWithQuoteDueToSingleItem()
        {
            // Arrange
            var quote = "'";
            var items = new string[] { "a" };

            // Act
            var commaSeparatedList = StringFormatter.ToCommaSeparatedList(items, quote);

            // Assert
            Assert.Equal("'a'", commaSeparatedList);
        }

        [Fact]
        public void ToCommaSeparatedList_ShouldReturnCommaSeparatedStringDueToMultipleItems()
        {
            // Arrange
            var quote = "'";
            var items = new string[] { "a", "b", "c" };

            // Act
            var commaSeparatedList = StringFormatter.ToCommaSeparatedList(items, quote);

            // Assert
            Assert.Equal("'a', 'b', 'c'", commaSeparatedList);
        }
    }
}