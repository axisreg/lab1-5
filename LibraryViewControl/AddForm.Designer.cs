namespace LibraryViewControl
{
    partial class AddForm
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
            this._okButton = new System.Windows.Forms.Button();
            this._cancellButton = new System.Windows.Forms.Button();
            this._randomButton = new System.Windows.Forms.Button();
            this._libraryCardControl = new LibraryViewControl.LibraryCardControl();
            this.SuspendLayout();
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(143, 251);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 8;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // _cancellButton
            // 
            this._cancellButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancellButton.Location = new System.Drawing.Point(224, 251);
            this._cancellButton.Name = "_cancellButton";
            this._cancellButton.Size = new System.Drawing.Size(75, 23);
            this._cancellButton.TabIndex = 9;
            this._cancellButton.Text = "Отмена";
            this._cancellButton.UseVisualStyleBackColor = true;
            // 
            // _randomButton
            // 
            this._randomButton.Location = new System.Drawing.Point(7, 251);
            this._randomButton.Name = "_randomButton";
            this._randomButton.Size = new System.Drawing.Size(75, 23);
            this._randomButton.TabIndex = 7;
            this._randomButton.Text = "Random";
            this._randomButton.UseVisualStyleBackColor = true;
            this._randomButton.Visible = false;
            this._randomButton.Click += new System.EventHandler(this.RandomButtonClick);
            // 
            // libraryCardControl1
            // 
            this._libraryCardControl.CanToggle = true;
            this._libraryCardControl.Location = new System.Drawing.Point(7, 5);
            this._libraryCardControl.Name = "libraryCardControl1";
            this._libraryCardControl.Publication = null;
            this._libraryCardControl.ReadOnly = true;
            this._libraryCardControl.Size = new System.Drawing.Size(450, 240);
            this._libraryCardControl.TabIndex = 10;
            // 
            // AddForm
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancellButton;
            this.ClientSize = new System.Drawing.Size(466, 282);
            this.Controls.Add(this._libraryCardControl);
            this.Controls.Add(this._randomButton);
            this.Controls.Add(this._cancellButton);
            this.Controls.Add(this._okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить издание";
            //this.Shown += new System.EventHandler(this.AddFormShown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancellButton;
        private System.Windows.Forms.Button _randomButton;
        private LibraryCardControl _libraryCardControl;
    }
}