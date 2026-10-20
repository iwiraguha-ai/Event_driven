Public Class Student

    'Private backing fields
    Private _FullName As String = String.Empty
    Private _Nationalid As String = String.Empty
    Private _Course As String = String.Empty
    Private _Country As String = String.Empty

    'Full Name property
    Public Property FullName As String
        Get
            Return _FullName
        End Get
        Set(value As String)
                If String.IsNullOrWhiteSpace(value) Then
                _FullName = String.Empty
            Else
                _FullName = value.Trim()
            End If
            End Set
        End Property

    'Registration Number property
    Public Property NationalID As String
        Get
            Return _Nationalid
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                _Nationalid = String.Empty
            Else
                _Nationalid = value.Trim()
            End If
        End Set
    End Property

    'Country property
    Public Property Country As String
        Get
            Return _Country
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                _Country = String.Empty
            Else
                _Country = value.Trim()
            End If
        End Set
    End Property

    'Programme property
    Public Property Course As String
        Get
            Return _Course
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                _Course = String.Empty
            Else
                _Course = value.Trim()
            End If
        End Set
    End Property

    'Validate the student details
    Public Function IsValid() As Boolean

        If String.IsNullOrWhiteSpace(FullName) Then
            Return False
        End If
        If String.IsNullOrWhiteSpace(NationalID) Then
            Return False
        End If
        If String.IsNullOrWhiteSpace(Course) Then
            Return False
        End If
        Return True

    End Function

End Class
