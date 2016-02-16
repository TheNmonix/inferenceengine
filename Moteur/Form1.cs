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
    public partial class Form1 : Form
    {
        ActionTableAdapter act = new ActionTableAdapter();
        CombinaisonTableAdapter cmb = new CombinaisonTableAdapter();
        FaitTableAdapter ft = new FaitTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            codF.DisplayMember = "CodFait";
            codF.ValueMember = "DesignFait";
            codF.DataSource = ft.GetData();
        }

        private void codF_SelectedIndexChanged(object sender, EventArgs e)
        {
            Designation.Text = codF.SelectedValue.ToString();
            Resultat.Text = GetAction(Convert.ToInt32(codF.Text)); 
            
        
        }

        string GetAxiomeAction(int codf)
        {
            string res = "";
            foreach (DS.ActionRow  action in act.GetData(codf ))
            {
                res += action.DesignAction.Trim() + ", "; 
            }
            res = res.Trim();
            if (!res.Equals("") )
            {
                res = res.Remove(res.Length-1); 
            }
            return res;
        }
        string GetAction(int codf)
        {
            string res = "", res1, res2;
            res = GetAxiomeAction(codf);
            if (!res.Trim().Equals("")) return "( " + res + " )";
            
            
            foreach (DS.CombinaisonRow  c in cmb.GetData(codf) )
            {
                res1 = GetAction(c.CodFait1);
                res2 = GetAction(c.CodFait2);
                return "( " + res1 + " " + c.Oper + " " + res2 + " )";  

            }
            return "?";

        }
   
    
    
    }
}