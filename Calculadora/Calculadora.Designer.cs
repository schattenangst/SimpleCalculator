namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextValue = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.AddMemory = new System.Windows.Forms.Button();
            this.RemoveMemory = new System.Windows.Forms.Button();
            this.TextShow = new System.Windows.Forms.TextBox();
            this.Minus = new System.Windows.Forms.Button();
            this.TotalMemory = new System.Windows.Forms.Button();
            this.CleanMemory = new System.Windows.Forms.Button();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextValue
            // 
            this.TextValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextValue.Location = new System.Drawing.Point(46, 41);
            this.TextValue.MaxLength = 16;
            this.TextValue.Name = "TextValue";
            this.TextValue.Size = new System.Drawing.Size(292, 38);
            this.TextValue.TabIndex = 1;
            this.TextValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextValue.TextChanged += new System.EventHandler(this.TextValue_TextChanged);
            this.TextValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Sum
            // 
            this.Sum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(206, 131);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(40, 40);
            this.Sum.TabIndex = 12;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Substraction
            // 
            this.Substraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Substraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Substraction.Location = new System.Drawing.Point(206, 177);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(40, 40);
            this.Substraction.TabIndex = 13;
            this.Substraction.Text = "-";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.Substraction_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplication.Location = new System.Drawing.Point(252, 131);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(40, 40);
            this.Multiplication.TabIndex = 14;
            this.Multiplication.Text = "x";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(252, 177);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(40, 40);
            this.Division.TabIndex = 15;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Equal
            // 
            this.Equal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(206, 223);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(132, 40);
            this.Equal.TabIndex = 16;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Clean
            // 
            this.Clean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clean.Location = new System.Drawing.Point(298, 177);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(40, 40);
            this.Clean.TabIndex = 18;
            this.Clean.Text = "C";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // AddMemory
            // 
            this.AddMemory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemory.Location = new System.Drawing.Point(206, 85);
            this.AddMemory.Name = "AddMemory";
            this.AddMemory.Size = new System.Drawing.Size(40, 40);
            this.AddMemory.TabIndex = 27;
            this.AddMemory.Text = "M+";
            this.AddMemory.UseVisualStyleBackColor = true;
            this.AddMemory.Click += new System.EventHandler(this.AddMemory_Click);
            // 
            // RemoveMemory
            // 
            this.RemoveMemory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveMemory.Location = new System.Drawing.Point(252, 85);
            this.RemoveMemory.Name = "RemoveMemory";
            this.RemoveMemory.Size = new System.Drawing.Size(40, 40);
            this.RemoveMemory.TabIndex = 28;
            this.RemoveMemory.Text = "M-";
            this.RemoveMemory.UseVisualStyleBackColor = true;
            this.RemoveMemory.Click += new System.EventHandler(this.RemoveMemory_Click);
            // 
            // TextShow
            // 
            this.TextShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextShow.Location = new System.Drawing.Point(46, 12);
            this.TextShow.MaxLength = 20;
            this.TextShow.Name = "TextShow";
            this.TextShow.ReadOnly = true;
            this.TextShow.Size = new System.Drawing.Size(292, 23);
            this.TextShow.TabIndex = 30;
            this.TextShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Minus
            // 
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.Location = new System.Drawing.Point(46, 226);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(40, 37);
            this.Minus.TabIndex = 17;
            this.Minus.Text = "-/+";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // TotalMemory
            // 
            this.TotalMemory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMemory.Location = new System.Drawing.Point(298, 131);
            this.TotalMemory.Name = "TotalMemory";
            this.TotalMemory.Size = new System.Drawing.Size(40, 40);
            this.TotalMemory.TabIndex = 32;
            this.TotalMemory.Text = "M";
            this.TotalMemory.UseVisualStyleBackColor = true;
            this.TotalMemory.Click += new System.EventHandler(this.TotalMemory_Click);
            // 
            // CleanMemory
            // 
            this.CleanMemory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CleanMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanMemory.Location = new System.Drawing.Point(298, 85);
            this.CleanMemory.Name = "CleanMemory";
            this.CleanMemory.Size = new System.Drawing.Size(40, 40);
            this.CleanMemory.TabIndex = 19;
            this.CleanMemory.Text = "MC";
            this.CleanMemory.UseVisualStyleBackColor = true;
            this.CleanMemory.Click += new System.EventHandler(this.CleanMemory_Click);
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(21, 62);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(19, 17);
            this.MemoryLabel.TabIndex = 34;
            this.MemoryLabel.Text = "M";
            this.MemoryLabel.Visible = false;
            // 
            // one
            // 
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(46, 85);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(40, 40);
            this.one.TabIndex = 2;
            this.one.Tag = "1";
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.Number_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(92, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 3;
            this.button1.Tag = "1";
            this.button1.Text = "2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Number_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(138, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 4;
            this.button2.Tag = "1";
            this.button2.Text = "3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Number_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(138, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 7;
            this.button3.Tag = "1";
            this.button3.Text = "6";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Number_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(92, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 6;
            this.button4.Tag = "1";
            this.button4.Text = "5";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Number_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(46, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 5;
            this.button5.Tag = "1";
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Number_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(138, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 10;
            this.button6.Tag = "1";
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Number_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(92, 177);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 9;
            this.button7.Tag = "1";
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Number_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(46, 177);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 8;
            this.button8.Tag = "1";
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Number_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(92, 223);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 40);
            this.button9.TabIndex = 11;
            this.button9.Tag = "1";
            this.button9.Text = "0";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Number_Click);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(138, 223);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 40);
            this.button10.TabIndex = 35;
            this.button10.Tag = "1";
            this.button10.Text = ".";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Number_Click);
            // 
            // Calculadora
            // 
            this.AcceptButton = this.Equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 273);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.one);
            this.Controls.Add(this.MemoryLabel);
            this.Controls.Add(this.CleanMemory);
            this.Controls.Add(this.TotalMemory);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.TextShow);
            this.Controls.Add(this.RemoveMemory);
            this.Controls.Add(this.AddMemory);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Substraction);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.TextValue);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculadora_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextValue;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Substraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button AddMemory;
        private System.Windows.Forms.Button RemoveMemory;
        private System.Windows.Forms.TextBox TextShow;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button TotalMemory;
        private System.Windows.Forms.Button CleanMemory;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

