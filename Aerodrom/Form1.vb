Imports System
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Aerodrom.WINFORMS_DBDataSetTableAdapters

Public Class Form1
    Dim airports As ArrayList = New ArrayList()
    'Dim WINFORMS_DBDataSet As Object

    Public Sub Form1()
        InitializeComponent()
        loadDestination()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim newAirport As NewAirport = New NewAirport()
        If newAirport.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            lbAirports.Items.Add(newAirport.Airport)
        End If
    End Sub

    Private Sub btnAddDestination_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Dim newDestination As NewDestination = New NewDestination()
        If newDestination.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            lbDestinations.Items.Add(newDestination.Destination)
        End If
        loadDestination()
    End Sub

    Private Sub loadDestination()
        Dim maxPrice As Integer = 0
        Dim totalDistance As Integer = 0

        If lbDestinations.Items.Count > 0 Then
            Dim firstDestination As Destination = lbDestinations.Items.Item(0)
            maxPrice = firstDestination.getPrice()
            For Each destination As Destination In lbDestinations.Items
                If destination.getPrice() > maxPrice Then
                    maxPrice = destination.getPrice()
                End If
                totalDistance += destination.getLength()
            Next
            tbAverage.Text = String.Format("{0:#.0}", totalDistance / lbDestinations.Items.Count)
            tbMaxPrice.Text = maxPrice.ToString()
        End If
    End Sub

    Private Sub btnRemoveAirport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim DialogResult As DialogResult = MessageBox.Show("Дали сте сигурни за да го избришете аеродромот !?", "Remove airport", MessageBoxButtons.YesNo)
        If (DialogResult = DialogResult.Yes) Then
            lbAirports.Items.Remove(lbAirports.SelectedItem)
        ElseIf (DialogResult = DialogResult.No) Then
            'do something else
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WINFORMS_DBDataSet.Airport' table. You can move, or remove it, as needed.
        'Me.AirportTableAdapter.Fill(Me.WINFORMS_DBDataSet.Airport)

        'Dim connection As SqlConnection = New SqlConnection()
        'connection.ConnectionString = "Data Source=localhost;Initial Catalog=WINFORMS_DB;Integrated Security=True"
        'connection.Open()
        'Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from Airport", connection)
        'Dim ds As DataSet = New DataSet()
        'adp.Fill(ds)
        'DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub lbAirports_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbAirports.SelectedIndexChanged
        Dim airport As Airport
        For Each airport In lbAirports.Items
            lbAirports.DisplayMember = airport.toString()
        Next
        ' btnDeleteDestination.Enabled = lbAirports.SelectedIndex <> -1
        'btnNewDestination.Enabled = lbAirports.SelectedIndex <> -1
        loadDestination()
    End Sub

    Private Sub lbDestinations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbDestinations.SelectedIndexChanged
        Dim destination As Destination
        For Each destination In lbDestinations.Items
            lbDestinations.DisplayMember = destination.toString()
        Next
        ' btnDeleteDestination.Enabled = lbAirports.SelectedIndex <> -1
        ' btnNewDestination.Enabled = lbAirports.SelectedIndex <> -1
        loadDestination()
    End Sub

End Class

