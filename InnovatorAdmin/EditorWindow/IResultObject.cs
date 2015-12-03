﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovatorAdmin
{
  public interface IResultObject
  {
    bool PreferTable { get; }
    int ItemCount { get; }
    string GetText();
    DataTable GetTable();
  }
}