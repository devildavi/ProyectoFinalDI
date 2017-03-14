Public Class frmMenu

    Private Sub cargarDatos(sender As Object, e As EventArgs) Handles ucPuntuacion1.Load
        ucPuntuacion1.setCampeon(My.Resources.Resource1.Amumu)

        UcJugador1.setFoto(My.Resources.Resource1.vizicsacsi)

    End Sub

    Private Sub tsbPlay_Click(sender As Object, e As EventArgs) Handles tsbPlay.Click
        MediaPlayer.Ctlcontrols.play()
        tsbPlay.Image = My.Resources.Resource1.pausa

    End Sub

    Private Sub PanelMediaPlayer_DragEnter(sender As Object, e As DragEventArgs) Handles PanelMediaPlayer.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub PanelMediaPlayer_DragDrop(sender As Object, e As DragEventArgs) Handles PanelMediaPlayer.DragDrop


    End Sub
End Class