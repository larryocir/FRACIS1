<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnDownloadReport = New System.Windows.Forms.Button()
        Me.btnShowReport = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbBarangay = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.radMMAnimals = New System.Windows.Forms.RadioButton()
        Me.radMMember = New System.Windows.Forms.RadioButton()
        Me.radMMCommodities = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgrdreport = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dgrdreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 39)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1047, 77)
        Me.Panel5.TabIndex = 20
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnDownloadReport)
        Me.Panel6.Controls.Add(Me.btnShowReport)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(661, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(386, 77)
        Me.Panel6.TabIndex = 11
        '
        'btnDownloadReport
        '
        Me.btnDownloadReport.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnDownloadReport.FlatAppearance.BorderSize = 0
        Me.btnDownloadReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownloadReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownloadReport.Location = New System.Drawing.Point(199, 24)
        Me.btnDownloadReport.Name = "btnDownloadReport"
        Me.btnDownloadReport.Size = New System.Drawing.Size(151, 26)
        Me.btnDownloadReport.TabIndex = 6
        Me.btnDownloadReport.Text = "Download Report(s)"
        Me.btnDownloadReport.UseVisualStyleBackColor = False
        '
        'btnShowReport
        '
        Me.btnShowReport.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnShowReport.FlatAppearance.BorderSize = 0
        Me.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowReport.Location = New System.Drawing.Point(44, 24)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(131, 26)
        Me.btnShowReport.TabIndex = 5
        Me.btnShowReport.Text = "Show Report(s)"
        Me.btnShowReport.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cmbBarangay)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(322, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(725, 77)
        Me.Panel2.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Barangay:"
        '
        'cmbBarangay
        '
        Me.cmbBarangay.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBarangay.FormattingEnabled = True
        Me.cmbBarangay.Items.AddRange(New Object() {"ALL", "ALDEZAR", "ALTEZA", "ANIB", "AWAYAN", "AZUCENA", "BAGONG SIRANG", "BINAHIAN", "BOLO NORTE", "BOLO SUR", "BULAN", "BULAWAN", "CABUYAO", "CAIMA", "CALAGBANGAN", "CALAMPINAY", "CARAYRAYAN", "COTMO", "GABI", "GAONGAN", "IMPIG", "LIPLIP", "LUBIGAN JR.", "LUBIGAN SR.", "MALAGUICO", "MALUBAGO", "MANANGLE", "MANGAPO", "MANGGA", "MANLUBANG", "MANTILLA", "NORTH CENTRO", "NORTH VILLAZAR", "SAGRADA FAMILIA", "SALANDA", "SALVACION", "SAN ISIDRO", "SAN VINCENTE", "SERRANZANA", "SOUTH CENTRO", "SOUTH VILLAZAR", "TAISAN", "TARA", "TIBLE", "TULA-TULA", "VIGAAN", "YABO"})
        Me.cmbBarangay.Location = New System.Drawing.Point(35, 36)
        Me.cmbBarangay.Name = "cmbBarangay"
        Me.cmbBarangay.Size = New System.Drawing.Size(283, 25)
        Me.cmbBarangay.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.radMMAnimals)
        Me.Panel7.Controls.Add(Me.radMMember)
        Me.Panel7.Controls.Add(Me.radMMCommodities)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(322, 77)
        Me.Panel7.TabIndex = 9
        '
        'radMMAnimals
        '
        Me.radMMAnimals.AutoSize = True
        Me.radMMAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radMMAnimals.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMMAnimals.Location = New System.Drawing.Point(16, 51)
        Me.radMMAnimals.Name = "radMMAnimals"
        Me.radMMAnimals.Size = New System.Drawing.Size(257, 22)
        Me.radMMAnimals.TabIndex = 19
        Me.radMMAnimals.TabStop = True
        Me.radMMAnimals.Text = "Masterlist of Members w/ Animals"
        Me.radMMAnimals.UseVisualStyleBackColor = True
        '
        'radMMember
        '
        Me.radMMember.AutoSize = True
        Me.radMMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radMMember.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMMember.Location = New System.Drawing.Point(16, 5)
        Me.radMMember.Name = "radMMember"
        Me.radMMember.Size = New System.Drawing.Size(179, 22)
        Me.radMMember.TabIndex = 17
        Me.radMMember.TabStop = True
        Me.radMMember.Text = "Masterlist of Members"
        Me.radMMember.UseVisualStyleBackColor = True
        '
        'radMMCommodities
        '
        Me.radMMCommodities.AutoSize = True
        Me.radMMCommodities.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radMMCommodities.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMMCommodities.Location = New System.Drawing.Point(16, 28)
        Me.radMMCommodities.Name = "radMMCommodities"
        Me.radMMCommodities.Size = New System.Drawing.Size(245, 22)
        Me.radMMCommodities.TabIndex = 18
        Me.radMMCommodities.TabStop = True
        Me.radMMCommodities.Text = "Masterlist of Members w/ Crops"
        Me.radMMCommodities.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1047, 5)
        Me.Panel4.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(495, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "---No Result Found.---"
        Me.Label4.Visible = False
        '
        'dgrdreport
        '
        Me.dgrdreport.AllowUserToAddRows = False
        Me.dgrdreport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(75, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdreport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgrdreport.ColumnHeadersHeight = 40
        Me.dgrdreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgrdreport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column10, Me.Column11, Me.Column12, Me.Column7, Me.Column8})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrdreport.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgrdreport.EnableHeadersVisualStyles = False
        Me.dgrdreport.Location = New System.Drawing.Point(12, 3)
        Me.dgrdreport.Name = "dgrdreport"
        Me.dgrdreport.ReadOnly = True
        Me.dgrdreport.RowHeadersVisible = False
        Me.dgrdreport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgrdreport.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrdreport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrdreport.Size = New System.Drawing.Size(1023, 502)
        Me.dgrdreport.TabIndex = 0
        '
        'Column9
        '
        Me.Column9.HeaderText = "RSBSA Number"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "First Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Last Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Middle Name"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Ext. Name"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Barangay"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'Column10
        '
        Me.Column10.HeaderText = "Municipality"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Province"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 120
        '
        'Column12
        '
        Me.Column12.HeaderText = "Birthday"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Gender"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "Contact Number"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 130
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.dgrdreport)
        Me.Panel3.Location = New System.Drawing.Point(0, 119)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1047, 517)
        Me.Panel3.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REPORTS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1047, 34)
        Me.Panel1.TabIndex = 16
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 636)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReport"
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.dgrdreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents dgrdreport As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents radMMAnimals As RadioButton
    Friend WithEvents radMMember As RadioButton
    Friend WithEvents radMMCommodities As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbBarangay As ComboBox
    Friend WithEvents btnDownloadReport As Button
    Friend WithEvents btnShowReport As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
