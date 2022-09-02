Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class NewAirport

    Public Airport As Airport

    ' Private WithEvents txtShortName As Object

    'Private WithEvents txtCityName As Object

    'Private WithEvents txtAirportName As Object

    'Public Property Airport As Airport

    Public Sub NewAirport()
        InitializeComponent()
    End Sub



    Private Sub tbCity_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles MyBase.Validating, TextBox1.Validating 'Handles TextBox1.Validating
        If (TextBox1.Text.Trim().Length = 0) Then

            ErrorProvider1.SetError(TextBox1, "Името на градот е задолжително")
            e.Cancel = True
        Else
            e.Cancel = False
            ErrorProvider1.SetError(TextBox1, Nothing)
        End If
    End Sub

    Private Sub tbName_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles TextBox2.Validating 'Handles TextBox2.Validating

        If (TextBox2.Text.Trim().Length = 0) Then
            ' Dim errorProvider As ErrorProvider = New ErrorProvider("Име на градот е задолжително")
            ' Throw errorProvider
            ErrorProvider1.SetError(TextBox2, "Името е задолжително")
            e.Cancel = True

        Else
            e.Cancel = False
            ErrorProvider1.SetError(TextBox2, Nothing)

        End If

        'ErrorProvider.SetError(txtCityName, Nothing)

    End Sub

    '  Private Sub ShortName_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles TextBox3.Validating
    '   If (TextBox3.Text.Length <> 3) Then
    'Dim errorProvider As ErrorProvider = New ErrorProvider("shortname needs to be 3 chars!")
    'Throw errorProvider
    '     ErrorProvider1.SetError(TextBox3, "Кратенката треба да биде точно 3 букви")
    '  End If
    ' End Sub

    Private Sub tbShortName_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles TextBox3.Validating
        If (TextBox3.Text.Trim().Length <> 3) Then
            ErrorProvider1.SetError(TextBox3, "Кратенката треба да има точно 3 големи букви")
            e.Cancel = True
        Else
            Dim sh As String = TextBox3.Text.Trim()
            For Each c In sh
                If Char.IsLower(c) Then
                    ErrorProvider1.SetError(TextBox3, "Кратенката треба да има точно 3 големи букви")
                    e.Cancel = True
                    Return
                End If
            Next
            ErrorProvider1.SetError(TextBox3, Nothing)
        End If
    End Sub

    Private Sub btnSaveAiroport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Airport = New Airport(TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox3.Text.Trim())
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnDeleteAirport_Click(ByVal sender As Object, ByVal e As EventArgs)
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    'Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
    ' Airport = New Airport(TextBox1.Text.Trim, TextBox2.Text.Trim, TextBox3.Text.Trim)
    '  DialogResult = System.Windows.Forms.DialogResult.OK




    'End Sub



    'Private Function Airport(ByVal p1 As Object, ByVal p2 As Object, ByVal p3 As Object) As Aerodrom.Airport
    ' Throw New NotImplementedException
    'End Function

    'Private Function Airport(ByVal p1 As Object, ByVal p2 As Object, ByVal p3 As Object) As Aerodrom.Airport
    ' Throw New NotImplementedException
    'End Function

  


End Class