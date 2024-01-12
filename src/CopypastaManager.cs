using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopypastaManager
{
    public partial class CopypastaManager : Form
    {

        public CopypastaManager()
        {
            /*VARIABLES*/

            /*List that contains copypasta information, excluding the actual copypasta. They will share the same Copypasta ID Number.
            Structure: <Copypasta ID number, Copypasta Name, Copypasta Description>
            */
            List<Tuple<int, string, string>> listInfo = new List<Tuple<int, string, string>>();

    



            InitializeComponent();
            uxListModeGeneral.Select();
            /*if (uxListModeGeneral.Checked) 
            {

            }
            else if (uxListModeProfessional.Checked) 
            { 

            }
            System.Diagnostics.Debug.WriteLine("cmanager.cs");*/

            

            /*
            1. Load assuming we're on general 
            Select General

            2. Load all the copypastas from all the csv
            
            */


        }
    }
}