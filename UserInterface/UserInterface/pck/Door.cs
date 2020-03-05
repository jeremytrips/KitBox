﻿using System;
using System.Collections.Generic;

namespace userInterface
{
    /*Abstract class for all types of door*/
    abstract class Door : Component

    {
        /*Variable that contains either glassdoor or classicdoor*/
        protected int width;
        protected string type;

        //public override abstract Dictionary<string, Object> GetDescription();
        //protected string determiningDimension1 = "width";
        //protected string determiningDimension2 = "height";
    }
}