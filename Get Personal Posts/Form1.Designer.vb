<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacebookSpam
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
        Me.components = New System.ComponentModel.Container()
        Me.Facebook = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.btnGO = New System.Windows.Forms.Button()
        Me.btnStartScroll = New System.Windows.Forms.Button()
        Me.btnStopScroll = New System.Windows.Forms.Button()
        Me.timerscroll = New System.Windows.Forms.Timer(Me.components)
        Me.btnFindIDs = New System.Windows.Forms.Button()
        Me.PostIDS = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Facebook
        '
        Me.Facebook.Location = New System.Drawing.Point(12, 127)
        Me.Facebook.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Facebook.Name = "Facebook"
        Me.Facebook.Size = New System.Drawing.Size(1348, 748)
        Me.Facebook.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "URL: "
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(54, 13)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(414, 20)
        Me.txtURL.TabIndex = 2
        '
        'btnGO
        '
        Me.btnGO.Location = New System.Drawing.Point(474, 8)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(57, 29)
        Me.btnGO.TabIndex = 3
        Me.btnGO.Text = "Go"
        Me.btnGO.UseVisualStyleBackColor = True
        '
        'btnStartScroll
        '
        Me.btnStartScroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartScroll.Location = New System.Drawing.Point(20, 39)
        Me.btnStartScroll.Name = "btnStartScroll"
        Me.btnStartScroll.Size = New System.Drawing.Size(161, 48)
        Me.btnStartScroll.TabIndex = 4
        Me.btnStartScroll.Text = "Start Scroll"
        Me.btnStartScroll.UseVisualStyleBackColor = True
        '
        'btnStopScroll
        '
        Me.btnStopScroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopScroll.Location = New System.Drawing.Point(210, 39)
        Me.btnStopScroll.Name = "btnStopScroll"
        Me.btnStopScroll.Size = New System.Drawing.Size(156, 48)
        Me.btnStopScroll.TabIndex = 5
        Me.btnStopScroll.Text = "Stop Scroll"
        Me.btnStopScroll.UseVisualStyleBackColor = True
        '
        'timerscroll
        '
        '
        'btnFindIDs
        '
        Me.btnFindIDs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindIDs.Location = New System.Drawing.Point(372, 42)
        Me.btnFindIDs.Name = "btnFindIDs"
        Me.btnFindIDs.Size = New System.Drawing.Size(159, 48)
        Me.btnFindIDs.TabIndex = 6
        Me.btnFindIDs.Text = "Find Post IDS"
        Me.btnFindIDs.UseVisualStyleBackColor = True
        '
        'PostIDS
        '
        Me.PostIDS.Location = New System.Drawing.Point(550, 8)
        Me.PostIDS.Name = "PostIDS"
        Me.PostIDS.Size = New System.Drawing.Size(801, 113)
        Me.PostIDS.TabIndex = 7
        Me.PostIDS.Text = ""
        '
        'FacebookSpam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1372, 887)
        Me.Controls.Add(Me.PostIDS)
        Me.Controls.Add(Me.btnFindIDs)
        Me.Controls.Add(Me.btnStopScroll)
        Me.Controls.Add(Me.btnStartScroll)
        Me.Controls.Add(Me.btnGO)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Facebook)
        Me.Name = "FacebookSpam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Get Personal Posts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Facebook As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents txtURL As TextBox
    Friend WithEvents btnGO As Button
    Friend WithEvents btnStartScroll As Button
    Friend WithEvents btnStopScroll As Button
    Friend WithEvents timerscroll As Timer
    Friend WithEvents btnFindIDs As Button
    Friend WithEvents PostIDS As RichTextBox
End Class
