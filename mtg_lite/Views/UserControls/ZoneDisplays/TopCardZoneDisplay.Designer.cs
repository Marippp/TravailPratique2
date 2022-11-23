namespace mtg_lite.Views.UserControls.ZoneDisplays
{
    partial class TopCardZoneDisplay
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblZoneName = new System.Windows.Forms.Label();
            this.cardDisplay = new mtg_lite.Views.UserControls.CardDisplays.CardDisplay();
            this.SuspendLayout();
            // 
            // lblZoneName
            // 
            this.lblZoneName.AutoSize = true;
            this.lblZoneName.Location = new System.Drawing.Point(2, 0);
            this.lblZoneName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZoneName.Name = "lblZoneName";
            this.lblZoneName.Size = new System.Drawing.Size(109, 20);
            this.lblZoneName.TabIndex = 1;
            this.lblZoneName.Text = "Zone Name (0)";
            // 
            // cardDisplay
            // 
            this.cardDisplay.Card = null;
            this.cardDisplay.Enabled = false;
            this.cardDisplay.Location = new System.Drawing.Point(2, 23);
            this.cardDisplay.Margin = new System.Windows.Forms.Padding(1);
            this.cardDisplay.Name = "cardDisplay";
            this.cardDisplay.Size = new System.Drawing.Size(165, 229);
            this.cardDisplay.TabIndex = 2;
            // 
            // TopCardZoneDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardDisplay);
            this.Controls.Add(this.lblZoneName);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TopCardZoneDisplay";
            this.Size = new System.Drawing.Size(509, 553);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblZoneName;
        private CardDisplays.CardDisplay cardDisplay;
    }
}
