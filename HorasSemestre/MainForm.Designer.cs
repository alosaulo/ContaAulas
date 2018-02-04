namespace HorasSemestre
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.tabHoras = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAulasMes = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblMon = new System.Windows.Forms.Label();
            this.lblTue = new System.Windows.Forms.Label();
            this.lblWed = new System.Windows.Forms.Label();
            this.lblThu = new System.Windows.Forms.Label();
            this.lblFri = new System.Windows.Forms.Label();
            this.nmSeg = new System.Windows.Forms.NumericUpDown();
            this.nmTer = new System.Windows.Forms.NumericUpDown();
            this.nmQua = new System.Windows.Forms.NumericUpDown();
            this.nmQui = new System.Windows.Forms.NumericUpDown();
            this.nmSex = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.tabFeriados = new System.Windows.Forms.TabPage();
            this.btnRemoverFerias = new System.Windows.Forms.Button();
            this.listFeriados = new System.Windows.Forms.ListBox();
            this.btnAddicionarFerias = new System.Windows.Forms.Button();
            this.calendarioFerias = new System.Windows.Forms.MonthCalendar();
            this.MainTabs.SuspendLayout();
            this.tabHoras.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tblPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSex)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabFeriados.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MainTabs.Controls.Add(this.tabHoras);
            this.MainTabs.Controls.Add(this.tabFeriados);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(475, 378);
            this.MainTabs.TabIndex = 0;
            // 
            // tabHoras
            // 
            this.tabHoras.Controls.Add(this.panel2);
            this.tabHoras.Controls.Add(this.groupBox1);
            this.tabHoras.Controls.Add(this.panel1);
            this.tabHoras.Location = new System.Drawing.Point(4, 25);
            this.tabHoras.Name = "tabHoras";
            this.tabHoras.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoras.Size = new System.Drawing.Size(467, 349);
            this.tabHoras.TabIndex = 1;
            this.tabHoras.Text = "Horas";
            this.tabHoras.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtAulasMes);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtOutput);
            this.panel2.Location = new System.Drawing.Point(6, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 147);
            this.panel2.TabIndex = 7;
            // 
            // txtAulasMes
            // 
            this.txtAulasMes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAulasMes.Location = new System.Drawing.Point(228, 21);
            this.txtAulasMes.Name = "txtAulasMes";
            this.txtAulasMes.Size = new System.Drawing.Size(219, 123);
            this.txtAulasMes.TabIndex = 7;
            this.txtAulasMes.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aulas por mês";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dias das aulas";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(7, 21);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(219, 123);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.tblPanel);
            this.groupBox1.Location = new System.Drawing.Point(238, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 181);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horas da disciplina";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(140, 148);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tblPanel
            // 
            this.tblPanel.ColumnCount = 2;
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.Controls.Add(this.lblMon, 0, 0);
            this.tblPanel.Controls.Add(this.lblTue, 0, 1);
            this.tblPanel.Controls.Add(this.lblWed, 0, 2);
            this.tblPanel.Controls.Add(this.lblThu, 0, 3);
            this.tblPanel.Controls.Add(this.lblFri, 0, 4);
            this.tblPanel.Controls.Add(this.nmSeg, 1, 0);
            this.tblPanel.Controls.Add(this.nmTer, 1, 1);
            this.tblPanel.Controls.Add(this.nmQua, 1, 2);
            this.tblPanel.Controls.Add(this.nmQui, 1, 3);
            this.tblPanel.Controls.Add(this.nmSex, 1, 4);
            this.tblPanel.Location = new System.Drawing.Point(6, 19);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.RowCount = 5;
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblPanel.Size = new System.Drawing.Size(209, 122);
            this.tblPanel.TabIndex = 5;
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Location = new System.Drawing.Point(3, 0);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(76, 13);
            this.lblMon.TabIndex = 0;
            this.lblMon.Text = "Segunda Feira";
            // 
            // lblTue
            // 
            this.lblTue.AutoSize = true;
            this.lblTue.Location = new System.Drawing.Point(3, 25);
            this.lblTue.Name = "lblTue";
            this.lblTue.Size = new System.Drawing.Size(61, 13);
            this.lblTue.TabIndex = 1;
            this.lblTue.Text = "Terça Feira";
            // 
            // lblWed
            // 
            this.lblWed.AutoSize = true;
            this.lblWed.Location = new System.Drawing.Point(3, 50);
            this.lblWed.Name = "lblWed";
            this.lblWed.Size = new System.Drawing.Size(65, 13);
            this.lblWed.TabIndex = 2;
            this.lblWed.Text = "Quarta Feira";
            // 
            // lblThu
            // 
            this.lblThu.AutoSize = true;
            this.lblThu.Location = new System.Drawing.Point(3, 75);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(64, 13);
            this.lblThu.TabIndex = 2;
            this.lblThu.Text = "Quinta Feira";
            // 
            // lblFri
            // 
            this.lblFri.AutoSize = true;
            this.lblFri.Location = new System.Drawing.Point(3, 100);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(60, 13);
            this.lblFri.TabIndex = 3;
            this.lblFri.Text = "Sexta Feira";
            // 
            // nmSeg
            // 
            this.nmSeg.Location = new System.Drawing.Point(107, 3);
            this.nmSeg.Name = "nmSeg";
            this.nmSeg.Size = new System.Drawing.Size(99, 20);
            this.nmSeg.TabIndex = 4;
            // 
            // nmTer
            // 
            this.nmTer.Location = new System.Drawing.Point(107, 28);
            this.nmTer.Name = "nmTer";
            this.nmTer.Size = new System.Drawing.Size(99, 20);
            this.nmTer.TabIndex = 5;
            // 
            // nmQua
            // 
            this.nmQua.Location = new System.Drawing.Point(107, 53);
            this.nmQua.Name = "nmQua";
            this.nmQua.Size = new System.Drawing.Size(99, 20);
            this.nmQua.TabIndex = 6;
            // 
            // nmQui
            // 
            this.nmQui.Location = new System.Drawing.Point(107, 78);
            this.nmQui.Name = "nmQui";
            this.nmQui.Size = new System.Drawing.Size(99, 20);
            this.nmQui.TabIndex = 7;
            // 
            // nmSex
            // 
            this.nmSex.Location = new System.Drawing.Point(107, 103);
            this.nmSex.Name = "nmSex";
            this.nmSex.Size = new System.Drawing.Size(99, 20);
            this.nmSex.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimeEnd);
            this.panel1.Controls.Add(this.dateTimeStart);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 182);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final do Semestre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Início do Semestre";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(3, 81);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(220, 20);
            this.dateTimeEnd.TabIndex = 1;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(3, 29);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(220, 20);
            this.dateTimeStart.TabIndex = 0;
            // 
            // tabFeriados
            // 
            this.tabFeriados.Controls.Add(this.btnRemoverFerias);
            this.tabFeriados.Controls.Add(this.listFeriados);
            this.tabFeriados.Controls.Add(this.btnAddicionarFerias);
            this.tabFeriados.Controls.Add(this.calendarioFerias);
            this.tabFeriados.Location = new System.Drawing.Point(4, 25);
            this.tabFeriados.Name = "tabFeriados";
            this.tabFeriados.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeriados.Size = new System.Drawing.Size(467, 349);
            this.tabFeriados.TabIndex = 2;
            this.tabFeriados.Text = "Feriados";
            this.tabFeriados.UseVisualStyleBackColor = true;
            // 
            // btnRemoverFerias
            // 
            this.btnRemoverFerias.Location = new System.Drawing.Point(320, 183);
            this.btnRemoverFerias.Name = "btnRemoverFerias";
            this.btnRemoverFerias.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverFerias.TabIndex = 3;
            this.btnRemoverFerias.Text = "Remover";
            this.btnRemoverFerias.UseVisualStyleBackColor = true;
            this.btnRemoverFerias.Click += new System.EventHandler(this.btnRemoverFerias_Click);
            // 
            // listFeriados
            // 
            this.listFeriados.FormattingEnabled = true;
            this.listFeriados.Location = new System.Drawing.Point(248, 9);
            this.listFeriados.Name = "listFeriados";
            this.listFeriados.Size = new System.Drawing.Size(211, 160);
            this.listFeriados.TabIndex = 2;
            // 
            // btnAddicionarFerias
            // 
            this.btnAddicionarFerias.Location = new System.Drawing.Point(83, 183);
            this.btnAddicionarFerias.Name = "btnAddicionarFerias";
            this.btnAddicionarFerias.Size = new System.Drawing.Size(75, 23);
            this.btnAddicionarFerias.TabIndex = 1;
            this.btnAddicionarFerias.Text = "Adicionar";
            this.btnAddicionarFerias.UseVisualStyleBackColor = true;
            this.btnAddicionarFerias.Click += new System.EventHandler(this.btnAddicionarFerias_Click);
            // 
            // calendarioFerias
            // 
            this.calendarioFerias.Location = new System.Drawing.Point(9, 9);
            this.calendarioFerias.Name = "calendarioFerias";
            this.calendarioFerias.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 378);
            this.Controls.Add(this.MainTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Contagem de horas por semestre";
            this.MainTabs.ResumeLayout(false);
            this.tabHoras.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tblPanel.ResumeLayout(false);
            this.tblPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSex)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFeriados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage tabHoras;
        private System.Windows.Forms.TabPage tabFeriados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tblPanel;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label lblTue;
        private System.Windows.Forms.Label lblWed;
        private System.Windows.Forms.Label lblThu;
        private System.Windows.Forms.Label lblFri;
        private System.Windows.Forms.NumericUpDown nmSeg;
        private System.Windows.Forms.NumericUpDown nmTer;
        private System.Windows.Forms.NumericUpDown nmQua;
        private System.Windows.Forms.NumericUpDown nmQui;
        private System.Windows.Forms.NumericUpDown nmSex;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRemoverFerias;
        private System.Windows.Forms.ListBox listFeriados;
        private System.Windows.Forms.Button btnAddicionarFerias;
        private System.Windows.Forms.MonthCalendar calendarioFerias;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtAulasMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

