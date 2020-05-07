﻿using System;
using System.Collections.Generic;

namespace userInterface
{
    /*Abstract class for all types of door*/
    abstract class Door : Component

    {
        protected const string attribute = "POR";

        public abstract string GetCupCode();
    }
}