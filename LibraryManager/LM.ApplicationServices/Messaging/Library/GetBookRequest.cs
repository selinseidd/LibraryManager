﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.ApplicationServices.Messaging.Library
{
    public class GetBookRequest : IntegerIdRequest
    {
        public GetBookRequest(int id) : base(id) { }
    }
}
