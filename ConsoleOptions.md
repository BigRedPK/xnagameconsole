The console can be customized with a number of options.  These options can be accessed through the `GameConsoleOptions` class.

To set the initial options, instantiate a new `GameConsoleOptions` class, set your desired options and pass it through one of the `GameConsole`'s overloaded constructors:

```
GameConsoleOptions options = new GameConsoleOptions { FontColor = Color.Crimson, Prompt = ">", BackgroundColor = Color.DarkGreen };
GameConsole console = new GameConsole(this, spriteBatch, options);
```

The options can also be changed dynamically through the `Options` property of `GameConsole`:

```
console.Options.Height = 200;
```



---


### Options ###

**ToggleKey** (`Microsoft.Xna.Framework.Input.Keys`)

Gets or sets the key that is used to show / hide the console

Default: `Keys.OemTilde`

**BackgroundColor** (`Microsoft.Xna.Framework.Graphics.Color`)

Gets or sets the color for the background of the console

Default: `new Color(0, 0, 0, 125)`

**FontColor** (`Microsoft.Xna.Framework.Graphics.Color`)

Sets the same specified color for all of the following properties:

  * `BufferColor`
  * `PastCommandColor`
  * `PastCommandOutputColor`
  * `PromptColor`
  * `CursorColor`

Default: `Color.White`

**BufferColor** (`Microsoft.Xna.Framework.Graphics.Color`)

Gets or sets the color of the text in the buffer

Default: `Color.White`

**PastCommandColor** (`Microsoft.Xna.Framework.Graphics.Color`)

Gets or sets the color of the past commands

Default: `Color.White`

**PastCommandOutputColor** (`Microsoft.Xna.Framework.Graphics.Color`)

Gets or sets the color of the past command outputs

Default: `Color.White`

**PromptColor** (`Microsoft.Xna.Framework.Graphics.Color`)

Gets or sets the color of the prompt

Default: `Color.White`

**CursorColor** (`Microsoft.Xna.Framework.Graphics.Color`)

Gets or sets the color of the cursor

Default: `Color.White`

**AnimationSpeed** (`float`)

Gets or sets the speed by which the console opens/closes

Default: `1`

**CursorBlinkSpeed** (`float`)

Gets or sets the speed by which the cursor blinks

Default: `0.5f`

**Height** (`int`)

Gets or sets the height of the console, in pixels

Default: `300`

**Prompt** (`string`)

Gets or sets the [prompt](http://en.wikipedia.org/wiki/Command-line_interface#Command_prompt)

Default: `$`

**Cursor** (`char`)

Gets or sets the cursor display character

Default: `_`

**Padding** (`int`)

Gets or sets the padding, in pixels, between the border of the console and the inner text

Default: `30`

**Margin** (`int`)

Gets or sets the margin, in pixels, between the left and right side of the screen to the console border

Default: `30`

**OpenOnWrite** (`bool`)

Gets or sets a boolean value that indicates whether to open the console, if it's closed, when [writing to the console](WritingToTheConsole.md)

Default: `true`

**Font** (`Microsoft.Xna.Framework.Graphics.SpriteFont`)

Gets or sets the font that is used in the console

Default: Consolas, Regular, 11pt