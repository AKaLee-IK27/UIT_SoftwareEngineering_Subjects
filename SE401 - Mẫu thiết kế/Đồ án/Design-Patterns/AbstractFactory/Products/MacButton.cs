﻿using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    internal class MacButton : IButton
    {
        public string OnClick(string text)
        {
            return $"Mac button clicked. Message: {text}";
        }

        public string Render()
        {
            return "Rendering Mac button...";
        }
    }
}
