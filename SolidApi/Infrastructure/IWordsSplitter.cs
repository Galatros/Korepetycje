﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidApi.Infrastructure
{
    public interface IWordsSplitter
    {
        string[] SplitWordsInString(string text);
    }
}
