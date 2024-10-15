namespace ProjetoCadastroBD
{
    partial class FormCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurso));
            TabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            ComboPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            ComboNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            ButtonSalvar = new ReaLTaiizor.Controls.MaterialButton();
            ButtonCancelar = new ReaLTaiizor.Controls.MaterialButton();
            TextDuracao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ComboArea = new ReaLTaiizor.Controls.MaterialComboBox();
            TextCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            BtnEditar = new ReaLTaiizor.Controls.MaterialButton();
            BtnNovo = new ReaLTaiizor.Controls.MaterialButton();
            BtnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            materialListView1 = new ReaLTaiizor.Controls.MaterialListView();
            imageList1 = new ImageList(components);
            TabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Controls.Add(tabPageCadastro);
            TabControlCadastro.Controls.Add(tabPageConsulta);
            TabControlCadastro.Depth = 0;
            TabControlCadastro.Dock = DockStyle.Fill;
            TabControlCadastro.ImageList = imageList1;
            TabControlCadastro.Location = new Point(3, 64);
            TabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastro.Multiline = true;
            TabControlCadastro.Name = "TabControlCadastro";
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Size = new Size(694, 320);
            TabControlCadastro.TabIndex = 0;
            TabControlCadastro.SelectedIndexChanged += TabControlCadastro_SelectedIndexChanged;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(ComboPeriodo);
            tabPageCadastro.Controls.Add(ComboNivel);
            tabPageCadastro.Controls.Add(ButtonSalvar);
            tabPageCadastro.Controls.Add(ButtonCancelar);
            tabPageCadastro.Controls.Add(TextDuracao);
            tabPageCadastro.Controls.Add(TextNome);
            tabPageCadastro.Controls.Add(ComboArea);
            tabPageCadastro.Controls.Add(TextCodigo);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(686, 285);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // ComboPeriodo
            // 
            ComboPeriodo.AutoResize = false;
            ComboPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            ComboPeriodo.Depth = 0;
            ComboPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            ComboPeriodo.DropDownHeight = 174;
            ComboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboPeriodo.DropDownWidth = 121;
            ComboPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboPeriodo.FormattingEnabled = true;
            ComboPeriodo.Hint = "Perído";
            ComboPeriodo.IntegralHeight = false;
            ComboPeriodo.ItemHeight = 43;
            ComboPeriodo.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno", "Integral" });
            ComboPeriodo.Location = new Point(5, 167);
            ComboPeriodo.MaxDropDownItems = 4;
            ComboPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboPeriodo.Name = "ComboPeriodo";
            ComboPeriodo.Size = new Size(332, 49);
            ComboPeriodo.StartIndex = 0;
            ComboPeriodo.TabIndex = 19;
            // 
            // ComboNivel
            // 
            ComboNivel.AutoResize = false;
            ComboNivel.BackColor = Color.FromArgb(255, 255, 255);
            ComboNivel.Depth = 0;
            ComboNivel.DrawMode = DrawMode.OwnerDrawVariable;
            ComboNivel.DropDownHeight = 174;
            ComboNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboNivel.DropDownWidth = 121;
            ComboNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboNivel.FormattingEnabled = true;
            ComboNivel.Hint = "Nível";
            ComboNivel.IntegralHeight = false;
            ComboNivel.ItemHeight = 43;
            ComboNivel.Items.AddRange(new object[] { "Superior", "Técnico" });
            ComboNivel.Location = new Point(5, 112);
            ComboNivel.MaxDropDownItems = 4;
            ComboNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboNivel.Name = "ComboNivel";
            ComboNivel.Size = new Size(472, 49);
            ComboNivel.StartIndex = -1;
            ComboNivel.TabIndex = 18;
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.AutoSize = false;
            ButtonSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSalvar.Depth = 0;
            ButtonSalvar.HighEmphasis = true;
            ButtonSalvar.Icon = null;
            ButtonSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonSalvar.Location = new Point(571, 225);
            ButtonSalvar.Margin = new Padding(4, 6, 4, 6);
            ButtonSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.NoAccentTextColor = Color.Empty;
            ButtonSalvar.Size = new Size(106, 48);
            ButtonSalvar.TabIndex = 12;
            ButtonSalvar.Text = "Salvar";
            ButtonSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSalvar.UseAccentColor = false;
            ButtonSalvar.UseVisualStyleBackColor = true;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.AutoSize = false;
            ButtonCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonCancelar.Depth = 0;
            ButtonCancelar.HighEmphasis = true;
            ButtonCancelar.Icon = null;
            ButtonCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonCancelar.Location = new Point(456, 225);
            ButtonCancelar.Margin = new Padding(4, 6, 4, 6);
            ButtonCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.NoAccentTextColor = Color.Empty;
            ButtonCancelar.Size = new Size(111, 48);
            ButtonCancelar.TabIndex = 17;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonCancelar.UseAccentColor = false;
            ButtonCancelar.UseVisualStyleBackColor = true;
            // 
            // TextDuracao
            // 
            TextDuracao.AnimateReadOnly = false;
            TextDuracao.AutoCompleteMode = AutoCompleteMode.None;
            TextDuracao.AutoCompleteSource = AutoCompleteSource.None;
            TextDuracao.BackgroundImageLayout = ImageLayout.None;
            TextDuracao.CharacterCasing = CharacterCasing.Normal;
            TextDuracao.Depth = 0;
            TextDuracao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextDuracao.HideSelection = true;
            TextDuracao.Hint = "Duração em semestres";
            TextDuracao.LeadingIcon = null;
            TextDuracao.Location = new Point(483, 113);
            TextDuracao.MaxLength = 32767;
            TextDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextDuracao.Name = "TextDuracao";
            TextDuracao.PasswordChar = '\0';
            TextDuracao.PrefixSuffixText = null;
            TextDuracao.ReadOnly = false;
            TextDuracao.RightToLeft = RightToLeft.No;
            TextDuracao.SelectedText = "";
            TextDuracao.SelectionLength = 0;
            TextDuracao.SelectionStart = 0;
            TextDuracao.ShortcutsEnabled = true;
            TextDuracao.Size = new Size(194, 48);
            TextDuracao.TabIndex = 15;
            TextDuracao.TabStop = false;
            TextDuracao.TextAlign = HorizontalAlignment.Left;
            TextDuracao.TrailingIcon = null;
            TextDuracao.UseSystemPasswordChar = false;
            // 
            // TextNome
            // 
            TextNome.AnimateReadOnly = false;
            TextNome.AutoCompleteMode = AutoCompleteMode.None;
            TextNome.AutoCompleteSource = AutoCompleteSource.None;
            TextNome.BackgroundImageLayout = ImageLayout.None;
            TextNome.CharacterCasing = CharacterCasing.Normal;
            TextNome.Depth = 0;
            TextNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextNome.HideSelection = true;
            TextNome.Hint = "Nome";
            TextNome.LeadingIcon = null;
            TextNome.Location = new Point(5, 59);
            TextNome.MaxLength = 32767;
            TextNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextNome.Name = "TextNome";
            TextNome.PasswordChar = '\0';
            TextNome.PrefixSuffixText = null;
            TextNome.ReadOnly = false;
            TextNome.RightToLeft = RightToLeft.No;
            TextNome.SelectedText = "";
            TextNome.SelectionLength = 0;
            TextNome.SelectionStart = 0;
            TextNome.ShortcutsEnabled = true;
            TextNome.Size = new Size(672, 48);
            TextNome.TabIndex = 14;
            TextNome.TabStop = false;
            TextNome.TextAlign = HorizontalAlignment.Left;
            TextNome.TrailingIcon = null;
            TextNome.UseSystemPasswordChar = false;
            // 
            // ComboArea
            // 
            ComboArea.AutoResize = false;
            ComboArea.BackColor = Color.FromArgb(255, 255, 255);
            ComboArea.Depth = 0;
            ComboArea.DrawMode = DrawMode.OwnerDrawVariable;
            ComboArea.DropDownHeight = 174;
            ComboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboArea.DropDownWidth = 121;
            ComboArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboArea.FormattingEnabled = true;
            ComboArea.Hint = "Área";
            ComboArea.IntegralHeight = false;
            ComboArea.ItemHeight = 43;
            ComboArea.Items.AddRange(new object[] { "Licenciatura", "Informática", "Industria", "Administração" });
            ComboArea.Location = new Point(343, 167);
            ComboArea.MaxDropDownItems = 4;
            ComboArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboArea.Name = "ComboArea";
            ComboArea.Size = new Size(334, 49);
            ComboArea.StartIndex = 0;
            ComboArea.TabIndex = 16;
            // 
            // TextCodigo
            // 
            TextCodigo.AnimateReadOnly = false;
            TextCodigo.AutoCompleteMode = AutoCompleteMode.None;
            TextCodigo.AutoCompleteSource = AutoCompleteSource.None;
            TextCodigo.BackgroundImageLayout = ImageLayout.None;
            TextCodigo.CharacterCasing = CharacterCasing.Normal;
            TextCodigo.Depth = 0;
            TextCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextCodigo.HideSelection = true;
            TextCodigo.Hint = "Código do curso";
            TextCodigo.LeadingIcon = null;
            TextCodigo.Location = new Point(5, 5);
            TextCodigo.MaxLength = 32767;
            TextCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCodigo.Name = "TextCodigo";
            TextCodigo.PasswordChar = '\0';
            TextCodigo.PrefixSuffixText = null;
            TextCodigo.ReadOnly = false;
            TextCodigo.RightToLeft = RightToLeft.No;
            TextCodigo.SelectedText = "";
            TextCodigo.SelectionLength = 0;
            TextCodigo.SelectionStart = 0;
            TextCodigo.ShortcutsEnabled = true;
            TextCodigo.Size = new Size(672, 48);
            TextCodigo.TabIndex = 13;
            TextCodigo.TabStop = false;
            TextCodigo.TextAlign = HorizontalAlignment.Left;
            TextCodigo.TrailingIcon = null;
            TextCodigo.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(BtnEditar);
            tabPageConsulta.Controls.Add(BtnNovo);
            tabPageConsulta.Controls.Add(BtnExcluir);
            tabPageConsulta.Controls.Add(materialListView1);
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(686, 285);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEditar.Depth = 0;
            BtnEditar.HighEmphasis = true;
            BtnEditar.Icon = null;
            BtnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BtnEditar.Location = new Point(608, 245);
            BtnEditar.Margin = new Padding(4, 6, 4, 6);
            BtnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.NoAccentTextColor = Color.Empty;
            BtnEditar.Size = new Size(71, 36);
            BtnEditar.TabIndex = 3;
            BtnEditar.Text = "Editar";
            BtnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnEditar.UseAccentColor = false;
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            BtnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnNovo.Depth = 0;
            BtnNovo.HighEmphasis = true;
            BtnNovo.Icon = null;
            BtnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BtnNovo.Location = new Point(536, 245);
            BtnNovo.Margin = new Padding(4, 6, 4, 6);
            BtnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BtnNovo.Name = "BtnNovo";
            BtnNovo.NoAccentTextColor = Color.Empty;
            BtnNovo.Size = new Size(64, 36);
            BtnNovo.TabIndex = 2;
            BtnNovo.Text = "Novo";
            BtnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnNovo.UseAccentColor = false;
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnExcluir.Depth = 0;
            BtnExcluir.HighEmphasis = true;
            BtnExcluir.Icon = null;
            BtnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BtnExcluir.Location = new Point(448, 245);
            BtnExcluir.Margin = new Padding(4, 6, 4, 6);
            BtnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.NoAccentTextColor = Color.Empty;
            BtnExcluir.Size = new Size(80, 36);
            BtnExcluir.TabIndex = 1;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnExcluir.UseAccentColor = false;
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(3, 6);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(676, 227);
            materialListView1.TabIndex = 0;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 387);
            Controls.Add(TabControlCadastro);
            DrawerTabControl = TabControlCadastro;
            Name = "FormCurso";
            Text = "FormCurso";
            TabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastro;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ReaLTaiizor.Controls.MaterialListView materialListView1;
        private ReaLTaiizor.Controls.MaterialComboBox ComboPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox ComboNivel;
        private ReaLTaiizor.Controls.MaterialButton ButtonSalvar;
        private ReaLTaiizor.Controls.MaterialButton ButtonCancelar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextDuracao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextNome;
        private ReaLTaiizor.Controls.MaterialComboBox ComboArea;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCodigo;
        private ReaLTaiizor.Controls.MaterialButton BtnEditar;
        private ReaLTaiizor.Controls.MaterialButton BtnNovo;
        private ReaLTaiizor.Controls.MaterialButton BtnExcluir;
        private ImageList imageList1;
    }
}