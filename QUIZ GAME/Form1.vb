Imports System

Public Class Form1
    Public Class QuizGame
        ' Variables to hold the score for each subject
        Private Const totalQuestionsPerTab As Integer = 3  ' Each tab has 3 questions

        ' Load event to initialize the correct answers
        Private Sub QuizGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Example answer setup, you can customize based on actual answers
            SetCorrectAnswers()
        End Sub

        ' Store correct answers for each question
        Private Sub SetCorrectAnswers()
            ' Assuming the first RadioButton in each GroupBox is the correct one
            radTb1Answer1A.Tag = True
            radTb1Answer2C.Tag = True
            radTb1Answer3B.Tag = True

            radTb2Answer1A.Tag = True
            radTb2Answer2A.Tag = True
            radTb2Answer3B.Tag = True

            radTb3Answer1A.Tag = True
            radTb3Answer2B.Tag = True
            radTb3Answer3C.Tag = True
        End Sub

        ' Check answers and calculate score for each subject
        Private Function CalculateScore(tab As TabPage) As Integer
            Dim score As Integer = 0
            For Each grpBox As GroupBox In tab.Controls.OfType(Of GroupBox)()
                For Each radBtn As RadioButton In grpBox.Controls.OfType(Of RadioButton)()
                    If radBtn.Checked AndAlso radBtn.Tag = True Then
                        score += 1
                        Exit For
                    End If
                Next
            Next
            Return score
        End Function

        ' Handle the submit button click for each tab
        Private Sub btnSubmitTb3_Click(sender As Object, e As EventArgs) Handles btnSubmitTb3.Click
            Dim physicsScore = CalculateScore(TbPhysics)
            DisplayResults(physicsScore, "Physics")
            lblScoreTb3.Text = "Your score is: " & physicsScore & " out of " & totalQuestionsPerTab
        End Sub

        Private Sub btnSubmitTb1_Click(sender As Object, e As EventArgs) Handles btnSubmitTb1.Click
            Dim historyScore = CalculateScore(TbHistory)
            lblScoreTb1.Text = "Your score is: " & historyScore & " out of " & totalQuestionsPerTab
            DisplayResults(historyScore, "History")
        End Sub

        Private Sub btnSubmitTb2_Click(sender As Object, e As EventArgs) Handles btnSubmitTb2.Click
            Dim englishScore = CalculateScore(TbEnglish)
            DisplayResults(englishScore, "English")
            lblScoreTb2.Text = "Your score is: " & englishScore & " out of " & totalQuestionsPerTab
        End Sub

        ' Display results and calculate grade for each tab separately
        Private Sub DisplayResults(score As Integer, subject As String)
            Dim percentage As Double = (score / totalQuestionsPerTab) * 100
            Dim grade As String = DetermineGrade(percentage)

            lblPercentageTb3.Text = "Your percentage is:  " & percentage.ToString() & "%"
            lblGradeTb3.Text = "Your grade is: " & grade

            lblPercentageTb2.Text = "Your percentage is:  " & percentage.ToString() & "%"
            lblGradeTb2.Text = "Your grade is: " & grade

            lblPercentageTb1.Text = "Your percentage is:  " & percentage.ToString() & "%"
            lblGradeTb1.Text = "Your grade is: " & grade

            MessageBox.Show($"{subject} Score: {score}/{totalQuestionsPerTab}" & Environment.NewLine &
                        $"Percentage: {percentage:F2}%" & Environment.NewLine &
                        $"Grade: {grade}", $"{subject} Results")
        End Sub

        ' Determine grade based on percentage
        Private Function DetermineGrade(percentage As Double) As String
            Select Case percentage
                Case >= 80
                    Return "A"
                Case >= 60
                    Return "B"
                Case >= 40
                    Return "C"
                Case Else
                    Return "F"
            End Select
        End Function
    End Class

End Class
'    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

'    End Sub

'    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles radTb2Answer1c.CheckedChanged

'    End Sub

'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub

'    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

'    End Sub



