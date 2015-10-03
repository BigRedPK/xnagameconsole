When the game console is open, you would normally want to prevent other input from the game to take effect as to prevent conflicts between game input and console input.

To check if the console is opened, use the `Opened` property:

```
if (console.Opened) { 
    //console is currently open, thus prevent game input
}
```

In future versions, I plan to automate this process via a flag.