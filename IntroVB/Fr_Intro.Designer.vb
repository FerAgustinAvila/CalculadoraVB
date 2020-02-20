<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Intro
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
        Me.Lbl_Hola = New System.Windows.Forms.Label()
        Me.Lbl_Valor1 = New System.Windows.Forms.Label()
        Me.Lbl_Valor2 = New System.Windows.Forms.Label()
        Me.Txt_Valor1 = New System.Windows.Forms.TextBox()
        Me.Txt_Valor2 = New System.Windows.Forms.TextBox()
        Me.Btn_Suma = New System.Windows.Forms.Button()
        Me.Btn_Resta = New System.Windows.Forms.Button()
        Me.Btn_Multi = New System.Windows.Forms.Button()
        Me.Btn_Divi = New System.Windows.Forms.Button()
        Me.Total = New System.Windows.Forms.Label()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Dgb_Datos = New System.Windows.Forms.DataGridView()
        Me.Operaciion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Result = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Hola
        '
        Me.Lbl_Hola.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Hola.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_Hola.Location = New System.Drawing.Point(217, 29)
        Me.Lbl_Hola.Name = "Lbl_Hola"
        Me.Lbl_Hola.Size = New System.Drawing.Size(253, 39)
        Me.Lbl_Hola.TabIndex = 0
        Me.Lbl_Hola.Text = "Hola mundo!"
        '
        'Lbl_Valor1
        '
        Me.Lbl_Valor1.AutoSize = True
        Me.Lbl_Valor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Valor1.Location = New System.Drawing.Point(141, 100)
        Me.Lbl_Valor1.Name = "Lbl_Valor1"
        Me.Lbl_Valor1.Size = New System.Drawing.Size(99, 16)
        Me.Lbl_Valor1.TabIndex = 2
        Me.Lbl_Valor1.Text = "Ingrese valor 1:"
        '
        'Lbl_Valor2
        '
        Me.Lbl_Valor2.AutoSize = True
        Me.Lbl_Valor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Valor2.Location = New System.Drawing.Point(141, 126)
        Me.Lbl_Valor2.Name = "Lbl_Valor2"
        Me.Lbl_Valor2.Size = New System.Drawing.Size(99, 16)
        Me.Lbl_Valor2.TabIndex = 3
        Me.Lbl_Valor2.Text = "Ingrese valor 2:"
        '
        'Txt_Valor1
        '
        Me.Txt_Valor1.Location = New System.Drawing.Point(246, 96)
        Me.Txt_Valor1.Name = "Txt_Valor1"
        Me.Txt_Valor1.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Valor1.TabIndex = 4
        Me.Txt_Valor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_Valor2
        '
        Me.Txt_Valor2.Location = New System.Drawing.Point(246, 122)
        Me.Txt_Valor2.Name = "Txt_Valor2"
        Me.Txt_Valor2.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Valor2.TabIndex = 5
        Me.Txt_Valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Btn_Suma
        '
        Me.Btn_Suma.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Suma.Location = New System.Drawing.Point(286, 171)
        Me.Btn_Suma.Name = "Btn_Suma"
        Me.Btn_Suma.Size = New System.Drawing.Size(59, 48)
        Me.Btn_Suma.TabIndex = 6
        Me.Btn_Suma.Text = "+"
        Me.Btn_Suma.UseVisualStyleBackColor = True
        '
        'Btn_Resta
        '
        Me.Btn_Resta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Resta.Location = New System.Drawing.Point(221, 171)
        Me.Btn_Resta.Name = "Btn_Resta"
        Me.Btn_Resta.Size = New System.Drawing.Size(59, 48)
        Me.Btn_Resta.TabIndex = 7
        Me.Btn_Resta.Text = "-"
        Me.Btn_Resta.UseVisualStyleBackColor = True
        '
        'Btn_Multi
        '
        Me.Btn_Multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Multi.Location = New System.Drawing.Point(221, 225)
        Me.Btn_Multi.Name = "Btn_Multi"
        Me.Btn_Multi.Size = New System.Drawing.Size(59, 48)
        Me.Btn_Multi.TabIndex = 9
        Me.Btn_Multi.Text = "x"
        Me.Btn_Multi.UseVisualStyleBackColor = True
        '
        'Btn_Divi
        '
        Me.Btn_Divi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Divi.Location = New System.Drawing.Point(286, 225)
        Me.Btn_Divi.Name = "Btn_Divi"
        Me.Btn_Divi.Size = New System.Drawing.Size(59, 48)
        Me.Btn_Divi.TabIndex = 8
        Me.Btn_Divi.Text = "/"
        Me.Btn_Divi.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(192, 303)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(48, 16)
        Me.Total.TabIndex = 10
        Me.Total.Text = "Total:  "
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Resultado.Location = New System.Drawing.Point(246, 299)
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.ReadOnly = True
        Me.Txt_Resultado.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Resultado.TabIndex = 11
        Me.Txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Dgb_Datos
        '
        Me.Dgb_Datos.AllowUserToAddRows = False
        Me.Dgb_Datos.AllowUserToDeleteRows = False
        Me.Dgb_Datos.AllowUserToResizeColumns = False
        Me.Dgb_Datos.AllowUserToResizeRows = False
        Me.Dgb_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgb_Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Operaciion, Me.Result})
        Me.Dgb_Datos.Location = New System.Drawing.Point(411, 96)
        Me.Dgb_Datos.Name = "Dgb_Datos"
        Me.Dgb_Datos.ReadOnly = True
        Me.Dgb_Datos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dgb_Datos.Size = New System.Drawing.Size(236, 223)
        Me.Dgb_Datos.TabIndex = 12
        '
        'Operaciion
        '
        Me.Operaciion.HeaderText = "Operaciion"
        Me.Operaciion.Name = "Operaciion"
        Me.Operaciion.ReadOnly = True
        '
        'Result
        '
        Me.Result.HeaderText = "Result"
        Me.Result.Name = "Result"
        Me.Result.ReadOnly = True
        '
        'Fr_Intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 522)
        Me.Controls.Add(Me.Dgb_Datos)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Btn_Multi)
        Me.Controls.Add(Me.Btn_Divi)
        Me.Controls.Add(Me.Btn_Resta)
        Me.Controls.Add(Me.Btn_Suma)
        Me.Controls.Add(Me.Txt_Valor2)
        Me.Controls.Add(Me.Txt_Valor1)
        Me.Controls.Add(Me.Lbl_Valor2)
        Me.Controls.Add(Me.Lbl_Valor1)
        Me.Controls.Add(Me.Lbl_Hola)
        Me.Name = "Fr_Intro"
        Me.Text = "Calculadora Simple(PP en VB)"
        CType(Me.Dgb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Hola As Label
    Friend WithEvents Lbl_Valor1 As Label
    Friend WithEvents Lbl_Valor2 As Label
    Friend WithEvents Txt_Valor1 As TextBox
    Friend WithEvents Txt_Valor2 As TextBox
    Friend WithEvents Btn_Suma As Button
    Friend WithEvents Btn_Resta As Button
    Friend WithEvents Btn_Multi As Button
    Friend WithEvents Btn_Divi As Button
    Friend WithEvents Total As Label
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Dgb_Datos As DataGridView
    Friend WithEvents Operaciion As DataGridViewTextBoxColumn
    Friend WithEvents Result As DataGridViewTextBoxColumn
End Class
