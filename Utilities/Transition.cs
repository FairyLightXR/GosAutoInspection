using GosAutoInspection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GosAutoInspection.Utilities
{
    internal class Transition
    {
        public static Frame MainFrame { get; set; }

        private static GosAutoInspectionBDEntities context;
        public static GosAutoInspectionBDEntities Context
        {
            get
            {
                if (context == null)
                    context = new GosAutoInspectionBDEntities();

                return context;
            }
        }
    }
}
