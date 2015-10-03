The console supports pasting via CTRL+V but this requires the game to be running in a Single Threaded Apartment.

To do this, add the `STAThread` attribute to the entry point of your game:

```
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            using (Game1 game = new Game1())
            {
                game.Run();
            }
        }
    }
```