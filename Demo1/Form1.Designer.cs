namespace Demo1;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        button6 = new System.Windows.Forms.Button();
        button7 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label1.ForeColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(225, 153);
        label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(305, 40);
        label1.TabIndex = 0;
        label1.Text = "I am a label!";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label1.Click += label1_Click;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(225, 207);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(146, 34);
        button1.TabIndex = 1;
        button1.Text = "Text";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(377, 207);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(153, 34);
        button2.TabIndex = 1;
        button2.Text = "Font";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(225, 247);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(146, 34);
        button3.TabIndex = 1;
        button3.Text = "Color";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(377, 247);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(153, 34);
        button4.TabIndex = 1;
        button4.Text = "Border";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new System.Drawing.Point(225, 287);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(146, 34);
        button5.TabIndex = 1;
        button5.Text = "AutoSize";
        button5.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        button6.Location = new System.Drawing.Point(377, 287);
        button6.Name = "button6";
        button6.Size = new System.Drawing.Size(153, 34);
        button6.TabIndex = 1;
        button6.Text = "Move";
        button6.UseVisualStyleBackColor = true;
        // 
        // button7
        // 
        button7.Location = new System.Drawing.Point(225, 327);
        button7.Name = "button7";
        button7.Size = new System.Drawing.Size(305, 36);
        button7.TabIndex = 2;
        button7.Text = "Reset";
        button7.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.MidnightBlue;
        ClientSize = new System.Drawing.Size(784, 601);
        Controls.Add(button7);
        Controls.Add(button6);
        Controls.Add(button4);
        Controls.Add(button2);
        Controls.Add(button5);
        Controls.Add(button3);
        Controls.Add(button1);
        Controls.Add(label1);
        Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        Margin = new System.Windows.Forms.Padding(5);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button7;

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label1;

    #endregion
}