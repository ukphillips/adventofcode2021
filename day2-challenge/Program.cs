internal class Program2
{
    private static readonly HttpClient client = new HttpClient();

    static void Main(string[] args)
    {
        PartTwo().Wait();
    }

    private static async Task PartOne()
    {
        List<string> inputs = new List<string>();
        
        var forwardPosition = 0;
        var depthPosition = 0;

        // Open the text file using a stream reader.
        using (var sr = new StreamReader("input"))
        {
            string line;

            while ((line = sr.ReadLine()) != null)
            {

                Console.WriteLine("Reading input");
            var commands = line.Split(" ");
            var command = commands[0];
            var commandValue = int.Parse(commands[1]);
            Console.WriteLine($"Reading input {command} {commandValue.ToString()}");
            switch(command)
            {
                case "forward":
                    forwardPosition = forwardPosition + commandValue;
                    break;
                case "up":
                    depthPosition = depthPosition - commandValue;
                    break;
                case "down": 
                    depthPosition = depthPosition + commandValue;
                    break;
                default:
                    break;
            }
            }
        }

        Console.WriteLine($"Total Outputs: {forwardPosition * depthPosition}");
    }

   private static async Task PartTwo()
    {
        List<string> inputs = new List<string>();
        
        var forwardPosition = 0;
        var depthPosition = 0;
        var aimPosition = 0;
        // Open the text file using a stream reader.
        using (var sr = new StreamReader("input"))
        {
            string line;

            while ((line = sr.ReadLine()) != null)
            {

                Console.WriteLine("Reading input");
            var commands = line.Split(" ");
            var command = commands[0];
            var commandValue = int.Parse(commands[1]);
            Console.WriteLine($"Reading input {command} {commandValue.ToString()}");
            switch(command)
            {
                case "forward":
                    forwardPosition = forwardPosition + commandValue;
                    depthPosition = depthPosition + (commandValue * aimPosition);
                    break;
                case "up":
                    //depthPosition = depthPosition - commandValue;
                    aimPosition = aimPosition - commandValue;
                    break;
                case "down": 
                    //depthPosition = depthPosition + commandValue;
                    aimPosition = aimPosition + commandValue;
                    break;
                default:
                    break;
            }
            }
        }

        Console.WriteLine($"Total Outputs: {forwardPosition * depthPosition}");
    }
}