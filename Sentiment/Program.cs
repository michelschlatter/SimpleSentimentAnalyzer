using VaderSharp;



SentimentIntensityAnalyzer analyzer = new SentimentIntensityAnalyzer();
Console.WriteLine("Hi! Welcome to the Sentiment Analyzer");

while (true)
{
    Console.WriteLine("Type your text and press enter");
    string text = Console.ReadLine() ?? "";
    if (string.IsNullOrEmpty(text))
    {
        Console.WriteLine("No empty strings allowed");
    }
    else
    {
        var results = analyzer.PolarityScores(text);

        Console.WriteLine("Positive score: " + results.Positive);
        Console.WriteLine("Negative score: " + results.Negative);
        Console.WriteLine("Neutral score: " + results.Neutral);
        Console.WriteLine("Compound score: " + results.Compound);
    }
}