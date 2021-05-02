﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SurveyWebform.UserControls
{
    public partial class LoginUserControl : System.Web.UI.UserControl
    {
        public string UsernameTextBox
        {
            get
            {
                return id_TextBoxUsername.Text;
            }
            set
            {
                id_TextBoxUsername.Text = value;
            }
        }

        public string PasswordTextBox
        {
            get
            {
                return id_TextBoxPassword.Text;
            }
            set
            {
                id_TextBoxPassword.Text = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

    }
}