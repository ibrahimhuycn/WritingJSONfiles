
Namespace SwatInc
    Public Class logHandler
        Public Sub New(ByVal LogClassification As String, ByVal ExLogDateTime As DateTime, ByVal TargetSite As String, ByVal GetExType As String, ByVal ExMessage As String, ByVal StackTrace As String, Optional HelpLink As String = Nothing)
            Log_Classification = LogClassification
            Ex_Log_DateTime = ExLogDateTime
            Target_Site = TargetSite
            Get_Ex_Type = GetExType
            Ex_Message = ExMessage
            Stack_Trace = StackTrace
            Help_Link = HelpLink
        End Sub
        Public Property Log_Classification() As String
        Public Property Ex_Log_DateTime() As DateTime
        Public Property Target_Site() As String
        Public Property Get_Ex_Type() As String
        Public Property Ex_Message() As String
        Public Property Stack_Trace() As String
        Public Property Help_Link() As String
    End Class
End Namespace
