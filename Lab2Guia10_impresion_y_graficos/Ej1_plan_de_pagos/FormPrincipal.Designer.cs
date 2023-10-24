
namespace Ej1_plan_de_pagos
{
    partial class FormPrincipal
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
            this.btnCrearPlan = new System.Windows.Forms.Button();
            this.tbApellidosYNombres = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPlanesDelInfractor = new System.Windows.Forms.ComboBox();
            this.btnConsultarPlanes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarFeriadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infractoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarPlanesDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearPlan
            // 
            this.btnCrearPlan.Location = new System.Drawing.Point(422, 248);
            this.btnCrearPlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrearPlan.Name = "btnCrearPlan";
            this.btnCrearPlan.Size = new System.Drawing.Size(151, 51);
            this.btnCrearPlan.TabIndex = 9;
            this.btnCrearPlan.Text = "Crear Plan de pagos";
            this.btnCrearPlan.UseVisualStyleBackColor = true;
            this.btnCrearPlan.Click += new System.EventHandler(this.btnCrearPlan_Click);
            // 
            // tbApellidosYNombres
            // 
            this.tbApellidosYNombres.Enabled = false;
            this.tbApellidosYNombres.Location = new System.Drawing.Point(184, 74);
            this.tbApellidosYNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbApellidosYNombres.Name = "tbApellidosYNombres";
            this.tbApellidosYNombres.Size = new System.Drawing.Size(224, 26);
            this.tbApellidosYNombres.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbPlanesDelInfractor);
            this.groupBox1.Controls.Add(this.btnConsultarPlanes);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbApellidosYNombres);
            this.groupBox1.Location = new System.Drawing.Point(7, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(574, 173);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vista de los Datos del Infractor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Planes creados";
            // 
            // cbPlanesDelInfractor
            // 
            this.cbPlanesDelInfractor.FormattingEnabled = true;
            this.cbPlanesDelInfractor.Location = new System.Drawing.Point(184, 122);
            this.cbPlanesDelInfractor.Name = "cbPlanesDelInfractor";
            this.cbPlanesDelInfractor.Size = new System.Drawing.Size(224, 28);
            this.cbPlanesDelInfractor.TabIndex = 26;
            // 
            // btnConsultarPlanes
            // 
            this.btnConsultarPlanes.Location = new System.Drawing.Point(415, 122);
            this.btnConsultarPlanes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultarPlanes.Name = "btnConsultarPlanes";
            this.btnConsultarPlanes.Size = new System.Drawing.Size(151, 35);
            this.btnConsultarPlanes.TabIndex = 25;
            this.btnConsultarPlanes.Text = "Ver Detalle plan";
            this.btnConsultarPlanes.UseVisualStyleBackColor = true;
            this.btnConsultarPlanes.Click += new System.EventHandler(this.btnConsultarPlanes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Buscar Infractor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Apellidos y Nombres";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(184, 27);
            this.tbDni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(224, 26);
            this.tbDni.TabIndex = 18;
            this.tbDni.TextChanged += new System.EventHandler(this.btnClearBackColor_TextChanged);
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dni";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.infractoresToolStripMenuItem,
            this.planesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(586, 29);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarFeriadosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cerrarToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // agregarFeriadosToolStripMenuItem
            // 
            this.agregarFeriadosToolStripMenuItem.Name = "agregarFeriadosToolStripMenuItem";
            this.agregarFeriadosToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.agregarFeriadosToolStripMenuItem.Text = "Agregar Feriados";
            this.agregarFeriadosToolStripMenuItem.Click += new System.EventHandler(this.btnAgregarFeriado_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // infractoresToolStripMenuItem
            // 
            this.infractoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importraciónToolStripMenuItem});
            this.infractoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infractoresToolStripMenuItem.Name = "infractoresToolStripMenuItem";
            this.infractoresToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.infractoresToolStripMenuItem.Text = "Infractores";
            // 
            // importraciónToolStripMenuItem
            // 
            this.importraciónToolStripMenuItem.Name = "importraciónToolStripMenuItem";
            this.importraciónToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.importraciónToolStripMenuItem.Text = "Importación";
            this.importraciónToolStripMenuItem.Click += new System.EventHandler(this.importraciónToolStripMenuItem_Click);
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarPlanesDePagoToolStripMenuItem});
            this.planesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.planesToolStripMenuItem.Text = "Planes";
            // 
            // exportarPlanesDePagoToolStripMenuItem
            // 
            this.exportarPlanesDePagoToolStripMenuItem.Name = "exportarPlanesDePagoToolStripMenuItem";
            this.exportarPlanesDePagoToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.exportarPlanesDePagoToolStripMenuItem.Text = "Exportar planes de pago";
            this.exportarPlanesDePagoToolStripMenuItem.Click += new System.EventHandler(this.exportarPlanesDePagoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 308);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(586, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 330);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCrearPlan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "Sistema de plan de pagos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCrearPlan;
        private System.Windows.Forms.TextBox tbApellidosYNombres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarFeriadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infractoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarPlanesDePagoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConsultarPlanes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPlanesDelInfractor;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

