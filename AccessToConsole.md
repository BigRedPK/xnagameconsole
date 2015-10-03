Once instantiated, the `GameConsole` class adds itself as a [Service](http://msdn.microsoft.com/en-us/library/microsoft.xna.framework.game.services.aspx), which means you can get access to it with the following:

```
GameConsole console = (GameConsole) game.Services.GetService(typeof (GameConsole));
```