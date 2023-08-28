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
        Me.txt = New System.Windows.Forms.TextBox()
        Me.btnxls = New System.Windows.Forms.Button()
        Me.btndocx = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(13, 82)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(329, 20)
        Me.txt.TabIndex = 0
        '
        'btnxls
        '
        Me.btnxls.BackgroundImage = Global.AppInteropVB.My.Resources.Resources.xls
        Me.btnxls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnxls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnxls.Location = New System.Drawing.Point(218, 153)
        Me.btnxls.Name = "btnxls"
        Me.btnxls.Size = New System.Drawing.Size(73, 60)
        Me.btnxls.TabIndex = 2
        Me.btnxls.UseVisualStyleBackColor = True
        '
        'btndocx
        '
        Me.btndocx.BackgroundImage = Global.AppInteropVB.My.Resources.Resources.doc
        Me.btndocx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btndocx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndocx.Location = New System.Drawing.Point(54, 153)
        Me.btndocx.Name = "btndocx"
        Me.btndocx.Size = New System.Drawing.Size(73, 60)
        Me.btndocx.TabIndex = 1
        Me.btndocx.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Aplicacion Interop Word/Excel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(354, 281)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnxls)
        Me.Controls.Add(Me.btndocx)
        Me.Controls.Add(Me.txt)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt As TextBox
    Friend WithEvents btndocx As Button
    Friend WithEvents btnxls As Button
    Friend WithEvents Label1 As Label
End Class
