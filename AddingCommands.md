There are currently 2 ways how to add custom commands to the console:

## Using IConsoleCommand ##
Console commands can be built via the `IConsoleCommand` interface.

The following is an example of a command:

```
    class MovePlayerCommand:IConsoleCommand
    {
        public string Name
        {
            get { return "move"; }
        }

        public string Description
        {
            get { return "Moves the player"; }
        }

        private Player player;
        public MovePlayerCommand(Player player)
        {
            this.player = player;
        }

        public string Execute(string[] arguments)
        {
            var newPosition = new Vector2(float.Parse(arguments[0]), float.Parse(arguments[1]));
            player.Position = newPosition;
            return "Moved player to " + newPosition;
        }
    }
```

Such a command can then be added to the console like such:

```
console.AddCommand(new MovePlayerCommand(player));
```

## Via a Func<string[.md](.md), string> ##

Commands can also be added without using `IConsoleCommand`, like the following:

```
console.AddCommand("rotRad", a =>
                                 {
                                     var angle = float.Parse(a[0]);
                                     player.Angle = angle;
                                     return String.Format("Rotated the player to {0} radians", angle);
                                 }, "Rotates the player");
```

The advantage of adding a command like this is that in the `Func<>` you have access to the variables outside the closure.