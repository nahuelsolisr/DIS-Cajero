namespace DIS_Cajero
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_ingresar = new Button();
            txt_Tarjeta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_Pin = new TextBox();
            SuspendLayout();
            // 
            // btn_ingresar
            // 
            btn_ingresar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ingresar.Location = new Point(126, 180);
            btn_ingresar.Margin = new Padding(4);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(96, 29);
            btn_ingresar.TabIndex = 0;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // txt_Tarjeta
            // 
            txt_Tarjeta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Tarjeta.Location = new Point(15, 34);
            txt_Tarjeta.Margin = new Padding(4);
            txt_Tarjeta.Name = "txt_Tarjeta";
            txt_Tarjeta.Size = new Size(207, 27);
            txt_Tarjeta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 2;
            label1.Text = "Tarjeta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 19);
            label2.TabIndex = 4;
            label2.Text = "Pin:";
            // 
            // txt_Pin
            // 
            txt_Pin.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Pin.Location = new Point(15, 90);
            txt_Pin.Margin = new Padding(4);
            txt_Pin.Name = "txt_Pin";
            txt_Pin.Size = new Size(207, 27);
            txt_Pin.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 222);
            Controls.Add(label2);
            Controls.Add(txt_Pin);
            Controls.Add(label1);
            Controls.Add(txt_Tarjeta);
            Controls.Add(btn_ingresar);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "-Login-";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ingresar;
        private TextBox txt_Tarjeta;
        private Label label1;
        private Label label2;
        private TextBox txt_Pin;
    }
}