namespace JuanahPrint
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_filamentCalculator = new System.Windows.Forms.GroupBox();
            this.lbn_filamentCalculator_base = new System.Windows.Forms.Label();
            this.cmb_diameter = new System.Windows.Forms.ComboBox();
            this.lbn_currentDiameter = new System.Windows.Forms.Label();
            this.lbn_measurements = new System.Windows.Forms.Label();
            this.lbn_nextValue = new System.Windows.Forms.Label();
            this.inp_nextValue = new System.Windows.Forms.TextBox();
            this.btn_addValue = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.grp_filamentCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_filamentCalculator
            // 
            this.grp_filamentCalculator.Controls.Add(this.btn_reset);
            this.grp_filamentCalculator.Controls.Add(this.btn_addValue);
            this.grp_filamentCalculator.Controls.Add(this.inp_nextValue);
            this.grp_filamentCalculator.Controls.Add(this.lbn_nextValue);
            this.grp_filamentCalculator.Controls.Add(this.lbn_measurements);
            this.grp_filamentCalculator.Controls.Add(this.lbn_currentDiameter);
            this.grp_filamentCalculator.Controls.Add(this.cmb_diameter);
            this.grp_filamentCalculator.Controls.Add(this.lbn_filamentCalculator_base);
            this.grp_filamentCalculator.Location = new System.Drawing.Point(12, 12);
            this.grp_filamentCalculator.Name = "grp_filamentCalculator";
            this.grp_filamentCalculator.Size = new System.Drawing.Size(200, 177);
            this.grp_filamentCalculator.TabIndex = 0;
            this.grp_filamentCalculator.TabStop = false;
            this.grp_filamentCalculator.Text = "Filament-Calculator";
            // 
            // lbn_filamentCalculator_base
            // 
            this.lbn_filamentCalculator_base.AutoSize = true;
            this.lbn_filamentCalculator_base.Location = new System.Drawing.Point(7, 20);
            this.lbn_filamentCalculator_base.Name = "lbn_filamentCalculator_base";
            this.lbn_filamentCalculator_base.Size = new System.Drawing.Size(86, 13);
            this.lbn_filamentCalculator_base.TabIndex = 0;
            this.lbn_filamentCalculator_base.Text = "Filamentdiameter";
            // 
            // cmb_diameter
            // 
            this.cmb_diameter.FormattingEnabled = true;
            this.cmb_diameter.Items.AddRange(new object[] {
            "1.75mm",
            "3.00mm"});
            this.cmb_diameter.Location = new System.Drawing.Point(10, 36);
            this.cmb_diameter.Name = "cmb_diameter";
            this.cmb_diameter.Size = new System.Drawing.Size(121, 21);
            this.cmb_diameter.TabIndex = 1;
            this.cmb_diameter.SelectedIndexChanged += new System.EventHandler(this.cmb_diameter_SelectedIndexChanged);
            // 
            // lbn_currentDiameter
            // 
            this.lbn_currentDiameter.AutoSize = true;
            this.lbn_currentDiameter.Location = new System.Drawing.Point(10, 64);
            this.lbn_currentDiameter.Name = "lbn_currentDiameter";
            this.lbn_currentDiameter.Size = new System.Drawing.Size(87, 13);
            this.lbn_currentDiameter.TabIndex = 2;
            this.lbn_currentDiameter.Text = "Current diameter:";
            // 
            // lbn_measurements
            // 
            this.lbn_measurements.AutoSize = true;
            this.lbn_measurements.Location = new System.Drawing.Point(10, 88);
            this.lbn_measurements.Name = "lbn_measurements";
            this.lbn_measurements.Size = new System.Drawing.Size(79, 13);
            this.lbn_measurements.TabIndex = 3;
            this.lbn_measurements.Text = "Measurements:";
            // 
            // lbn_nextValue
            // 
            this.lbn_nextValue.AutoSize = true;
            this.lbn_nextValue.Location = new System.Drawing.Point(10, 116);
            this.lbn_nextValue.Name = "lbn_nextValue";
            this.lbn_nextValue.Size = new System.Drawing.Size(61, 13);
            this.lbn_nextValue.TabIndex = 4;
            this.lbn_nextValue.Text = "Next value:";
            // 
            // inp_nextValue
            // 
            this.inp_nextValue.Location = new System.Drawing.Point(77, 113);
            this.inp_nextValue.Name = "inp_nextValue";
            this.inp_nextValue.Size = new System.Drawing.Size(54, 20);
            this.inp_nextValue.TabIndex = 5;
            this.inp_nextValue.Text = "1.75";
            // 
            // btn_addValue
            // 
            this.btn_addValue.Location = new System.Drawing.Point(137, 111);
            this.btn_addValue.Name = "btn_addValue";
            this.btn_addValue.Size = new System.Drawing.Size(56, 23);
            this.btn_addValue.TabIndex = 6;
            this.btn_addValue.Text = "Add";
            this.btn_addValue.UseVisualStyleBackColor = true;
            this.btn_addValue.Click += new System.EventHandler(this.btn_addValue_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(13, 144);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(180, 23);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 201);
            this.Controls.Add(this.grp_filamentCalculator);
            this.Name = "Form1";
            this.Text = "JuanahPrint";
            this.grp_filamentCalculator.ResumeLayout(false);
            this.grp_filamentCalculator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_filamentCalculator;
        private System.Windows.Forms.Label lbn_filamentCalculator_base;
        private System.Windows.Forms.Label lbn_currentDiameter;
        private System.Windows.Forms.ComboBox cmb_diameter;
        private System.Windows.Forms.Label lbn_measurements;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_addValue;
        private System.Windows.Forms.TextBox inp_nextValue;
        private System.Windows.Forms.Label lbn_nextValue;
    }
}

