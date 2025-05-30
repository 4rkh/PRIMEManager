﻿namespace Prime_Gadgets.modulos.moduloSenhas
{
    partial class UpdateSenhas
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSenhas));
            btUpdateSenhasCancelar = new Button();
            btUpdateSenhasAtualizar = new Button();
            campUpdateSenhasOrigem = new TextBox();
            campUpdateSenhasSenha = new TextBox();
            campUpdateSenhasEmail = new TextBox();
            campUpdateSenhasNome = new TextBox();
            lbUpdateSenhasEmailInvalido = new Label();
            lbUpdateSenhasOrigem = new Label();
            lbUpdateSenhasSenha = new Label();
            lbUpdateSenhasEmail = new Label();
            lbUpdateSenhasNome = new Label();
            lbUpdateSenhasTitulo = new Label();
            campUpdateSenhasId = new TextBox();
            lbUpdateSenhasId = new Label();
            lbUpdateSenhasSenhaInvalida = new Label();
            btUpdateSenhasMostrar = new Button();
            btUpdateSenhasGerar = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            SuspendLayout();
            // 
            // btUpdateSenhasCancelar
            // 
            btUpdateSenhasCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btUpdateSenhasCancelar.BackColor = Color.FromArgb(230, 34, 34);
            btUpdateSenhasCancelar.FlatAppearance.BorderSize = 0;
            btUpdateSenhasCancelar.FlatStyle = FlatStyle.Flat;
            btUpdateSenhasCancelar.Font = new Font("Arial", 12.75F);
            btUpdateSenhasCancelar.ForeColor = Color.FromArgb(255, 252, 237);
            btUpdateSenhasCancelar.Location = new Point(199, 382);
            btUpdateSenhasCancelar.Name = "btUpdateSenhasCancelar";
            btUpdateSenhasCancelar.Size = new Size(118, 37);
            btUpdateSenhasCancelar.TabIndex = 23;
            btUpdateSenhasCancelar.Text = "Cancelar";
            btUpdateSenhasCancelar.UseVisualStyleBackColor = false;
            btUpdateSenhasCancelar.Click += btUpdateSenhasCancelar_Click;
            // 
            // btUpdateSenhasAtualizar
            // 
            btUpdateSenhasAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btUpdateSenhasAtualizar.BackColor = Color.FromArgb(230, 34, 34);
            btUpdateSenhasAtualizar.FlatAppearance.BorderSize = 0;
            btUpdateSenhasAtualizar.FlatStyle = FlatStyle.Flat;
            btUpdateSenhasAtualizar.Font = new Font("Arial", 12.75F);
            btUpdateSenhasAtualizar.ForeColor = Color.FromArgb(255, 252, 237);
            btUpdateSenhasAtualizar.Location = new Point(47, 382);
            btUpdateSenhasAtualizar.Name = "btUpdateSenhasAtualizar";
            btUpdateSenhasAtualizar.Size = new Size(118, 37);
            btUpdateSenhasAtualizar.TabIndex = 22;
            btUpdateSenhasAtualizar.Text = "Atualizar";
            btUpdateSenhasAtualizar.UseVisualStyleBackColor = false;
            btUpdateSenhasAtualizar.Click += btUpdateSenhasAtualizar_Click;
            // 
            // campUpdateSenhasOrigem
            // 
            campUpdateSenhasOrigem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campUpdateSenhasOrigem.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateSenhasOrigem.BorderStyle = BorderStyle.None;
            campUpdateSenhasOrigem.Font = new Font("Arial", 12.75F);
            campUpdateSenhasOrigem.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateSenhasOrigem.Location = new Point(163, 244);
            campUpdateSenhasOrigem.Name = "campUpdateSenhasOrigem";
            campUpdateSenhasOrigem.Size = new Size(100, 20);
            campUpdateSenhasOrigem.TabIndex = 21;
            // 
            // campUpdateSenhasSenha
            // 
            campUpdateSenhasSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campUpdateSenhasSenha.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateSenhasSenha.BorderStyle = BorderStyle.None;
            campUpdateSenhasSenha.Font = new Font("Arial", 12.75F);
            campUpdateSenhasSenha.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateSenhasSenha.Location = new Point(163, 215);
            campUpdateSenhasSenha.Name = "campUpdateSenhasSenha";
            campUpdateSenhasSenha.Size = new Size(100, 20);
            campUpdateSenhasSenha.TabIndex = 20;
            campUpdateSenhasSenha.UseSystemPasswordChar = true;
            campUpdateSenhasSenha.TextChanged += Campos_TextChanged;
            campUpdateSenhasSenha.Validating += PasswordValidator;
            // 
            // campUpdateSenhasEmail
            // 
            campUpdateSenhasEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campUpdateSenhasEmail.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateSenhasEmail.BorderStyle = BorderStyle.None;
            campUpdateSenhasEmail.Font = new Font("Arial", 12.75F);
            campUpdateSenhasEmail.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateSenhasEmail.Location = new Point(163, 186);
            campUpdateSenhasEmail.Name = "campUpdateSenhasEmail";
            campUpdateSenhasEmail.Size = new Size(100, 20);
            campUpdateSenhasEmail.TabIndex = 19;
            campUpdateSenhasEmail.Validating += campUpdateSenhasEmail_Validating;
            // 
            // campUpdateSenhasNome
            // 
            campUpdateSenhasNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campUpdateSenhasNome.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateSenhasNome.BorderStyle = BorderStyle.None;
            campUpdateSenhasNome.Font = new Font("Arial", 12.75F);
            campUpdateSenhasNome.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateSenhasNome.Location = new Point(163, 157);
            campUpdateSenhasNome.Name = "campUpdateSenhasNome";
            campUpdateSenhasNome.Size = new Size(100, 20);
            campUpdateSenhasNome.TabIndex = 18;
            campUpdateSenhasNome.KeyPress += campUpdateSenhasNome_KeyPress;
            // 
            // lbUpdateSenhasEmailInvalido
            // 
            lbUpdateSenhasEmailInvalido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasEmailInvalido.AutoSize = true;
            lbUpdateSenhasEmailInvalido.Font = new Font("Arial", 9F);
            lbUpdateSenhasEmailInvalido.ForeColor = Color.FromArgb(230, 34, 34);
            lbUpdateSenhasEmailInvalido.Location = new Point(168, 270);
            lbUpdateSenhasEmailInvalido.Name = "lbUpdateSenhasEmailInvalido";
            lbUpdateSenhasEmailInvalido.Size = new Size(91, 15);
            lbUpdateSenhasEmailInvalido.TabIndex = 17;
            lbUpdateSenhasEmailInvalido.Text = "E-mail inválido!";
            // 
            // lbUpdateSenhasOrigem
            // 
            lbUpdateSenhasOrigem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasOrigem.AutoSize = true;
            lbUpdateSenhasOrigem.Font = new Font("Arial", 12.75F);
            lbUpdateSenhasOrigem.Location = new Point(49, 245);
            lbUpdateSenhasOrigem.Name = "lbUpdateSenhasOrigem";
            lbUpdateSenhasOrigem.Size = new Size(62, 19);
            lbUpdateSenhasOrigem.TabIndex = 16;
            lbUpdateSenhasOrigem.Text = "Origem";
            // 
            // lbUpdateSenhasSenha
            // 
            lbUpdateSenhasSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasSenha.AutoSize = true;
            lbUpdateSenhasSenha.Font = new Font("Arial", 12.75F);
            lbUpdateSenhasSenha.Location = new Point(51, 216);
            lbUpdateSenhasSenha.Name = "lbUpdateSenhasSenha";
            lbUpdateSenhasSenha.Size = new Size(56, 19);
            lbUpdateSenhasSenha.TabIndex = 15;
            lbUpdateSenhasSenha.Text = "Senha";
            // 
            // lbUpdateSenhasEmail
            // 
            lbUpdateSenhasEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasEmail.AutoSize = true;
            lbUpdateSenhasEmail.Font = new Font("Arial", 12.75F);
            lbUpdateSenhasEmail.Location = new Point(49, 187);
            lbUpdateSenhasEmail.Name = "lbUpdateSenhasEmail";
            lbUpdateSenhasEmail.Size = new Size(55, 19);
            lbUpdateSenhasEmail.TabIndex = 14;
            lbUpdateSenhasEmail.Text = "E-mail";
            // 
            // lbUpdateSenhasNome
            // 
            lbUpdateSenhasNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasNome.AutoSize = true;
            lbUpdateSenhasNome.Font = new Font("Arial", 12.75F);
            lbUpdateSenhasNome.Location = new Point(14, 158);
            lbUpdateSenhasNome.Name = "lbUpdateSenhasNome";
            lbUpdateSenhasNome.Size = new Size(135, 19);
            lbUpdateSenhasNome.TabIndex = 13;
            lbUpdateSenhasNome.Text = "Nome de Usuário";
            // 
            // lbUpdateSenhasTitulo
            // 
            lbUpdateSenhasTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasTitulo.AutoSize = true;
            lbUpdateSenhasTitulo.Font = new Font("Arial", 24F);
            lbUpdateSenhasTitulo.Location = new Point(70, 47);
            lbUpdateSenhasTitulo.Name = "lbUpdateSenhasTitulo";
            lbUpdateSenhasTitulo.Size = new Size(230, 36);
            lbUpdateSenhasTitulo.TabIndex = 12;
            lbUpdateSenhasTitulo.Text = "Atualizar Conta";
            // 
            // campUpdateSenhasId
            // 
            campUpdateSenhasId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            campUpdateSenhasId.BackColor = Color.FromArgb(255, 252, 237);
            campUpdateSenhasId.BorderStyle = BorderStyle.None;
            campUpdateSenhasId.Font = new Font("Arial", 12.75F);
            campUpdateSenhasId.ForeColor = Color.FromArgb(230, 34, 34);
            campUpdateSenhasId.Location = new Point(163, 128);
            campUpdateSenhasId.Name = "campUpdateSenhasId";
            campUpdateSenhasId.Size = new Size(100, 20);
            campUpdateSenhasId.TabIndex = 25;
            campUpdateSenhasId.KeyPress += campUpdateSenhasId_KeyPress;
            // 
            // lbUpdateSenhasId
            // 
            lbUpdateSenhasId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasId.AutoSize = true;
            lbUpdateSenhasId.Font = new Font("Arial", 12.75F);
            lbUpdateSenhasId.Location = new Point(68, 129);
            lbUpdateSenhasId.Name = "lbUpdateSenhasId";
            lbUpdateSenhasId.Size = new Size(26, 19);
            lbUpdateSenhasId.TabIndex = 24;
            lbUpdateSenhasId.Text = "ID";
            // 
            // lbUpdateSenhasSenhaInvalida
            // 
            lbUpdateSenhasSenhaInvalida.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbUpdateSenhasSenhaInvalida.AutoSize = true;
            lbUpdateSenhasSenhaInvalida.Font = new Font("Arial", 9F);
            lbUpdateSenhasSenhaInvalida.ForeColor = Color.FromArgb(230, 34, 34);
            lbUpdateSenhasSenhaInvalida.Location = new Point(51, 288);
            lbUpdateSenhasSenhaInvalida.Name = "lbUpdateSenhasSenhaInvalida";
            lbUpdateSenhasSenhaInvalida.Size = new Size(91, 15);
            lbUpdateSenhasSenhaInvalida.TabIndex = 28;
            lbUpdateSenhasSenhaInvalida.Text = "Senha inválida!";
            // 
            // btUpdateSenhasMostrar
            // 
            btUpdateSenhasMostrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btUpdateSenhasMostrar.BackColor = Color.FromArgb(230, 34, 34);
            btUpdateSenhasMostrar.FlatAppearance.BorderSize = 0;
            btUpdateSenhasMostrar.FlatStyle = FlatStyle.Flat;
            btUpdateSenhasMostrar.Image = (Image)resources.GetObject("btUpdateSenhasMostrar.Image");
            btUpdateSenhasMostrar.Location = new Point(277, 244);
            btUpdateSenhasMostrar.Name = "btUpdateSenhasMostrar";
            btUpdateSenhasMostrar.Size = new Size(40, 40);
            btUpdateSenhasMostrar.TabIndex = 27;
            toolTip2.SetToolTip(btUpdateSenhasMostrar, "Mostrar/Ocultar senha");
            btUpdateSenhasMostrar.UseVisualStyleBackColor = false;
            btUpdateSenhasMostrar.Click += btUpdateSenhasMostrar_Click;
            // 
            // btUpdateSenhasGerar
            // 
            btUpdateSenhasGerar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btUpdateSenhasGerar.BackColor = Color.FromArgb(230, 34, 34);
            btUpdateSenhasGerar.FlatAppearance.BorderSize = 0;
            btUpdateSenhasGerar.FlatStyle = FlatStyle.Flat;
            btUpdateSenhasGerar.Image = (Image)resources.GetObject("btUpdateSenhasGerar.Image");
            btUpdateSenhasGerar.Location = new Point(277, 195);
            btUpdateSenhasGerar.Name = "btUpdateSenhasGerar";
            btUpdateSenhasGerar.Size = new Size(40, 40);
            btUpdateSenhasGerar.TabIndex = 26;
            toolTip1.SetToolTip(btUpdateSenhasGerar, "Gerar senha aleatória com os padrões de segurança");
            btUpdateSenhasGerar.UseVisualStyleBackColor = false;
            btUpdateSenhasGerar.Click += btUpdateSenhasGerar_Click;
            // 
            // UpdateSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 190, 191);
            ClientSize = new Size(367, 450);
            ControlBox = false;
            Controls.Add(lbUpdateSenhasSenhaInvalida);
            Controls.Add(btUpdateSenhasMostrar);
            Controls.Add(btUpdateSenhasGerar);
            Controls.Add(campUpdateSenhasId);
            Controls.Add(lbUpdateSenhasId);
            Controls.Add(btUpdateSenhasCancelar);
            Controls.Add(btUpdateSenhasAtualizar);
            Controls.Add(campUpdateSenhasOrigem);
            Controls.Add(campUpdateSenhasSenha);
            Controls.Add(campUpdateSenhasEmail);
            Controls.Add(campUpdateSenhasNome);
            Controls.Add(lbUpdateSenhasEmailInvalido);
            Controls.Add(lbUpdateSenhasOrigem);
            Controls.Add(lbUpdateSenhasSenha);
            Controls.Add(lbUpdateSenhasEmail);
            Controls.Add(lbUpdateSenhasNome);
            Controls.Add(lbUpdateSenhasTitulo);
            ForeColor = Color.FromArgb(52, 60, 76);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateSenhas";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "UpdateSenhas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btUpdateSenhasCancelar;
        private Button btUpdateSenhasAtualizar;
        private TextBox campUpdateSenhasOrigem;
        private TextBox campUpdateSenhasSenha;
        private TextBox campUpdateSenhasEmail;
        private TextBox campUpdateSenhasNome;
        private Label lbUpdateSenhasEmailInvalido;
        private Label lbUpdateSenhasOrigem;
        private Label lbUpdateSenhasSenha;
        private Label lbUpdateSenhasEmail;
        private Label lbUpdateSenhasNome;
        private Label lbUpdateSenhasTitulo;
        private TextBox campUpdateSenhasId;
        private Label lbUpdateSenhasId;
        private Label lbUpdateSenhasSenhaInvalida;
        private Button btUpdateSenhasMostrar;
        private Button btUpdateSenhasGerar;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}