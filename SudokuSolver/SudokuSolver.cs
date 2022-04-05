using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class SudokuSolver : Form
    {
        public SudokuSolver()
        {
            InitializeComponent();
        }

        private void solve_Click(object sender, EventArgs e)
        {

            int[,] tab = new int[9,9];
            tab[0,0] =  Convert.ToInt32(a1.Text);
            tab[0, 1] = Convert.ToInt32(a2.Text);
            tab[0, 2] = Convert.ToInt32(a3.Text);
            tab[0, 3] = Convert.ToInt32(a4.Text);
            tab[0, 4] = Convert.ToInt32(a5.Text);
            tab[0, 5] = Convert.ToInt32(a6.Text);
            tab[0, 6] = Convert.ToInt32(a7.Text);
            tab[0, 7] = Convert.ToInt32(a8.Text);
            tab[0, 8] = Convert.ToInt32(a9.Text);
            //---------------------------------
            tab[1, 0] = Convert.ToInt32(b1.Text);
            tab[1, 1] = Convert.ToInt32(b2.Text);
            tab[1,2] = Convert.ToInt32(b3.Text);
            tab[1,3] = Convert.ToInt32(b4.Text);
            tab[1,4] = Convert.ToInt32(b5.Text);
            tab[1,5] = Convert.ToInt32(b6.Text);
            tab[1,6] = Convert.ToInt32(b7.Text);
            tab[1,7] = Convert.ToInt32(b8.Text);
            tab[1, 8] = Convert.ToInt32(b9.Text);
            //---------------------------------
            tab[2, 0] = Convert.ToInt32(c1.Text);
            tab[2, 1] = Convert.ToInt32(c2.Text);
            tab[2, 2] = Convert.ToInt32(c3.Text);
            tab[2, 3] = Convert.ToInt32(c4.Text);
            tab[2, 4] = Convert.ToInt32(c5.Text);
            tab[2, 5] = Convert.ToInt32(c6.Text);
            tab[2, 6] = Convert.ToInt32(c7.Text);
            tab[2, 7] = Convert.ToInt32(c8.Text);
            tab[2, 8] = Convert.ToInt32(c9.Text);
            //---------------------------------
            tab[3, 0] = Convert.ToInt32(d1.Text);
            tab[3, 1] = Convert.ToInt32(d2.Text);
            tab[3, 2] = Convert.ToInt32(d3.Text);
            tab[3, 3] = Convert.ToInt32(d4.Text);
            tab[3, 4] = Convert.ToInt32(d5.Text);
            tab[3, 5] = Convert.ToInt32(d6.Text);
            tab[3, 6] = Convert.ToInt32(d7.Text);
            tab[3, 7] = Convert.ToInt32(d8.Text);
            tab[3, 8] = Convert.ToInt32(d9.Text);
            //---------------------------------
            tab[4, 0] = Convert.ToInt32(e1.Text);
            tab[4, 1] = Convert.ToInt32(e2.Text);
            tab[4, 2] = Convert.ToInt32(e3.Text);
            tab[4, 3] = Convert.ToInt32(e4.Text);
            tab[4, 4] = Convert.ToInt32(e5.Text);
            tab[4, 5] = Convert.ToInt32(e6.Text);
            tab[4, 6] = Convert.ToInt32(e7.Text);
            tab[4, 7] = Convert.ToInt32(e8.Text);
            tab[4, 8] = Convert.ToInt32(e9.Text);
            //---------------------------------
            tab[5, 0] = Convert.ToInt32(f1.Text);
            tab[5, 1] = Convert.ToInt32(f2.Text);
            tab[5, 2] = Convert.ToInt32(f3.Text);
            tab[5, 3] = Convert.ToInt32(f4.Text);
            tab[5, 4] = Convert.ToInt32(f5.Text);
            tab[5, 5] = Convert.ToInt32(f6.Text);
            tab[5, 6] = Convert.ToInt32(f7.Text);
            tab[5, 7] = Convert.ToInt32(f8.Text);
            tab[5, 8] = Convert.ToInt32(f9.Text);
            //---------------------------------
            tab[6, 0] = Convert.ToInt32(g1.Text);
            tab[6, 1] = Convert.ToInt32(g2.Text);
            tab[6, 2] = Convert.ToInt32(g3.Text);
            tab[6, 3] = Convert.ToInt32(g4.Text);
            tab[6, 4] = Convert.ToInt32(g5.Text);
            tab[6, 5] = Convert.ToInt32(g6.Text);
            tab[6, 6] = Convert.ToInt32(g7.Text);
            tab[6, 7] = Convert.ToInt32(g8.Text);
            tab[6, 8] = Convert.ToInt32(g9.Text);
            //---------------------------------
            tab[7, 0] = Convert.ToInt32(h1.Text);
            tab[7, 1] = Convert.ToInt32(h2.Text);
            tab[7, 2] = Convert.ToInt32(h3.Text);
            tab[7, 3] = Convert.ToInt32(h4.Text);
            tab[7, 4] = Convert.ToInt32(h5.Text);
            tab[7, 5] = Convert.ToInt32(h6.Text);
            tab[7, 6] = Convert.ToInt32(h7.Text);
            tab[7, 7] = Convert.ToInt32(h8.Text);
            tab[7, 8] = Convert.ToInt32(h9.Text);
            //---------------------------------
            tab[8, 0] = Convert.ToInt32(i1.Text);
            tab[8, 1] = Convert.ToInt32(i2.Text);
            tab[8, 2] = Convert.ToInt32(i3.Text);
            tab[8, 3] = Convert.ToInt32(i4.Text);
            tab[8, 4] = Convert.ToInt32(i5.Text);
            tab[8, 5] = Convert.ToInt32(i6.Text);
            tab[8, 6] = Convert.ToInt32(i7.Text);
            tab[8, 7] = Convert.ToInt32(i8.Text);
            tab[8, 8] = Convert.ToInt32(i9.Text);
            //---------------------------------


        }
    }
}
