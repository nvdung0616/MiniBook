﻿using System;
using System.Collections.Generic;
using System.Text;
using MiniBook.Models;

namespace MiniBook
{
    internal class AppContext
    {
        public static AppContext Current { get; } = new AppContext();

        public TokenResponse Token { get; set; }

        public User Profile { get; set; }
    }
}
