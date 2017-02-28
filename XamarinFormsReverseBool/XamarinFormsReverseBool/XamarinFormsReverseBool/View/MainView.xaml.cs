using System;

using Xamarin.Forms;

namespace XamarinFormsReverseBool.View
{
    public partial class MainView : ContentPage
    {
        private bool _VisibleText;
        public bool VisibleText
        {
            get { return _VisibleText; }
            set
            {
                _VisibleText = value;
                OnPropertyChanged("VisibleText");
            }
        }

        public MainView()
        {
            InitializeComponent();
            VisibleText = true;
            BindingContext = this;
        }

        public void OnButtonClicked(object sender, EventArgs args)
        {
            VisibleText = !VisibleText;
        }
    }
}
