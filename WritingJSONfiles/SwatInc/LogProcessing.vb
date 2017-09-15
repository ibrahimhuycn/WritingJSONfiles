Imports System.IO
Imports Newtonsoft.Json

Namespace SwatInc

    Public Class LogProcessing
        Dim CurrentProcessingException As Exception
        Dim ExLogDateTime As String
        ReadOnly LogTrace As New List(Of logHandler)
        Dim exMessage As String

        'WORKING DIRCETORIES
        Dim location As String = Reflection.Assembly.GetEntryAssembly.Location
        Dim executableDirectory As String = Path.GetDirectoryName(location)
        Dim LoggingDirectory As String = String.Format("{0}\Logs\", executableDirectory)
        Public Sub LogManager(exception As Exception)
            'WORKING: ACCEPTS EXCEPTION AS PARAMETERS, 
            'ITERATES INTO THE EXCEPTION TO LOOK FOR INNER EXCEPTIONS
            'CALL PROCESSES EXCEPTION METHOD TO PROCESS THEM

            ExLogDateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff")  'GET SYSTEM DATE AND TIME FOR RECORDING WITH LOGS.
            exMessage = Nothing
            CurrentProcessingException = Nothing    'CLEARING THE EXCEPTION BEFORE ASSIGNING A NEW EXCEPTON
            CurrentProcessingException = exception

            ProcessException(CurrentProcessingException)    'PROCESSING THE EXCEPTION

            Dim ProcessInnerEx As Exception = exception.InnerException      ' CHECKING FOR INNEREXCEPTION AND PROCESSING ALL IF ANY.
            While ProcessInnerEx IsNot Nothing
                ProcessException(ProcessInnerEx)
                ProcessInnerEx = ProcessInnerEx.InnerException
            End While

            'WRITE DATA TO DISK
            LogToDisk()

        End Sub

        Private Sub ProcessException(ProcessEx As Exception)
            'ADD THE EXCEPTION AS A NEW RECORD TO LogHandler CLASS 
            LogTrace.Add(New logHandler(LogClassification.EXCEPTION.ToString, ExLogDateTime, ProcessEx.TargetSite.Name, ProcessEx.GetType.ToString, ProcessEx.Message, ProcessEx.StackTrace, ProcessEx.HelpLink))

            'PREPARE PROMPT FOR END USER
            If exMessage IsNot Nothing Then
                exMessage = vbCrLf & ProcessEx.Message
            Else
                exMessage = ProcessEx.Message
            End If
        End Sub
        Private Sub LogToDisk()

            'CHECK FOR THE PRESENCE OF LOGGING DIRECTORY, CREATES THE DIR IF NOT.
            If Not My.Computer.FileSystem.DirectoryExists(LoggingDirectory) Then
                My.Computer.FileSystem.CreateDirectory(LoggingDirectory)
            End If

            Dim SerialisedJsonString As String = JsonConvert.SerializeObject(LogTrace, Formatting.Indented)     'SERIALISE THE LOGGED DATA AS JSON 
            'OUTPUT THE LOGS TO DISK- TO A PREDEFINED LOCATION
            File.AppendAllText(String.Format("{0}{1:yyyyMMdd HHmmss.ffff}.JSON", LoggingDirectory, Convert.ToDateTime(ExLogDateTime)), SerialisedJsonString)

            MsgBox(exMessage)    'NOTIFY THE ENDUSER ABOUT THE ERROR

        End Sub

    End Class
End Namespace

