using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace To_do_List
{
    public partial class Form1 : Form
    {
        private Database db = new Database();
        private bool isProcessing = false; // Flag para indicar que uma operação está em andamento

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Desabilitar os botões enquanto os dados estão sendo carregados
                ToggleButtons(false);

                string query = "SELECT * FROM TodoList";
                using (var adapter = new MySqlDataAdapter(query, db.GetConnection()))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgTodoList.DataSource = table;

                    dgTodoList.Columns["Id"].Visible = false;
                    db.CloseConnection();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Habilitar os botões novamente após carregar os dados
                ToggleButtons(true);
            }
        }

        private void ToggleButtons(bool enable)
        {
            btnAdicionar.Enabled = enable;
            btnEditar.Enabled = enable;
            btnExcluir.Enabled = enable;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de adição de tarefa
            FormAdd formAdicionar = new FormAdd();
            formAdicionar.ShowDialog();
            if (formAdicionar.DialogResult == DialogResult.OK)
            {
                LoadData();
                MessageBox.Show("Tarefa adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar se uma linha foi selecionada
            if (dgTodoList.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgTodoList.SelectedRows[0].Cells["Id"].Value);
                string tarefa = dgTodoList.SelectedRows[0].Cells["tarefa"].Value.ToString();
                string status = dgTodoList.SelectedRows[0].Cells["status"].Value.ToString();

                // Abrir o formulário de edição de tarefa
                FormAdd formAdd = new FormAdd(id, tarefa, status);
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                    MessageBox.Show("Tarefa editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verificar se uma linha foi selecionada
            if (dgTodoList.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgTodoList.SelectedRows[0].Cells["Id"].Value);
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir esta tarefa?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        db.OpenConnection();
                        string query = "DELETE FROM TodoList WHERE Id = @id";
                        using (var cmd = new MySqlCommand(query, db.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Tarefa excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir a tarefa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
