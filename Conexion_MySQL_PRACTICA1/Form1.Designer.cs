namespace Conexion_MySQL_PRACTICA1
{
    partial class Conexion_BaseDatos
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
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Variable Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(354, 265);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(171, 54);
            button1.TabIndex = 0;
            button1.Text = "Conectar";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 33);
            label1.Name = "label1";
            label1.Size = new Size(247, 31);
            label1.TabIndex = 1;
            label1.Text = "Estado de la conexion";
            // 
            // Conexion_BaseDatos
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(576, 376);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Conexion_BaseDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}
