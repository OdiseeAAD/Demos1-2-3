using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface INotifiable
    {
        string Title { get; }
        string Description { get; }
        string Logo { get; }

        void OnClicked();
    }

    class FacebookMessage : INotifiable
    {
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Logo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void OnClicked()
        {
            throw new NotImplementedException();
        }
    }
}
