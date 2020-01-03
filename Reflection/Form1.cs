using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Idayir_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            Type type = typeof(Ogrenci);//Ogrencinin tipini mueyyen edir - 1-ci usul
                                        // Type type1 = o.GetType();//Ogrencinin tipini mueyyen edir - 2-ci usul
            foreach (FieldInfo field in type.GetFields())
            {
                listBox1.Items.Add(field.Name);
            };

            foreach (PropertyInfo property in type.GetProperties())
            {
                listBox2.Items.Add(property.Name);
            };
            foreach (MethodInfo method in type.GetMethods())
            {
                //if (method.Name.Contains("get") || method.Name.Contains("set"))
                //{
                //    continue;
                //}
                listBox3.Items.Add(method.Name);
            }
        }
        Ogrenci ogrenci = new Ogrenci();
        private void Button1_Click(object sender, EventArgs e)
        {

            Type tip = ogrenci.GetType();
            FieldInfo ozellik = tip.GetField(listBox1.SelectedItem.ToString());
            ozellik.SetValue(ogrenci, textBox1.Text);
            string deger = ozellik.GetValue(ogrenci).ToString();
            MessageBox.Show(deger);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Type type = ogrenci.GetType();
            FieldInfo field = type.GetField(listBox1.SelectedItem.ToString());
            string deger = field.GetValue(ogrenci).ToString();
            MessageBox.Show(deger);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Type type = typeof(Ogrenci);
            MethodInfo methodname = type.GetMethod(listBox3.SelectedItem.ToString());
            string result = (string)methodname.Invoke(ogrenci, null);
            MessageBox.Show(result);
        }
    }
}
