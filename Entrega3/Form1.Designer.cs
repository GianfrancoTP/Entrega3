namespace Entrega3
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Titulo = new System.Windows.Forms.Label();
            this.BotonMeses = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelinfo = new System.Windows.Forms.Label();
            this.LabelMes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelInfoMes = new System.Windows.Forms.Label();
            this.CantidadMeses = new System.Windows.Forms.Label();
            this.MesesBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 196);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 594);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Menu;
            this.Titulo.Location = new System.Drawing.Point(424, 29);
            this.Titulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(353, 64);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Bitmonlandia";
            // 
            // BotonMeses
            // 
            this.BotonMeses.Location = new System.Drawing.Point(40, 54);
            this.BotonMeses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonMeses.Name = "BotonMeses";
            this.BotonMeses.Size = new System.Drawing.Size(149, 94);
            this.BotonMeses.TabIndex = 2;
            this.BotonMeses.Text = "Empezar simulacion";
            this.BotonMeses.UseVisualStyleBackColor = true;
            this.BotonMeses.Click += new System.EventHandler(this.Meses_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.labelinfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(882, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 1137);
            this.panel1.TabIndex = 3;
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfo.Location = new System.Drawing.Point(15, 9);
            this.labelinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(92, 36);
            this.labelinfo.TabIndex = 0;
            this.labelinfo.Text = "label1";
            // 
            // LabelMes
            // 
            this.LabelMes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMes.AutoSize = true;
            this.LabelMes.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMes.ForeColor = System.Drawing.SystemColors.Menu;
            this.LabelMes.Location = new System.Drawing.Point(530, 138);
            this.LabelMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMes.Name = "LabelMes";
            this.LabelMes.Size = new System.Drawing.Size(137, 52);
            this.LabelMes.TabIndex = 3;
            this.LabelMes.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Save);
            this.panel2.Controls.Add(this.Titulo);
            this.panel2.Controls.Add(this.BotonMeses);
            this.panel2.Controls.Add(this.LabelMes);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 852);
            this.panel2.TabIndex = 4;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(667, 196);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(158, 94);
            this.Save.TabIndex = 4;
            this.Save.Text = "Guardar resultados";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.labelInfoMes);
            this.panel3.Controls.Add(this.CantidadMeses);
            this.panel3.Controls.Add(this.MesesBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 852);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(882, 285);
            this.panel3.TabIndex = 5;
            // 
            // labelInfoMes
            // 
            this.labelInfoMes.AutoSize = true;
            this.labelInfoMes.Font = new System.Drawing.Font("Trebuchet MS", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoMes.ForeColor = System.Drawing.SystemColors.Info;
            this.labelInfoMes.Location = new System.Drawing.Point(22, 37);
            this.labelInfoMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfoMes.Name = "labelInfoMes";
            this.labelInfoMes.Size = new System.Drawing.Size(87, 33);
            this.labelInfoMes.TabIndex = 6;
            this.labelInfoMes.Text = "label2";
            // 
            // CantidadMeses
            // 
            this.CantidadMeses.AutoSize = true;
            this.CantidadMeses.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadMeses.ForeColor = System.Drawing.SystemColors.Info;
            this.CantidadMeses.Location = new System.Drawing.Point(22, 28);
            this.CantidadMeses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CantidadMeses.Name = "CantidadMeses";
            this.CantidadMeses.Size = new System.Drawing.Size(493, 36);
            this.CantidadMeses.TabIndex = 4;
            this.CantidadMeses.Text = "Cantidad de meses que desea simular:";
            // 
            // MesesBox
            // 
            this.MesesBox.Location = new System.Drawing.Point(539, 31);
            this.MesesBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MesesBox.Multiline = true;
            this.MesesBox.Name = "MesesBox";
            this.MesesBox.Size = new System.Drawing.Size(81, 39);
            this.MesesBox.TabIndex = 3;
            this.MesesBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MesesBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1332, 1137);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Bitmonlandia";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MesesBox_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button BotonMeses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelMes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Label CantidadMeses;
        private System.Windows.Forms.TextBox MesesBox;
        private System.Windows.Forms.Label labelInfoMes;
        private System.Windows.Forms.Button Save;
    }
}

