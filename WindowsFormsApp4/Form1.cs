using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        bool jogadorX=true;
        int jogadas = 0;
       
        public Form1()
        {
            InitializeComponent();
        }
        private void Jogada_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "")
            {
                btn.Text = jogadorX ? "X" : "O";
                jogadorX = !jogadorX;
                jogadas++;

                if (verificaTemVencedor())
                {
                    string vencedor = jogadorX ? "O" : "X";
                    MessageBox.Show("JOGADOR " + vencedor + " venceu");
                    return;
                }

                if(jogadas==9)
                    {
                        MessageBox.Show("Deu Velha!");
                    return;
                    }
            }
           
        }
         private bool verificaTemVencedor()
        {
            if (
              (btPos1.Text == btPos2.Text && btPos2.Text == btPos3.Text && btPos1.Text != "") ||
              (btPos4.Text == btPos5.Text && btPos5.Text == btPos6.Text && btPos4.Text != "") ||
              (btPos7.Text == btPos8.Text && btPos8.Text == btPos9.Text && btPos7.Text != "") ||

              (btPos1.Text == btPos4.Text && btPos4.Text == btPos7.Text && btPos1.Text != "") ||
              (btPos2.Text == btPos5.Text && btPos5.Text == btPos8.Text && btPos2.Text != "") ||
              (btPos3.Text == btPos6.Text && btPos6.Text == btPos9.Text && btPos3.Text != "") ||

              (btPos1.Text == btPos5.Text && btPos5.Text == btPos9.Text && btPos1.Text != "") ||
              (btPos3.Text == btPos5.Text && btPos5.Text == btPos7.Text && btPos3.Text != "") 

              ) 
                    
            {
                return true;
                
            }
                return false;
        }
      




    }
}
