<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
      PictureBox1 = New PictureBox()
      PictureBox2 = New PictureBox()
      CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
      CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
      SuspendLayout()
      ' 
      ' PictureBox1
      ' 
      PictureBox1.Location = New Point(12, 22)
      PictureBox1.Name = "PictureBox1"
      PictureBox1.Size = New Size(202, 234)
      PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
      PictureBox1.TabIndex = 0
      PictureBox1.TabStop = False
      ' 
      ' PictureBox2
      ' 
      PictureBox2.Location = New Point(220, 22)
      PictureBox2.Name = "PictureBox2"
      PictureBox2.Size = New Size(202, 234)
      PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
      PictureBox2.TabIndex = 1
      PictureBox2.TabStop = False
      ' 
      ' Form1
      ' 
      AutoScaleDimensions = New SizeF(7F, 15F)
      AutoScaleMode = AutoScaleMode.Font
      ClientSize = New Size(434, 268)
      Controls.Add(PictureBox2)
      Controls.Add(PictureBox1)
      Name = "Form1"
      Text = "Form1"
      CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
      CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
      ResumeLayout(False)
   End Sub

   Friend WithEvents PictureBox1 As PictureBox
   Friend WithEvents PictureBox2 As PictureBox
End Class
