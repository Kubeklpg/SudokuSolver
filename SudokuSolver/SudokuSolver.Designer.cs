namespace SudokuSolver
{
    partial class SudokuSolver
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.a1 = new System.Windows.Forms.TextBox();
            this.a2 = new System.Windows.Forms.TextBox();
            this.a3 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.TextBox();
            this.b3 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.TextBox();
            this.c2 = new System.Windows.Forms.TextBox();
            this.c3 = new System.Windows.Forms.TextBox();
            this.solve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(208, 120);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(20, 20);
            this.a1.TabIndex = 0;
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(234, 120);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(20, 20);
            this.a2.TabIndex = 1;
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(260, 120);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(20, 20);
            this.a3.TabIndex = 2;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(208, 146);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(20, 20);
            this.b1.TabIndex = 3;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(234, 146);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(20, 20);
            this.b2.TabIndex = 4;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(260, 146);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(20, 20);
            this.b3.TabIndex = 5;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(208, 172);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(20, 20);
            this.c1.TabIndex = 6;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(234, 172);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(20, 20);
            this.c2.TabIndex = 7;
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(260, 172);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(20, 20);
            this.c3.TabIndex = 8;
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(600, 142);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 23);
            this.solve.TabIndex = 9;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // SudokuSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Name = "SudokuSolver";
            this.Text = "Sudoku Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.TextBox a2;
        private System.Windows.Forms.TextBox a3;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.TextBox b2;
        private System.Windows.Forms.TextBox b3;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.TextBox c2;
        private System.Windows.Forms.TextBox c3;
        private System.Windows.Forms.Button solve;
    }
}

