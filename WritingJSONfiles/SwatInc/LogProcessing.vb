Imports System.Linq
Imports Newtonsoft.Json

Namespace SwatInc

    Public Class LogProcessing
        Dim CurrentProcessingException As Exception
        Dim ExLogDateTime As DateTime
        ReadOnly LogTrace As New List(Of LogTempStore)
        Public Sub LogManager(exception As Exception)
            ExLogDateTime = DateTime.Now
            CurrentProcessingException = Nothing
            CurrentProcessingException = exception

            ProcessException(CurrentProcessingException)

            Dim ProcessInnerEx As Exception = exception.InnerException
            While ProcessInnerEx IsNot Nothing
                ProcessException(ProcessInnerEx)
                ProcessInnerEx = ProcessInnerEx.InnerException
            End While

        End Sub

        Private Sub ProcessException(ProcessEx As Exception)

            'Dim LogTrace As New LogTempStore(LogClassification.EXCEPTION.ToString, ExLogDateTime, ProcessEx.TargetSite.Name, ProcessEx.GetType.ToString, ProcessEx.Message, ProcessEx.StackTrace, ProcessEx.HelpLink)
            LogTrace.Add(New LogTempStore(LogClassification.EXCEPTION.ToString, ExLogDateTime, ProcessEx.TargetSite.Name, ProcessEx.GetType.ToString, ProcessEx.Message, ProcessEx.StackTrace, ProcessEx.HelpLink))

            Dim json As String = JsonConvert.SerializeObject(LogTrace, Formatting.Indented)


            MsgBox(json)

        End Sub

    End Class
End Namespace
Namespace SwatInc.Log
End Namespace