'    Public Class FormWithTabs
'        Inherits Form


'        Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click






'            Dim correctAnswer1Tab3 As String = "Newton"    'Correct answer question 1

'            Dim correctAnswer2Tab3 As Decimal = "Mass"   'Correct answer question 2

'            Dim correctAnswer3Tab3 As String = "Power"    'Correct answer question 3



'            'Users score
'            Dim score As Integer = 0
'            Dim totalQuestions As Integer = 3




'            ' Question 1
'            If radTb3Answer1A.Checked Then
'                score += 1  ' Add 1 point if correct
'            End If

'            ' Question 2
'            If radTb3Answer2B.Checked Then
'                score += 1
'            End If

'            ' Question 3
'            If radTb3Answer3C.Checked Then
'                score += 1
'            End If


'            End If




'            ' Display the result
'            labelResultTb3.Text = "Your score is: " & score.ToString() & " out of " & totalQuestions



'            'Displaying the grade

'            Dim percentage As Integer = (score / totalQuestions) * 100
'            Dim grade As String

'            If percentage >= 90 Then
'                grade = "A"
'            ElseIf percentage >= 80 Then
'                grade = "B"
'            ElseIf percentage >= 60 Then
'                grade = "C"
'            ElseIf percentage >= 50 Then
'                grade = "D"
'            ElseIf percentage >= 30 Then
'                grade = "E"
'            ElseIf percentage >= 0 Then
'                grade = "F"

'            Else
'                grade = "Invalid Input!"
'            End If

'            labelPercentageTb3.Text = "Your percentage is:  " & percentage.ToString() & "%"

'            labelGradeTb3.Text = "Your grade is: " & grade








'        End Sub


'        Private Sub ClearAnswers(sender As Object, e As EventArgs)

'            ' Clear RadioButton selections for each question
'            radAnswer1C.Checked = False
'            radAnswer2B.Checked = False
'            radAnswer3A.Checked = False
'            radAnswer4A.Checked = False
'            radAnswer5B.Checked = False
'            radAnswer6C.Checked = False


'            ' Clear the result display label
'            labelResultTb3.Text = ""
'        End Sub




'        Private Sub Label4_Click(sender As Object, e As EventArgs) Handles labelResultTb3.Click

'        End Sub

'        Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles labelGradeTb.Click

'        End Sub

'        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        End Sub

'        Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

'        End Sub

'        Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

'        End Sub
'    End Class
'    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles radTb3Answer1B.CheckedChanged

'    End Sub

'    Private Sub TbPhysics_Click(sender As Object, e As EventArgs) Handles TbPhysics.Click

'    End Sub

'    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

'        ' Public Class QuizForm

'        ' Define variables to track the selected answers and scores
'        Private selectedAnswers As New Dictionary(Of String, String)
'        Private score As Integer = 0

'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Initialize questions and choices here if needed
'        ' For example, set default values or enable/disable controls as necessary
'    End Sub

'    ' Method to check answers for Tab 1
'    Private Sub CheckAnswersTab1()


'        If radTb1Answer1A.Checked Then selectedAnswers("George Washington ") = "A"
'        End If
'        If radTb1Answer1B.Checked Then selectedAnswers("Thomas Jefferson") = "B"
'        If radTb1Answer1C.Checked Then selectedAnswers("Abraham Lincoln") = "C"

'        If radTb1Answer2A.Checked Then selectedAnswers("Greece") = "A"
'        If radTb1Answer2B.Checked Then selectedAnswers("Rome") = "B"
'        If radTb1Answer2C.Checked Then selectedAnswers("Egypt") = "C"

'        If radTb1Answer3A.Checked Then selectedAnswers("Albert Einstein") = "A"
'        If radTb1Answer3B.Checked Then selectedAnswers("Isaac Newton") = "B"
'        If radTb1Answer3C.Checked Then selectedAnswers("Gallileo Gallilei") = "C"

