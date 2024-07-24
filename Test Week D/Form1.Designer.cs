namespace Test_Week_D
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Day_cmb = new ComboBox();
            Month_cmb = new ComboBox();
            DatAtMonth_cmb = new ComboBox();
            Year_cmb = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(947, 142);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "יום בשבוע";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(712, 142);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "היום בחודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(486, 142);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 142);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 3;
            label4.Text = "שנה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(577, 52);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "כתיבת תאריך";
            label5.Click += label5_Click;
            // 
            // Day_cmb
            // 
            Day_cmb.FormattingEnabled = true;
            Day_cmb.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי" });
            Day_cmb.Location = new Point(893, 209);
            Day_cmb.Name = "Day_cmb";
            Day_cmb.Size = new Size(151, 28);
            Day_cmb.TabIndex = 5;
            // 
            // Month_cmb
            // 
            Month_cmb.FormattingEnabled = true;
            Month_cmb.Items.AddRange(new object[] { "תשרי", "מרחשוון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן אייר", "סיון", "תמוז", "אב", "אלול" });
            Month_cmb.Location = new Point(434, 209);
            Month_cmb.Name = "Month_cmb";
            Month_cmb.Size = new Size(151, 28);
            Month_cmb.TabIndex = 6;
            // 
            // DatAtMonth_cmb
            // 
            DatAtMonth_cmb.FormattingEnabled = true;
            DatAtMonth_cmb.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            DatAtMonth_cmb.Location = new Point(663, 209);
            DatAtMonth_cmb.Name = "DatAtMonth_cmb";
            DatAtMonth_cmb.Size = new Size(151, 28);
            DatAtMonth_cmb.TabIndex = 7;
            // 
            // Year_cmb
            // 
            Year_cmb.FormattingEnabled = true;
            Year_cmb.Items.AddRange(new object[] { "תשפ''ד", "תשפ''ה", "תשפ''ו", "תשפ''ז", "תשפ''ח", "תשפ''ט", "תש''צ" });
            Year_cmb.Location = new Point(226, 209);
            Year_cmb.Name = "Year_cmb";
            Year_cmb.Size = new Size(151, 28);
            Year_cmb.TabIndex = 8;
            
            // 
            // button1
            // 
            button1.Location = new Point(486, 363);
            button1.Name = "button1";
            button1.Size = new Size(199, 29);
            button1.TabIndex = 9;
            button1.Text = "קבל תאריך לפי הכללים";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GetCorrectDate_btn;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 580);
            Controls.Add(button1);
            Controls.Add(Year_cmb);
            Controls.Add(DatAtMonth_cmb);
            Controls.Add(Month_cmb);
            Controls.Add(Day_cmb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "בחירת תאריך";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox Day_cmb;
        private ComboBox Month_cmb;
        private ComboBox DatAtMonth_cmb;
        private ComboBox Year_cmb;
        private Button button1;
    }
}
