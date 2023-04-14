namespace WindowsFormsApp
{
    partial class frmMarcaCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcaCat));
            this.btnAceptarCat = new System.Windows.Forms.Button();
            this.btnCancelarCat = new System.Windows.Forms.Button();
            this.lblMarcaAdd = new System.Windows.Forms.Label();
            this.txtMarcaAdd = new System.Windows.Forms.TextBox();
            this.lblCategoriaAdd = new System.Windows.Forms.Label();
            this.txtCategoriaAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptarCat
            // 
            this.btnAceptarCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarCat.Location = new System.Drawing.Point(38, 169);
            this.btnAceptarCat.Name = "btnAceptarCat";
            this.btnAceptarCat.Size = new System.Drawing.Size(75, 27);
            this.btnAceptarCat.TabIndex = 0;
            this.btnAceptarCat.Text = "&Aceptar";
            this.btnAceptarCat.UseVisualStyleBackColor = true;
            this.btnAceptarCat.Click += new System.EventHandler(this.btnAceptarCat_Click);
            // 
            // btnCancelarCat
            // 
            this.btnCancelarCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCat.Location = new System.Drawing.Point(224, 169);
            this.btnCancelarCat.Name = "btnCancelarCat";
            this.btnCancelarCat.Size = new System.Drawing.Size(75, 27);
            this.btnCancelarCat.TabIndex = 1;
            this.btnCancelarCat.Text = "&Cancelar";
            this.btnCancelarCat.UseVisualStyleBackColor = true;
            this.btnCancelarCat.Click += new System.EventHandler(this.btnCancelarCat_Click);
            // 
            // lblMarcaAdd
            // 
            this.lblMarcaAdd.AutoSize = true;
            this.lblMarcaAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaAdd.Location = new System.Drawing.Point(13, 45);
            this.lblMarcaAdd.Name = "lblMarcaAdd";
            this.lblMarcaAdd.Size = new System.Drawing.Size(54, 18);
            this.lblMarcaAdd.TabIndex = 2;
            this.lblMarcaAdd.Text = "Marca:";
            // 
            // txtMarcaAdd
            // 
            this.txtMarcaAdd.Location = new System.Drawing.Point(98, 45);
            this.txtMarcaAdd.Name = "txtMarcaAdd";
            this.txtMarcaAdd.Size = new System.Drawing.Size(201, 20);
            this.txtMarcaAdd.TabIndex = 3;
            // 
            // lblCategoriaAdd
            // 
            this.lblCategoriaAdd.AutoSize = true;
            this.lblCategoriaAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaAdd.Location = new System.Drawing.Point(13, 107);
            this.lblCategoriaAdd.Name = "lblCategoriaAdd";
            this.lblCategoriaAdd.Size = new System.Drawing.Size(76, 18);
            this.lblCategoriaAdd.TabIndex = 4;
            this.lblCategoriaAdd.Text = "Categoría:";
            // 
            // txtCategoriaAdd
            // 
            this.txtCategoriaAdd.Location = new System.Drawing.Point(98, 105);
            this.txtCategoriaAdd.Name = "txtCategoriaAdd";
            this.txtCategoriaAdd.Size = new System.Drawing.Size(201, 20);
            this.txtCategoriaAdd.TabIndex = 5;
            // 
            // frmMarcaCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(329, 219);
            this.Controls.Add(this.txtCategoriaAdd);
            this.Controls.Add(this.lblCategoriaAdd);
            this.Controls.Add(this.txtMarcaAdd);
            this.Controls.Add(this.lblMarcaAdd);
            this.Controls.Add(this.btnCancelarCat);
            this.Controls.Add(this.btnAceptarCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMarcaCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Añadir...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarCat;
        private System.Windows.Forms.Button btnCancelarCat;
        private System.Windows.Forms.Label lblMarcaAdd;
        private System.Windows.Forms.TextBox txtMarcaAdd;
        private System.Windows.Forms.Label lblCategoriaAdd;
        private System.Windows.Forms.TextBox txtCategoriaAdd;
    }
}