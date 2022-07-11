Namespace ubiLease.UI.BusinessUi.PS 
 
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _  
    Partial Class PSF105 
        Inherits CommonControls.UiControl                                  
                                                                           
        'UserControl overrides dispose to clean up the component list.     
        <System.Diagnostics.DebuggerNonUserCode()> _                       
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)        
            If disposing AndAlso components IsNot Nothing Then             
                components.Dispose()                                       
            End If                                                         
            MyBase.Dispose(disposing)                                      
        End Sub                                                            
                                                                           
        'Required by the Windows Form Designer                             
        Private components As System.ComponentModel.IContainer             
                                                                           
        'NOTE: The following procedure is required by the Windows Form Designer   
        'It can be modified using the Windows Form Designer.                      
        'Do not modify it using the code editor.                                  
        <System.Diagnostics.DebuggerStepThrough()> _                              
        Private Sub InitializeComponent()                                         
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSF105)) 
            Me.picCriteria = New System.Windows.Forms.PictureBox 
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit() 
            Me.SuspendLayout() 
            '
            'picCriteria
            '
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(5, 5)
            Me.picCriteria.Name = "picCriteria_1"
            Me.picCriteria.Size = New System.Drawing.Size(790, 60)
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.TabStop = False
            '                                                                      
            'PSF105 
            '                                                                      
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)         
            Me.Controls.Add(Me.picCriteria) 
            Me.Name = "PSF105"                                           
            Me.Size = New System.Drawing.Size(800, 640)                            
            Me.ResumeLayout(False)                                                 
 
        End Sub                                                                                                                                   
 
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox 
 
    End Class 
 
End Namespace 