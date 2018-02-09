using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Employee a1 = new Employee("1","2","3","4");
            Employee a2 = new Employee("1", "2", "3", "4");
            Employee a3 = new Employee("1", "2", "3", "4");
            Employee a4 = new Employee("Петр", "2", "3", "4");
            Employee a5 = new Employee("1", "2", "3", "4");

            MessageBox.Show(a4.Name);
        }
    }
}
