using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Identificando qual botão disparou o evento
            Button btn = (Button)sender;
            
            // Desabilitando o botão
            btn.IsEnabled = false;

            // Trocando texto do botão de acordo com quem é a vez.
            if (vez == "X")
            {
                btn.Text = "X";                
                vez = "O";
            } else
            {
                btn.Text = "O";
                vez = "X";
            }

            // verificando se a primeira linha(horizontal) teve ganhador
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();            

            } else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            // verficando se a segunda linha(horizontal) teve ganhador
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            } else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }



            // verificando se a terceira linha(horizontal) teve ganhador
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            } else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }



            // verificando se a diagonal teve ganhador
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            }
            else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }


            // verficando se a outra diagonal teve ganhador 
            if (btn12.Text == "X" && btn21.Text=="X" && btn30.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            } else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }


            // verificando se a vertical teve ganhador
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            } else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }



            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            }
            else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();

            }


            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            }
            else if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();

            }
            else if (btn10.IsEnabled == false && btn11.IsEnabled == false && btn12.IsEnabled == false && btn20.IsEnabled == false && btn21.IsEnabled == false && btn22.IsEnabled == false && btn30.IsEnabled == false && btn31.IsEnabled == false && btn32.IsEnabled == false)

            {
                await DisplayAlert("Vish...", "Deu Velha!", "OK");
                zerar();

            }

        }
    
    
        void zerar()
        {
            btn10.IsEnabled = true;
            btn10.Text = "";
            btn11.IsEnabled = true;
            btn11.Text = "";
            btn12.IsEnabled = true;
            btn12.Text = "";
            btn20.IsEnabled = true;
            btn20.Text = "";
            btn21.IsEnabled = true;
            btn21.Text = "";
            btn22.IsEnabled = true;
            btn22.Text = "";
            btn30.IsEnabled = true;
            btn30.Text = "";
            btn31.IsEnabled = true;
            btn31.Text = "";
            btn32.IsEnabled = true;
            btn32.Text = "";

        }    
    }
}
