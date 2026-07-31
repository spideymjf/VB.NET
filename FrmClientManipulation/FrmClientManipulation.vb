Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports Microsoft.Data.SqlClient

Public Class FrmClientManipulation

    Private ReadOnly connString As String =
        "Server=.\SQLEXPRESS;Database=Fmsoft;Integrated Security=True;TrustServerCertificate=True;"

    Private isAdding As Boolean = False
    Private isEditing As Boolean = False

    Private selectedCode As Object = Nothing

    Private originalName As String = ""
    Private originalTelephone As String = ""
    Private originalEmail As String = ""

    Private Sub FrmClientManipulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientData()
        SetIdleState()
    End Sub

    Private Sub LoadClientData()
        Using conn As New SqlConnection(connString)
            Try
                dgvclient.AutoGenerateColumns = True

                Dim query As String = "SELECT * FROM Client"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvclient.DataSource = dt
                dgvclient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                dgvclient.RowsDefaultCellStyle.BackColor = Color.White
                dgvclient.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
            Catch ex As SqlException
                MessageBox.Show("Database error: " & ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub dgvclient_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclient.CellClick
        If e.RowIndex < 0 Then Return

        isAdding = False
        isEditing = False

        Dim row As DataGridViewRow = dgvclient.Rows(e.RowIndex)
        selectedCode = row.Cells("code_client").Value

        TxtCodeClient.Text = selectedCode.ToString()
        TxtNomClient.Text = row.Cells("Nom_client").Value.ToString()
        TxtTelephone.Text = row.Cells("Tel").Value.ToString()
        TxtEmail.Text = row.Cells("email").Value.ToString()

        SetFieldsEnabled(False)
        Save.Enabled = False
        Update.Enabled = False
    End Sub

    Private Sub BtnPanelVertical_Click(sender As Object, e As EventArgs) Handles Vertical_Panel.Click
        SplitContainer1.Panel1Collapsed = Not SplitContainer1.Panel1Collapsed
    End Sub

    Private Sub SetIdleState()
        isAdding = False
        isEditing = False
        selectedCode = Nothing
        ClearFields()
        SetFieldsEnabled(False)
        Save.Enabled = False
        Update.Enabled = False
    End Sub

    Private Sub ClearFields()
        TxtCodeClient.Text = ""
        TxtNomClient.Text = ""
        TxtTelephone.Text = ""
        TxtEmail.Text = ""
    End Sub

    Private Sub SetFieldsEnabled(enabled As Boolean)
        TxtNomClient.Enabled = enabled
        TxtTelephone.Enabled = enabled
        TxtEmail.Enabled = enabled
        TxtCodeClient.Enabled = False
    End Sub

    Private Function GetNextClientCode() As Integer
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim query As String = "SELECT COUNT(*) + 1 FROM Client"
            Using cmd As New SqlCommand(query, conn)
                Return CInt(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        isAdding = True
        isEditing = False
        selectedCode = Nothing
        ClearFields()
        TxtCodeClient.Text = GetNextClientCode().ToString()
        SetFieldsEnabled(True)
        Update.Enabled = False
        Save.Enabled = False
        TxtNomClient.Focus()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO Client (code_client, Nom_client, Tel, email) VALUES (@Code, @Nom, @Tel, @Email)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Code", CInt(TxtCodeClient.Text))
                    cmd.Parameters.AddWithValue("@Nom", TxtNomClient.Text.Trim())
                    cmd.Parameters.AddWithValue("@Tel", TxtTelephone.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Client added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadClientData()
                SetIdleState()
            Catch ex As SqlException
                MessageBox.Show("Database error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Change_Click(sender As Object, e As EventArgs) Handles Change.Click
        If dgvclient.CurrentRow Is Nothing Then
            MessageBox.Show("Select a client in the grid first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        isAdding = False
        isEditing = True

        Dim row As DataGridViewRow = dgvclient.CurrentRow
        selectedCode = row.Cells("code_client").Value

        originalName = row.Cells("Nom_client").Value.ToString()
        originalTelephone = row.Cells("Tel").Value.ToString()
        originalEmail = row.Cells("email").Value.ToString()

        TxtCodeClient.Text = selectedCode.ToString()
        TxtNomClient.Text = originalName
        TxtTelephone.Text = originalTelephone
        TxtEmail.Text = originalEmail

        SetFieldsEnabled(True)
        Save.Enabled = False
        Update.Enabled = False
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "UPDATE Client SET Nom_client = @Nom, Tel = @Tel, email = @Email WHERE code_client = @Code"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Nom", TxtNomClient.Text.Trim())
                    cmd.Parameters.AddWithValue("@Tel", TxtTelephone.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@Code", selectedCode)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Client updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadClientData()
                SetIdleState()
            Catch ex As SqlException
                MessageBox.Show("Database error: " & ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If dgvclient.CurrentRow Is Nothing Then
            MessageBox.Show("Select a client in the grid first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim codeToDelete = dgvclient.CurrentRow.Cells("code_client").Value

        Dim confirm = MessageBox.Show("Delete this client?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "DELETE FROM Client WHERE code_client = @Code"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Code", codeToDelete)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Client deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadClientData()
                SetIdleState()
            Catch ex As SqlException
                MessageBox.Show("Database error: " & ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Field_TextChanged(sender As Object, e As EventArgs) Handles TxtNomClient.TextChanged, TxtTelephone.TextChanged, TxtEmail.TextChanged
        If isAdding Then
            Save.Enabled = TxtNomClient.Text.Trim() <> "" AndAlso
                            TxtTelephone.Text.Trim() <> "" AndAlso
                            TxtEmail.Text.Trim() <> ""
        ElseIf isEditing Then
            Update.Enabled = TxtNomClient.Text.Trim() <> originalName OrElse
                               TxtTelephone.Text.Trim() <> originalTelephone OrElse
                               TxtEmail.Text.Trim() <> originalEmail
        End If
    End Sub

End Class