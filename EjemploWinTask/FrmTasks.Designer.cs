namespace EjemploWinTask
{
    partial class FrmTasks
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
            pb1 = new ProgressBar();
            pb4 = new ProgressBar();
            pb3 = new ProgressBar();
            pb2 = new ProgressBar();
            btnIniciar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // pb1
            // 
            pb1.Location = new Point(58, 116);
            pb1.Name = "pb1";
            pb1.Size = new Size(100, 23);
            pb1.TabIndex = 0;
            // 
            // pb4
            // 
            pb4.Location = new Point(465, 116);
            pb4.Name = "pb4";
            pb4.Size = new Size(100, 23);
            pb4.TabIndex = 1;
            // 
            // pb3
            // 
            pb3.Location = new Point(331, 116);
            pb3.Name = "pb3";
            pb3.Size = new Size(100, 23);
            pb3.TabIndex = 2;
            // 
            // pb2
            // 
            pb2.Location = new Point(196, 116);
            pb2.Name = "pb2";
            pb2.Size = new Size(100, 23);
            pb2.TabIndex = 3;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(76, 45);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 162);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new Size(100, 250);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 162);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ShortcutsEnabled = false;
            textBox2.Size = new Size(100, 250);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(331, 162);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ShortcutsEnabled = false;
            textBox3.Size = new Size(100, 250);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(465, 162);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ShortcutsEnabled = false;
            textBox4.Size = new Size(100, 250);
            textBox4.TabIndex = 8;
            // 
            // FrmTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 428);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnIniciar);
            Controls.Add(pb2);
            Controls.Add(pb3);
            Controls.Add(pb4);
            Controls.Add(pb1);
            Name = "FrmTasks";
            Text = "FrmTasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pb1;
        private ProgressBar pb4;
        private ProgressBar pb3;
        private ProgressBar pb2;
        private Button btnIniciar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}