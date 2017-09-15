
Public Class GenerateException

    Private Sub btnGenerateEx_Click(sender As Object, e As EventArgs) Handles btnGenerateEx.Click
        'THIS CLASS GENERATES A DEMO EXCEPTION FOR THE LOG PROCESSING AND LOGGING TO DISK TO PROCEED.

        Try
            Dim s(1) As String
            s(5) = "Ibrahim"
        Catch Boom As Exception
            Dim InitiateErrorProcessing As New SwatInc.LogProcessing
            InitiateErrorProcessing.LogManager(Boom)
        End Try
    End Sub
End Class