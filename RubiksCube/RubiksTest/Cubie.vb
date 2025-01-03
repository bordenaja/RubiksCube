Public Class Cubie
    Dim iCubieType As Integer '0:middle 1:centre 2:edge 3:corner
    Dim iPermutation As Integer
    Dim arrColours(2) As Char
    Property pCubieType
        Set(value)
            If 0 <= value And value < 4 Then
                iCubieType = value
            Else
                MsgBox("Hello I'm going to annoy you bc you entered an incorrect cubie type.")
            End If
        End Set
        Get
            Return iCubieType
        End Get
    End Property
    Public Function GetCubieType()
        Return pCubieType
    End Function
    Public Sub SetCubieType(type As Integer)
        pCubieType = type
    End Sub

    Property Colours As String
        Set(value As String)
            For i = 1 To value.Length
                arrColours(i - 1) = Mid(value, i, 1)
            Next
        End Set
        Get
            Dim returnstring As String = ""
            For i = 1 To arrColours.Length
                returnstring = returnstring + arrColours(i - 1)
            Next
            Return returnstring
        End Get
    End Property

    Public Sub SetColours(value As String)
        If value.Length <> iCubieType Then
            MsgBox("Incorrect number of colours entered for this cubie")
        Else
            Colours = value
        End If
    End Sub

    Public Function GetColours()
        Return Colours
    End Function

    Property ppermutation As Integer
        Set(value As Integer)
            If value < iCubieType And value >= 0 Then
                If value > 2 Then
                    value = value - 3
                End If
                iPermutation = value
            End If
        End Set
        Get
            Return iPermutation
        End Get
    End Property

    Public Sub SetPermutation(value As Integer)
        If value < iCubieType And value >= 0 Then
            If value > 2 Then
                value = value - 3
            End If
            ppermutation = value
        Else
            MsgBox("An error occured.")
        End If
    End Sub

    Public Function GetPermutation()
        Return ppermutation
    End Function
End Class
