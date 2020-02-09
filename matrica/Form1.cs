using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrica
{
    public partial class Form1 : Form
    {
        TextBox[,] matrix_vis1;
        TextBox[,] matrix_vis2;
        TextBox[,] matrix_vis3;
        Matrix matrix1, matrix2, matrix3, matrix4, matrix5;
        int default_size = 5;


        public Form1()
        {

            InitializeComponent();
            matrix_vis1 = new TextBox[,] {
            {m1_00, m1_01, m1_02, m1_03, m1_04 },
            {m1_10, m1_11, m1_12, m1_13, m1_14 },
            {m1_20, m1_21, m1_22, m1_23, m1_24 },
            {m1_30, m1_31, m1_32, m1_33, m1_34 },
            {m1_40, m1_41, m1_42, m1_43, m1_44 }
            };

            matrix_vis2 = new TextBox[,] {
            {m2_00, m2_01, m2_02, m2_03, m2_04},
            {m2_10, m2_11, m2_12, m2_13, m2_14},
            {m2_20, m2_21, m2_22, m2_23, m2_24},
            {m2_30, m2_31, m2_32, m2_33, m2_34},
            {m2_40, m2_41, m2_42, m2_43, m2_44}
            };

            matrix_vis3 = new TextBox[,] {
            {m3_00, m3_01, m3_02, m3_03, m3_04},
            {m3_10, m3_11, m3_12, m3_13, m3_14},
            {m3_20, m3_21, m3_22, m3_23, m3_24},
            {m3_30, m3_31, m3_32, m3_33, m3_34},
            {m3_40, m3_41, m3_42, m3_43, m3_44},
            };

            int[,] numbers2 = new int[default_size, default_size];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            matrix1 = new Matrix(5, 5, 0, 11);
          
            show_numbers(matrix_vis1, matrix1.numbers);
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            matrix3 = new Matrix(5, 5, 0, 0);
            sum(matrix1,  matrix2, matrix3);
            show_numbers(matrix_vis3, matrix3.numbers);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            matrix2 = new Matrix(5, 5, 0, 11);
            show_numbers(matrix_vis2, matrix2.numbers);
        }

        private void show_numbers(TextBox[,]matrix, int[,] numbers)
        {

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j].Text = numbers[i, j].ToString();

                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            matrix5 = new Matrix(5, 5, 0, 0);
            com(matrix1, matrix2, matrix5);
            show_numbers(matrix_vis3, matrix5.numbers);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            matrix4 = new Matrix(5, 5, 0, 0);
            dif(matrix1, matrix2, matrix4);
            show_numbers(matrix_vis3, matrix4.numbers);
        }

        private void sum(Matrix matrix1, Matrix matrix2, Matrix matrix3)
        {
            int[,] numbersP = new int[5, 5];
            for(int i = 0; i < numbersP.GetLength(0); i++)
            {
                for (int j = 0; j < numbersP.GetLength(1); j++)
                {
                    matrix3.numbers[i, j] = matrix1.numbers[i, j] + matrix2.numbers[i, j];
                }
            }
           
        }

        private void dif(Matrix matrix1, Matrix matrix2, Matrix matrix4)
        {
            int[,] numbersP = new int[5, 5];
            for (int i = 0; i < numbersP.GetLength(0); i++)
            {
                for (int j = 0; j < numbersP.GetLength(1); j++)
                {
                    matrix4.numbers[i, j] = matrix1.numbers[i, j] - matrix2.numbers[i, j];
                    
                }
            }

        }

        private void com(Matrix matrix1, Matrix matrix2, Matrix matrix3)
        {
            int n = 0;
            matrix5 = new Matrix();
            int[,] numbersP = new int[5, 5];
            for (int i = 0; i < numbersP.GetLength(0); i++)
            {
                n = 0;
                for (int j = 0; j < numbersP.GetLength(1); j++)
                {
                    matrix5.numbers[i, j] = matrix1.numbers[i, n] * matrix2.numbers[n, j];
                    n++;
                }
            }

        }
    }
}

    
