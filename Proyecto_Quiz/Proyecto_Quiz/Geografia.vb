Public Class Geografia
    'Como es exactamente igual a historia, hacemos lo mismo

    Private Sub LimpiarCampos()
        rdn_Paris.Checked = False
        rdn_Roma.Checked = False
        rdn_Berlin.Checked = False
        rdn_Madrid.Checked = False
        rdn_Amazonas.Checked = False
        rdn_Nilo.Checked = False
        rdn_Yangtse.Checked = False
        rdn_Misisipi.Checked = False
        rdn_Asia.Checked = False
        rdn_Africa.Checked = False
        rdn_Europa.Checked = False
        rdn_Oceania.Checked = False
    End Sub

    Public Sub CargarPreguntas()
        'Haremos una condicion que si la pregunta actual es menor a 1
        'o mayor a 3 se limpiaran los campos

        If preguntaActual < 1 OrElse preguntaActual > 3 Then Return
        LimpiarCampos()

        'Si no se cumple, usaremos select case para cada pregunta

        Select Case preguntaActual
            Case 1
                gbx_PreguntaG1.Text = "¿Cual es la capital de Francia?"
                rdn_Paris.Text = "Paris" '<- Correcta
                rdn_Roma.Text = "Roma"
                rdn_Berlin.Text = "Berlin"
                rdn_Madrid.Text = "Madrid"

            Case 2
                gbx_PreguntaG2.Text = "¿Cual es el rio mas largo del mundo?"
                rdn_Amazonas.Text = "Amazonas" '<- Correcta
                rdn_Nilo.Text = "Nilo"
                rdn_Yangtse.Text = "Yangtse"
                rdn_Misisipi.Text = "Misisipi"

            Case 3
                gbx_PreguntaG3.Text = "¿En que continente esta Egipto?"
                rdn_Asia.Text = "Asia"
                rdn_Africa.Text = "Africa" '<- Correcta
                rdn_Europa.Text = "Europa"
                rdn_Oceania.Text = "Oceania"

        End Select
    End Sub


    Private Sub btn_Finalizar_Click(sender As Object, e As EventArgs) Handles btn_Finalizar.Click

        Select Case preguntaActual
            Case 1
                If rdn_Paris.Checked Then puntaje += 1
            Case 2
                If rdn_Amazonas.Checked Then puntaje += 1
            Case 3
                If rdn_Africa.Checked Then puntaje += 1
        End Select

        preguntaActual += 1

        If preguntaActual > 3 Then
            Dim res As New Resultados()
            res.Show()
            Me.Close()
            CargarPreguntas()
        End If

    End Sub

    Private Sub Geografia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPreguntas()
    End Sub
End Class