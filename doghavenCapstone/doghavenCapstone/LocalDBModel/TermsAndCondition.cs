﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace doghavenCapstone.LocalDBModel
{
    public class TermsAndCondition
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(250)]
        public string isRead { get; set; }
    }
}
