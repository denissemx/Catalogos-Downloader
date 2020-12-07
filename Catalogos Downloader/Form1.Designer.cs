
namespace Catalogos_Downloader
{
    partial class frmPriceshoes
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
            this.cmbTiendas = new System.Windows.Forms.ComboBox();
            this.lbl_Tienda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTiendas
            // 
            this.cmbTiendas.FormattingEnabled = true;
            this.cmbTiendas.Items.AddRange(new object[] {
            "AGUASCALIENTES",
            "ARCO NORTE",
            "CENTRO HISTORICO",
            "COMUNIDAD",
            "ECATEPEC",
            "GDL MIRAVALLE",
            "GUADALAJARA",
            "IXTAPALUCA",
            "IZTAPALAPA",
            "LEON",
            "NAUCALPAN",
            "OLIVAR DEL CONDE",
            "PUEBLA",
            "QUERETARO",
            "TIJUANA",
            "TMK",
            "TOLUCA",
            "VALLEJO",
            "VERACRUZ",
            "WEB"});
            this.cmbTiendas.Location = new System.Drawing.Point(87, 32);
            this.cmbTiendas.Name = "cmbTiendas";
            this.cmbTiendas.Size = new System.Drawing.Size(121, 21);
            this.cmbTiendas.TabIndex = 0;
            // 
            // lbl_Tienda
            // 
            this.lbl_Tienda.AutoSize = true;
            this.lbl_Tienda.Location = new System.Drawing.Point(27, 32);
            this.lbl_Tienda.Name = "lbl_Tienda";
            this.lbl_Tienda.Size = new System.Drawing.Size(43, 13);
            this.lbl_Tienda.TabIndex = 1;
            this.lbl_Tienda.Text = "Tienda:";
            // 
            // frmPriceshoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Tienda);
            this.Controls.Add(this.cmbTiendas);
            this.Name = "frmPriceshoes";
            this.Text = "Priceshoes Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTiendas;
        private System.Windows.Forms.Label lbl_Tienda;
    }
}

