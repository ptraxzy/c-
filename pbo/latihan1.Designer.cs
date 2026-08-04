namespace pbo.pertemuan2;

partial class Latihan1
{
    private Label lblJudul;
    private Button btnTampil;
    private Label lblOutput;

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
        lblJudul = new Label();
        btnTampil = new Button();
        lblOutput = new Label();
        SuspendLayout();
        // 
        // lblJudul
        // 
        lblJudul.AutoSize = true;
        lblJudul.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblJudul.Location = new Point(275, 74);
        lblJudul.Name = "lblJudul";
        lblJudul.Size = new Size(257, 30);
        lblJudul.TabIndex = 0;
        lblJudul.Text = "Latihan 1 - Hello World";
        // 
        // btnTampil
        // 
        btnTampil.Location = new Point(329, 151);
        btnTampil.Name = "btnTampil";
        btnTampil.Size = new Size(141, 38);
        btnTampil.TabIndex = 1;
        btnTampil.Text = "Tampilkan Output";
        btnTampil.UseVisualStyleBackColor = true;
        btnTampil.Click += btnTampil_Click;
        // 
        // lblOutput
        // 
        lblOutput.BorderStyle = BorderStyle.FixedSingle;
        lblOutput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblOutput.Location = new Point(230, 228);
        lblOutput.Name = "lblOutput";
        lblOutput.Size = new Size(332, 52);
        lblOutput.TabIndex = 2;
        lblOutput.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // Latihan1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblOutput);
        Controls.Add(btnTampil);
        Controls.Add(lblJudul);
        Name = "Latihan1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Pertemuan 2 - Latihan 1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
