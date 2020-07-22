using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
       

        
       
        
       
        private void button1_Click(object sender, EventArgs e)
        {
           




        }


        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
        

        
        
        int tahminSayisi = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {



           
            tahminSayisi++; 

            int tutanBasamak = 0;
            int tutanSayi = 0;
            
            int kontrolSayaci = 0;
            
            char[] girilenSayi = textBox1.Text.ToCharArray();  
            char[] uretilenSayi = textBox2.Text.ToCharArray(); 

            for (int i = 0; i < girilenSayi.Length; i++)
            {
                for(int j = 1; j < girilenSayi.Length; j++) 
                {
                    if (girilenSayi[i] == girilenSayi[j]  && i!=j) 
                    { 
                        kontrolSayaci++;
                        

                    }
                }
            }
                if (kontrolSayaci != 0) {
                    MessageBox.Show("YANLIŞ SAYI GİRDİNİZ RAKAMLARI BİRBİRİNDEN FARKLI BİR SAYI GİRİNİZ ");
                 tahminSayisi--;  
            }
            
            

           


            for (int i = 0; i < girilenSayi.Length; i++)
            {
          
                if (girilenSayi[i] == uretilenSayi[i])  
                {
                    tutanBasamak++;

                }

                for (int j = 0; j < uretilenSayi.Length; j++) 
                {
                    
                    if (girilenSayi[i] == uretilenSayi[j] )
                    {
                        tutanSayi++;
                        
                       

                    }
                }
                if (textBox1.Text == textBox2.Text) 
                {
                    tutanBasamak = 4;
                    tutanSayi = 0;
                    MessageBox.Show("DOĞRU TAHMİN ETTİNİZ OYUN KAPATILIYOR. TAHMİN SAYISI :" + tahminSayisi);
                    this.Close();
                    break;
                }
                 
            }

           

            label6.Text = tahminSayisi.ToString();


           
            
            

            label3.Text = "(+"+ tutanBasamak.ToString()+",-"+ tutanSayi + ")";

            label8.Text = textBox1.Text;  

            textBox1.Text = null; 
            if (kontrolSayaci != 0)   
            
            {
                label3.Text = "";
                
                

            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random r = new Random();
   

            int basamak1 = r.Next(1, 10); 
            int basamak2, basamak3, basamak4;
            int i = 0;
            while (i < 1)
            {
                basamak2 = r.Next(0, 10); 
                basamak3 = r.Next(0, 10);
                basamak4 = r.Next(0, 10);
                if (basamak1 != basamak2 && basamak1 != basamak3 && basamak1 != basamak4 && basamak2 != basamak3 && basamak2 != basamak4 && basamak3 != basamak4)
                {   
                   
                    textBox2.Text = basamak1 + "" + basamak2 + "" + basamak3 + "" + basamak4; 
                    i++;
                }
            }








            
        }
        
        
    }
}
