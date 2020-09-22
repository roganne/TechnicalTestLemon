namespace ClientWinFormApp
{
    partial class Home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCallFibonacciWS = new System.Windows.Forms.Button();
            this.numericUpDownInput = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btXmlToJson = new System.Windows.Forms.Button();
            this.btGenerateXml = new System.Windows.Forms.Button();
            this.tbJson = new System.Windows.Forms.TextBox();
            this.tbXml = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCallFibonacciWS
            // 
            this.btCallFibonacciWS.Location = new System.Drawing.Point(178, 17);
            this.btCallFibonacciWS.Name = "btCallFibonacciWS";
            this.btCallFibonacciWS.Size = new System.Drawing.Size(111, 23);
            this.btCallFibonacciWS.TabIndex = 0;
            this.btCallFibonacciWS.Text = "Compute Fibonacci";
            this.btCallFibonacciWS.UseVisualStyleBackColor = true;
            this.btCallFibonacciWS.Click += new System.EventHandler(this.btCallFibonacciWS_Click);
            // 
            // numericUpDownInput
            // 
            this.numericUpDownInput.Location = new System.Drawing.Point(328, 20);
            this.numericUpDownInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownInput.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownInput.Name = "numericUpDownInput";
            this.numericUpDownInput.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownInput.TabIndex = 1;
            this.numericUpDownInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCallFibonacciWS);
            this.panel1.Controls.Add(this.numericUpDownInput);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 54);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btXmlToJson);
            this.panel2.Controls.Add(this.btGenerateXml);
            this.panel2.Controls.Add(this.tbJson);
            this.panel2.Controls.Add(this.tbXml);
            this.panel2.Location = new System.Drawing.Point(12, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 286);
            this.panel2.TabIndex = 5;
            // 
            // btXmlToJson
            // 
            this.btXmlToJson.Location = new System.Drawing.Point(247, 156);
            this.btXmlToJson.Name = "btXmlToJson";
            this.btXmlToJson.Size = new System.Drawing.Size(112, 23);
            this.btXmlToJson.TabIndex = 2;
            this.btXmlToJson.Text = "XmlToJson =>";
            this.btXmlToJson.UseVisualStyleBackColor = true;
            this.btXmlToJson.Click += new System.EventHandler(this.btXmlToJson_Click);
            // 
            // btGenerateXml
            // 
            this.btGenerateXml.Location = new System.Drawing.Point(247, 77);
            this.btGenerateXml.Name = "btGenerateXml";
            this.btGenerateXml.Size = new System.Drawing.Size(112, 23);
            this.btGenerateXml.TabIndex = 1;
            this.btGenerateXml.Text = "<= Generate Xml";
            this.btGenerateXml.UseVisualStyleBackColor = true;
            this.btGenerateXml.Click += new System.EventHandler(this.btGenerateXml_Click);
            // 
            // tbJson
            // 
            this.tbJson.Location = new System.Drawing.Point(374, 3);
            this.tbJson.Multiline = true;
            this.tbJson.Name = "tbJson";
            this.tbJson.Size = new System.Drawing.Size(229, 278);
            this.tbJson.TabIndex = 0;
            // 
            // tbXml
            // 
            this.tbXml.Location = new System.Drawing.Point(3, 3);
            this.tbXml.Multiline = true;
            this.tbXml.Name = "tbXml";
            this.tbXml.Size = new System.Drawing.Size(229, 278);
            this.tbXml.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 364);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCallFibonacciWS;
        private System.Windows.Forms.NumericUpDown numericUpDownInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btXmlToJson;
        private System.Windows.Forms.Button btGenerateXml;
        private System.Windows.Forms.TextBox tbJson;
        private System.Windows.Forms.TextBox tbXml;
    }
}

