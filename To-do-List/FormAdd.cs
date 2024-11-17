using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace To_do_List
{
    public partial class FormAdd : Form
    {
        private int? TodoListId = null;
        private Database db = new Database();

        public FormAdd()
        {
            InitializeComponent();
        }

        public FormAdd(int id, string tarefa, string status)
        {
            TodoListId = id;
            InitializeComponent();
            txtTarefa.Text = tarefa;

            // Definir o checkbox de status correto com base no valor do status
            SetStatusCheckbox(status);
        }

        // Define o checkbox de status corretamente com base no valor passado
        private void SetStatusCheckbox(string status)
        {
            chkFazer.Checked = false;
            chkFazendo.Checked = false;
            chkFeito.Checked = false;

            if (status == "A fazer")
            {
                chkFazer.Checked = true;
            }
            else if (status == "Fazendo")
            {
                chkFazendo.Checked = true;
            }
            else if (status == "Feito")
            {
                chkFeito.Checked = true;
            }
        }
        // Método para desmarcar os outros Checkboxes
        private void DeselecionarOutrosCheckBoxes(CheckBox checkboxSelecionado)
        {
            if (checkboxSelecionado == chkFazer)
            {
                chkFazendo.Checked = false;
                chkFeito.Checked = false;
            }
            else if (checkboxSelecionado == chkFazendo)
            {
                chkFazer.Checked = false;
                chkFeito.Checked = false;
            }
            else if (checkboxSelecionado == chkFeito)
            {
                chkFazer.Checked = false;
                chkFazendo.Checked = false;
            }
        }

        private void chkFazer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFazer.Checked)
            {
                DeselecionarOutrosCheckBoxes(chkFazer);
            }
        }

        private void chkFeito_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFeito.Checked)
            {
                DeselecionarOutrosCheckBoxes(chkFeito);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tarefa = txtTarefa.Text;
            string status = GetStatus();

            // Validar se a tarefa foi preenchida
            if (string.IsNullOrWhiteSpace(tarefa))
            {
                MessageBox.Show("A tarefa não pode estar vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se o status foi selecionado
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Selecione o status da tarefa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.OpenConnection();
                string query;

                if (TodoListId == null)
                {
                    query = "INSERT INTO todolist(Tarefa, Status) VALUES (@tarefa, @status)";
                }
                else
                {
                    query = "UPDATE todolist SET Tarefa = @tarefa, Status = @status WHERE ID = @TodoListId";
                }

                using (var cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@tarefa", tarefa);
                    cmd.Parameters.AddWithValue("@status", status);

                    if (TodoListId != null)
                    {
                        cmd.Parameters.AddWithValue("@TodoListId", TodoListId);
                    }

                    cmd.ExecuteNonQuery();
                }

                // Fechar o formulário
                DialogResult = DialogResult.OK;  // Isso fecha o Form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a tarefa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // Obtém o status da tarefa selecionado pelo usuário
        private string GetStatus()
        {
            if (chkFazer.Checked)
                return "A fazer";
            if (chkFazendo.Checked)
                return "Fazendo";
            if (chkFeito.Checked)
                return "Feito";

            return null; // Nenhum status selecionado
        }
    }
}
