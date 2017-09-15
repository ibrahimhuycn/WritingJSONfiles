
Public Class GenerateException
    Private Sub GenerateException_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim er As SwatInc.LogProcessing
        Try
            Dim s(1) As String
            s(5) = "Ibrahim"
        Catch Boom As Exception
            Dim InitiateErrorProcessing As New SwatInc.LogProcessing
            InitiateErrorProcessing.LogManager(Boom)
            '  MsgBox(String.Format("Source: {0}{1}{0}Message: {2}{0}Stack Trace: {3}{0}TargetSite Name :{4}", vbCrLf, Boom.Source, Boom.Message, Boom.StackTrace, Boom.TargetSite.Name))
        End Try



    End Sub
End Class