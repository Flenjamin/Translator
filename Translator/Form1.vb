Imports System.Diagnostics.Eventing.Reader

Public Class Form1

    Private Function GetWord()
        If radMother.Checked And cbl.SelectedIndex = 0 Then
            Return "Mere"
        ElseIf radMother.Checked And cbl.SelectedIndex = 1 Then
            Return "Madre"
        ElseIf radMother.Checked And cbl.SelectedIndex = 2 Then
            Return "Madre"
        ElseIf radFather.Checked And cbl.SelectedIndex = 0 Then
            Return "Pere"
        ElseIf radFather.Checked And cbl.SelectedIndex = 1 Then
            Return "Padre"
        ElseIf radFather.Checked And cbl.SelectedIndex = 2 Then
            Return "Padre"
        ElseIf radSister.Checked And cbl.SelectedIndex = 0 Then
            Return "sœur"
        ElseIf radSister.Checked And cbl.SelectedIndex = 1 Then
            Return "hermana"
        ElseIf radSister.Checked And cbl.SelectedIndex = 2 Then
            Return "sorella"
        ElseIf radBrother.Checked And cbl.SelectedIndex = 0 Then
            Return "Frere"
        ElseIf radBrother.Checked And cbl.SelectedIndex = 1 Then
            Return "Hermano"
        ElseIf radBrother.Checked And cbl.SelectedIndex = 2 Then
            Return "fratello"
        End If
    End Function
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles radSister.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbl.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btntranslate_Click(sender As Object, e As EventArgs) Handles btntranslate.Click
        Label1.Text = GetWord()
    End Sub

    Private Sub btnext_Click(sender As Object, e As EventArgs) Handles btnext.Click
        Dim dglButton As DialogResult
        dglButton = MessageBox.Show("Do you want to exit?",
                                    "Big Nuts",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Exclamation)

        If dglButton = DialogResult.No Then
            
        End If
    End Sub
End Class
