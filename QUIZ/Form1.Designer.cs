namespace QUIZ
{
    partial class QUIZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QUIZ));
            this.leftPlus = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Label();
            this.rightPlus = new System.Windows.Forms.Label();
            this.equa = new System.Windows.Forms.Label();
            this.startQuiz = new System.Windows.Forms.Button();
            this.plusResult = new System.Windows.Forms.NumericUpDown();
            this.check = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plusResult)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPlus
            // 
            resources.ApplyResources(this.leftPlus, "leftPlus");
            this.leftPlus.Name = "leftPlus";
            // 
            // sign
            // 
            resources.ApplyResources(this.sign, "sign");
            this.sign.Name = "sign";
            // 
            // rightPlus
            // 
            resources.ApplyResources(this.rightPlus, "rightPlus");
            this.rightPlus.Name = "rightPlus";
            // 
            // equa
            // 
            resources.ApplyResources(this.equa, "equa");
            this.equa.Name = "equa";
            // 
            // startQuiz
            // 
            resources.ApplyResources(this.startQuiz, "startQuiz");
            this.startQuiz.Name = "startQuiz";
            this.startQuiz.UseVisualStyleBackColor = true;
            this.startQuiz.Click += new System.EventHandler(this.startQuiz_Click);
            // 
            // plusResult
            // 
            resources.ApplyResources(this.plusResult, "plusResult");
            this.plusResult.Name = "plusResult";
            this.plusResult.ValueChanged += new System.EventHandler(this.plusResult_ValueChanged);
            // 
            // check
            // 
            resources.ApplyResources(this.check, "check");
            this.check.Name = "check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeLabel
            // 
            resources.ApplyResources(this.TimeLabel, "TimeLabel");
            this.TimeLabel.Name = "TimeLabel";
            // 
            // QUIZ
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.check);
            this.Controls.Add(this.plusResult);
            this.Controls.Add(this.startQuiz);
            this.Controls.Add(this.equa);
            this.Controls.Add(this.rightPlus);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.leftPlus);
            this.Name = "QUIZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plusResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leftPlus;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.Label rightPlus;
        private System.Windows.Forms.Label equa;
        private System.Windows.Forms.Button startQuiz;
        private System.Windows.Forms.NumericUpDown plusResult;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeLabel;
    }
}

