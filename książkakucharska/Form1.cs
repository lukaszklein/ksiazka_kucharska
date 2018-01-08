using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace książkakucharska
{
    public partial class Form1 : Form
    {
        bool clear = true;

        public void CreateList()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Danie", 100);
            listView1.Columns.Add("Składniki", 150);
        }

        public void ShowDish(Stack Ing, string Dish)//funkcja przyjmująca składniki i nazwę dania do wyświetlenia w listview
        {
            if (clear)
            {
                listView1.Clear();
                CreateList();
                clear = false;
            }
            bool IsFirst = true;
            string[] arr = new string[2];
            ListViewItem itm;
            int Length = Ing.Count;
            for (int i = 0; i < Length; i++)
            {
                if (IsFirst)
                {
                    arr[0] = Dish;
                    arr[1] = (string)Ing.Pop();
                    IsFirst = false;
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
                else
                {
                    arr[0] = "";
                    arr[1] = (string)Ing.Pop();
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
            IsFirst = true;
        }

        public Form1()
        {
            InitializeComponent();
            CreateList();
        }

        private void dzialanie_Click(object sender, EventArgs e)
        {
            clear = true;

            if (nabiał.GetItemCheckState(0).ToString() == "Checked")
            {
                Stack Ingredients = new Stack();
                Ingredients.Push("jajka");
                ShowDish(Ingredients, "jajecznica");
            }

            if (inne.GetItemCheckState(0).ToString() == "Checked" && 
                warzywa.GetItemCheckState(0).ToString() == "Checked" && 
                mięso.GetItemCheckState(0).ToString() == "Checked" && 
                zboża.GetItemCheckState(0).ToString() == "Checked")
            {
                Stack Ingredients = new Stack();
                Ingredients.Push("pomidory");
                Ingredients.Push("makaron");
                Ingredients.Push("wieprzowina");
                Ingredients.Push("przecier pomidorowy");
                ShowDish(Ingredients, "spaghetti");
            }

            if (warzywa.GetItemCheckState(1).ToString() == "Checked" && 
                warzywa.GetItemCheckState(2).ToString() == "Checked" && 
                warzywa.GetItemCheckState(3).ToString() == "Checked" && 
                mięso.GetItemCheckState(1).ToString() == "Checked" && 
                inne.GetItemCheckState(1).ToString() == "Checked" && 
                inne.GetItemCheckState(2).ToString() == "Checked" && 
                inne.GetItemCheckState(3).ToString() == "Checked")
            {
                Stack Ingredients = new Stack();
                Ingredients.Push("kukurydza");
                Ingredients.Push("kapusta pekińska");
                Ingredients.Push("ogórki kiszone");
                Ingredients.Push("kurczak");
                Ingredients.Push("ketchup");
                Ingredients.Push("majonez");
                Ingredients.Push("przyprawa do mięsa");
                ShowDish(Ingredients, "gyros");
            }

            if (warzywa.GetItemCheckState(4).ToString() == "Checked" && 
                mięso.GetItemCheckState(0).ToString() == "Checked" && 
                mięso.GetItemCheckState(2).ToString() == "Checked" && 
                inne.GetItemCheckState(4).ToString() == "Checked")
            {
                Stack Ingredients = new Stack();
                Ingredients.Push("kapusta kiszona");
                Ingredients.Push("wieprzowina");
                Ingredients.Push("kiełbasa");
                Ingredients.Push("koncentrat pomidorowy");
                ShowDish(Ingredients, "bigos");
            }

            if (warzywa.GetItemCheckState(5).ToString() == "Checked" && 
                mięso.GetItemCheckState(0).ToString() == "Checked" && 
                nabiał.GetItemCheckState(0).ToString() == "Checked" && 
                zboża.GetItemCheckState(1).ToString() == "Checked")
            {
                Stack Ingredients = new Stack();
                Ingredients.Push("ziemniaki");
                Ingredients.Push("wieprzowina");
                Ingredients.Push("jajka");
                Ingredients.Push("mąka");
                ShowDish(Ingredients, "kotlety schabowe");
            }

            if (warzywa.GetItemCheckState(6).ToString() == "Checked" && 
                warzywa.GetItemCheckState(7).ToString() == "Checked" && 
                mięso.GetItemCheckState(3).ToString() == "Checked" && 
                inne.GetItemCheckState(0).ToString() == "Checked")
            {
                Stack Ingredients = new Stack();
                Ingredients.Push("cebula");
                Ingredients.Push("marchewka");
                Ingredients.Push("ryba");
                Ingredients.Push("przecier pomidorowy");
                ShowDish(Ingredients, "ryba po grecku");
            }

            if (warzywa.GetItemCheckState(0).ToString() == "Checked" && 
                warzywa.GetItemCheckState(8).ToString() == "Checked" && 
                warzywa.GetItemCheckState(9).ToString() == "Checked" && 
                mięso.GetItemCheckState(1).ToString() == "Checked" && 
                zboża.GetItemCheckState(2).ToString() == "Checked")
            {
                Stack Ingredients = new Stack();
                Ingredients.Push("pomidory");
                Ingredients.Push("ogórek świeży");
                Ingredients.Push("kurczak");
                Ingredients.Push("sałata");
                Ingredients.Push("placek pszenny");
                ShowDish(Ingredients, "tortilla");
            }

            if (nabiał.GetItemCheckState(2).ToString() == "Checked" && 
                nabiał.GetItemCheckState(1).ToString() == "Checked" && 
                zboża.GetItemCheckState(0).ToString() == "Checked" && 
                mięso.GetItemCheckState(0).ToString() == "Checked" && 
                inne.GetItemCheckState(6).ToString() == "Checked")
            {
                Stack Ingredients = new Stack();
                Ingredients.Push("makaron");
                Ingredients.Push("sos pomidorowy");
                Ingredients.Push("wieprzowina");
                Ingredients.Push("śmietana");
                Ingredients.Push("ser");
                ShowDish(Ingredients, "lasagne");
            }

            //if (nabiał.GetItemCheckState(2).ToString() == "Checked" && 
            //    nabiał.GetItemCheckState(1).ToString() == "Checked" && 
            //    zboża.GetItemCheckState(0).ToString() == "Checked" && 
            //    mięso.GetItemCheckState(0).ToString() == "Checked" && 
            //    inne.GetItemCheckState(6).ToString() == "Checked")
            //{
            //    Stack Ingredients = new Stack();
            //    Ingredients.Push("makaron");
            //    Ingredients.Push("sos pomidorowy");
            //    Ingredients.Push("wieprzowina");
            //    Ingredients.Push("śmietana");
            //    Ingredients.Push("ser");
            //    ShowDish(Ingredients, "lasagne");
            //}

            if (nabiał.GetItemCheckState(3).ToString() == "Checked" && 
                zboża.GetItemCheckState(1).ToString() == "Checked" && 
                nabiał.GetItemCheckState(0).ToString() == "Checked" && 
                inne.GetItemCheckState(6).ToString() == "Checked")
            {
                Stack Ingredients = new Stack();
                Ingredients.Push("mąka");
                Ingredients.Push("mleko");
                Ingredients.Push("jajka");
                Ingredients.Push("cukier");
                ShowDish(Ingredients, "naleśniki");
            }
        }
    }
}