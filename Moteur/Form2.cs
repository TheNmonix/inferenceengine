using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Moteur.DSTableAdapters;

namespace Moteur
{
    public partial class Form2 : Form
    {
        ActionTableAdapter act = new ActionTableAdapter();
        FaitTableAdapter ft = new FaitTableAdapter();
        DesignActTableAdapter DSA = new DesignActTableAdapter();
        CombinaisonPrTableAdapter cmp = new CombinaisonPrTableAdapter();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //comboBox1.DisplayMember = "DesignFait";
            //comboBox1.ValueMember = "CodeAction";
            //comboBox1.DataSource = ft.GetData();
            pictureBox1.Image = Moteur.Properties.Resources.mtr;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label1.Text = GetAxiomeAction(comboBox1.Text.Trim());
           // label1.Text = GetAction(comboBox1.Text.Trim());
           
            
        }

        string GetAxiomeAction(string DesignF)
        {
            string res = "";
            foreach (DS.DesignActRow action in DSA.GetData(DesignF))
            {
                res += action.DesignAction.Trim() + ", ";
            }
            res = res.Trim();
            if (!res.Equals(""))
            {
                res = res.Remove(res.Length - 1);
            }
            return res;
        }
        string GetAction(string DesignF)
        {
            string res = "", res1, res2;
            res = GetAxiomeAction(DesignF);
            if (!res.Trim().Equals("")) return "( " + res + " )";


            foreach (DS.CombinaisonPrRow c in cmp.GetData(DesignF))
            {
                res1 = GetAction(c.DesignFait1);
              
                res2 = GetAction(c.DesignFait2);

                return "( " + res1 + " " + c.Oper + " " + res2 + " )";
              


            }
            return "Ce fait n'existe pas pouriez vous le changer ! ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = GetAction(textBox1.Text.Trim());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
   
    }
}