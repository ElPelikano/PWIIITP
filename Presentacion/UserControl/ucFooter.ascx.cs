﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class ucFooter : System.Web.UI.UserControl
    {
        public string lblText
        {
            set { lbl.Text = value; }
        }

    }
}