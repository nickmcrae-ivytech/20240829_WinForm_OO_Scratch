namespace WindowsFormsApp1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.ddlAnimalTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAnimals = new System.Windows.Forms.ListView();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnNewTrick = new System.Windows.Forms.Button();
            this.lblSpeak = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(138, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 44);
            this.txtName.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(748, 135);
            this.lblResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 51);
            this.lblResult.TabIndex = 4;
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.AutoSize = true;
            this.lblAnimalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimalName.Location = new System.Drawing.Point(696, 26);
            this.lblAnimalName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(410, 73);
            this.lblAnimalName.TabIndex = 6;
            this.lblAnimalName.Text = "animal name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddAnimal);
            this.groupBox1.Controls.Add(this.ddlAnimalTypes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(46, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 277);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Animal";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Location = new System.Drawing.Point(287, 179);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(147, 65);
            this.btnAddAnimal.TabIndex = 9;
            this.btnAddAnimal.Text = "➕ Add";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // ddlAnimalTypes
            // 
            this.ddlAnimalTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlAnimalTypes.FormattingEnabled = true;
            this.ddlAnimalTypes.Location = new System.Drawing.Point(138, 100);
            this.ddlAnimalTypes.Name = "ddlAnimalTypes";
            this.ddlAnimalTypes.Size = new System.Drawing.Size(296, 45);
            this.ddlAnimalTypes.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type";
            // 
            // lstAnimals
            // 
            this.lstAnimals.HideSelection = false;
            this.lstAnimals.Location = new System.Drawing.Point(46, 318);
            this.lstAnimals.Name = "lstAnimals";
            this.lstAnimals.Size = new System.Drawing.Size(473, 327);
            this.lstAnimals.TabIndex = 9;
            this.lstAnimals.UseCompatibleStateImageBehavior = false;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(702, 114);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(181, 37);
            this.lblDetails.TabIndex = 10;
            this.lblDetails.Text = "animal dets";
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeak.Location = new System.Drawing.Point(1181, 32);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(261, 65);
            this.btnSpeak.TabIndex = 10;
            this.btnSpeak.Text = "🔊 Speak";
            this.btnSpeak.UseVisualStyleBackColor = false;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnNewTrick
            // 
            this.btnNewTrick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewTrick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTrick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTrick.Location = new System.Drawing.Point(1181, 114);
            this.btnNewTrick.Name = "btnNewTrick";
            this.btnNewTrick.Size = new System.Drawing.Size(261, 65);
            this.btnNewTrick.TabIndex = 11;
            this.btnNewTrick.Text = "➕ New Trick";
            this.btnNewTrick.UseVisualStyleBackColor = false;
            this.btnNewTrick.Click += new System.EventHandler(this.btnNewTrick_Click);
            // 
            // lblSpeak
            // 
            this.lblSpeak.AutoSize = true;
            this.lblSpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeak.Location = new System.Drawing.Point(1174, 219);
            this.lblSpeak.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSpeak.Name = "lblSpeak";
            this.lblSpeak.Size = new System.Drawing.Size(0, 37);
            this.lblSpeak.TabIndex = 12;
            this.lblSpeak.AutoSize = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1600, 687);
            this.Controls.Add(this.lblSpeak);
            this.Controls.Add(this.btnNewTrick);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lstAnimals);
            this.Controls.Add(this.lblAnimalName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "My Cool Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ddlAnimalTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ListView lstAnimals;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnNewTrick;
        private System.Windows.Forms.Label lblSpeak;
    }
}

