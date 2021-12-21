
namespace sql
{
    partial class Form2
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Item = new System.Windows.Forms.ToolStripButton();
            this.Add = new System.Windows.Forms.ToolStripButton();
            this.Edit = new System.Windows.Forms.ToolStripButton();
            this.Delete = new System.Windows.Forms.ToolStripButton();
            this.Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtCari = new System.Windows.Forms.ToolStripTextBox();
            this.Cari = new System.Windows.Forms.ToolStripButton();
            this.Previous = new System.Windows.Forms.ToolStripButton();
            this.Next = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item,
            this.Add,
            this.Edit,
            this.Delete,
            this.Refresh,
            this.toolStripLabel1,
            this.txtCari,
            this.Cari,
            this.Previous,
            this.Next});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(451, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Item
            // 
            this.Item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Item.Image = global::sql.Properties.Resources.file__1_;
            this.Item.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Item.Name = "Item";
            this.Item.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Item.Size = new System.Drawing.Size(25, 22);
            this.Item.Text = "toolStripButton1";
            this.Item.Click += new System.EventHandler(this.Item_Click);
            // 
            // Add
            // 
            this.Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add.Image = global::sql.Properties.Resources.Add;
            this.Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Add.Size = new System.Drawing.Size(25, 22);
            this.Add.Text = "toolStripButton2";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Edit.Image = global::sql.Properties.Resources.Edit;
            this.Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Edit.Size = new System.Drawing.Size(25, 22);
            this.Edit.Text = "toolStripButton3";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete.Image = global::sql.Properties.Resources.Delete1;
            this.Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete.Name = "Delete";
            this.Delete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Delete.Size = new System.Drawing.Size(25, 22);
            this.Delete.Text = "toolStripButton4";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Refresh
            // 
            this.Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Refresh.Image = global::sql.Properties.Resources.Reset;
            this.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh.Name = "Refresh";
            this.Refresh.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Refresh.Size = new System.Drawing.Size(25, 22);
            this.Refresh.Text = "toolStripButton5";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Cari : ";
            // 
            // txtCari
            // 
            this.txtCari.Name = "txtCari";
            this.txtCari.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txtCari.Size = new System.Drawing.Size(125, 25);
            // 
            // Cari
            // 
            this.Cari.BackgroundImage = global::sql.Properties.Resources.search_icon;
            this.Cari.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cari.Image = global::sql.Properties.Resources.search_icon;
            this.Cari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cari.Name = "Cari";
            this.Cari.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Cari.Size = new System.Drawing.Size(25, 22);
            this.Cari.Text = "toolStripButton6";
            this.Cari.Click += new System.EventHandler(this.Cari_Click);
            // 
            // Previous
            // 
            this.Previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Previous.Image = global::sql.Properties.Resources.Prev;
            this.Previous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Previous.Name = "Previous";
            this.Previous.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Previous.Size = new System.Drawing.Size(35, 22);
            this.Previous.Text = "toolStripButton7";
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Next.Image = global::sql.Properties.Resources.Next;
            this.Next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Next.Name = "Next";
            this.Next.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Next.Size = new System.Drawing.Size(35, 22);
            this.Next.Text = "toolStripButton8";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Harga";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(143, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(133, 23);
            this.txtId.TabIndex = 4;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(143, 96);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(192, 23);
            this.txtNama.TabIndex = 5;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(143, 137);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(133, 23);
            this.txtHarga.TabIndex = 6;
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(30, 192);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowTemplate.Height = 25;
            this.dgvMenu.Size = new System.Drawing.Size(388, 150);
            this.dgvMenu.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 375);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Item;
        private System.Windows.Forms.ToolStripButton Add;
        private System.Windows.Forms.ToolStripButton Edit;
        private System.Windows.Forms.ToolStripButton Delete;
        private System.Windows.Forms.ToolStripButton Refresh;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtCari;
        private System.Windows.Forms.ToolStripButton Cari;
        private System.Windows.Forms.ToolStripButton Previous;
        private System.Windows.Forms.ToolStripButton Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.DataGridView dgvMenu;
    }
}