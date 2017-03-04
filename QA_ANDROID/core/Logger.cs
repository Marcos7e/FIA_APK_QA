using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_ANDROID.core
{
    public partial class Logger : Component
    {
        public Logger()
        {
            InitializeComponent();
        }

        public Logger(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
