using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : ContentPage
    {
         

        public Main()
        {
            InitializeComponent();
        }

        private async void Seven(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "7";
        }

        private async void Eight(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "8";
        }

        private async void Nine(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "9";
        }

        private async void Six(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "6";
        }

        private async void Five(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "5";
        }

        private async void Four(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "4";
        }

        private async void Three(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "3";
        }

        private async void Two(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "2";
        }

        private async void One(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "1";
        }

        private async void Multiply(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "x";
        }

        private async void Minus(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "-";
        }

        private async void Add(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "+";
        }

        private async void Div(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "/";
        }

        private async void Zero(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "0";
        }

        private async void Delete(object sender, EventArgs e)
        {
            Output.Text = string.Empty;
        }

        private async void DeleteAll(object sender, EventArgs e)
        {
            Output.Text = string.Empty;
            Result.Text = string.Empty;
        }

        private async void Persent(object sender, EventArgs e)
        {
            Result.Text = Output.Text + "%";
            var text = Output.Text;
            string[] ok;
            ok = (text.Split('%'));
            float x = float.Parse((ok[0]));
            float result = x / 100;
            Output.Text = result.ToString();
        }

        private async void Dot(object sender, EventArgs e)
        {
            Output.Text = Output.Text + ".";
        }

        private async void Equals(object sender, EventArgs e)
        {
            if (Output.Text.Contains("+"))
            {
                var text = Output.Text;
                Result.Text = text + "=";
                string[] ok;
                ok = (text.Split('+'));
                float x = float.Parse((ok[0]));
                float y = float.Parse((ok[1]));
                float result = x + y;
                Output.Text = result.ToString();

            }

            if (Output.Text.Contains("-"))
            {
                var text = Output.Text;
                Result.Text = text + "=";
                string[] ok;
                ok = (text.Split('-'));
                float x = float.Parse((ok[0]));
                float y = float.Parse((ok[1]));
                float result = x - y;
                Output.Text = result.ToString();
            }

            if (Output.Text.Contains("x"))
            {
                var text = Output.Text;
                Result.Text = text + "=";
                string[] ok;
                ok = (text.Split('x'));
                float x = float.Parse((ok[0]));
                float y = float.Parse((ok[1]));
                float result = x * y;
                Output.Text = result.ToString();

            }

            if (Output.Text.Contains("/"))
            {
                var text = Output.Text;
                Result.Text = text + "=";
                string[] ok;
                ok = (text.Split('/'));
                float x = float.Parse((ok[0]));
                float y = float.Parse((ok[1]));
                float result = x / y;
                Output.Text = result.ToString();

            }

        }



    }
}