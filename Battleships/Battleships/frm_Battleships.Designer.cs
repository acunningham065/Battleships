namespace Battleships
{
    partial class frm_Battleships
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Battleships));
            this.flp_Board = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_PlayGame = new System.Windows.Forms.Button();
            this.imgLst_Ships = new System.Windows.Forms.ImageList(this.components);
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_Missiles = new System.Windows.Forms.Label();
            this.btn_EasyLevel = new System.Windows.Forms.Button();
            this.btn_IntermediateLevel = new System.Windows.Forms.Button();
            this.btn_HardLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_Board
            // 
            this.flp_Board.Location = new System.Drawing.Point(322, 41);
            this.flp_Board.Name = "flp_Board";
            this.flp_Board.Size = new System.Drawing.Size(600, 560);
            this.flp_Board.TabIndex = 0;
            // 
            // btn_PlayGame
            // 
            this.btn_PlayGame.Enabled = false;
            this.btn_PlayGame.Location = new System.Drawing.Point(22, 41);
            this.btn_PlayGame.Name = "btn_PlayGame";
            this.btn_PlayGame.Size = new System.Drawing.Size(185, 48);
            this.btn_PlayGame.TabIndex = 0;
            this.btn_PlayGame.Text = "Play";
            this.btn_PlayGame.UseVisualStyleBackColor = true;
            this.btn_PlayGame.Click += new System.EventHandler(this.btn_PlayGame_Click);
            // 
            // imgLst_Ships
            // 
            this.imgLst_Ships.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst_Ships.ImageStream")));
            this.imgLst_Ships.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLst_Ships.Images.SetKeyName(0, "miss.jpg");
            this.imgLst_Ships.Images.SetKeyName(1, "submarine.jpg");
            this.imgLst_Ships.Images.SetKeyName(2, "frigate.png");
            this.imgLst_Ships.Images.SetKeyName(3, "destroyer.jpg");
            this.imgLst_Ships.Images.SetKeyName(4, "battleship.jpg");
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(17, 530);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(78, 26);
            this.lbl_Score.TabIndex = 1;
            this.lbl_Score.Text = "Score:";
            // 
            // lbl_Missiles
            // 
            this.lbl_Missiles.AutoSize = true;
            this.lbl_Missiles.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Missiles.Location = new System.Drawing.Point(17, 570);
            this.lbl_Missiles.Name = "lbl_Missiles";
            this.lbl_Missiles.Size = new System.Drawing.Size(102, 26);
            this.lbl_Missiles.TabIndex = 2;
            this.lbl_Missiles.Text = "Missiles:";
            // 
            // btn_EasyLevel
            // 
            this.btn_EasyLevel.Location = new System.Drawing.Point(22, 125);
            this.btn_EasyLevel.Name = "btn_EasyLevel";
            this.btn_EasyLevel.Size = new System.Drawing.Size(185, 48);
            this.btn_EasyLevel.TabIndex = 3;
            this.btn_EasyLevel.Text = "Easy Level";
            this.btn_EasyLevel.UseVisualStyleBackColor = true;
            this.btn_EasyLevel.Click += new System.EventHandler(this.btn_EasyLevel_Click);
            // 
            // btn_IntermediateLevel
            // 
            this.btn_IntermediateLevel.Location = new System.Drawing.Point(22, 209);
            this.btn_IntermediateLevel.Name = "btn_IntermediateLevel";
            this.btn_IntermediateLevel.Size = new System.Drawing.Size(185, 48);
            this.btn_IntermediateLevel.TabIndex = 4;
            this.btn_IntermediateLevel.Text = "Intermediate Level";
            this.btn_IntermediateLevel.UseVisualStyleBackColor = true;
            this.btn_IntermediateLevel.Click += new System.EventHandler(this.btn_IntermediateLevel_Click);
            // 
            // btn_HardLevel
            // 
            this.btn_HardLevel.Location = new System.Drawing.Point(22, 293);
            this.btn_HardLevel.Name = "btn_HardLevel";
            this.btn_HardLevel.Size = new System.Drawing.Size(185, 48);
            this.btn_HardLevel.TabIndex = 5;
            this.btn_HardLevel.Text = "Hard Level";
            this.btn_HardLevel.UseVisualStyleBackColor = true;
            this.btn_HardLevel.Click += new System.EventHandler(this.btn_HardLevel_Click);
            // 
            // frm_Battleships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 687);
            this.Controls.Add(this.btn_HardLevel);
            this.Controls.Add(this.btn_IntermediateLevel);
            this.Controls.Add(this.btn_EasyLevel);
            this.Controls.Add(this.lbl_Missiles);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.btn_PlayGame);
            this.Controls.Add(this.flp_Board);
            this.Name = "frm_Battleships";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Board;
        private System.Windows.Forms.Button btn_PlayGame;
        private System.Windows.Forms.ImageList imgLst_Ships;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_Missiles;
        private System.Windows.Forms.Button btn_EasyLevel;
        private System.Windows.Forms.Button btn_IntermediateLevel;
        private System.Windows.Forms.Button btn_HardLevel;
    }
}

