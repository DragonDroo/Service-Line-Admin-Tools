﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Slats
{
    partial class QuestionsDictionary
    {
        private void txtbScoreValue_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            TextBox txtb = sender as TextBox;
            int parsedValue;
            if (!int.TryParse(txtb.Text, out parsedValue))
            {
                txtb.Text = "";
                return;
            }
        }
    }
}