'        ' Define correct answers for Tab 1 questions
'        Dim correctAnswersTab1 As New Dictionary(Of String, String) From {
'            {"George Washington", "A"},
'            {"Egypt", "C"},
'            {"Isaac Newton", "B"}
'}

'        ' Check answers for Tab 1
'        score += CheckScore(correctAnswersTab1)
'    End Sub

'    ' Method to check answers for Tab 2
'    Private Sub CheckAnswersTab2()

'        If RadioButton1Tab2Q1.Checked Then selectedAnswers("Tab2Q1") = "A"
'        If RadioButton2Tab2Q1.Checked Then selectedAnswers("Tab2Q1") = "B"
'        If RadioButton3Tab2Q1.Checked Then selectedAnswers("Tab2Q1") = "C"

'        If RadioButton1Tab2Q2.Checked Then selectedAnswers("Tab2Q2") = "A"
'        If RadioButton2Tab2Q2.Checked Then selectedAnswers("Tab2Q2") = "B"
'        If RadioButton3Tab2Q2.Checked Then selectedAnswers("Tab2Q2") = "C"

'        If RadioButton1Tab2Q3.Checked Then selectedAnswers("Tab2Q3") = "A"
'        If RadioButton2Tab2Q3.Checked Then selectedAnswers("Tab2Q3") = "B"
'        If RadioButton3Tab2Q3.Checked Then selectedAnswers("Tab2Q3") = "C"

'        ' Define correct answers for Tab 2 questions
'        Dim correctAnswersTab2 As New Dictionary(Of String, String) From {
'            {"Tab2Q1", "B"},
'            {"Tab2Q2", "C"},
'            {"Tab2Q3", "A"}

'        }

'        ' Check answers for Tab 2
'        score += CheckScore(correctAnswersTab2)
'    End Sub

'    ' Method to check answers for Tab 3
'    Private Sub CheckAnswersTab3()
'        If RadioButton1Tab3Q1.Checked Then selectedAnswers("Tab3Q1") = "A"
'        If RadioButton2Tab3Q1.Checked Then selectedAnswers("Tab3Q1") = "B"
'        If RadioButton3Tab3Q1.Checked Then selectedAnswers("Tab3Q1") = "C"

'        If RadioButton1Tab3Q2.Checked Then selectedAnswers("Tab3Q2") = "A"
'        If RadioButton2Tab3Q2.Checked Then selectedAnswers("Tab3Q2") = "B"
'        If RadioButton3Tab3Q2.Checked Then selectedAnswers("Tab3Q2") = "C"

'        If RadioButton1Tab3Q3.Checked Then selectedAnswers("Tab3Q3") = "A"
'        If RadioButton2Tab3Q3.Checked Then selectedAnswers("Tab3Q3") = "B"
'        If RadioButton3Tab3Q3.Checked Then selectedAnswers("Tab3Q3") = "C"

'        ' Define correct answers for Tab 3 questions
'        Dim correctAnswersTab3 As New Dictionary(Of String, String) From {
'            {"Tab3Q1", "C"},
'            {"Tab3Q2", "A"},
'            {"Tab3Q3", "B"}

'        }

'        ' Check answers for Tab 3
'        score += CheckScore(correctAnswersTab3)
'    End Sub

'    ' Helper method to check answers and calculate score
'    Private Function CheckScore(correctAnswers As Dictionary(Of String, String)) As Integer
'        Dim tabScore As Integer = 0
'        For Each question As String In correctAnswers.Keys
'            If selectedAnswers.ContainsKey(question) AndAlso selectedAnswers(question) = correctAnswers(question) Then
'                tabScore += 1
'            End If
'        Next
'        Return tabScore
'    End Function

'    ' Button click event to submit answers and calculate total score
'    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
'        ' Reset score and selected answers
'        score = 0
'        selectedAnswers.Clear()

'        ' Check answers for each tab
'        CheckAnswersTab1()
'        CheckAnswersTab2()
'        CheckAnswersTab3()

'        ' Display final score
'        MessageBox.Show("Your score is: " & score & " out of 9")
'    End Sub

'End Class