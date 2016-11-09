using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsBeispiel.ViewModels
{
    class MainViewModels
    {
        private string title;
        private double price;

        #region Properties
        public double Price
        {
            get { return price; }
            set { price = value; }
        }



        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        #endregion
    }
}
