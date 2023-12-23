namespace IntegracionForm
{
    partial class altaCobranza
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
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            listBox2 = new ListBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(538, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(58, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 24);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Afiliado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(538, 25);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha de Cobro";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(57, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 181);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metodo de Pago";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(330, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(129, 127);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(129, 87);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(129, 42);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 131);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 2;
            label5.Text = "Transferencia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 87);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 1;
            label4.Text = "Tarjeta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 41);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 0;
            label3.Text = "Efectivo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 317);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Venta";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(88, 335);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(88, 375);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(330, 49);
            listBox2.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(489, 457);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(592, 457);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 9;
            button5.Text = "Aceptar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(268, 334);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 10;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            // 
            // altaCobranza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(listBox2);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Name = "altaCobranza";
            Text = "Alta Cobranza";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private ListBox listBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
        private ListBox listBox2;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}