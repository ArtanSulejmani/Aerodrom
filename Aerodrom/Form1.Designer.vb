<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbAirports = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbDestinations = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbMaxPrice = New System.Windows.Forms.Label()
        Me.tbAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbAirports
        '
        Me.lbAirports.FormattingEnabled = True
        Me.lbAirports.ItemHeight = 20
        Me.lbAirports.Location = New System.Drawing.Point(18, 48)
        Me.lbAirports.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbAirports.Name = "lbAirports"
        Me.lbAirports.Size = New System.Drawing.Size(440, 344)
        Me.lbAirports.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 417)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(442, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Додади нов аеродром"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(18, 478)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(442, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Избриши аеродром"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(18, 537)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(442, 35)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Додади дестинација"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Аеродроми"
        '
        'lbDestinations
        '
        Me.lbDestinations.FormattingEnabled = True
        Me.lbDestinations.ItemHeight = 20
        Me.lbDestinations.Location = New System.Drawing.Point(500, 48)
        Me.lbDestinations.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbDestinations.Name = "lbDestinations"
        Me.lbDestinations.Size = New System.Drawing.Size(445, 344)
        Me.lbDestinations.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(500, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Дестинации"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(495, 398)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Дестинации"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(500, 432)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Најскапа дестинација"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(495, 494)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(290, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Просечна должина на дестинациите"
        '
        'tbMaxPrice
        '
        Me.tbMaxPrice.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbMaxPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMaxPrice.Location = New System.Drawing.Point(500, 460)
        Me.tbMaxPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tbMaxPrice.Name = "tbMaxPrice"
        Me.tbMaxPrice.Size = New System.Drawing.Size(447, 34)
        Me.tbMaxPrice.TabIndex = 10
        '
        'tbAverage
        '
        Me.tbAverage.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbAverage.Location = New System.Drawing.Point(500, 537)
        Me.tbAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tbAverage.Name = "tbAverage"
        Me.tbAverage.Size = New System.Drawing.Size(447, 35)
        Me.tbAverage.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 591)
        Me.Controls.Add(Me.tbAverage)
        Me.Controls.Add(Me.tbMaxPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbDestinations)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbAirports)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Додади нов аеродром"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbAirports As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbDestinations As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbMaxPrice As System.Windows.Forms.Label
    Friend WithEvents tbAverage As System.Windows.Forms.Label



    
End Class
