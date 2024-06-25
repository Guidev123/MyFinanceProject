﻿using MyFinance.Shared.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Shared.Commands.Transactions
{
    public class GetTransactionByIdCommand : Command
    {
        public long Id { get; set; }
    }
}
