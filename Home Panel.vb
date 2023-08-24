Public Class Home_Panel
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If visionPB.Visible = True Then
            visionPB.Visible = False
            missionPB.Visible = True
        ElseIf missionPB.Visible = True Then
            visionPB.Visible = True
            missionPB.Visible = False

        End If

    End Sub

    Private Sub Home_Panel_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

End Class