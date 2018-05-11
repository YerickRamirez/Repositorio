Imports System.IO

Public Class Form1

    Dim tblDatosPersonas As New DataTable
    Dim strNombre As String
    Dim strApellido1 As String
    Dim strApellido2 As String



    Private Sub btnLoadTxt_Click(sender As Object, e As EventArgs) Handles btnLoadTxt.Click

        Dim fileReader As StreamReader
        Dim line As String
        'Dim persons As New ArrayList()

        tblDatosPersonas.Columns.Add("Nombre")
        tblDatosPersonas.Columns.Add("Apellido1")
        tblDatosPersonas.Columns.Add("Apellido2")
        tblDatosPersonas.Columns.Add("Aprueba2")
        tblDatosPersonas.Columns.Add("prueba2")
        tblDatosPersonas.Columns.Add("Apellido2")




        fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\yeric\Downloads\UCR\10 Registros.txt")
        line = fileReader.ReadLine

        Do While line <> Nothing
            Dim vector = line.Split(" ")
            If (vector.Length > 3) Then

            Else

            End If

            line = fileReader.ReadLine
        Loop



        'Do While line <> Nothing
        'persons.Add(line)
        'line = fileReader.ReadLine
        'Loop

        'For i = 0 To persons.Count - 1
        'Dim vector = persons(i).ToString.Split(" ")
        'If (vector.Length = 4) Then

        'End If
        'Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
