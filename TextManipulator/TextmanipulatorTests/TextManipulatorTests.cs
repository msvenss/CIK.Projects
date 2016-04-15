using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;
using TextManipulator.Core.ManipulateText.Rules;
using TextManipulator.Core.ReadText;
using TextManipulator.Core.WriteText;

namespace TextmanipulatorTests
{
    [TestFixture]
    public class TextManipulatorTests
    {
        [Test]
        public void Should_be_able_to_read_text_from_string()
        {
            var readFromString = new ReadText();
            var read = readFromString.Read();
            read.Length.Should().NotBe(null);
        }

        [Test]
        public void Should_be_able_to_replace_word()
        {
            var replaceWord = new ReplaceWord(new Dictionary<string, string> {{"foo", "newWord"}});
            var execute = replaceWord.Manipulate("Hello foo");
            execute.Should().Be("Hello newWord");
        }

        [Test]
        public void Should_be_able_to_write_text_to_string()
        {
            var writer = new TextToStringWriter();
            writer.Write("foo").Should().Be("foo");
        }

    }
}
