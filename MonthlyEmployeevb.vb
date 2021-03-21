Imports MySql.Data.MySqlClient



Public Class MonthlyEmployeevb
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy/MM/dd")

        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy/MM/dd")




        Dim DA = New DataTable()
        Dim sqlAdapter = New MySqlDataAdapter
        'Dim v = ComboBox1.SelectedItem
        'Dim LogQuery As String = "SELECT USERNAME, PASSWORD, USER_TYPE FROM tbl_user WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD "
        Using con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=mysql;database=db_attendance")
            Using cmd As MySqlCommand = New MySqlCommand("", con)

                cmd.CommandText = "prcMonthly"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("date1", date1)
                cmd.Parameters.AddWithValue("date2", date2)
                sqlAdapter.SelectCommand = cmd

                If DA.Rows.Count > 0 Then
                    DA.Clear()
                    sqlAdapter.Fill(DA)
                    DataGridView1.RowCount = DA.Rows.Count

                    row = 0
                    While Not DA.Rows.Count - 1 < row
                        With DataGridView1
                            .Rows(row).Cells(0).Value = DA.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = DA.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(2).Value = DA.Rows(row).Item("l_name").ToStringzz

                            .Rows(row).Cells(3).Value = DA.Rows(row).Item("date").ToString
                            .Rows(row).Cells(4).Value = DA.Rows(row).Item("time_in").ToString
                            .Rows(row).Cells(5).Value = DA.Rows(row).Item("time_out").ToString
                            .Rows(row).Cells(6).Value = DA.Rows(row).Item("total_hours").ToString


                        End With
                        row = row + 1
                    End While
                Else

                End If
                DA.Dispose()
                sqlAdapter.Dispose()

            End Using
        End Using
    End Sub




    Private Sub prcDisplayTimesheet()

        dataAttendance = New DataTable()

        sqlAttendanceAdapter = New MySqlDataAdapter
        command.Connection = conAttendanceSystem
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayTotalHours"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)



                If dataAttendance.Rows.Count > 0 Then
                    DataGridView1.RowCount = dataAttendance.Rows.Count

                    row = 0
                    While Not dataAttendance.Rows.Count - 1 < row
                        With DataGridView1
                            .Rows(row).Cells(0).Value = dataAttendance.Rows(row).Item("id").ToString
                            .Rows(row).Cells(1).Value = dataAttendance.Rows(row).Item("f_name").ToString
                            .Rows(row).Cells(2).Value = dataAttendance.Rows(row).Item("l_name").ToString

                            .Rows(row).Cells(3).Value = dataAttendance.Rows(row).Item("date").ToString
                            .Rows(row).Cells(4).Value = dataAttendance.Rows(row).Item("time_in").ToString
                            .Rows(row).Cells(5).Value = dataAttendance.Rows(row).Item("time_out").ToString
                            .Rows(row).Cells(6).Value = dataAttendance.Rows(row).Item("total_hours").ToString


                        End With
                        row = row + 1
                    End While


                Else

                End If
                sqlAttendanceAdapter.Dispose()
                dataAttendance.Dispose()
            End With
        Catch ex As Exception

        End Try
        Me.Refresh()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub MonthlyEmployeevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy/MM/dd"


        Try
            dataAttendance = New DataTable()

            sqlAttendanceAdapter = New MySqlDataAdapter
            command.Connection = conAttendanceSystem
            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayEmployee"
                .CommandType = CommandType.StoredProcedure
                sqlAttendanceAdapter.SelectCommand = command
                dataAttendance.Clear()
                sqlAttendanceAdapter.Fill(dataAttendance)
            End With


            sqlAttendanceAdapter.Fill(dataAttendance)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        prcDisplayTimesheet()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        With dt
            .Columns.Add("ID")
            .Columns.Add("Firstname")
            .Columns.Add("Lastname")
            .Columns.Add("Date")
            .Columns.Add("TimeIN")
            .Columns.Add("TimeOUT")


        End With

        For Each dgr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value)
        Next
        Dim report1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
        report1 = New CrystalReport4
        report1.SetDataSource(dt)
        report.CrystalReportViewer1.ReportSource = report1
        report.ShowDialog()
        report.Dispose()



    End Sub
End Class