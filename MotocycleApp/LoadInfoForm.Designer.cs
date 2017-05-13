namespace MotocycleApp
{
    partial class LoadInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idCheck = new System.Windows.Forms.Label();
            this.性别 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.birthDateFor = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(64, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(110, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(249, 26);
            this.name.TabIndex = 1;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.id.Location = new System.Drawing.Point(110, 68);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(249, 26);
            this.id.TabIndex = 3;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "身份证号";
            // 
            // idCheck
            // 
            this.idCheck.AutoSize = true;
            this.idCheck.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idCheck.Location = new System.Drawing.Point(107, 97);
            this.idCheck.Name = "idCheck";
            this.idCheck.Size = new System.Drawing.Size(0, 16);
            this.idCheck.TabIndex = 4;
            // 
            // 性别
            // 
            this.性别.AutoSize = true;
            this.性别.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.性别.Location = new System.Drawing.Point(67, 139);
            this.性别.Name = "性别";
            this.性别.Size = new System.Drawing.Size(40, 16);
            this.性别.TabIndex = 5;
            this.性别.Text = "姓名";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.male.Location = new System.Drawing.Point(114, 138);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(42, 20);
            this.male.TabIndex = 6;
            this.male.TabStop = true;
            this.male.Text = "男";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.female.Location = new System.Drawing.Point(171, 138);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(42, 20);
            this.female.TabIndex = 7;
            this.female.TabStop = true;
            this.female.Text = "女";
            this.female.UseVisualStyleBackColor = true;
            // 
            // birthDateFor
            // 
            this.birthDateFor.AutoSize = true;
            this.birthDateFor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.birthDateFor.Location = new System.Drawing.Point(35, 180);
            this.birthDateFor.Name = "birthDateFor";
            this.birthDateFor.Size = new System.Drawing.Size(72, 16);
            this.birthDateFor.TabIndex = 8;
            this.birthDateFor.Text = "出生日期";
            // 
            // birthDate
            // 
            this.birthDate.CalendarFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.birthDate.Location = new System.Drawing.Point(110, 180);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(249, 21);
            this.birthDate.TabIndex = 10;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submit.Location = new System.Drawing.Point(101, 398);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(112, 32);
            this.submit.TabIndex = 11;
            this.submit.Text = "确认";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(287, 398);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(72, 32);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(366, 71);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(70, 23);
            this.update.TabIndex = 13;
            this.update.Text = "自动关联";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // LoadInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 442);
            this.Controls.Add(this.update);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.birthDateFor);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.性别);
            this.Controls.Add(this.idCheck);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "LoadInfoForm";
            this.Text = "LoadInfoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.LoadInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idCheck;
        private System.Windows.Forms.Label 性别;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label birthDateFor;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button update;
    }
}