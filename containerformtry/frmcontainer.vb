Imports Microsoft.Data.SqlClient

Public Class FrmContainer

    Private ReadOnly connString As String =
        "Server=.\SQLEXPRESS;Database=Fmsoft;Integrated Security=True;TrustServerCertificate=True;"

    Private Sub FrmContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientData()
    End Sub

    Private Sub LoadClientData()
        Using conn As New SqlConnection(connString)
            Try
                dgvDataClient.AutoGenerateColumns = False

                Dim query As String = "SELECT Code_Client, Nom_client FROM Client"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvDataClient.DataSource = dt
                dgvDataClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                dgvDataClient.RowsDefaultCellStyle.BackColor = Color.White
                dgvDataClient.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
            Catch ex As SqlException
                MessageBox.Show("Database error: " & ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub dgvDataClient_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDataClient.SelectionChanged
        If dgvDataClient.CurrentRow Is Nothing Then Return

        Dim rowView As DataRowView = TryCast(dgvDataClient.CurrentRow.DataBoundItem, DataRowView)
        If rowView Is Nothing Then Return

        LoadFacturesForClient(rowView("Code_Client"))
    End Sub

    Private Sub LoadFacturesForClient(codeClient As Object)
        Using conn As New SqlConnection(connString)
            Try
                Dim query As String = "SELECT * FROM Facture WHERE Code_Client = @Code_Client"
                Dim adapter As New SqlDataAdapter(query, conn)
                adapter.SelectCommand.Parameters.AddWithValue("@Code_Client", codeClient)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvFacture.DataSource = dt
                dgvFacture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvFacture.RowsDefaultCellStyle.BackColor = Color.White
                dgvFacture.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
            Catch ex As SqlException
                MessageBox.Show("Database error: " & ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub dgvFacture_SelectionChanged(sender As Object, e As EventArgs) Handles dgvFacture.SelectionChanged
        If dgvFacture.CurrentRow Is Nothing Then Return

        Dim rowView As DataRowView = TryCast(dgvFacture.CurrentRow.DataBoundItem, DataRowView)
        If rowView Is Nothing Then Return

        LoadDetailFacturesForFacture(rowView("NumFacture"))
    End Sub

    Private Sub LoadDetailFacturesForFacture(numFacture As Object)
        Using conn As New SqlConnection(connString)
            Try
                Dim query As String = "SELECT Code_Produit,Designation_Produit,Remise,TVA,Quantite,Prix_unitaire_TTC,Prix_Total_TTC FROM DetailFactureRequest WHERE NumFacture = @NumFacture"
                Dim adapter As New SqlDataAdapter(query, conn)
                adapter.SelectCommand.Parameters.AddWithValue("@NumFacture", numFacture)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvdetailfacture.DataSource = dt
                dgvdetailfacture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                dgvdetailfacture.RowsDefaultCellStyle.BackColor = Color.White
                dgvdetailfacture.AlternatingRowsDefaultCellStyle.BackColor = Color.LightPink
            Catch ex As SqlException
                MessageBox.Show("Database error: " & ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub BtnPanelVertical_Click(sender As Object, e As EventArgs) Handles BtnPanelVertical.Click
        SplitMain.Panel1Collapsed = Not SplitMain.Panel1Collapsed
    End Sub

    Private Sub BtnPanelHorizontal_Click(sender As Object, e As EventArgs) Handles BtnPanelHorizontal.Click
        SplitRight.Panel2Collapsed = Not SplitRight.Panel2Collapsed
    End Sub

End Class