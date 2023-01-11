//Writes the Pomo ascii art to the console in red.
void printAsciiLogo()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(
        "\r\n______                     " +
        "\r\n| ___ \\                    " +
        "\r\n| |_/ /__  _ __ ___   ___  " +
        "\r\n|  __/ _ \\| '_ ` _ \\ / _ \\ " +
        "\r\n| | | (_) | | | | | | (_) |" +
        "\r\n\\_|  \\___/|_| |_| |_|\\___/ " +
        "\r\n                           \r");
    Console.ForegroundColor = ConsoleColor.White;
}

//Converts time in seconds to mm:ss
string timer(int seconds)
{
    TimeSpan t = TimeSpan.FromSeconds(seconds);
    return string.Format("{0:D2}m:{1:D2}s", t.Minutes, t.Seconds);
}


//Convert totalSecondsWorked into hh:mm:ss
string totalTime(int seconds)
{
    TimeSpan t = TimeSpan.FromSeconds(seconds);
    return string.Format("{0:D2}h:{1:D2}m:{2:D2}s", t.Hours, t.Minutes, t.Seconds);
}

int totalSecondsWorked = 0;
//Main pomodoro loop
while (true)
{
    //25 minute study loop
    for (int i = 1500; i > 0; i--)
    {
        Console.Clear();

        printAsciiLogo();

        //Display work timer
        Console.WriteLine("Time: " + "{0:HH:mm:ss}", DateTime.Now);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Work for: " + timer(i));

        //Increase and display total working time
        totalSecondsWorked++;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Total working time: " + totalTime(totalSecondsWorked));

        //Wait 1 second
        Thread.Sleep(1000);
    }
    //5 minute break loop
    for (int j = 300; j > 0; j--)
    {
        Console.Clear();

        printAsciiLogo();

        //Display rest timer
        Console.WriteLine("Time: " + "{0:HH:mm:ss}", DateTime.Now);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Rest for: " + timer(j));

        //Display total working time
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Total working time: " + totalTime(totalSecondsWorked));

        //Wait 1 second
        Thread.Sleep(1000);
    }

}