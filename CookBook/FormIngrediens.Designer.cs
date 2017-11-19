﻿namespace CookBook
{
    partial class FormIngrediens
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
            this.groupBoxIngrediens = new System.Windows.Forms.GroupBox();
            this.buttonUnselect = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listBoxListOfIngrediens = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPutIngredient = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNoOfIngrediens = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.groupBoxIngrediens.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIngrediens
            // 
            this.groupBoxIngrediens.Controls.Add(this.buttonUnselect);
            this.groupBoxIngrediens.Controls.Add(this.buttonDelete);
            this.groupBoxIngrediens.Controls.Add(this.buttonEdit);
            this.groupBoxIngrediens.Controls.Add(this.listBoxListOfIngrediens);
            this.groupBoxIngrediens.Controls.Add(this.buttonAdd);
            this.groupBoxIngrediens.Controls.Add(this.textBoxPutIngredient);
            this.groupBoxIngrediens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIngrediens.Location = new System.Drawing.Point(27, 81);
            this.groupBoxIngrediens.Name = "groupBoxIngrediens";
            this.groupBoxIngrediens.Size = new System.Drawing.Size(487, 373);
            this.groupBoxIngrediens.TabIndex = 0;
            this.groupBoxIngrediens.TabStop = false;
            this.groupBoxIngrediens.Text = "Ingrediens";
            // 
            // buttonUnselect
            // 
            this.buttonUnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnselect.Location = new System.Drawing.Point(382, 310);
            this.buttonUnselect.Name = "buttonUnselect";
            this.buttonUnselect.Size = new System.Drawing.Size(78, 28);
            this.buttonUnselect.TabIndex = 5;
            this.buttonUnselect.Text = "Unselect";
            this.buttonUnselect.UseVisualStyleBackColor = true;
            this.buttonUnselect.Click += new System.EventHandler(this.buttonUnselect_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(383, 184);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(76, 34);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(382, 137);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(78, 29);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // listBoxListOfIngrediens
            // 
            this.listBoxListOfIngrediens.FormattingEnabled = true;
            this.listBoxListOfIngrediens.ItemHeight = 18;
            this.listBoxListOfIngrediens.Location = new System.Drawing.Point(24, 82);
            this.listBoxListOfIngrediens.Name = "listBoxListOfIngrediens";
            this.listBoxListOfIngrediens.Size = new System.Drawing.Size(320, 256);
            this.listBoxListOfIngrediens.TabIndex = 2;
            this.listBoxListOfIngrediens.SelectedIndexChanged += new System.EventHandler(this.listBoxListOfIngrediens_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(382, 34);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 24);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPutIngredient
            // 
            this.textBoxPutIngredient.Location = new System.Drawing.Point(24, 34);
            this.textBoxPutIngredient.Name = "textBoxPutIngredient";
            this.textBoxPutIngredient.Size = new System.Drawing.Size(320, 24);
            this.textBoxPutIngredient.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(85, 484);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(91, 30);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(247, 483);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 31);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelNoOfIngrediens
            // 
            this.labelNoOfIngrediens.AutoSize = true;
            this.labelNoOfIngrediens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOfIngrediens.Location = new System.Drawing.Point(39, 27);
            this.labelNoOfIngrediens.Name = "labelNoOfIngrediens";
            this.labelNoOfIngrediens.Size = new System.Drawing.Size(149, 18);
            this.labelNoOfIngrediens.TabIndex = 3;
            this.labelNoOfIngrediens.Text = "Number of Ingrediens";
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNo.Location = new System.Drawing.Point(272, 32);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(46, 18);
            this.labelNo.TabIndex = 4;
            this.labelNo.Text = "label2";
            // 
            // FormIngrediens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 553);
            this.Controls.Add(this.labelNo);
            this.Controls.Add(this.labelNoOfIngrediens);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxIngrediens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormIngrediens";
            this.Text = "Number of ingrediens in the recipe";
            this.groupBoxIngrediens.ResumeLayout(false);
            this.groupBoxIngrediens.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIngrediens;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ListBox listBoxListOfIngrediens;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPutIngredient;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNoOfIngrediens;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Button buttonUnselect;
    }
}