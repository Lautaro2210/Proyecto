namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCancion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSL = new System.Windows.Forms.CheckBox();
            this.cbLunes = new System.Windows.Forms.CheckBox();
            this.cbMartes = new System.Windows.Forms.CheckBox();
            this.cbMiercoles = new System.Windows.Forms.CheckBox();
            this.cbJueves = new System.Windows.Forms.CheckBox();
            this.cbViernes = new System.Windows.Forms.CheckBox();
            this.cbSabado = new System.Windows.Forms.CheckBox();
            this.cbDomingo = new System.Windows.Forms.CheckBox();
            this.tbthora = new System.Windows.Forms.TextBox();
            this.tbtmin = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btActivar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESPERTADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // lbCancion
            // 
            this.lbCancion.AutoSize = true;
            this.lbCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancion.Location = new System.Drawing.Point(150, 347);
            this.lbCancion.Name = "lbCancion";
            this.lbCancion.Size = new System.Drawing.Size(77, 20);
            this.lbCancion.TabIndex = 2;
            this.lbCancion.Text = "Canción";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seleccionar Canción";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSL
            // 
            this.cbSL.AutoSize = true;
            this.cbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSL.Location = new System.Drawing.Point(12, 97);
            this.cbSL.Name = "cbSL";
            this.cbSL.Size = new System.Drawing.Size(155, 24);
            this.cbSL.TabIndex = 4;
            this.cbSL.Text = "Seleccionar todos";
            this.cbSL.UseVisualStyleBackColor = true;
            this.cbSL.CheckedChanged += new System.EventHandler(this.cbSL_CheckedChanged);
            // 
            // cbLunes
            // 
            this.cbLunes.AutoSize = true;
            this.cbLunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLunes.Location = new System.Drawing.Point(12, 127);
            this.cbLunes.Name = "cbLunes";
            this.cbLunes.Size = new System.Drawing.Size(72, 24);
            this.cbLunes.TabIndex = 5;
            this.cbLunes.Text = "Lunes";
            this.cbLunes.UseVisualStyleBackColor = true;
            // 
            // cbMartes
            // 
            this.cbMartes.AutoSize = true;
            this.cbMartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMartes.Location = new System.Drawing.Point(12, 157);
            this.cbMartes.Name = "cbMartes";
            this.cbMartes.Size = new System.Drawing.Size(77, 24);
            this.cbMartes.TabIndex = 6;
            this.cbMartes.Text = "Martes";
            this.cbMartes.UseVisualStyleBackColor = true;
            // 
            // cbMiercoles
            // 
            this.cbMiercoles.AutoSize = true;
            this.cbMiercoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMiercoles.Location = new System.Drawing.Point(12, 187);
            this.cbMiercoles.Name = "cbMiercoles";
            this.cbMiercoles.Size = new System.Drawing.Size(95, 24);
            this.cbMiercoles.TabIndex = 7;
            this.cbMiercoles.Text = "Miércoles";
            this.cbMiercoles.UseVisualStyleBackColor = true;
            // 
            // cbJueves
            // 
            this.cbJueves.AutoSize = true;
            this.cbJueves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJueves.Location = new System.Drawing.Point(12, 217);
            this.cbJueves.Name = "cbJueves";
            this.cbJueves.Size = new System.Drawing.Size(78, 24);
            this.cbJueves.TabIndex = 8;
            this.cbJueves.Text = "Jueves";
            this.cbJueves.UseVisualStyleBackColor = true;
            // 
            // cbViernes
            // 
            this.cbViernes.AutoSize = true;
            this.cbViernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViernes.Location = new System.Drawing.Point(12, 247);
            this.cbViernes.Name = "cbViernes";
            this.cbViernes.Size = new System.Drawing.Size(82, 24);
            this.cbViernes.TabIndex = 9;
            this.cbViernes.Text = "Viernes";
            this.cbViernes.UseVisualStyleBackColor = true;
            // 
            // cbSabado
            // 
            this.cbSabado.AutoSize = true;
            this.cbSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSabado.Location = new System.Drawing.Point(12, 277);
            this.cbSabado.Name = "cbSabado";
            this.cbSabado.Size = new System.Drawing.Size(84, 24);
            this.cbSabado.TabIndex = 10;
            this.cbSabado.Text = "Sábado";
            this.cbSabado.UseVisualStyleBackColor = true;
            // 
            // cbDomingo
            // 
            this.cbDomingo.AutoSize = true;
            this.cbDomingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDomingo.Location = new System.Drawing.Point(12, 307);
            this.cbDomingo.Name = "cbDomingo";
            this.cbDomingo.Size = new System.Drawing.Size(92, 24);
            this.cbDomingo.TabIndex = 11;
            this.cbDomingo.Text = "Domingo";
            this.cbDomingo.UseVisualStyleBackColor = true;
            // 
            // tbthora
            // 
            this.tbthora.Location = new System.Drawing.Point(8, 49);
            this.tbthora.Name = "tbthora";
            this.tbthora.Size = new System.Drawing.Size(39, 20);
            this.tbthora.TabIndex = 12;
            // 
            // tbtmin
            // 
            this.tbtmin.Location = new System.Drawing.Point(69, 49);
            this.tbtmin.Name = "tbtmin";
            this.tbtmin.Size = new System.Drawing.Size(39, 20);
            this.tbtmin.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btActivar
            // 
            this.btActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActivar.Location = new System.Drawing.Point(203, 101);
            this.btActivar.Name = "btActivar";
            this.btActivar.Size = new System.Drawing.Size(162, 32);
            this.btActivar.TabIndex = 14;
            this.btActivar.Text = "Activar";
            this.btActivar.UseVisualStyleBackColor = true;
            this.btActivar.Click += new System.EventHandler(this.btActivar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 376);
            this.Controls.Add(this.btActivar);
            this.Controls.Add(this.tbtmin);
            this.Controls.Add(this.tbthora);
            this.Controls.Add(this.cbDomingo);
            this.Controls.Add(this.cbSabado);
            this.Controls.Add(this.cbViernes);
            this.Controls.Add(this.cbJueves);
            this.Controls.Add(this.cbMiercoles);
            this.Controls.Add(this.cbMartes);
            this.Controls.Add(this.cbLunes);
            this.Controls.Add(this.cbSL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCancion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(393, 415);
            this.MinimumSize = new System.Drawing.Size(393, 415);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCancion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbSL;
        private System.Windows.Forms.CheckBox cbLunes;
        private System.Windows.Forms.CheckBox cbMartes;
        private System.Windows.Forms.CheckBox cbMiercoles;
        private System.Windows.Forms.CheckBox cbJueves;
        private System.Windows.Forms.CheckBox cbViernes;
        private System.Windows.Forms.CheckBox cbSabado;
        private System.Windows.Forms.CheckBox cbDomingo;
        private System.Windows.Forms.TextBox tbthora;
        private System.Windows.Forms.TextBox tbtmin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btActivar;
    }
}

