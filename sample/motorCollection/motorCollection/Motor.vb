Public Class Motor

    ' Private variables
	Private strId As String		   ' Holds the ID number
	Private strDescription As String	  ' Holds the description
	Private sngRpmValue As Single  ' Holds the RPMs
	Private sngVoltage As Single	  ' Holds the voltage
    Private stat As String      ' Holds the status

    ' Constructor
    Public Sub New()
        ' Initialize the private variables.
		strId = String.Empty
		strDescription = String.Empty
		sngRpmValue = 0
		sngVoltage = 0
		stat = String.Empty
    End Sub

    ' Properties
    Public Property MotorId() As String
        Get
			Return strId
        End Get
        Set(ByVal value As String)
            strId = value
        End Set
    End Property

    Public Property Description() As String
        Get
			Return strDescription
        End Get
        Set(ByVal value As String)
			strDescription = value
        End Set
    End Property

    Public Property RPM() As Single
        Get
			Return sngRpmValue
        End Get
        Set(ByVal value As Single)
			sngRpmValue = value
        End Set
    End Property

    Public Property Voltage() As Single
        Get
			Return sngVoltage
        End Get
        Set(ByVal value As Single)
            sngVoltage = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return stat
        End Get
        Set(ByVal value As String)
            stat = value.ToUpper
        End Set
    End Property

    'overridden tostring method
    Public Overrides Function ToString() As String

        Dim str As String
        str = "ID: " & strId & " " & _
            "DESCRIPTION: " & strDescription & " " & _
            "RPMS: " & sngRpmValue & " " & _
            "Voltage: " & sngVoltage & " " & _
            "STATUS: " & stat.ToString()
        Return str
    End Function

End Class
