using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace PartialSway.ViewModels
{
    public class MainPageViewModel : MvxViewModel
    {

        public MainPageViewModel()
        {
            SessionItems = new List<Session>
            {
                new Session(),
                new Session(),
                new Session(),
                new Session(),

            };
        }

        public List<Session> SessionItems { get; private set; }
        public class Session 
        {
            public string Name => "Hello World";
        }
    }
}
