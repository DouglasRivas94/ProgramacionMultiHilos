namespace EjemploWinThread
{
    partial class FrmThread
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
            btnIniciar = new Button();
            pb1 = new ProgressBar();
            pb2 = new ProgressBar();
            pb3 = new ProgressBar();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(27, 100);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(85, 45);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // pb1
            // 
            pb1.Location = new Point(200, 53);
            pb1.Name = "pb1";
            pb1.Size = new Size(219, 32);
            pb1.TabIndex = 1;
            // 
            // pb2
            // 
            pb2.Location = new Point(200, 100);
            pb2.Name = "pb2";
            pb2.Size = new Size(219, 32);
            pb2.TabIndex = 2;
            // 
            // pb3
            // 
            pb3.Location = new Point(200, 145);
            pb3.Name = "pb3";
            pb3.Size = new Size(219, 32);
            pb3.TabIndex = 3;
            // 
            // FrmThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 229);
            Controls.Add(pb3);
            Controls.Add(pb2);
            Controls.Add(pb1);
            Controls.Add(btnIniciar);
            Name = "FrmThread";
            Text = "FrmThread";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private ProgressBar pb1;
        private ProgressBar pb2;
        private ProgressBar pb3;
    }
}