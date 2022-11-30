
namespace POOOrtoedro.windows
{
    partial class Frm_Nuevo
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
            this.components = new System.ComponentModel.Container();
            this.RellenoComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.AristaATextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AristaBtextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AristaCtextBox2 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RellenoComboBox
            // 
            this.RellenoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RellenoComboBox.FormattingEnabled = true;
            this.RellenoComboBox.Location = new System.Drawing.Point(161, 182);
            this.RellenoComboBox.Name = "RellenoComboBox";
            this.RellenoComboBox.Size = new System.Drawing.Size(279, 21);
            this.RellenoComboBox.TabIndex = 60;
            this.RellenoComboBox.SelectedIndexChanged += new System.EventHandler(this.RellenoComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "ColorRelleno";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(352, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 61);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(65, 282);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 61);
            this.btnOK.TabIndex = 61;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AristaATextBox
            // 
            this.AristaATextBox.Location = new System.Drawing.Point(161, 24);
            this.AristaATextBox.MaxLength = 50;
            this.AristaATextBox.Name = "AristaATextBox";
            this.AristaATextBox.Size = new System.Drawing.Size(279, 20);
            this.AristaATextBox.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "AristaA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "AristaB";
            // 
            // AristaBtextBox1
            // 
            this.AristaBtextBox1.Location = new System.Drawing.Point(161, 71);
            this.AristaBtextBox1.MaxLength = 50;
            this.AristaBtextBox1.Name = "AristaBtextBox1";
            this.AristaBtextBox1.Size = new System.Drawing.Size(279, 20);
            this.AristaBtextBox1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "AristaC";
            // 
            // AristaCtextBox2
            // 
            this.AristaCtextBox2.Location = new System.Drawing.Point(161, 123);
            this.AristaCtextBox2.MaxLength = 50;
            this.AristaCtextBox2.Name = "AristaCtextBox2";
            this.AristaCtextBox2.Size = new System.Drawing.Size(279, 20);
            this.AristaCtextBox2.TabIndex = 63;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.ControlBox = false;
            this.Controls.Add(this.AristaCtextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AristaBtextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AristaATextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.RellenoComboBox);
            this.Controls.Add(this.label4);
            this.Name = "Frm_Nuevo";
            this.Text = "Frm_Nuevo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RellenoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox AristaATextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AristaBtextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AristaCtextBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}