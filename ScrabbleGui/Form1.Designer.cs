namespace ScrabbleGui
{
    partial class Form1
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
            this._btnLoadDictionary = new System.Windows.Forms.Button();
            this._lblWordsLoaded = new System.Windows.Forms.Label();
            this.@__descLabelWordsLoaded = new System.Windows.Forms.Label();
            this._txtUsableChars = new System.Windows.Forms.TextBox();
            this.@__descLongestWord = new System.Windows.Forms.Label();
            this._lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnLoadDictionary
            // 
            this._btnLoadDictionary.Location = new System.Drawing.Point(12, 12);
            this._btnLoadDictionary.Name = "_btnLoadDictionary";
            this._btnLoadDictionary.Size = new System.Drawing.Size(151, 32);
            this._btnLoadDictionary.TabIndex = 0;
            this._btnLoadDictionary.Text = "Load Dictionary";
            this._btnLoadDictionary.UseVisualStyleBackColor = true;
            this._btnLoadDictionary.Click += new System.EventHandler(this._btnLoadDictionary_Click);
            // 
            // _lblWordsLoaded
            // 
            this._lblWordsLoaded.Location = new System.Drawing.Point(123, 47);
            this._lblWordsLoaded.Name = "_lblWordsLoaded";
            this._lblWordsLoaded.Size = new System.Drawing.Size(78, 20);
            this._lblWordsLoaded.TabIndex = 1;
            this._lblWordsLoaded.Text = "None";
            // 
            // __descLabelWordsLoaded
            // 
            this.@__descLabelWordsLoaded.Location = new System.Drawing.Point(12, 47);
            this.@__descLabelWordsLoaded.Name = "__descLabelWordsLoaded";
            this.@__descLabelWordsLoaded.Size = new System.Drawing.Size(105, 17);
            this.@__descLabelWordsLoaded.TabIndex = 2;
            this.@__descLabelWordsLoaded.Text = "Words loaded:";
            // 
            // _txtUsableChars
            // 
            this._txtUsableChars.Location = new System.Drawing.Point(241, 12);
            this._txtUsableChars.Name = "_txtUsableChars";
            this._txtUsableChars.Size = new System.Drawing.Size(250, 22);
            this._txtUsableChars.TabIndex = 3;
            this._txtUsableChars.TextChanged += new System.EventHandler(this._txtUsableChars_TextChanged);
            // 
            // __descLongestWord
            // 
            this.@__descLongestWord.Location = new System.Drawing.Point(241, 37);
            this.@__descLongestWord.Name = "__descLongestWord";
            this.@__descLongestWord.Size = new System.Drawing.Size(116, 19);
            this.@__descLongestWord.TabIndex = 4;
            this.@__descLongestWord.Text = "Longest word:";
            // 
            // _lblResult
            // 
            this._lblResult.Location = new System.Drawing.Point(344, 37);
            this._lblResult.Name = "_lblResult";
            this._lblResult.Size = new System.Drawing.Size(444, 15);
            this._lblResult.TabIndex = 5;
            this._lblResult.Text = "RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lblResult);
            this.Controls.Add(this.@__descLongestWord);
            this.Controls.Add(this._txtUsableChars);
            this.Controls.Add(this.@__descLabelWordsLoaded);
            this.Controls.Add(this._lblWordsLoaded);
            this.Controls.Add(this._btnLoadDictionary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox _txtUsableChars;
        private System.Windows.Forms.Label __descLongestWord;
        private System.Windows.Forms.Label _lblResult;

        private System.Windows.Forms.Button _btnLoadDictionary;
        private System.Windows.Forms.Label _lblWordsLoaded;
        private System.Windows.Forms.Label __descLabelWordsLoaded;

        #endregion
    }
}