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
        Me.chkTopMost = New System.Windows.Forms.CheckBox()
        Me.chkMouseMove = New System.Windows.Forms.CheckBox()
        Me.lblZpos = New System.Windows.Forms.Label()
        Me.lblXpos = New System.Windows.Forms.Label()
        Me.nmbCrtNum = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtZpos = New System.Windows.Forms.TextBox()
        Me.txtXpos = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.nmbCrtNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkTopMost
        '
        Me.chkTopMost.AutoSize = True
        Me.chkTopMost.BackColor = System.Drawing.Color.LightGray
        Me.chkTopMost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTopMost.Location = New System.Drawing.Point(16, 755)
        Me.chkTopMost.Name = "chkTopMost"
        Me.chkTopMost.Size = New System.Drawing.Size(81, 20)
        Me.chkTopMost.TabIndex = 52
        Me.chkTopMost.Text = "TopMost"
        Me.chkTopMost.UseVisualStyleBackColor = False
        '
        'chkMouseMove
        '
        Me.chkMouseMove.AutoSize = True
        Me.chkMouseMove.BackColor = System.Drawing.Color.LightGray
        Me.chkMouseMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMouseMove.Location = New System.Drawing.Point(16, 735)
        Me.chkMouseMove.Name = "chkMouseMove"
        Me.chkMouseMove.Size = New System.Drawing.Size(121, 20)
        Me.chkMouseMove.TabIndex = 51
        Me.chkMouseMove.Text = "CtrlMouseMove"
        Me.chkMouseMove.UseVisualStyleBackColor = False
        '
        'lblZpos
        '
        Me.lblZpos.AutoSize = True
        Me.lblZpos.BackColor = System.Drawing.Color.LightGray
        Me.lblZpos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZpos.Location = New System.Drawing.Point(20, 120)
        Me.lblZpos.Name = "lblZpos"
        Me.lblZpos.Size = New System.Drawing.Size(48, 16)
        Me.lblZpos.TabIndex = 50
        Me.lblZpos.Text = "Z pos: "
        '
        'lblXpos
        '
        Me.lblXpos.AutoSize = True
        Me.lblXpos.BackColor = System.Drawing.Color.LightGray
        Me.lblXpos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXpos.Location = New System.Drawing.Point(20, 99)
        Me.lblXpos.Name = "lblXpos"
        Me.lblXpos.Size = New System.Drawing.Size(48, 16)
        Me.lblXpos.TabIndex = 48
        Me.lblXpos.Text = "X pos: "
        '
        'nmbCrtNum
        '
        Me.nmbCrtNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmbCrtNum.Location = New System.Drawing.Point(74, 145)
        Me.nmbCrtNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmbCrtNum.Name = "nmbCrtNum"
        Me.nmbCrtNum.Size = New System.Drawing.Size(53, 22)
        Me.nmbCrtNum.TabIndex = 53
        Me.nmbCrtNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Crt Num"
        '
        'txtZpos
        '
        Me.txtZpos.Location = New System.Drawing.Point(74, 119)
        Me.txtZpos.Name = "txtZpos"
        Me.txtZpos.Size = New System.Drawing.Size(63, 20)
        Me.txtZpos.TabIndex = 55
        '
        'txtXpos
        '
        Me.txtXpos.Location = New System.Drawing.Point(74, 98)
        Me.txtXpos.Name = "txtXpos"
        Me.txtXpos.Size = New System.Drawing.Size(63, 20)
        Me.txtXpos.TabIndex = 56
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 21)
        Me.Button1.TabIndex = 57
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(1324, 831)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtXpos)
        Me.Controls.Add(Me.txtZpos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nmbCrtNum)
        Me.Controls.Add(Me.chkTopMost)
        Me.Controls.Add(Me.chkMouseMove)
        Me.Controls.Add(Me.lblZpos)
        Me.Controls.Add(Me.lblXpos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nmbCrtNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkTopMost As CheckBox
    Friend WithEvents chkMouseMove As CheckBox
    Friend WithEvents lblZpos As Label
    Friend WithEvents lblXpos As Label
    Friend WithEvents nmbCrtNum As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents txtZpos As TextBox
    Friend WithEvents txtXpos As TextBox
    Friend WithEvents Button1 As Button
End Class
