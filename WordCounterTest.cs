using WordCounter;
using Xunit;
public class WordCounterTest
{
    [Fact]
    public void UniqueWordCounterTest()
    {
        var text = "Go and do that thing more that you do not so well";
        var text2 = "I do many things very well";
        var uniqueWordCounter = new UniqueWordCounter();
        var result = uniqueWordCounter.GetNumberOfUniqueWords(text);
        var result2 = uniqueWordCounter.GetNumberOfUniqueWords(text2);
        Assert.Equal(10, result);
        Assert.Equal(6,result2);
    }
}