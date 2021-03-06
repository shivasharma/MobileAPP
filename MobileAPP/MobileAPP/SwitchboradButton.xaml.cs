﻿using Xamarin.Forms;

namespace MSTL
{
    public partial class SwitchboradButton : ContentView
    {
        public SwitchboradButton()
        {
            InitializeComponent();
        }

        public ImageSource Icon
        {
            get { return SwitchboardIcon.Source; }
            set { SwitchboardIcon.Source = value; }
        }

        public string Label
        {
            get { return SwitchboardLabel.Text; }
            set { SwitchboardLabel.Text = value; }
        }
    }
}