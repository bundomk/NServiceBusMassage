﻿using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EContracts
{
    public class ERemoteMassage : IMessage
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}