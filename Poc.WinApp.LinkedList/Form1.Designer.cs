namespace Poc.WinApp.LinkedList
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
            textBoxValue = new TextBox();
            buttonAddTop = new Button();
            buttonAddLast = new Button();
            buttonAddAbove = new Button();
            buttonBelow = new Button();
            textBoxData = new TextBox();
            textBoxFind = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            buttonMoveUp = new Button();
            buttonMoveDown = new Button();
            buttonRemove = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxValue
            // 
            textBoxValue.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValue.Location = new Point(757, 117);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(156, 20);
            textBoxValue.TabIndex = 0;
            // 
            // buttonAddTop
            // 
            buttonAddTop.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddTop.Location = new Point(757, 290);
            buttonAddTop.Name = "buttonAddTop";
            buttonAddTop.Size = new Size(75, 23);
            buttonAddTop.TabIndex = 1;
            buttonAddTop.Text = "Add to Top";
            buttonAddTop.UseVisualStyleBackColor = true;
            // 
            // buttonAddLast
            // 
            buttonAddLast.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddLast.Location = new Point(838, 290);
            buttonAddLast.Name = "buttonAddLast";
            buttonAddLast.Size = new Size(75, 23);
            buttonAddLast.TabIndex = 2;
            buttonAddLast.Text = "Add to Last";
            buttonAddLast.UseVisualStyleBackColor = true;
            // 
            // buttonAddAbove
            // 
            buttonAddAbove.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddAbove.Location = new Point(757, 381);
            buttonAddAbove.Name = "buttonAddAbove";
            buttonAddAbove.Size = new Size(75, 23);
            buttonAddAbove.TabIndex = 3;
            buttonAddAbove.Text = "Add above";
            buttonAddAbove.UseVisualStyleBackColor = true;
            // 
            // buttonBelow
            // 
            buttonBelow.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBelow.Location = new Point(838, 381);
            buttonBelow.Name = "buttonBelow";
            buttonBelow.Size = new Size(75, 23);
            buttonBelow.TabIndex = 4;
            buttonBelow.Text = "Add below";
            buttonBelow.UseVisualStyleBackColor = true;
            // 
            // textBoxData
            // 
            textBoxData.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxData.Location = new Point(42, 99);
            textBoxData.Multiline = true;
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(693, 366);
            textBoxData.TabIndex = 5;
            // 
            // textBoxFind
            // 
            textBoxFind.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFind.Location = new Point(757, 352);
            textBoxFind.Name = "textBoxFind";
            textBoxFind.Size = new Size(156, 20);
            textBoxFind.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(757, 99);
            label1.Name = "label1";
            label1.Size = new Size(34, 13);
            label1.TabIndex = 7;
            label1.Text = "Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(757, 334);
            label2.Name = "label2";
            label2.Size = new Size(27, 13);
            label2.TabIndex = 8;
            label2.Text = "Find";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(757, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(156, 129);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(18, 97);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(58, 17);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Cancel";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(18, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(69, 17);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Complete";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(18, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 17);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Producing";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(18, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 17);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Available";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(42, 41);
            label3.Name = "label3";
            label3.Size = new Size(409, 37);
            label3.TabIndex = 10;
            label3.Text = "Proof Concept Linked List";
            // 
            // buttonMoveUp
            // 
            buttonMoveUp.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMoveUp.Location = new Point(757, 410);
            buttonMoveUp.Name = "buttonMoveUp";
            buttonMoveUp.Size = new Size(75, 23);
            buttonMoveUp.TabIndex = 11;
            buttonMoveUp.Text = "Move Up";
            buttonMoveUp.UseVisualStyleBackColor = true;
            // 
            // buttonMoveDown
            // 
            buttonMoveDown.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMoveDown.Location = new Point(838, 410);
            buttonMoveDown.Name = "buttonMoveDown";
            buttonMoveDown.Size = new Size(75, 23);
            buttonMoveDown.TabIndex = 12;
            buttonMoveDown.Text = "Move Down";
            buttonMoveDown.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemove.Location = new Point(757, 439);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 13;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 493);
            Controls.Add(buttonRemove);
            Controls.Add(buttonMoveDown);
            Controls.Add(buttonMoveUp);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxFind);
            Controls.Add(textBoxData);
            Controls.Add(buttonBelow);
            Controls.Add(buttonAddAbove);
            Controls.Add(buttonAddLast);
            Controls.Add(buttonAddTop);
            Controls.Add(textBoxValue);
            Name = "Form1";
            Text = "PoC Linked List";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxValue;
        private Button buttonAddTop;
        private Button buttonAddLast;
        private Button buttonAddAbove;
        private Button buttonBelow;
        private TextBox textBoxData;
        private TextBox textBoxFind;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private Button buttonMoveUp;
        private Button buttonMoveDown;
        private Button buttonRemove;
    }
}