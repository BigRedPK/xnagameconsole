﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace XNAGameConsole
{
    public class GameConsoleOptions
    {
        public char ToggleKey { get; set; }
        public Color BackgroundColor { get; set; }
        public Color FontColor { get; set; }
        public float AnimationSpeed { get; set; }
        public float CursorBlinkSpeed { get; set; }
        public int Height { get; set; }
        public string Prompt { get; set; }
        public int Padding { get; set; }
        public int Margin { get; set; }
        public bool OpenOnWrite { get; set; }
        public SpriteFont Font { get; set; }
        internal Texture2D RoundedCorner { get; set; }

        public GameConsoleOptions()
        {
            //Set the default options
            ToggleKey = '`';
            BackgroundColor = new Color(0, 0, 0, 125);
            FontColor = Color.White;
            AnimationSpeed = 1;
            CursorBlinkSpeed = 0.5f;
            Height = 300;
            Prompt = "$";
            Padding = 30;
            Margin = 30;
            OpenOnWrite = true;
        }

        internal static GameConsoleOptions Options { get; set; }
        internal static List<IConsoleCommand> Commands { get; set; }
    }
}
