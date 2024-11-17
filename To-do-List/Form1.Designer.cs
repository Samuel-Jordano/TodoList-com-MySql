namespace To_do_List
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dgTodoList = new DataGridView();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            databaseBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgTodoList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12.1846151F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(34, 26);
            label1.Name = "label1";
            label1.Size = new Size(89, 27);
            label1.TabIndex = 0;
            label1.Text = "Tarefas";
            // 
            // dgTodoList
            // 
            dgTodoList.BackgroundColor = Color.FromArgb(244, 246, 248);
            dgTodoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTodoList.GridColor = Color.WhiteSmoke;
            dgTodoList.Location = new Point(23, 56);
            dgTodoList.Name = "dgTodoList";
            dgTodoList.RowHeadersWidth = 56;
            dgTodoList.Size = new Size(734, 276);
            dgTodoList.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.White;
            btnAdicionar.FlatStyle = FlatStyle.Popup;
            btnAdicionar.Font = new Font("Impact", 9.969231F);
            btnAdicionar.ForeColor = Color.Navy;
            btnAdicionar.Location = new Point(102, 363);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(152, 66);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Impact", 9.969231F);
            btnEditar.ForeColor = Color.Navy;
            btnEditar.Location = new Point(336, 363);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(132, 66);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.White;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Impact", 9.969231F);
            btnExcluir.ForeColor = Color.Navy;
            btnExcluir.Location = new Point(544, 363);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(128, 66);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // databaseBindingSource
            // 
            databaseBindingSource.DataSource = typeof(Database);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(dgTodoList);
            Controls.Add(label1);
            ImeMode = ImeMode.Off;
            Name = "Form1";
            Text = "ToDoList";
            ((System.ComponentModel.ISupportInitialize)dgTodoList).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgTodoList;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
        private BindingSource databaseBindingSource;
    }
}
