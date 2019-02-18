using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MvvmCross.Forms.Views;
using PartialSway.ViewModels;

namespace PartialSway.Views
{
    public partial class MainPage : MvxContentPage<MainPageViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
