﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Models
{
    public class ReadUserJson
    {
        public Response response { get; set; }
    }
    public class Response
    {
        public string displayName { get; set; }
    }
}
