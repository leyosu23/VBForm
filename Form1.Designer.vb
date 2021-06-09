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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtValue1 = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtValue2 = New System.Windows.Forms.TextBox()
        Me.lblAddEqual = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(14, 14)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(66, 14)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 22)
        Me.txtName.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(17, 45)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 30)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnMessage
        '
        Me.btnMessage.Location = New System.Drawing.Point(110, 45)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(75, 30)
        Me.btnMessage.TabIndex = 3
        Me.btnMessage.Text = "&Message"
        Me.btnMessage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(199, 45)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtValue1
        '
        Me.txtValue1.Location = New System.Drawing.Point(17, 92)
        Me.txtValue1.Name = "txtValue1"
        Me.txtValue1.Size = New System.Drawing.Size(50, 22)
        Me.txtValue1.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(73, 91)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(23, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtValue2
        '
        Me.txtValue2.Location = New System.Drawing.Point(102, 91)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(50, 22)
        Me.txtValue2.TabIndex = 7
        '
        'lblAddEqual
        '
        Me.lblAddEqual.AutoSize = True
        Me.lblAddEqual.Location = New System.Drawing.Point(158, 94)
        Me.lblAddEqual.Name = "lblAddEqual"
        Me.lblAddEqual.Size = New System.Drawing.Size(16, 17)
        Me.lblAddEqual.TabIndex = 8
        Me.lblAddEqual.Text = "="
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(180, 91)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(50, 22)
        Me.txtResult.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 382)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblAddEqual)
        Me.Controls.Add(Me.txtValue2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtValue1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnMessage As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtValue1 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtValue2 As TextBox
    Friend WithEvents lblAddEqual As Label
    Friend WithEvents txtResult As TextBox
End Class
