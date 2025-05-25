using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LashaMurgvaLominadzeShraieri.Final
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
            firstNameBox = new TextBox();
            lastNameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addBtn = new Button();
            listBox = new ListBox();
            deleteBtn = new Button();
            updateBtn = new Button();
            SuspendLayout();
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(14, 92);
            firstNameBox.Margin = new Padding(3, 4, 3, 4);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(114, 27);
            firstNameBox.TabIndex = 0;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(135, 92);
            lastNameBox.Margin = new Padding(3, 4, 3, 4);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(114, 27);
            lastNameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 56);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Firstname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 56);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Latname";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(14, 168);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(86, 31);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addUser;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(14, 308);
            listBox.Margin = new Padding(3, 4, 3, 4);
            listBox.Name = "listBox";
            listBox.Size = new Size(886, 264);
            listBox.TabIndex = 5;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(135, 168);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(86, 31);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteUser;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(245, 168);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 7;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(listBox);
            Controls.Add(addBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameBox;
        private TextBox lastNameBox;
        private Label label1;
        private Label label2;
        private Button addBtn;
        private ListBox listBox;
        private Button deleteBtn;
        private Button updateBtn;
    }
}
