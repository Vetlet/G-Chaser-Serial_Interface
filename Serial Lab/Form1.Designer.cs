namespace Seriallab
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.connect = new System.Windows.Forms.Button();
            this.portConfig = new System.Windows.Forms.ComboBox();
            this.baudrateConfig = new System.Windows.Forms.ComboBox();
            this.mySerial = new System.IO.Ports.SerialPort(this.components);
            this.serial_options_group = new System.Windows.Forms.GroupBox();
            this.baudrate_label = new System.Windows.Forms.Label();
            this.port_label = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.byte_counter_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graph_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datalogger_options_panel = new System.Windows.Forms.Panel();
            this.datalogger_overwrite_radiobutton = new System.Windows.Forms.RadioButton();
            this.datalogger_append_radiobutton = new System.Windows.Forms.RadioButton();
            this.datalogger_checkbox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.alert_messege = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rx_textarea = new System.Windows.Forms.RichTextBox();
            this.read_options_group = new System.Windows.Forms.GroupBox();
            this.dsiplayas_options_panel = new System.Windows.Forms.Panel();
            this.display_hex_radiobutton = new System.Windows.Forms.RadioButton();
            this.display_string_radiobutton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.serial_options_group.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.graph_menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.datalogger_options_panel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.read_options_group.SuspendLayout();
            this.dsiplayas_options_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(412, 113);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(176, 40);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // portConfig
            // 
            this.portConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portConfig.FormattingEnabled = true;
            this.portConfig.Location = new System.Drawing.Point(89, 34);
            this.portConfig.Name = "portConfig";
            this.portConfig.Size = new System.Drawing.Size(76, 21);
            this.portConfig.TabIndex = 1;
            this.portConfig.SelectedIndexChanged += new System.EventHandler(this.portConfig_SelectedIndexChanged);
            this.portConfig.Click += new System.EventHandler(this.portConfig_Click);
            // 
            // baudrateConfig
            // 
            this.baudrateConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudrateConfig.FormattingEnabled = true;
            this.baudrateConfig.Location = new System.Drawing.Point(89, 63);
            this.baudrateConfig.Name = "baudrateConfig";
            this.baudrateConfig.Size = new System.Drawing.Size(75, 21);
            this.baudrateConfig.TabIndex = 2;
            // 
            // serial_options_group
            // 
            this.serial_options_group.Controls.Add(this.baudrate_label);
            this.serial_options_group.Controls.Add(this.port_label);
            this.serial_options_group.Controls.Add(this.portConfig);
            this.serial_options_group.Controls.Add(this.baudrateConfig);
            this.serial_options_group.Location = new System.Drawing.Point(14, 20);
            this.serial_options_group.Name = "serial_options_group";
            this.serial_options_group.Size = new System.Drawing.Size(385, 133);
            this.serial_options_group.TabIndex = 9;
            this.serial_options_group.TabStop = false;
            this.serial_options_group.Text = "Serial port options";
            // 
            // baudrate_label
            // 
            this.baudrate_label.AutoSize = true;
            this.baudrate_label.Location = new System.Drawing.Point(26, 66);
            this.baudrate_label.Name = "baudrate_label";
            this.baudrate_label.Size = new System.Drawing.Size(50, 13);
            this.baudrate_label.TabIndex = 8;
            this.baudrate_label.Text = "Baudrate";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(28, 37);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(26, 13);
            this.port_label.TabIndex = 7;
            this.port_label.Text = "Port";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byte_counter_label,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.MinimumSize = new System.Drawing.Size(569, 25);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(606, 25);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // byte_counter_label
            // 
            this.byte_counter_label.Name = "byte_counter_label";
            this.byte_counter_label.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(6, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 20);
            this.toolStripStatusLabel1.Text = "No Connection";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(40, 20);
            this.toolStripStatusLabel2.Text = "About";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clear_rx_textarea_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(102, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.toolStripMenuItem1.Text = "Clear";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // graph_menu
            // 
            this.graph_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsImageToolStripMenuItem,
            this.clearToolStripMenuItem1});
            this.graph_menu.Name = "clear_graph";
            this.graph_menu.Size = new System.Drawing.Size(149, 48);
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveAsImageToolStripMenuItem.Text = "Save as image";
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datalogger_options_panel);
            this.groupBox1.Location = new System.Drawing.Point(412, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 87);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data logger";
            // 
            // datalogger_options_panel
            // 
            this.datalogger_options_panel.Controls.Add(this.datalogger_overwrite_radiobutton);
            this.datalogger_options_panel.Controls.Add(this.datalogger_append_radiobutton);
            this.datalogger_options_panel.Controls.Add(this.datalogger_checkbox);
            this.datalogger_options_panel.Location = new System.Drawing.Point(9, 25);
            this.datalogger_options_panel.Name = "datalogger_options_panel";
            this.datalogger_options_panel.Size = new System.Drawing.Size(154, 54);
            this.datalogger_options_panel.TabIndex = 28;
            // 
            // datalogger_overwrite_radiobutton
            // 
            this.datalogger_overwrite_radiobutton.AutoSize = true;
            this.datalogger_overwrite_radiobutton.Enabled = false;
            this.datalogger_overwrite_radiobutton.Location = new System.Drawing.Point(74, 30);
            this.datalogger_overwrite_radiobutton.Name = "datalogger_overwrite_radiobutton";
            this.datalogger_overwrite_radiobutton.Size = new System.Drawing.Size(70, 17);
            this.datalogger_overwrite_radiobutton.TabIndex = 29;
            this.datalogger_overwrite_radiobutton.Text = "Overwrite";
            this.datalogger_overwrite_radiobutton.UseVisualStyleBackColor = true;
            // 
            // datalogger_append_radiobutton
            // 
            this.datalogger_append_radiobutton.AutoSize = true;
            this.datalogger_append_radiobutton.Checked = true;
            this.datalogger_append_radiobutton.Enabled = false;
            this.datalogger_append_radiobutton.Location = new System.Drawing.Point(6, 30);
            this.datalogger_append_radiobutton.Name = "datalogger_append_radiobutton";
            this.datalogger_append_radiobutton.Size = new System.Drawing.Size(62, 17);
            this.datalogger_append_radiobutton.TabIndex = 28;
            this.datalogger_append_radiobutton.TabStop = true;
            this.datalogger_append_radiobutton.Text = "Append";
            this.datalogger_append_radiobutton.UseVisualStyleBackColor = true;
            // 
            // datalogger_checkbox
            // 
            this.datalogger_checkbox.AutoSize = true;
            this.datalogger_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.datalogger_checkbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.datalogger_checkbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.datalogger_checkbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalogger_checkbox.Location = new System.Drawing.Point(6, 3);
            this.datalogger_checkbox.MaximumSize = new System.Drawing.Size(400, 19);
            this.datalogger_checkbox.Name = "datalogger_checkbox";
            this.datalogger_checkbox.Size = new System.Drawing.Size(125, 19);
            this.datalogger_checkbox.TabIndex = 15;
            this.datalogger_checkbox.Text = "Enable Data logger";
            this.datalogger_checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.datalogger_checkbox.UseVisualStyleBackColor = false;
            this.datalogger_checkbox.CheckedChanged += new System.EventHandler(this.datalogger_checkbox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "log_file";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.FileName = "figure";
            this.saveFileDialog1.Filter = "PNG|.png| JPEG|.jpg";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // alert_messege
            // 
            this.alert_messege.Text = "notifyIcon1";
            this.alert_messege.Visible = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.rx_textarea);
            this.tabPage1.Controls.Add(this.read_options_group);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(572, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read";
            // 
            // rx_textarea
            // 
            this.rx_textarea.BackColor = System.Drawing.Color.White;
            this.rx_textarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rx_textarea.ContextMenuStrip = this.contextMenuStrip1;
            this.rx_textarea.DetectUrls = false;
            this.rx_textarea.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rx_textarea.HideSelection = false;
            this.rx_textarea.Location = new System.Drawing.Point(18, 76);
            this.rx_textarea.Name = "rx_textarea";
            this.rx_textarea.ReadOnly = true;
            this.rx_textarea.Size = new System.Drawing.Size(533, 305);
            this.rx_textarea.TabIndex = 29;
            this.rx_textarea.Text = "";
            // 
            // read_options_group
            // 
            this.read_options_group.Controls.Add(this.dsiplayas_options_panel);
            this.read_options_group.Controls.Add(this.label4);
            this.read_options_group.Location = new System.Drawing.Point(18, 16);
            this.read_options_group.Name = "read_options_group";
            this.read_options_group.Size = new System.Drawing.Size(533, 54);
            this.read_options_group.TabIndex = 26;
            this.read_options_group.TabStop = false;
            this.read_options_group.Text = "Read Options";
            // 
            // dsiplayas_options_panel
            // 
            this.dsiplayas_options_panel.Controls.Add(this.display_hex_radiobutton);
            this.dsiplayas_options_panel.Controls.Add(this.display_string_radiobutton);
            this.dsiplayas_options_panel.Location = new System.Drawing.Point(83, 18);
            this.dsiplayas_options_panel.Name = "dsiplayas_options_panel";
            this.dsiplayas_options_panel.Size = new System.Drawing.Size(230, 25);
            this.dsiplayas_options_panel.TabIndex = 18;
            // 
            // display_hex_radiobutton
            // 
            this.display_hex_radiobutton.AutoSize = true;
            this.display_hex_radiobutton.Location = new System.Drawing.Point(63, 5);
            this.display_hex_radiobutton.Name = "display_hex_radiobutton";
            this.display_hex_radiobutton.Size = new System.Drawing.Size(47, 17);
            this.display_hex_radiobutton.TabIndex = 26;
            this.display_hex_radiobutton.Text = "HEX";
            this.display_hex_radiobutton.UseVisualStyleBackColor = true;
            // 
            // display_string_radiobutton
            // 
            this.display_string_radiobutton.AutoSize = true;
            this.display_string_radiobutton.Checked = true;
            this.display_string_radiobutton.Location = new System.Drawing.Point(3, 5);
            this.display_string_radiobutton.Name = "display_string_radiobutton";
            this.display_string_radiobutton.Size = new System.Drawing.Size(52, 17);
            this.display_string_radiobutton.TabIndex = 25;
            this.display_string_radiobutton.TabStop = true;
            this.display_string_radiobutton.Text = "String";
            this.display_string_radiobutton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Display as:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(14, 169);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 413);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(606, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.serial_options_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G-Chaser Serial Interface";
            this.serial_options_group.ResumeLayout(false);
            this.serial_options_group.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.graph_menu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.datalogger_options_panel.ResumeLayout(false);
            this.datalogger_options_panel.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.read_options_group.ResumeLayout(false);
            this.read_options_group.PerformLayout();
            this.dsiplayas_options_panel.ResumeLayout(false);
            this.dsiplayas_options_panel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ComboBox portConfig;
        private System.Windows.Forms.ComboBox baudrateConfig;
        private System.IO.Ports.SerialPort mySerial;
        private System.Windows.Forms.GroupBox serial_options_group;
        private System.Windows.Forms.Label baudrate_label;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip graph_menu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel datalogger_options_panel;
        private System.Windows.Forms.NotifyIcon alert_messege;
        private System.Windows.Forms.RadioButton datalogger_overwrite_radiobutton;
        private System.Windows.Forms.RadioButton datalogger_append_radiobutton;
        private System.Windows.Forms.CheckBox datalogger_checkbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel byte_counter_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rx_textarea;
        private System.Windows.Forms.GroupBox read_options_group;
        private System.Windows.Forms.Panel dsiplayas_options_panel;
        private System.Windows.Forms.RadioButton display_hex_radiobutton;
        private System.Windows.Forms.RadioButton display_string_radiobutton;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TabControl tabControl1;
    }
}

