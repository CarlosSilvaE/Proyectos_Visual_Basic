Public Class Bienvenida
    'Al momento de darle a una de las opciones ya sea
    'Historia o geografia se mostrara una imagen usando
    'un if para hacer cada condicion por opcion
    Private Sub rdn_Historia_CheckedChanged(sender As Object, e As EventArgs) Handles rdn_Historia.CheckedChanged

        If rdn_Historia.Checked Then
            pbx_Tema.Image = Proyecto_Quiz.My.Resources.Historia
        End If

    End Sub

    Private Sub rdn_Geografia_CheckedChanged(sender As Object, e As EventArgs) Handles rdn_Geografia.CheckedChanged

        If rdn_Geografia.Checked Then
            pbx_Tema.Image = Proyecto_Quiz.My.Resources.Geografia
        End If

    End Sub

    Private Sub btn_Comenzar_Click(sender As Object, e As EventArgs) Handles btn_Comenzar.Click

        'Con unos if daremos la condicion de si se elige una de las
        'opciones abrira su form correspondiente
        'Inicializando puntaje en 0 y la preguntaActual en 1 (Globales)

        If rdn_Historia.Checked Then
            puntaje = 0
            preguntaActual = 1
            Historia.Show()
        End If

        If rdn_Geografia.Checked Then
            puntaje = 0
            preguntaActual = 1
            Geografia.Show()
        End If

        'Al momento de abrir cualquier otro formulario
        'este se ocultara

        Me.Hide()

    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.Exit()
    End Sub
End Class
