﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GoogleClientPlugin
{
    public class GoogleUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Uri Picture { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
