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
            this.SuspendLayout();
            // 
            // TextValue
            // 
            this.TextValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextValue.Location = new System.Drawing.Point(46, 41);
            this.TextValue.MaxLength = 16;
            this.TextValue.Name = "TextValue";
            this.TextValue.Size = new System.Drawing.Size(325, 38);
            this.TextValue.TabIndex = 1;
            this.TextValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Sum
            // 
            this.Sum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(142, 85);
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
            this.Substraction.Location = new System.Drawing.Point(142, 131);
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
            this.Multiplication.Location = new System.Drawing.Point(188, 85);
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
            this.Division.Location = new System.Drawing.Point(188, 131);
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
            this.Equal.Location = new System.Drawing.Point(142, 180);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(86, 40);
            this.Equal.TabIndex = 18;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Clean
            // 
            this.Clean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clean.Location = new System.Drawing.Point(234, 131);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(69, 40);
            this.Clean.TabIndex = 26;
            this.Clean.Text = "C";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // AddMemory
            // 
            this.AddMemory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemory.Location = new System.Drawing.Point(309, 85);
            this.AddMemory.Name = "AddMemory";
            this.AddMemory.Size = new System.Drawing.Size(62, 40);
            this.AddMemory.TabIndex = 27;
            this.AddMemory.Text = "M+";
            this.AddMemory.UseVisualStyleBackColor = true;
            this.AddMemory.Click += new System.EventHandler(this.AddMemory_Click);
            // 
            // RemoveMemory
            // 
            this.RemoveMemory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveMemory.Location = new System.Drawing.Point(309, 131);
            this.RemoveMemory.Name = "RemoveMemory";
            this.RemoveMemory.Size = new System.Drawing.Size(62, 40);
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
            this.TextShow.Size = new System.Drawing.Size(325, 23);
            this.TextShow.TabIndex = 30;
            this.TextShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Minus
            // 
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.Location = new System.Drawing.Point(234, 85);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(69, 40);
            this.Minus.TabIndex = 31;
            this.Minus.Text = "-/+";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // TotalMemory
            // 
            this.TotalMemory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMemory.Location = new System.Drawing.Point(309, 177);
            this.TotalMemory.Name = "TotalMemory";
            this.TotalMemory.Size = new System.Drawing.Size(62, 40);
            this.TotalMemory.TabIndex = 32;
            this.TotalMemory.Text = "M";
            this.TotalMemory.UseVisualStyleBackColor = true;
            this.TotalMemory.Click += new System.EventHandler(this.TotalMemory_Click);
            // 
            // CleanMemory
            // 
            this.CleanMemory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CleanMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanMemory.Location = new System.Drawing.Point(234, 177);
            this.CleanMemory.Name = "CleanMemory";
            this.CleanMemory.Size = new System.Drawing.Size(69, 40);
            this.CleanMemory.TabIndex = 33;
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
            // Calculadora
            // 
            this.AcceptButton = this.Equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 253);
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
    }
}

