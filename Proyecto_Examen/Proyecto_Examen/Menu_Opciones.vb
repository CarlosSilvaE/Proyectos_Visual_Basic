Public Class Menu

    Private Sub Paquetes()

        If cbx_P1.Checked Then
            PedidoDetalle &= "Paquete 1 $" & Paquete1 & vbCrLf
            TotalPedido += Paquete1
        End If

        If cbx_P2.Checked Then
            PedidoDetalle &= "Paquete 2 $" & Paquete2 & vbCrLf
            TotalPedido += Paquete2
        End If

        If cbx_P3.Checked Then
            PedidoDetalle &= "Paquete 3 $" & Paquete3 & vbCrLf
            TotalPedido += Paquete3
        End If

        If cbx_P4.Checked Then
            PedidoDetalle &= "Paquete 4 $" & Paquete4 & vbCrLf
            TotalPedido += Paquete4
        End If

        If cbx_P5.Checked Then
            PedidoDetalle &= "Paquete 5 $" & Paquete5 & vbCrLf
            TotalPedido += Paquete5
        End If

        If cbx_P6.Checked Then
            PedidoDetalle &= "Paquete 6 $" & Paquete6 & vbCrLf
            TotalPedido += Paquete6
        End If

    End Sub

    Private Sub Refrescos()

        If cbx_Coca.Checked Then
            If rdn_Light.Checked Then
                PedidoDetalle &= "Coca Cola Light $" & CocaColaLight & vbCrLf
                TotalPedido += CocaColaLight
            End If

            If rdn_Normal.Checked Then
                PedidoDetalle &= "Coca Cola Normal $" & CocaColaNormal & vbCrLf
                TotalPedido += CocaColaNormal
            End If
        End If

        If cbx_Agua.Checked Then
            PedidoDetalle &= "Agua $" & Agua & vbCrLf
            TotalPedido += Agua
        End If

        If cbx_Jugo.Checked Then
            PedidoDetalle &= "Jugo $" & Jugo & vbCrLf
            TotalPedido += Jugo
        End If

    End Sub

    Private Sub Postres()
        If lst_Postres.SelectedItem IsNot Nothing Then
            PedidoDetalle &= lst_Postres.SelectedItem.ToString() & " $"
            Select Case lst_Postres.SelectedItem.ToString()
                Case "Pay de limon"
                    PedidoDetalle &= PayDeLimon & vbCrLf
                    TotalPedido += PayDeLimon
                Case "Pay de queso"
                    PedidoDetalle &= PayDeQueso & vbCrLf
                    TotalPedido += PayDeQueso
                Case "Cono de nieve"
                    PedidoDetalle &= ConoDeNieve & vbCrLf
                    TotalPedido += ConoDeNieve
                Case "Sundae"
                    PedidoDetalle &= Sundae & vbCrLf
                    TotalPedido += Sundae
            End Select
        End If
    End Sub

    Private Sub Cupones()
        If rdn_Diez.Checked Then
            PedidoDetalle &= "Cupon 10%" & vbCrLf
            TotalPedido -= TotalPedido * 0.1   '10% de descuento
        ElseIf rdn_Quince.Checked Then
            PedidoDetalle &= "Cupon 15%" & vbCrLf
            TotalPedido -= TotalPedido * 0.15  '15% de descuento
        End If
    End Sub

    Private Sub Modalidad()

        If rdn_Llevar.Checked Then
            PedidoDetalle &= "Para llevar" & vbCrLf
        End If

        If rdn_Aqui.Checked Then
            PedidoDetalle &= "Para comer aqui" & vbCrLf
        End If

    End Sub


    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_Confirmar_Click(sender As Object, e As EventArgs) Handles btn_Confirmar.Click
        Paquetes()
        Refrescos()
        Postres()
        Cupones()
        Modalidad()

        Dim ven2 As New Confirmar_Compra
        ven2.Show()
        Me.Hide()
    End Sub
End Class
