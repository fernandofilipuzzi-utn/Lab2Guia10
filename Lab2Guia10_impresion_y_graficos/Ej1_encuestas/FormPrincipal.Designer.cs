
namespace Ej1_encuestas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarFeriadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.estadisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.verÍndiceDeValoracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.procesarToolStripMenuItem,
            this.estadisticaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(606, 29);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarFeriadosToolStripMenuItem,
            this.imprimirListadoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cerrarToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.configuraciónToolStripMenuItem.Text = "Edición";
            // 
            // agregarFeriadosToolStripMenuItem
            // 
            this.agregarFeriadosToolStripMenuItem.Name = "agregarFeriadosToolStripMenuItem";
            this.agregarFeriadosToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.agregarFeriadosToolStripMenuItem.Text = "Agregar comentario";
            this.agregarFeriadosToolStripMenuItem.Click += new System.EventHandler(this.btnAgregarComentario_Click);
            // 
            // imprimirListadoToolStripMenuItem
            // 
            this.imprimirListadoToolStripMenuItem.Name = "imprimirListadoToolStripMenuItem";
            this.imprimirListadoToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.imprimirListadoToolStripMenuItem.Text = "Imprimir Listado";
            this.imprimirListadoToolStripMenuItem.Click += new System.EventHandler(this.imprimirListadoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // procesarToolStripMenuItem
            // 
            this.procesarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valorarToolStripMenuItem});
            this.procesarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.procesarToolStripMenuItem.Name = "procesarToolStripMenuItem";
            this.procesarToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.procesarToolStripMenuItem.Text = "Procesar";
            // 
            // valorarToolStripMenuItem
            // 
            this.valorarToolStripMenuItem.Name = "valorarToolStripMenuItem";
            this.valorarToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.valorarToolStripMenuItem.Text = "Valorar listado";
            this.valorarToolStripMenuItem.Click += new System.EventHandler(this.valorarToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Contenido,
            this.Valoracion});
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 317);
            this.dataGridView1.TabIndex = 25;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Contenido
            // 
            this.Contenido.HeaderText = "Contenido";
            this.Contenido.Name = "Contenido";
            // 
            // Valoracion
            // 
            this.Valoracion.HeaderText = "Valoracion";
            this.Valoracion.Name = "Valoracion";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // estadisticaToolStripMenuItem
            // 
            this.estadisticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verÍndiceDeValoracionesToolStripMenuItem});
            this.estadisticaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadisticaToolStripMenuItem.Name = "estadisticaToolStripMenuItem";
            this.estadisticaToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.estadisticaToolStripMenuItem.Text = "Estadistica";
            // 
            // verÍndiceDeValoracionesToolStripMenuItem
            // 
            this.verÍndiceDeValoracionesToolStripMenuItem.Name = "verÍndiceDeValoracionesToolStripMenuItem";
            this.verÍndiceDeValoracionesToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.verÍndiceDeValoracionesToolStripMenuItem.Text = "Índice de valoraciones";
            this.verÍndiceDeValoracionesToolStripMenuItem.Click += new System.EventHandler(this.verÍndiceDeValoracionesToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 384);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "Sistema de opinión pública";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarFeriadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoracion;
        private System.Windows.Forms.ToolStripMenuItem imprimirListadoToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem procesarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.ToolStripMenuItem verÍndiceDeValoracionesToolStripMenuItem;
    }
}

