namespace To_do_List
{
    partial class FormAdd
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
            label1 = new Label();
            txtTarefa = new TextBox();
            gpStatus = new GroupBox();
            chkFeito = new CheckBox();
            chkFazendo = new CheckBox();
            chkFazer = new CheckBox();
            btnAdd = new Button();
            gpStatus.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12.1846151F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(255, 63);
            label1.Name = "label1";
            label1.Size = new Size(85, 27);
            label1.TabIndex = 0;
            label1.Text = "Tarefa:";
            // 
            // txtTarefa
            // 
            txtTarefa.Font = new Font("Arial", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTarefa.Location = new Point(257, 94);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(265, 28);
            txtTarefa.TabIndex = 1;
            // 
            // gpStatus
            // 
            gpStatus.Controls.Add(chkFeito);
            gpStatus.Controls.Add(chkFazendo);
            gpStatus.Controls.Add(chkFazer);
            gpStatus.Font = new Font("Constantia", 9.969231F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpStatus.Location = new Point(257, 146);
            gpStatus.Name = "gpStatus";
            gpStatus.Size = new Size(271, 185);
            gpStatus.TabIndex = 3;
            gpStatus.TabStop = false;
            gpStatus.Text = "Status:";
            // 
            // chkFeito
            // 
            chkFeito.AutoSize = true;
            chkFeito.Location = new Point(22, 101);
            chkFeito.Name = "chkFeito";
            chkFeito.Size = new Size(75, 26);
            chkFeito.TabIndex = 2;
            chkFeito.Text = "Feito";
            chkFeito.UseVisualStyleBackColor = true;
            // 
            // chkFazendo
            // 
            chkFazendo.AutoSize = true;
            chkFazendo.Location = new Point(22, 70);
            chkFazendo.Name = "chkFazendo";
            chkFazendo.Size = new Size(104, 26);
            chkFazendo.TabIndex = 1;
            chkFazendo.Text = "Fazendo";
            chkFazendo.UseVisualStyleBackColor = true;
            // 
            // chkFazer
            // 
            chkFazer.AutoSize = true;
            chkFazer.Location = new Point(22, 39);
            chkFazer.Name = "chkFazer";
            chkFazer.Size = new Size(91, 26);
            chkFazer.TabIndex = 0;
            chkFazer.Text = "A fazer";
            chkFazer.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Impact", 9.969231F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Navy;
            btnAdd.Location = new Point(323, 355);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 58);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Salvar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(gpStatus);
            Controls.Add(txtTarefa);
            Controls.Add(label1);
            Name = "FormAdd";
            Text = "Adicionar Tarefas";
            TopMost = true;
            gpStatus.ResumeLayout(false);
            gpStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTarefa;
        private GroupBox gpStatus;
        private CheckBox chkFeito;
        private CheckBox chkFazendo;
        private CheckBox chkFazer;
        private Button btnAdd;
    }
}