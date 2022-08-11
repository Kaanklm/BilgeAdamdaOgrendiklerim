﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Validate.Interface
{
    public interface IReport
    {
        void SendEmail(string email);
        void GeneratePerformanceReport(Employee sender);
    }
}
