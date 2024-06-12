namespace STARTSTOP2._1GUI
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
            button_Start = new Button();
            button_Stop = new Button();
            progressBar_StartStop = new ProgressBar();
            textBox_StartStop = new TextBox();
            checkBox_Function = new CheckBox();
            panel1 = new Panel();
            button_NewForm = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_Start
            // 
            button_Start.BackColor = Color.LawnGreen;
            button_Start.Enabled = false;
            button_Start.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Start.Location = new Point(0, 0);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(116, 44);
            button_Start.TabIndex = 0;
            button_Start.Text = "START";
            button_Start.UseVisualStyleBackColor = false;
            button_Start.Click += button_Start_Click;
            // 
            // button_Stop
            // 
            button_Stop.BackColor = Color.Red;
            button_Stop.Enabled = false;
            button_Stop.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Stop.Location = new Point(197, 5);
            button_Stop.Name = "button_Stop";
            button_Stop.Size = new Size(110, 44);
            button_Stop.TabIndex = 1;
            button_Stop.Text = "STOP";
            button_Stop.UseVisualStyleBackColor = false;
            button_Stop.Click += button_Stop_Click;
            // 
            // progressBar_StartStop
            // 
            progressBar_StartStop.Location = new Point(12, 3);
            progressBar_StartStop.Name = "progressBar_StartStop";
            progressBar_StartStop.Size = new Size(789, 42);
            progressBar_StartStop.TabIndex = 2;
            progressBar_StartStop.Click += progressBar_StartStop_Click;
            // 
            // textBox_StartStop
            // 
            textBox_StartStop.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_StartStop.Location = new Point(209, 158);
            textBox_StartStop.Name = "textBox_StartStop";
            textBox_StartStop.Size = new Size(197, 37);
            textBox_StartStop.TabIndex = 3;
            // 
            // checkBox_Function
            // 
            checkBox_Function.AutoSize = true;
            checkBox_Function.Location = new Point(24, 176);
            checkBox_Function.Name = "checkBox_Function";
            checkBox_Function.Size = new Size(104, 19);
            checkBox_Function.TabIndex = 4;
            checkBox_Function.Text = "Click to Enable";
            checkBox_Function.UseVisualStyleBackColor = true;
            checkBox_Function.CheckedChanged += checkBox_Function_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Start);
            panel1.Controls.Add(button_Stop);
            panel1.Location = new Point(186, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 100);
            panel1.TabIndex = 5;
            // 
            // button_NewForm
            // 
            button_NewForm.Location = new Point(186, 286);
            button_NewForm.Name = "button_NewForm";
            button_NewForm.Size = new Size(75, 23);
            button_NewForm.TabIndex = 6;
            button_NewForm.Text = "New Form";
            button_NewForm.UseVisualStyleBackColor = true;
            button_NewForm.Click += button_NewForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_NewForm);
            Controls.Add(panel1);
            Controls.Add(checkBox_Function);
            Controls.Add(textBox_StartStop);
            Controls.Add(progressBar_StartStop);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Start;
        private Button button_Stop;
        private ProgressBar progressBar_StartStop;
        private TextBox textBox_StartStop;
        private CheckBox checkBox_Function;
        private Panel panel1;
        private Button button_NewForm;
    }
}
