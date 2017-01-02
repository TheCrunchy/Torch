﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torch.API
{
    public interface ILogger
    {
        void Write(string message);
        void WriteException(Exception e);
    }
}