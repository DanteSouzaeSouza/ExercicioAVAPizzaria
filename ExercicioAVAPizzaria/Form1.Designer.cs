namespace ExercicioAVAPizzaria
{
    partial class FrmPizzaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSabores = new System.Windows.Forms.Label();
            this.cboSabor = new System.Windows.Forms.ComboBox();
            this.grpIngredientes = new System.Windows.Forms.GroupBox();
            this.grpBorda = new System.Windows.Forms.GroupBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.chkAzeitona = new System.Windows.Forms.CheckBox();
            this.rdbSemBorda = new System.Windows.Forms.RadioButton();
            this.rdbComBorda = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.grpIngredientes.SuspendLayout();
            this.grpBorda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSabores
            // 
            this.lblSabores.AutoSize = true;
            this.lblSabores.Location = new System.Drawing.Point(20, 11);
            this.lblSabores.Name = "lblSabores";
            this.lblSabores.Size = new System.Drawing.Size(133, 17);
            this.lblSabores.TabIndex = 0;
            this.lblSabores.Text = "Sabores das Pizzas";
            // 
            // cboSabor
            // 
            this.cboSabor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSabor.FormattingEnabled = true;
            this.cboSabor.Location = new System.Drawing.Point(159, 8);
            this.cboSabor.Name = "cboSabor";
            this.cboSabor.Size = new System.Drawing.Size(215, 24);
            this.cboSabor.Sorted = true;
            this.cboSabor.TabIndex = 1;
            // 
            // grpIngredientes
            // 
            this.grpIngredientes.Controls.Add(this.chkAzeitona);
            this.grpIngredientes.Controls.Add(this.chkCebola);
            this.grpIngredientes.Location = new System.Drawing.Point(12, 57);
            this.grpIngredientes.Name = "grpIngredientes";
            this.grpIngredientes.Size = new System.Drawing.Size(166, 142);
            this.grpIngredientes.TabIndex = 2;
            this.grpIngredientes.TabStop = false;
            this.grpIngredientes.Text = "Ingredientes";
            // 
            // grpBorda
            // 
            this.grpBorda.Controls.Add(this.rdbComBorda);
            this.grpBorda.Controls.Add(this.rdbSemBorda);
            this.grpBorda.Location = new System.Drawing.Point(207, 57);
            this.grpBorda.Name = "grpBorda";
            this.grpBorda.Size = new System.Drawing.Size(167, 142);
            this.grpBorda.TabIndex = 3;
            this.grpBorda.TabStop = false;
            this.grpBorda.Text = "Borda";
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(31, 41);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(74, 21);
            this.chkCebola.TabIndex = 0;
            this.chkCebola.Text = "Cebola";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // chkAzeitona
            // 
            this.chkAzeitona.AutoSize = true;
            this.chkAzeitona.Location = new System.Drawing.Point(31, 84);
            this.chkAzeitona.Name = "chkAzeitona";
            this.chkAzeitona.Size = new System.Drawing.Size(85, 21);
            this.chkAzeitona.TabIndex = 1;
            this.chkAzeitona.Text = "Azeitona";
            this.chkAzeitona.UseVisualStyleBackColor = true;
            // 
            // rdbSemBorda
            // 
            this.rdbSemBorda.AutoSize = true;
            this.rdbSemBorda.Location = new System.Drawing.Point(34, 40);
            this.rdbSemBorda.Name = "rdbSemBorda";
            this.rdbSemBorda.Size = new System.Drawing.Size(99, 21);
            this.rdbSemBorda.TabIndex = 0;
            this.rdbSemBorda.TabStop = true;
            this.rdbSemBorda.Text = "Sem Borda";
            this.rdbSemBorda.UseVisualStyleBackColor = true;
            // 
            // rdbComBorda
            // 
            this.rdbComBorda.AutoSize = true;
            this.rdbComBorda.Location = new System.Drawing.Point(34, 83);
            this.rdbComBorda.Name = "rdbComBorda";
            this.rdbComBorda.Size = new System.Drawing.Size(99, 21);
            this.rdbComBorda.TabIndex = 1;
            this.rdbComBorda.TabStop = true;
            this.rdbComBorda.Text = "Com Borda";
            this.rdbComBorda.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(54, 218);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(252, 218);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmPizzaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 271);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grpBorda);
            this.Controls.Add(this.grpIngredientes);
            this.Controls.Add(this.cboSabor);
            this.Controls.Add(this.lblSabores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPizzaria";
            this.Text = "Pizzaria";
            this.Load += new System.EventHandler(this.FrmPizzaria_Load);
            this.grpIngredientes.ResumeLayout(false);
            this.grpIngredientes.PerformLayout();
            this.grpBorda.ResumeLayout(false);
            this.grpBorda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSabores;
        private System.Windows.Forms.ComboBox cboSabor;
        private System.Windows.Forms.GroupBox grpIngredientes;
        private System.Windows.Forms.CheckBox chkAzeitona;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.GroupBox grpBorda;
        private System.Windows.Forms.RadioButton rdbComBorda;
        private System.Windows.Forms.RadioButton rdbSemBorda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImprimir;
    }
}

