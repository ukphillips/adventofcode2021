using System.Net.Http;
using System.Net.Http.Headers;

internal class Program
{
    private static readonly HttpClient client = new HttpClient();

    static void Main(string[] args)
    {
        PartTwo().Wait();
    }

    private static async Task PartOne()
    {
        string inputString = string.Empty;
        // Open the text file using a stream reader.
        using (var sr = new StreamReader("input"))
        {
            inputString = sr.ReadToEnd();
            Console.WriteLine(inputString);
        }

        string[] lines = inputString.Split(new string[] { Environment.NewLine },StringSplitOptions.None);

        var previousDepth = -1;
        var totalMeasurementsGreaterThanPrevious = 0;
        foreach(string depth in lines)
        {
            var currentDepth = Int32.Parse(depth);

            if(previousDepth != -1 && currentDepth > previousDepth)
            {
                    totalMeasurementsGreaterThanPrevious++;
            }

            previousDepth = currentDepth;
        }

        Console.WriteLine($"Total Measurements larger than previous reading: {totalMeasurementsGreaterThanPrevious}");
    }

    private static async Task PartTwo()
    {
        string inputString = string.Empty;
        // Open the text file using a stream reader.
        using (var sr = new StreamReader("input"))
        {
            inputString = sr.ReadToEnd();
            Console.WriteLine(inputString);
        }

        string[] lines = inputString.Split(new string[] { Environment.NewLine },StringSplitOptions.None);
        List<int> measurementWindows = new List<int>();

        //Calculate window measurements
        for(var position = 0; (position + 2) < lines.Count(); position++)
        {
            var windowSum = Int32.Parse(lines[position]) + Int32.Parse(lines[position+1]) + Int32.Parse(lines[position+2]);
             measurementWindows.Add(windowSum);
             Console.WriteLine($"Window {position} sum: {windowSum}");
        }
        Console.WriteLine($"Total Windows: {measurementWindows.Count()}");

        //Calculate increases across windows
        var previousDepth = -1;
        var totalMeasurementsGreaterThanPrevious = 0;
        foreach(int depth in measurementWindows)
        {
            var currentDepth = depth;

            if(previousDepth != -1 && currentDepth > previousDepth)
            {
                    totalMeasurementsGreaterThanPrevious++;
            }

            previousDepth = currentDepth;
        }

                Console.WriteLine($"Total Measurements larger than previous reading: {totalMeasurementsGreaterThanPrevious}");
    }
}

