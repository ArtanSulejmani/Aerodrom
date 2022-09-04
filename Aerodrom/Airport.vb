
Public Class Airport

    Public name As String   ' Name of airport
    Public city As String   ' Location
    Public shortName As String
    Public Destinations As List(Of Destination) 'List Destination

    'Public _txtShortName As TextBox()
    'Public _txtCityName As TextBox()
    'Public _txtShortName1 As TextBox()

    Public Sub New()

    End Sub


    Public Sub New(ByVal n As String, ByVal c As String, ByVal shrt As String)
        name = n
        city = c
        shortName = shrt
        'Destinations = New List(Of Destination)()

    End Sub

    ' Sub New(ByVal txtShortName As TextBox(), ByVal txtCityName As TextBox(), ByVal txtShortName1 As TextBox())
    'TODO: Complete member initialization 
    '  _txtShortName = txtShortName
    '  _txtCityName = txtCityName
    ' _txtShortName1 = txtShortName1
    ' End Sub



    'Public Sub NewDestination(ByVal destination As Destination)
    ' Destinations.Add(destination)

    'End Sub
    


    Public Overrides Function toString() As String
        Return String.Format("{0} - {1} - {2}", shortName, name, city)
    End Function

    Public Function getName() As String
        Return name
    End Function

    Public Function getCity() As String
        Return city
    End Function

    Public Function getShortName() As String
        Return shortName
    End Function

    Public Sub setName(ByVal n As String)
        name = n
    End Sub

    Public Sub setCity(ByVal c As String)
        city = c
    End Sub

    Public Sub setShortName(ByVal sh As String)
        shortName = sh
    End Sub

    ' Sub NewDestination(ByVal destination As Destination)
    '  Throw New NotImplementedException
    'End Sub



End Class
