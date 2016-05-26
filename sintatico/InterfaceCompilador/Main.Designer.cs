namespace InterfaceCompilador
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.localArquivo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusEditor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEquipe = new System.Windows.Forms.Button();
            this.btnGerarCodigo = new System.Windows.Forms.Button();
            this.btnCompilar = new System.Windows.Forms.Button();
            this.btnRecortar = new System.Windows.Forms.Button();
            this.btnColar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.areaMensagem = new System.Windows.Forms.RichTextBox();
            this.areaEditor = new System.Windows.Forms.RichTextBox();
            this.lineNumbers_For_RichTextBox1 = new LineNumbers.LineNumbers_For_RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.localArquivo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.statusEditor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 25);
            this.panel1.TabIndex = 0;
            // 
            // localArquivo
            // 
            this.localArquivo.AutoSize = true;
            this.localArquivo.Location = new System.Drawing.Point(476, 6);
            this.localArquivo.Name = "localArquivo";
            this.localArquivo.Size = new System.Drawing.Size(0, 13);
            this.localArquivo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local do arquivo:";
            // 
            // statusEditor
            // 
            this.statusEditor.AutoSize = true;
            this.statusEditor.Location = new System.Drawing.Point(41, 6);
            this.statusEditor.Name = "statusEditor";
            this.statusEditor.Size = new System.Drawing.Size(0, 13);
            this.statusEditor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEquipe);
            this.panel2.Controls.Add(this.btnGerarCodigo);
            this.panel2.Controls.Add(this.btnCompilar);
            this.panel2.Controls.Add(this.btnRecortar);
            this.panel2.Controls.Add(this.btnColar);
            this.panel2.Controls.Add(this.btnCopiar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnAbrir);
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 612);
            this.panel2.TabIndex = 1;
            // 
            // btnEquipe
            // 
            this.btnEquipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEquipe.Image = global::InterfaceCompilador.Properties.Resources._1457859010_system_users;
            this.btnEquipe.Location = new System.Drawing.Point(0, 544);
            this.btnEquipe.Name = "btnEquipe";
            this.btnEquipe.Size = new System.Drawing.Size(144, 68);
            this.btnEquipe.TabIndex = 26;
            this.btnEquipe.Text = "equipe [F1]";
            this.btnEquipe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEquipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEquipe.UseVisualStyleBackColor = true;
            this.btnEquipe.Click += new System.EventHandler(this.equipe_Click);
            // 
            // btnGerarCodigo
            // 
            this.btnGerarCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGerarCodigo.Image = global::InterfaceCompilador.Properties.Resources._1457857983_emblem_system;
            this.btnGerarCodigo.Location = new System.Drawing.Point(0, 476);
            this.btnGerarCodigo.Name = "btnGerarCodigo";
            this.btnGerarCodigo.Size = new System.Drawing.Size(144, 68);
            this.btnGerarCodigo.TabIndex = 24;
            this.btnGerarCodigo.Text = "gerar código [F9]";
            this.btnGerarCodigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGerarCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGerarCodigo.UseVisualStyleBackColor = true;
            this.btnGerarCodigo.Click += new System.EventHandler(this.gerarCodigo_Click);
            // 
            // btnCompilar
            // 
            this.btnCompilar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCompilar.Image = global::InterfaceCompilador.Properties.Resources.Play_1_Hot_icon;
            this.btnCompilar.Location = new System.Drawing.Point(0, 408);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(144, 68);
            this.btnCompilar.TabIndex = 19;
            this.btnCompilar.Text = "compilar [F8]";
            this.btnCompilar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompilar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.compilar_Click);
            // 
            // btnRecortar
            // 
            this.btnRecortar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecortar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRecortar.Image = global::InterfaceCompilador.Properties.Resources._1457857242_edit_cut;
            this.btnRecortar.Location = new System.Drawing.Point(0, 340);
            this.btnRecortar.Name = "btnRecortar";
            this.btnRecortar.Size = new System.Drawing.Size(144, 68);
            this.btnRecortar.TabIndex = 18;
            this.btnRecortar.Text = "recortar [ctrl+x]";
            this.btnRecortar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecortar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecortar.UseVisualStyleBackColor = true;
            this.btnRecortar.Click += new System.EventHandler(this.recortar_Click);
            // 
            // btnColar
            // 
            this.btnColar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnColar.Image = global::InterfaceCompilador.Properties.Resources._1457857979_edit_paste;
            this.btnColar.Location = new System.Drawing.Point(0, 272);
            this.btnColar.Name = "btnColar";
            this.btnColar.Size = new System.Drawing.Size(144, 68);
            this.btnColar.TabIndex = 17;
            this.btnColar.Text = "colar [ctrl+v]";
            this.btnColar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnColar.UseVisualStyleBackColor = true;
            this.btnColar.Click += new System.EventHandler(this.colar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCopiar.Image = global::InterfaceCompilador.Properties.Resources._1457858900_edit_copy;
            this.btnCopiar.Location = new System.Drawing.Point(0, 204);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(144, 68);
            this.btnCopiar.TabIndex = 12;
            this.btnCopiar.Text = "copiar [ctrl+c]";
            this.btnCopiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.copiar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Image = global::InterfaceCompilador.Properties.Resources._1457857872_media_floppy;
            this.btnSalvar.Location = new System.Drawing.Point(0, 136);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(144, 68);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "salvar [ctrl+s]";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Image = global::InterfaceCompilador.Properties.Resources._1457856941_folder;
            this.btnAbrir.Location = new System.Drawing.Point(0, 68);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(144, 68);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "abrir [ctrl+a]";
            this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::InterfaceCompilador.Properties.Resources._1457857005_document_new;
            this.btnNovo.Location = new System.Drawing.Point(0, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(144, 68);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "novo [ctrl+n]";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.novo_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.areaMensagem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(144, 477);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(767, 135);
            this.panel4.TabIndex = 3;
            // 
            // areaMensagem
            // 
            this.areaMensagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areaMensagem.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaMensagem.Location = new System.Drawing.Point(0, 0);
            this.areaMensagem.Name = "areaMensagem";
            this.areaMensagem.ReadOnly = true;
            this.areaMensagem.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.areaMensagem.Size = new System.Drawing.Size(767, 135);
            this.areaMensagem.TabIndex = 5;
            this.areaMensagem.Text = "";
            this.areaMensagem.WordWrap = false;
            // 
            // areaEditor
            // 
            this.areaEditor.AcceptsTab = true;
            this.areaEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areaEditor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaEditor.Location = new System.Drawing.Point(161, 0);
            this.areaEditor.Name = "areaEditor";
            this.areaEditor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.areaEditor.Size = new System.Drawing.Size(750, 477);
            this.areaEditor.TabIndex = 6;
            this.areaEditor.Text = "";
            this.areaEditor.WordWrap = false;
            this.areaEditor.TextChanged += new System.EventHandler(this.areaEditor_TextChanged);
            // 
            // lineNumbers_For_RichTextBox1
            // 
            this.lineNumbers_For_RichTextBox1._SeeThroughMode_ = false;
            this.lineNumbers_For_RichTextBox1.AutoSizing = true;
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_AlphaColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_BetaColor = System.Drawing.Color.LightSteelBlue;
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lineNumbers_For_RichTextBox1.BorderLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_RichTextBox1.BorderLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lineNumbers_For_RichTextBox1.DockSide = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Left;
            this.lineNumbers_For_RichTextBox1.GridLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_RichTextBox1.GridLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.LineNrs_Alignment = System.Drawing.ContentAlignment.TopRight;
            this.lineNumbers_For_RichTextBox1.LineNrs_AntiAlias = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_AsHexadecimal = false;
            this.lineNumbers_For_RichTextBox1.LineNrs_ClippedByItemRectangle = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_LeadingZeroes = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_Offset = new System.Drawing.Size(0, 0);
            this.lineNumbers_For_RichTextBox1.Location = new System.Drawing.Point(144, 0);
            this.lineNumbers_For_RichTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.lineNumbers_For_RichTextBox1.MarginLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.MarginLines_Side = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Right;
            this.lineNumbers_For_RichTextBox1.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.lineNumbers_For_RichTextBox1.MarginLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.Name = "lineNumbers_For_RichTextBox1";
            this.lineNumbers_For_RichTextBox1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.lineNumbers_For_RichTextBox1.ParentRichTextBox = this.areaEditor;
            this.lineNumbers_For_RichTextBox1.Show_BackgroundGradient = true;
            this.lineNumbers_For_RichTextBox1.Show_BorderLines = true;
            this.lineNumbers_For_RichTextBox1.Show_GridLines = true;
            this.lineNumbers_For_RichTextBox1.Show_LineNrs = true;
            this.lineNumbers_For_RichTextBox1.Show_MarginLines = true;
            this.lineNumbers_For_RichTextBox1.Size = new System.Drawing.Size(17, 477);
            this.lineNumbers_For_RichTextBox1.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 637);
            this.Controls.Add(this.areaEditor);
            this.Controls.Add(this.lineNumbers_For_RichTextBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Compilador";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGerarCodigo;
        private System.Windows.Forms.Button btnRecortar;
        private System.Windows.Forms.Button btnColar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnEquipe;
        private System.Windows.Forms.Button btnCompilar;
        private System.Windows.Forms.Label statusEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label localArquivo;
        private System.Windows.Forms.Label label2;
        private LineNumbers.LineNumbers_For_RichTextBox lineNumbers_For_RichTextBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox areaMensagem;
        private System.Windows.Forms.RichTextBox areaEditor;

    }
}

