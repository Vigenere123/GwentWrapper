﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GwentSite.ApiWrapper.Models
{
    public interface IPageOfCardData
    {
        int Count { get; set; }
        string Next { get; set; }
        List<BasicInfo> Results { get; set; }
    }
}
