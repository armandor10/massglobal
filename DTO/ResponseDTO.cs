﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ResponseDTO
    {
        public bool status { get; set; }
        public string message { get; set; }
        public Object data { get; set; }
    }
}
