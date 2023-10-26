using System;
using System.Windows.Forms;

namespace CadastroDePessoas
{
    public partial class Form1 : Form
    {
        private TextBox nomeTextBox;
        private TextBox sobrenomeTextBox;
        private TextBox idadeTextBox;
        private TextBox enderecoTextBox;
        private TextBox telefoneTextBox;
        private Button cadastrarButton;

       public Form1()
{
    InitializeComponent();


    nomeTextBox = new TextBox();
    sobrenomeTextBox = new TextBox();
    idadeTextBox = new TextBox();
    enderecoTextBox = new TextBox();
    telefoneTextBox = new TextBox();
    cadastrarButton = new Button();
}

        private void InitializeComponent()
        {
            this.nomeTextBox = new TextBox();
            this.sobrenomeTextBox = new TextBox();
            this.idadeTextBox = new TextBox();
            this.enderecoTextBox = new TextBox();
            this.telefoneTextBox = new TextBox();
            this.cadastrarButton = new Button();

            // Configuração da janela
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Cadastro de Pessoas";

            // Rótulos para os campos
            Label nomeLabel = new Label();
            nomeLabel.Text = "Nome:";
            nomeLabel.Location = new System.Drawing.Point(20, 20);

            Label sobrenomeLabel = new Label();
            sobrenomeLabel.Text = "Sobrenome:";
            sobrenomeLabel.Location = new System.Drawing.Point(20, 60);

            Label idadeLabel = new Label();
            idadeLabel.Text = "Idade:";
            idadeLabel.Location = new System.Drawing.Point(20, 100);

            Label enderecoLabel = new Label();
            enderecoLabel.Text = "Endereço:";
            enderecoLabel.Location = new System.Drawing.Point(20, 140);

            Label telefoneLabel = new Label();
            telefoneLabel.Text = "Telefone:";
            telefoneLabel.Location = new System.Drawing.Point(20, 180);

            // Configuração dos controles
            this.nomeTextBox.Location = new System.Drawing.Point(120, 20);
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);

            this.sobrenomeTextBox.Location = new System.Drawing.Point(120, 60);
            this.sobrenomeTextBox.Size = new System.Drawing.Size(200, 20);

            this.idadeTextBox.Location = new System.Drawing.Point(120, 100);
            this.idadeTextBox.Size = new System.Drawing.Size(200, 20);

            this.enderecoTextBox.Location = new System.Drawing.Point(120, 140);
            this.enderecoTextBox.Size = new System.Drawing.Size(200, 20);

            this.telefoneTextBox.Location = new System.Drawing.Point(120, 180);
            this.telefoneTextBox.Size = new System.Drawing.Size(200, 20);

            this.cadastrarButton.Location = new System.Drawing.Point(20, 220);
            this.cadastrarButton.Size = new System.Drawing.Size(70,70);
            this.cadastrarButton.Text = "Salvar";
            this.cadastrarButton.Click += CadastrarButton_Click;

            this.Controls.Add(nomeLabel);
            this.Controls.Add(sobrenomeLabel);
            this.Controls.Add(idadeLabel);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(telefoneLabel);

            this.Controls.Add(nomeTextBox);
            this.Controls.Add(sobrenomeTextBox);
            this.Controls.Add(idadeTextBox);
            this.Controls.Add(enderecoTextBox);
            this.Controls.Add(telefoneTextBox);
            this.Controls.Add(cadastrarButton);
        }

       private void CadastrarButton_Click(object? sender, EventArgs e)
{
    string nome = nomeTextBox.Text;
    string sobrenome = sobrenomeTextBox.Text;
    string idade = idadeTextBox.Text;
    string endereco = enderecoTextBox.Text;
    string telefone = telefoneTextBox.Text;

    MessageBox.Show($"Nome: {nome}\nSobrenome: {sobrenome}\nIdade: {idade}\nEndereço: {endereco}\nTelefone: {telefone}", "Cadastro Efetuado");

    nomeTextBox.Clear();
    sobrenomeTextBox.Clear();
    idadeTextBox.Clear();
    enderecoTextBox.Clear();
    telefoneTextBox.Clear();
}

    }
}
