Public Class Fr_Intro

    Dim valor_uno As Integer = 0
    Dim valor_dos As Integer = 0
    Dim resultado As Double = 0


    ' Validación de entrada
    Private Function Validacion() As Boolean
        If IsNumeric(Txt_Valor1.Text) Then
            valor_uno = Txt_Valor1.Text
        Else
            MsgBox("El valor 1 debe ser numérico")
            Return False
        End If

        If IsNumeric(Txt_Valor2.Text) Then
            valor_dos = Txt_Valor2.Text
        Else
            MsgBox("El valor 2 debe ser númerico")
            Return False
        End If

        Return True
    End Function


    ' Resultado de operación
    Private Sub Resultadof(ByVal Operacion As String)

        Txt_Resultado.Text = resultado
        DataGrid(Operacion, resultado)

    End Sub


    ' Data Grid
    Private Sub DataGrid(ByVal Operacion As String, ByVal ResultadoDG As Double)
        Dgb_Datos.Rows.Add()
        Dim j As Integer = Dgb_Datos.RowCount - 1

        Dgb_Datos.Rows(j).Cells(0).Value = Operacion
        Dgb_Datos.Rows(j).Cells(1).Value = ResultadoDG
    End Sub



    Private Sub Fr_Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lbl_Hola.Click

    End Sub



    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Lbl_Valor1.Click

    End Sub



    Private Sub Lbl_Valor2_Click(sender As Object, e As EventArgs) Handles Lbl_Valor2.Click

    End Sub


    ' Suma
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Suma.Click


        If Validacion() = False Then
            Exit Sub
        End If

        resultado = valor_uno + valor_dos

        Resultadof("Suma")
    End Sub


    ' Division
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_Divi.Click

        If Validacion() = False Then
            Exit Sub
        End If


        resultado = valor_uno / valor_dos


        Resultadof("División")
    End Sub


    ' Resta
    Private Sub Btn_Resta_Click(sender As Object, e As EventArgs) Handles Btn_Resta.Click

        If Validacion() = False Then
            Exit Sub
        End If


        resultado = valor_uno - valor_dos


        Resultadof("Resta")
    End Sub


    ' Multiplicacion
    Private Sub Btn_Multi_Click(sender As Object, e As EventArgs) Handles Btn_Multi.Click

        If Validacion() = False Then
            Exit Sub
        End If


        resultado = valor_uno * valor_dos


        Resultadof("Multiplicación")
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgb_Datos.CellContentClick

    End Sub
End Class


