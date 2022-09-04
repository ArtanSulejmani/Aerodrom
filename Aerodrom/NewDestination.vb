Imports System
Imports System.ComponentModel
Imports System.Windows.Forms


Public Class NewDestination
    Public Destination As Destination

    'Private Property nudPrice As Object

    'Private Property nudLength As Object

    ' Private Property numPrice As Object

    'Private Property numLength As Object

    Public Sub NewDestination()
        InitializeComponent()
    End Sub

    Private Sub btn_Destination_Click(ByVal sender As Object, ByVal e As CancelEventArgs) Handles TextBox1.Validating 'Handles TextBox1.Validating
        If TextBox1.Text.Trim().Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(TextBox1, "Името на дестинацијата е задолжително")

        Else
            e.Cancel = False
            ErrorProvider1.SetError(TextBox1, Nothing)
        End If
    End Sub


    '  Private Sub btnAddDestination_Click(ByVal sender As Object, ByVal e As EventArgs) 'Handles Button1.Click
    ' Destination = New Destination(tbName.Text.Trim(), CInt(nudLength.Value), CInt(nudPrice.Value))
    ' DialogResult = System.Windows.Forms.DialogResult.OK
    ' End Sub

    ' Private Sub btnCancelDestination_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
    ' DialogResult = System.Windows.Forms.DialogResult.Cancel
    'End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Destination = New Destination(TextBox1.Text.Trim(), NumericUpDown1.Value, NumericUpDown2.Value)
        DialogResult = System.Windows.Forms.DialogResult.OK

        ' If Destination.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        ' Destination.Items.Add(Destination.NewDestination.toString)
        ' End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub


    ' Private Sub InitializeComponent()
    '  Me.SuspendLayout()
    '
    'NewDestination
    '
    ' Me.ClientSize = New System.Drawing.Size(284, 261)
    ' Me.Name = "NewDestination"
    'Me.ResumeLayout(False)

    'End Sub

End Class
