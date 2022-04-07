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
        int boardSize = 9;
        public SudokuSolver()
        {
            InitializeComponent();
        }

        private int[,] CreateMatrix()
        {
            int[,] tab = new int[9, 9];
            
            
            tab[0, 0] = Convert.ToInt32(a1.Text);
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
            return tab;
        }

        private void PrintMatrix(int[,] arr)
        {
            a1.Text = arr[0, 0].ToString();
            a2.Text = arr[0, 1].ToString();
            a3.Text = arr[0, 2].ToString();
            a4.Text = arr[0, 3].ToString();
            a5.Text = arr[0, 4].ToString();
            a6.Text = arr[0, 5].ToString();
            a7.Text = arr[0, 6].ToString();
            a8.Text = arr[0, 7].ToString();
            a9.Text = arr[0, 8].ToString();
            //============================
            b1.Text = arr[1, 0].ToString();
            b2.Text = arr[1, 1].ToString();
            b3.Text = arr[1, 2].ToString();
            b4.Text = arr[1, 3].ToString();
            b5.Text = arr[1, 4].ToString();
            b6.Text = arr[1, 5].ToString();
            b7.Text = arr[1, 6].ToString();
            b8.Text = arr[1, 7].ToString();
            b9.Text = arr[1, 8].ToString();
            //===========================
            c1.Text = arr[2, 0].ToString();
            c2.Text = arr[2, 1].ToString();
            c3.Text = arr[2, 2].ToString();
            c4.Text = arr[2, 3].ToString();
            c5.Text = arr[2, 4].ToString();
            c6.Text = arr[2, 5].ToString();
            c7.Text = arr[2, 6].ToString();
            c8.Text = arr[2, 7].ToString();
            c9.Text = arr[2, 8].ToString();
            //===========================
            d1.Text = arr[3, 0].ToString();
            d2.Text = arr[3, 1].ToString();
            d3.Text = arr[3, 2].ToString();
            d4.Text = arr[3, 3].ToString();
            d5.Text = arr[3, 4].ToString();
            d6.Text = arr[3, 5].ToString();
            d7.Text = arr[3, 6].ToString();
            d8.Text = arr[3, 7].ToString();
            a9.Text = arr[3, 8].ToString();
            //===========================
            e1.Text = arr[4, 0].ToString();
            e2.Text = arr[4, 1].ToString();
            e3.Text = arr[4, 2].ToString();
            e4.Text = arr[4, 3].ToString();
            e5.Text = arr[4, 4].ToString();
            e6.Text = arr[4, 5].ToString();
            e7.Text = arr[4, 6].ToString();
            e8.Text = arr[4, 7].ToString();
            e9.Text = arr[4, 8].ToString();
            //===========================
            f1.Text = arr[5, 0].ToString();
            f2.Text = arr[5, 1].ToString();
            f3.Text = arr[5, 2].ToString();
            f4.Text = arr[5, 3].ToString();
            f5.Text = arr[5, 4].ToString();
            f6.Text = arr[5, 5].ToString();
            f7.Text = arr[5, 6].ToString();
            f8.Text = arr[5, 7].ToString();
            f9.Text = arr[5, 8].ToString();
            //============================
            g1.Text = arr[6, 0].ToString();
            g2.Text = arr[6, 1].ToString();
            g3.Text = arr[6, 2].ToString();
            g4.Text = arr[6, 3].ToString();
            g5.Text = arr[6, 4].ToString();
            g6.Text = arr[6, 5].ToString();
            g7.Text = arr[6, 6].ToString();
            g8.Text = arr[6, 7].ToString();
            g9.Text = arr[6, 8].ToString();
            //============================
            h1.Text = arr[7, 0].ToString();
            h2.Text = arr[7, 1].ToString();
            h3.Text = arr[7, 2].ToString();
            h4.Text = arr[7, 3].ToString();
            h5.Text = arr[7, 4].ToString();
            h6.Text = arr[7, 5].ToString();
            h7.Text = arr[7, 6].ToString();
            h8.Text = arr[7, 7].ToString();
            h9.Text = arr[7, 8].ToString();
            //============================
            i1.Text = arr[8, 0].ToString();
            i2.Text = arr[8, 1].ToString();
            i3.Text = arr[8, 2].ToString();
            i4.Text = arr[8, 3].ToString();
            i5.Text = arr[8, 4].ToString();
            i6.Text = arr[8, 5].ToString();
            i7.Text = arr[8, 6].ToString();
            i8.Text = arr[8, 7].ToString();
            i9.Text = arr[8, 8].ToString();
        }

        
        private void solve_Click(object sender, EventArgs e)
        {

            int [,] array = CreateMatrix();
            
            bool done = Solve(array);
            if (done)
            {
                label1.Text = "Done";
                PrintMatrix(array);
            }
           
           

        }
        
        private bool CheckIfValidRow(int[,] tab,int number, int row)
        {
            bool state = false;
            for(int i = 0; i < boardSize; i++)
            {
                if (tab[row, i] == number)
                {
                    state = false;
                }
                else state = true;
            }
            return state;
        }
        private bool CheckIfValidColumn(int[,] tab, int number, int column)
        {
            bool state = false;
            for (int i = 0; i < boardSize; i++)
            {
                if (tab[i,column] == number)
                {
                    state = false;
                }
                else state = true;
            }
            return state;
        }
        private bool CheckIfValidBox(int[,] tab, int number,int row, int column)
        {
            int smolRow = row - row % 3;
            int smolColumn = column - column % 3;
            bool state = false;
            for (int i = smolRow; i < 3; i++)
            {
                for(int j = smolColumn; j < 3 ; j++)
                {
                    if (tab[i, j] == number)
                    {
                        state = false;
                    }
                    else state = true;
                }
            }
            return state;
        }
        private bool CheckIfValid( int[,] tab, int number, int row, int column)
        {
            bool final = CheckIfValidColumn(tab, number, column) & CheckIfValidRow(tab, number, row) & CheckIfValidBox(tab, number, row, column);
            return final;        
        }
        private bool Solve(int[,] tab)
        {
            for( int i = 0; i < boardSize; i++)
            {
                for ( int j = 0; j < boardSize; j++)
                {
                    if(tab[i,j] == 0)
                    {
                        for(int k = 1; k < 9; k++)
                        {
                            if (CheckIfValid(tab, k, i, j))
                            {
                                tab[i, j] = k;

                                if (Solve(tab))
                                {
                                    return true;
                                }
                                else
                                {
                                    tab[i, j] = 0;
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        
    }
}




