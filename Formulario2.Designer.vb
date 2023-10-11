<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Check1 = New CheckBox()
        Check2 = New CheckBox()
        Check3 = New CheckBox()
        Check4 = New CheckBox()
        Label1 = New Label()
        Nike = New Label()
        btnPagar = New Button()
        btnRegresar = New Button()
        SuspendLayout()
        ' 
        ' Check1
        ' 
        Check1.AutoSize = True
        Check1.Location = New Point(29, 69)
        Check1.Name = "Check1"
        Check1.Size = New Size(65, 19)
        Check1.TabIndex = 0
        Check1.Text = "Credito"
        Check1.UseVisualStyleBackColor = True
        ' 
        ' Check2
        ' 
        Check2.AutoSize = True
        Check2.Location = New Point(194, 69)
        Check2.Name = "Check2"
        Check2.Size = New Size(68, 19)
        Check2.TabIndex = 1
        Check2.Text = "Efectivo"
        Check2.UseVisualStyleBackColor = True
        ' 
        ' Check3
        ' 
        Check3.AutoSize = True
        Check3.Location = New Point(29, 142)
        Check3.Name = "Check3"
        Check3.Size = New Size(70, 19)
        Check3.TabIndex = 2
        Check3.Text = "contado"
        Check3.UseVisualStyleBackColor = True
        ' 
        ' Check4
        ' 
        Check4.AutoSize = True
        Check4.Location = New Point(194, 142)
        Check4.Name = "Check4"
        Check4.Size = New Size(71, 19)
        Check4.TabIndex = 3
        Check4.Text = "sin pago"
        Check4.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 15)
        Label1.TabIndex = 4
        Label1.Text = "Seleccione un tipo de pago"
        ' 
        ' Nike
        ' 
        Nike.AutoSize = True
        Nike.Location = New Point(73, 180)
        Nike.Name = "Nike"
        Nike.Size = New Size(56, 15)
        Nike.TabIndex = 5
        Nike.Text = "resultado"
        ' 
        ' btnPagar
        ' 
        btnPagar.Location = New Point(39, 215)
        btnPagar.Name = "btnPagar"
        btnPagar.Size = New Size(75, 23)
        btnPagar.TabIndex = 6
        btnPagar.Text = "Pagar"
        btnPagar.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(184, 215)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(75, 23)
        btnRegresar.TabIndex = 7
        btnRegresar.Text = "Regresar"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' Formulario2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(334, 261)
        Controls.Add(btnRegresar)
        Controls.Add(btnPagar)
        Controls.Add(Nike)
        Controls.Add(Label1)
        Controls.Add(Check4)
        Controls.Add(Check3)
        Controls.Add(Check2)
        Controls.Add(Check1)
        Name = "Formulario2"
        Text = "Formulario2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Check1 As CheckBox
    Friend WithEvents Check2 As CheckBox
    Friend WithEvents Check3 As CheckBox
    Friend WithEvents Check4 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Nike As Label
    Friend WithEvents btnPagar As Button
    Friend WithEvents btnRegresar As Button
End Class
