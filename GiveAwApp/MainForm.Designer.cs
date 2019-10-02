namespace GiveAwApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbPAdd = new System.Windows.Forms.TabPage();
            this.mtxtBGive = new System.Windows.Forms.MaskedTextBox();
            this.grBGive = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtBResume = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBWhere = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.trvGive = new System.Windows.Forms.TreeView();
            this.tpBRes = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.trvResult = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.tbPAdd.SuspendLayout();
            this.grBGive.SuspendLayout();
            this.tpBRes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPAdd
            // 
            this.tbPAdd.Controls.Add(this.maskedTextBox2);
            this.tbPAdd.Controls.Add(this.grBGive);
            this.tbPAdd.Controls.Add(this.btnUpdate);
            this.tbPAdd.Controls.Add(this.btnDelete);
            this.tbPAdd.Controls.Add(this.btnAdd);
            this.tbPAdd.Controls.Add(this.trvGive);
            this.tbPAdd.Location = new System.Drawing.Point(4, 22);
            this.tbPAdd.Name = "tbPAdd";
            this.tbPAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tbPAdd.Size = new System.Drawing.Size(550, 425);
            this.tbPAdd.TabIndex = 1;
            this.tbPAdd.Text = "Add Giveaway";
            this.tbPAdd.UseVisualStyleBackColor = true;
            // 
            // mtxtBGive
            // 
            this.mtxtBGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtBGive.Location = new System.Drawing.Point(86, 21);
            this.mtxtBGive.Mask = "00/00/0000";
            this.mtxtBGive.Name = "mtxtBGive";
            this.mtxtBGive.Size = new System.Drawing.Size(135, 22);
            this.mtxtBGive.TabIndex = 8;
            this.mtxtBGive.ValidatingType = typeof(System.DateTime);
            // 
            // grBGive
            // 
            this.grBGive.Controls.Add(this.label3);
            this.grBGive.Controls.Add(this.mtxtBGive);
            this.grBGive.Controls.Add(this.rtxtBResume);
            this.grBGive.Controls.Add(this.label2);
            this.grBGive.Controls.Add(this.label1);
            this.grBGive.Controls.Add(this.btnCancel);
            this.grBGive.Controls.Add(this.txtBWhere);
            this.grBGive.Controls.Add(this.btnSubmit);
            this.grBGive.Enabled = false;
            this.grBGive.Location = new System.Drawing.Point(314, 6);
            this.grBGive.Name = "grBGive";
            this.grBGive.Size = new System.Drawing.Size(227, 218);
            this.grBGive.TabIndex = 7;
            this.grBGive.TabStop = false;
            this.grBGive.Text = "Add Giveaway";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resume";
            // 
            // rtxtBResume
            // 
            this.rtxtBResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtBResume.Location = new System.Drawing.Point(86, 96);
            this.rtxtBResume.Name = "rtxtBResume";
            this.rtxtBResume.Size = new System.Drawing.Size(135, 62);
            this.rtxtBResume.TabIndex = 7;
            this.rtxtBResume.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Platform";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(65, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBWhere
            // 
            this.txtBWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBWhere.Location = new System.Drawing.Point(86, 58);
            this.txtBWhere.Name = "txtBWhere";
            this.txtBWhere.Size = new System.Drawing.Size(135, 22);
            this.txtBWhere.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(146, 177);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(233, 86);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(233, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(233, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // trvGive
            // 
            this.trvGive.Location = new System.Drawing.Point(7, 6);
            this.trvGive.Name = "trvGive";
            this.trvGive.Size = new System.Drawing.Size(220, 411);
            this.trvGive.TabIndex = 0;
            this.trvGive.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvGive_NodeMouseClick);
            // 
            // tpBRes
            // 
            this.tpBRes.Controls.Add(this.label4);
            this.tpBRes.Controls.Add(this.trvResult);
            this.tpBRes.Location = new System.Drawing.Point(4, 22);
            this.tpBRes.Name = "tpBRes";
            this.tpBRes.Padding = new System.Windows.Forms.Padding(3);
            this.tpBRes.Size = new System.Drawing.Size(550, 425);
            this.tpBRes.TabIndex = 0;
            this.tpBRes.Text = "Results";
            this.tpBRes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(84, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Results giveaway (Max 5 days)";
            // 
            // trvResult
            // 
            this.trvResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvResult.Location = new System.Drawing.Point(7, 92);
            this.trvResult.Name = "trvResult";
            this.trvResult.Size = new System.Drawing.Size(535, 325);
            this.trvResult.TabIndex = 0;
            this.trvResult.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBRes);
            this.tabControl1.Controls.Add(this.tbPAdd);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(869, 588);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiveAwApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tbPAdd.ResumeLayout(false);
            this.tbPAdd.PerformLayout();
            this.grBGive.ResumeLayout(false);
            this.grBGive.PerformLayout();
            this.tpBRes.ResumeLayout(false);
            this.tpBRes.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbPAdd;
        private System.Windows.Forms.GroupBox grBGive;
        private System.Windows.Forms.TextBox txtBWhere;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TreeView trvGive;
        private System.Windows.Forms.TabPage tpBRes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtBResume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView trvResult;
        private System.Windows.Forms.MaskedTextBox mtxtBGive;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}

