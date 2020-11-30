namespace ManyJobsClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.group_joboffer = new System.Windows.Forms.GroupBox();
            this.txt_idOffer = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_searchOffer = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_savejob = new System.Windows.Forms.Button();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_jobSkill = new System.Windows.Forms.TextBox();
            this.txt_Exp = new System.Windows.Forms.TextBox();
            this.txt_jobTitle = new System.Windows.Forms.TextBox();
            this.txt_jobName = new System.Windows.Forms.TextBox();
            this.label_salary = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_jobSkill = new System.Windows.Forms.Label();
            this.label_exp = new System.Windows.Forms.Label();
            this.label_jobtitle = new System.Windows.Forms.Label();
            this.label_jobname = new System.Windows.Forms.Label();
            this.group_seeker = new System.Windows.Forms.GroupBox();
            this.btn_searchJS = new System.Windows.Forms.Button();
            this.txt_idSeeker = new System.Windows.Forms.TextBox();
            this.btn_deletejs = new System.Windows.Forms.Button();
            this.btn_editjs = new System.Windows.Forms.Button();
            this.btn_saveseeker = new System.Windows.Forms.Button();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_seekerSkill = new System.Windows.Forms.TextBox();
            this.txt_major = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_seekername = new System.Windows.Forms.TextBox();
            this.label_country = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_seekerSkill = new System.Windows.Forms.Label();
            this.label_major = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_seekername = new System.Windows.Forms.Label();
            this.btn_GetAllJO = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btn_GetAllJS = new System.Windows.Forms.Button();
            this.group_joboffer.SuspendLayout();
            this.group_seeker.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(451, 22);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(239, 35);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "ManyJobs Client API";
            // 
            // group_joboffer
            // 
            this.group_joboffer.Controls.Add(this.txt_idOffer);
            this.group_joboffer.Controls.Add(this.btn_delete);
            this.group_joboffer.Controls.Add(this.btn_searchOffer);
            this.group_joboffer.Controls.Add(this.btn_edit);
            this.group_joboffer.Controls.Add(this.btn_savejob);
            this.group_joboffer.Controls.Add(this.txt_salary);
            this.group_joboffer.Controls.Add(this.txt_address);
            this.group_joboffer.Controls.Add(this.txt_jobSkill);
            this.group_joboffer.Controls.Add(this.txt_Exp);
            this.group_joboffer.Controls.Add(this.txt_jobTitle);
            this.group_joboffer.Controls.Add(this.txt_jobName);
            this.group_joboffer.Controls.Add(this.label_salary);
            this.group_joboffer.Controls.Add(this.label_address);
            this.group_joboffer.Controls.Add(this.label_jobSkill);
            this.group_joboffer.Controls.Add(this.label_exp);
            this.group_joboffer.Controls.Add(this.label_jobtitle);
            this.group_joboffer.Controls.Add(this.label_jobname);
            this.group_joboffer.Location = new System.Drawing.Point(556, 78);
            this.group_joboffer.Name = "group_joboffer";
            this.group_joboffer.Size = new System.Drawing.Size(303, 452);
            this.group_joboffer.TabIndex = 1;
            this.group_joboffer.TabStop = false;
            this.group_joboffer.Text = "JOB";
            // 
            // txt_idOffer
            // 
            this.txt_idOffer.Location = new System.Drawing.Point(13, 401);
            this.txt_idOffer.Name = "txt_idOffer";
            this.txt_idOffer.Size = new System.Drawing.Size(93, 27);
            this.txt_idOffer.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(201, 350);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(68, 30);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_searchOffer
            // 
            this.btn_searchOffer.Location = new System.Drawing.Point(131, 400);
            this.btn_searchOffer.Name = "btn_searchOffer";
            this.btn_searchOffer.Size = new System.Drawing.Size(138, 29);
            this.btn_searchOffer.TabIndex = 4;
            this.btn_searchOffer.Text = "Search by ID";
            this.btn_searchOffer.UseVisualStyleBackColor = true;
            this.btn_searchOffer.Click += new System.EventHandler(this.btn_searchOffer_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(13, 351);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(80, 29);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_savejob
            // 
            this.btn_savejob.Location = new System.Drawing.Point(108, 350);
            this.btn_savejob.Name = "btn_savejob";
            this.btn_savejob.Size = new System.Drawing.Size(72, 29);
            this.btn_savejob.TabIndex = 2;
            this.btn_savejob.Text = "Save";
            this.btn_savejob.UseVisualStyleBackColor = true;
            this.btn_savejob.Click += new System.EventHandler(this.btn_savejob_Click);
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(118, 300);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(161, 27);
            this.txt_salary.TabIndex = 1;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(118, 254);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(161, 27);
            this.txt_address.TabIndex = 1;
            // 
            // txt_jobSkill
            // 
            this.txt_jobSkill.Location = new System.Drawing.Point(118, 202);
            this.txt_jobSkill.Name = "txt_jobSkill";
            this.txt_jobSkill.Size = new System.Drawing.Size(161, 27);
            this.txt_jobSkill.TabIndex = 1;
            // 
            // txt_Exp
            // 
            this.txt_Exp.Location = new System.Drawing.Point(118, 153);
            this.txt_Exp.Name = "txt_Exp";
            this.txt_Exp.Size = new System.Drawing.Size(161, 27);
            this.txt_Exp.TabIndex = 1;
            // 
            // txt_jobTitle
            // 
            this.txt_jobTitle.Location = new System.Drawing.Point(118, 100);
            this.txt_jobTitle.Name = "txt_jobTitle";
            this.txt_jobTitle.Size = new System.Drawing.Size(161, 27);
            this.txt_jobTitle.TabIndex = 1;
            // 
            // txt_jobName
            // 
            this.txt_jobName.Location = new System.Drawing.Point(118, 46);
            this.txt_jobName.Name = "txt_jobName";
            this.txt_jobName.Size = new System.Drawing.Size(161, 27);
            this.txt_jobName.TabIndex = 1;
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(25, 303);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(49, 20);
            this.label_salary.TabIndex = 0;
            this.label_salary.Text = "Salary";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(25, 254);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(62, 20);
            this.label_address.TabIndex = 0;
            this.label_address.Text = "Address";
            // 
            // label_jobSkill
            // 
            this.label_jobSkill.AutoSize = true;
            this.label_jobSkill.Location = new System.Drawing.Point(25, 202);
            this.label_jobSkill.Name = "label_jobSkill";
            this.label_jobSkill.Size = new System.Drawing.Size(36, 20);
            this.label_jobSkill.TabIndex = 0;
            this.label_jobSkill.Text = "Skill";
            // 
            // label_exp
            // 
            this.label_exp.AutoSize = true;
            this.label_exp.Location = new System.Drawing.Point(25, 153);
            this.label_exp.Name = "label_exp";
            this.label_exp.Size = new System.Drawing.Size(81, 20);
            this.label_exp.TabIndex = 0;
            this.label_exp.Text = "Experience";
            // 
            // label_jobtitle
            // 
            this.label_jobtitle.AutoSize = true;
            this.label_jobtitle.Location = new System.Drawing.Point(25, 100);
            this.label_jobtitle.Name = "label_jobtitle";
            this.label_jobtitle.Size = new System.Drawing.Size(65, 20);
            this.label_jobtitle.TabIndex = 0;
            this.label_jobtitle.Text = "Job Title";
            // 
            // label_jobname
            // 
            this.label_jobname.AutoSize = true;
            this.label_jobname.Location = new System.Drawing.Point(25, 46);
            this.label_jobname.Name = "label_jobname";
            this.label_jobname.Size = new System.Drawing.Size(76, 20);
            this.label_jobname.TabIndex = 0;
            this.label_jobname.Text = "Job Name";
            // 
            // group_seeker
            // 
            this.group_seeker.Controls.Add(this.btn_searchJS);
            this.group_seeker.Controls.Add(this.txt_idSeeker);
            this.group_seeker.Controls.Add(this.btn_deletejs);
            this.group_seeker.Controls.Add(this.btn_editjs);
            this.group_seeker.Controls.Add(this.btn_saveseeker);
            this.group_seeker.Controls.Add(this.txt_country);
            this.group_seeker.Controls.Add(this.txt_city);
            this.group_seeker.Controls.Add(this.txt_seekerSkill);
            this.group_seeker.Controls.Add(this.txt_major);
            this.group_seeker.Controls.Add(this.txt_email);
            this.group_seeker.Controls.Add(this.txt_seekername);
            this.group_seeker.Controls.Add(this.label_country);
            this.group_seeker.Controls.Add(this.label_city);
            this.group_seeker.Controls.Add(this.label_seekerSkill);
            this.group_seeker.Controls.Add(this.label_major);
            this.group_seeker.Controls.Add(this.label_email);
            this.group_seeker.Controls.Add(this.label_seekername);
            this.group_seeker.Location = new System.Drawing.Point(877, 78);
            this.group_seeker.Name = "group_seeker";
            this.group_seeker.Size = new System.Drawing.Size(321, 448);
            this.group_seeker.TabIndex = 2;
            this.group_seeker.TabStop = false;
            this.group_seeker.Text = "Seeker";
            // 
            // btn_searchJS
            // 
            this.btn_searchJS.Location = new System.Drawing.Point(147, 398);
            this.btn_searchJS.Name = "btn_searchJS";
            this.btn_searchJS.Size = new System.Drawing.Size(139, 29);
            this.btn_searchJS.TabIndex = 5;
            this.btn_searchJS.Text = "Search by ID";
            this.btn_searchJS.UseVisualStyleBackColor = true;
            this.btn_searchJS.Click += new System.EventHandler(this.btn_searchJS_Click);
            // 
            // txt_idSeeker
            // 
            this.txt_idSeeker.Location = new System.Drawing.Point(22, 401);
            this.txt_idSeeker.Name = "txt_idSeeker";
            this.txt_idSeeker.Size = new System.Drawing.Size(93, 27);
            this.txt_idSeeker.TabIndex = 1;
            // 
            // btn_deletejs
            // 
            this.btn_deletejs.Location = new System.Drawing.Point(211, 355);
            this.btn_deletejs.Name = "btn_deletejs";
            this.btn_deletejs.Size = new System.Drawing.Size(75, 30);
            this.btn_deletejs.TabIndex = 4;
            this.btn_deletejs.Text = "Delete";
            this.btn_deletejs.UseVisualStyleBackColor = true;
            this.btn_deletejs.Click += new System.EventHandler(this.btn_deletejs_Click);
            // 
            // btn_editjs
            // 
            this.btn_editjs.Location = new System.Drawing.Point(18, 356);
            this.btn_editjs.Name = "btn_editjs";
            this.btn_editjs.Size = new System.Drawing.Size(78, 29);
            this.btn_editjs.TabIndex = 3;
            this.btn_editjs.Text = "Edit";
            this.btn_editjs.UseVisualStyleBackColor = true;
            this.btn_editjs.Click += new System.EventHandler(this.btn_editjs_Click);
            // 
            // btn_saveseeker
            // 
            this.btn_saveseeker.Location = new System.Drawing.Point(116, 356);
            this.btn_saveseeker.Name = "btn_saveseeker";
            this.btn_saveseeker.Size = new System.Drawing.Size(68, 29);
            this.btn_saveseeker.TabIndex = 2;
            this.btn_saveseeker.Text = "Save";
            this.btn_saveseeker.UseVisualStyleBackColor = true;
            this.btn_saveseeker.Click += new System.EventHandler(this.btn_saveseeker_Click);
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(120, 302);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(161, 27);
            this.txt_country.TabIndex = 1;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(121, 252);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(163, 27);
            this.txt_city.TabIndex = 1;
            // 
            // txt_seekerSkill
            // 
            this.txt_seekerSkill.Location = new System.Drawing.Point(122, 204);
            this.txt_seekerSkill.Name = "txt_seekerSkill";
            this.txt_seekerSkill.Size = new System.Drawing.Size(163, 27);
            this.txt_seekerSkill.TabIndex = 1;
            // 
            // txt_major
            // 
            this.txt_major.Location = new System.Drawing.Point(121, 157);
            this.txt_major.Name = "txt_major";
            this.txt_major.Size = new System.Drawing.Size(163, 27);
            this.txt_major.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(122, 104);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(163, 27);
            this.txt_email.TabIndex = 1;
            // 
            // txt_seekername
            // 
            this.txt_seekername.Location = new System.Drawing.Point(123, 48);
            this.txt_seekername.Name = "txt_seekername";
            this.txt_seekername.Size = new System.Drawing.Size(163, 27);
            this.txt_seekername.TabIndex = 1;
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Location = new System.Drawing.Point(22, 305);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(60, 20);
            this.label_country.TabIndex = 0;
            this.label_country.Text = "Country";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(22, 259);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(34, 20);
            this.label_city.TabIndex = 0;
            this.label_city.Text = "City";
            // 
            // label_seekerSkill
            // 
            this.label_seekerSkill.AutoSize = true;
            this.label_seekerSkill.Location = new System.Drawing.Point(19, 210);
            this.label_seekerSkill.Name = "label_seekerSkill";
            this.label_seekerSkill.Size = new System.Drawing.Size(36, 20);
            this.label_seekerSkill.TabIndex = 0;
            this.label_seekerSkill.Text = "Skill";
            // 
            // label_major
            // 
            this.label_major.AutoSize = true;
            this.label_major.Location = new System.Drawing.Point(18, 158);
            this.label_major.Name = "label_major";
            this.label_major.Size = new System.Drawing.Size(48, 20);
            this.label_major.TabIndex = 0;
            this.label_major.Text = "Major";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(19, 105);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(46, 20);
            this.label_email.TabIndex = 0;
            this.label_email.Text = "Email";
            // 
            // label_seekername
            // 
            this.label_seekername.AutoSize = true;
            this.label_seekername.Location = new System.Drawing.Point(12, 51);
            this.label_seekername.Name = "label_seekername";
            this.label_seekername.Size = new System.Drawing.Size(101, 20);
            this.label_seekername.TabIndex = 0;
            this.label_seekername.Text = " Seeker Name";
            // 
            // btn_GetAllJO
            // 
            this.btn_GetAllJO.Location = new System.Drawing.Point(280, 83);
            this.btn_GetAllJO.Name = "btn_GetAllJO";
            this.btn_GetAllJO.Size = new System.Drawing.Size(179, 29);
            this.btn_GetAllJO.TabIndex = 3;
            this.btn_GetAllJO.Text = "Get All JobOffer";
            this.btn_GetAllJO.UseVisualStyleBackColor = true;
            this.btn_GetAllJO.Click += new System.EventHandler(this.btn_GetAllJO_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(32, 196);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(477, 295);
            this.txtResponse.TabIndex = 5;
            // 
            // btn_GetAllJS
            // 
            this.btn_GetAllJS.Location = new System.Drawing.Point(280, 129);
            this.btn_GetAllJS.Name = "btn_GetAllJS";
            this.btn_GetAllJS.Size = new System.Drawing.Size(179, 29);
            this.btn_GetAllJS.TabIndex = 6;
            this.btn_GetAllJS.Text = "Get All JobSeeker";
            this.btn_GetAllJS.UseVisualStyleBackColor = true;
            this.btn_GetAllJS.Click += new System.EventHandler(this.btn_GetAllJS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 547);
            this.Controls.Add(this.btn_GetAllJS);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btn_GetAllJO);
            this.Controls.Add(this.group_seeker);
            this.Controls.Add(this.group_joboffer);
            this.Controls.Add(this.label_title);
            this.Name = "Form1";
            this.Text = "ManyJobs API Client";
            this.group_joboffer.ResumeLayout(false);
            this.group_joboffer.PerformLayout();
            this.group_seeker.ResumeLayout(false);
            this.group_seeker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.GroupBox group_joboffer;
        private System.Windows.Forms.Button btn_savejob;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_jobSkill;
        private System.Windows.Forms.TextBox txt_Exp;
        private System.Windows.Forms.TextBox txt_jobTitle;
        private System.Windows.Forms.TextBox txt_jobName;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_jobSkill;
        private System.Windows.Forms.Label label_exp;
        private System.Windows.Forms.Label label_jobtitle;
        private System.Windows.Forms.Label label_jobname;
        private System.Windows.Forms.GroupBox group_seeker;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_seekerSkill;
        private System.Windows.Forms.TextBox txt_major;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_seekername;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_seekerSkill;
        private System.Windows.Forms.Label label_major;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_seekername;
        private System.Windows.Forms.Button btn_saveseeker;
        private System.Windows.Forms.Button btn_GetAllJO;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btn_GetAllJS;
        private System.Windows.Forms.TextBox txt_jobSkill;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_deletejs;
        private System.Windows.Forms.Button btn_editjs;
        private System.Windows.Forms.TextBox txt_idOffer;
        private System.Windows.Forms.Button btn_searchOffer;
        private System.Windows.Forms.TextBox txt_idSeeker;
        private System.Windows.Forms.Button btn_searchJS;
    }
}

