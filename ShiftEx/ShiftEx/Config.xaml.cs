using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShiftEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Config : ContentPage
    {
        public bool Enviar { get { return enviar.On; } }
        public string Email { get { return txtNome.Text; } }
        public Config()
        {
            InitializeComponent();
        }

    }
}