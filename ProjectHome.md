XnaGameConsole is a game developer console that can be used in any XNA game.

## Quick Start ##

Add the compiled XnaGameConsole dll as a reference and initialize the `GameConsole`:

```
GameConsole console = new GameConsole(this, spriteBatch); // where `this` is your `Game` class
```

By default, the console is opened with the ` (OemTilde key) but this, amongst other settings, can be changed via the [Options](ConsoleOptions.md) property.

## Features ##

  * [Add your own commands](AddingCommands.md)
  * [Customizable Options](ConsoleOptions.md)
  * [Clipboard Support](ClipboardSupport.md)
  * [External Writing](WritingToTheConsole.md)
  * Command Auto-Complete
  * Command History

## Screenshots ##

![http://2.bp.blogspot.com/_xl08dEExoZk/TG_xVPG01eI/AAAAAAAAA5E/t01-LxJ7v8Q/s320/xnaconsole_default.png](http://2.bp.blogspot.com/_xl08dEExoZk/TG_xVPG01eI/AAAAAAAAA5E/t01-LxJ7v8Q/s320/xnaconsole_default.png)
![http://4.bp.blogspot.com/_xl08dEExoZk/TG_xYEBCEcI/AAAAAAAAA5M/Lx_BaFa6Vto/s320/xnaconsole_custom.png](http://4.bp.blogspot.com/_xl08dEExoZk/TG_xYEBCEcI/AAAAAAAAA5M/Lx_BaFa6Vto/s320/xnaconsole_custom.png)
![http://3.bp.blogspot.com/_xl08dEExoZk/THNCSQAY2NI/AAAAAAAAA5U/dKFramcaDv4/s320/xnaconsole_custom2.png](http://3.bp.blogspot.com/_xl08dEExoZk/THNCSQAY2NI/AAAAAAAAA5U/dKFramcaDv4/s320/xnaconsole_custom2.png)