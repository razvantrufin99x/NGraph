using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        _graph g = new _graph();

        public void addnewNodeInGraph(ref _graph pg)
        {
            pg.cap.Add(new NNode());
        }

        public void addnewvaluetonodeindex(ref _graph pg,string v)
        {
            pg.cap[g.cap.Count - 1].value = v;
        }

        public void addnewnodelinkedtonodeindex(ref _graph pg,int n)
        { 
            pg.cap[g.cap.Count - 1].Nodes.Add(n);
        }
        public void addnewnnodestograph(int n, ref _graph pg)
        {
            for (int i = 0; i < n; i++)
            {
                addnewNodeInGraph(ref pg);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            




        }
    }
}
