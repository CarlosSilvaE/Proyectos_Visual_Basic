Public Class Historia
    'Para hacer el quiz historia haremos dos metodos aparte
    'uno para limpiar todos los campos
    'y otro para cargar las preguntas

    Private Sub LimpiarCampos()
        rdn_11.Checked = False
        rdn_12.Checked = False
        rdn_10.Checked = False
        rdn_9.Checked = False
        rdn_Vicente.Checked = False
        rdn_Hidalgo.Checked = False
        rdn_Zapata.Checked = False
        rdn_Juarez.Checked = False
        rdn_2000.Checked = False
        rdn_1980.Checked = False
        rdn_1821.Checked = False
        rdn_1492.Checked = False
    End Sub

    Public Sub CargarPreguntas()
        'Haremos una condicion que si la pregunta actual es menor a 1
        'o mayor a 3 se limpiaran los campos

        If preguntaActual < 1 OrElse preguntaActual > 3 Then Return
        LimpiarCampos()

        'Si no se cumple, usaremos select case para cada pregunta

        Select Case preguntaActual
            Case 1
                gbx_PreguntaH1.Text = "¿Cuantos años duro la guerra de la independencia?"
                rdn_11.Text = "11 años"
                rdn_12.Text = "12 años"
                rdn_10.Text = "10 años" '<- Correcta
                rdn_9.Text = "9 años"

            Case 2
                gbx_PreguntaH2.Text = "¿General Mexicano que peleo bajo las ordenes de Morelos?"
                rdn_Vicente.Text = "Vicente Guerrero" '<- Correcta
                rdn_Hidalgo.Text = "Miguel Hidalgo"
                rdn_Zapata.Text = "Zapata"
                rdn_Juarez.Text = "Benito Juarez"

            Case 3
                gbx_PreguntaH3.Text = "¿En que año se proclamo la independencia de Mexico?"
                rdn_2000.Text = "2000"
                rdn_1980.Text = "1980"
                rdn_1821.Text = "1821" '<- Correcta
                rdn_1492.Text = "1492"

        End Select
    End Sub


    Private Sub btn_Finalizar_Click(sender As Object, e As EventArgs) Handles btn_Finalizar.Click

        'Ya cuando se hayan elegido las opciones haremos otro case dentro del boton de finalizar
        'Al momento de que se haya elegido la respuesta correcta se sumara uno al puntaje
        'siendo un maximo de 3

        Select Case preguntaActual
            Case 1
                If rdn_10.Checked Then puntaje += 1
            Case 2
                If rdn_Vicente.Checked Then puntaje += 1
            Case 3
                If rdn_1821.Checked Then puntaje += 1
        End Select

        'Al momento de contestar una pregunta se le sumara 1 a preguntaActual

        preguntaActual += 1

        'Si preguntaActual es mayor a 3 o al total de preguntas agregadas se abrira el
        'form resultados y se cargaran las preguntas

        If preguntaActual > 3 Then
            Dim res As New Resultados()
            res.Show()
            Me.Close()
            CargarPreguntas()
        End If

    End Sub

    'Cargamos el metodo para que vaya cargando pregunta por pregunta y sume el total

    Private Sub Historia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPreguntas()
    End Sub
End Class