﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexLegendsApp.Views
{

    public class MasterDetailMenuDetailMenuItemMenuItem
    {
        public MasterDetailMenuDetailMenuItemMenuItem()
        {
            TargetType = typeof(MasterDetailMenuDetailMenuItemDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}