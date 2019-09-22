Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrSplash.Start()
        tmrSplash.Interval = 4000
    End Sub

    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick
        frmDiceGame.Show()
        Me.Hide()
        tmrSplash.Stop()


    End Sub
End Class