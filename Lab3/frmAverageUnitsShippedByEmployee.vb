Option Strict On
''' <summary>
''' Author: Nicholas Lindsay
''' Project name: Average Unit shipped by Employee
''' Date: 07 March 2018
''' Description: Create Windows application that creates a 2 dimensional array that allows three employee's to enter their units shipped in a week.
''' It will allow for every employee to be calculated and an overall average.
''' </summary>
Public Class frmAverageUnitsShippedByEmployees

    ' Constants
    Private Const finalRowIndex As Integer = 3
    Private Const finalColumnIndex As Integer = 6

    ' For a 2 dimensional array
    ' 3 columns = 7
    ' 2 rows = 3

    ' Variables
    Private numberArray(finalRowIndex, finalColumnIndex) As Double  ' Array for final row and column
    Private soldUnitsArray(amountOfEmployees, totaldays) As Integer ' Array for amount of employee cut off and total day
    Private presentColumnIndex As Integer = 0                       ' This declares a variable for the present column index
    Private employeeInputValidator As Integer = 0                   ' This declares a variable for a private function for validation
    Private employeeInput As String                                 ' This stores the employee input as a string
    Private employeeAvgCounter As Integer                           ' This declares a variable for the average counter
    Const minimumInputValue As Integer = 0                          ' This declares that no values can be smaller than 0
    Const maximumInputValue As Integer = 1000                       ' This declares that no values can be bigger than 1000   
    Dim counter As Integer = 0                                      ' This will increase the days everytime a valid number is entered 
    Dim employeeEntry As Integer = 7                                ' This declares that user input cannot be a decimal value
    Dim total3 As Integer = 0                                       ' This declares the total for the third employee
    Dim total2 As Integer = 0                                       ' This declares the total for the second employee
    Dim total As Integer = 0                                        ' This declares the total for the first employee
    Dim employeeCounter As Integer = 0                              ' This variable is for the employee counter
    Dim average As Double = 0                                       ' This declares the average of the average units shipped by dividing the total by 7
    Private output1 As String = String.Empty                        ' This declares the employee output 1 as a string
    Private output2 As String = String.Empty                        ' This declares the employee output 2 as a string
    Private output3 As String = String.Empty                        ' This declares the employee output 3 as a string
    Private average1 As Double                                      ' This declares the average for employee 1 as a double
    Private average2 As Double                                      ' This declares the average for employee 2 as a double
    Private average3 As Double                                      ' This declares the average for employee 3 as a double
    Private avgCounter As Integer = 0                               ' This declares the average counter as an integer
    Private Const totaldays = 7                                     ' This declares the total days in a week
    Private Const amountOfEmployees = 3                             ' This declares the totsl amount of employee in the application
    Dim maxDays As Integer = 7                                      ' This declares the maxdays to be divide by to get the average

    ' This declares the maximum days before cut off

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        employeeInput = txtEmployeeInput.Text
        If counter = totaldays And employeeCounter = 2 Then
            ' If the counter equals total days and employee counter equals 2 then the button enter will be false
            ' The button enable will be true
            btnEnter.Enabled = False
            txtEmployeeInput.Enabled = True
        End If
        ' The employee input variable will be taking the employee input text
        employeeInput = txtEmployeeInput.Text



        If CheckInput(employeeInput, employeeInputValidator) = True Then
            ' If validation is true , it will proceed

            presentColumnIndex += 1

            soldUnitsArray(employeeCounter, totaldays) = employeeInputValidator
            ' An Array for for the employee counter and days to increment

            If employeeCounter = 0 Then
                ' If the employee counter is equal to 0 which is the first column , the values will be outputted into the output
                ' The total days will also increse
                output1 += soldUnitsArray(employeeCounter, totaldays).ToString() & vbCrLf
            ElseIf employeeCounter = 1 Then
                ' If the employee counter is equal to 1 which is the second column , the values will be outputted into the output
                output2 += soldUnitsArray(employeeCounter, totaldays).ToString() & vbCrLf
            ElseIf employeeCounter = 2 Then
                ' If the employee counter is equal to 2 which is the third column , the values will be outputted into the output
                output3 += soldUnitsArray(employeeCounter, totaldays).ToString() & vbCrLf

            End If
            ' Message box to display Message for error
        Else
            MessageBox.Show("Please enter a number between 0 and 1000") ' If number is not valid or not between the range message will display
        End If
        ' If value passes validation the value will be stored into the employee ouput label
        ' The text box will becaome empty and the focus will go back to the text box as well
        txtEmployeeInput.Text = ""
        txtEmployeeInput.Focus()


        counter += 1                                       ' This will allow users to input an amount and will add a day everytime they press enter 
        lblDays.Text = "Day: " & counter + 1

        If (counter > 6 And employeeCounter = 0) Then      ' If the counter has 6 values for first dimension it will restart its days
            lblDays.Text = ""                              ' This will make the day label empty and restart in a new column for the next employee 

            For counter As Integer = 0 To totaldays - 1  ' This will include value 0 as an integer and will stop the counter when it reaches 7
                total += soldUnitsArray(employeeCounter, counter)
            Next
        End If
        If counter > 6 And employeeCounter = 0 Then
            ' If counter is greater than 6 and employee counter is zero
            ' Calculate the average for employee 1
            For employeeAvgCounter As Integer = 0 To totaldays
                average1 = average1 + soldUnitsArray(employeeCounter, employeeAvgCounter)
            Next
            ' The average 1 will display in the average 1 label box
            average1 += total / (maxDays + 1)
            'Displays message with the value of the average rounded to 2 decimal places
            lblAverage1.Text = "Average: " & average1.ToString("n2")

        End If
        If counter > 6 And employeeCounter = 1 Then
            ' If counter is greater than 6 and employee counter is one
            ' Calculate the average for employee 2
            For employeeAvgCounter As Integer = 0 To totaldays
                average2 = average2 + soldUnitsArray(employeeCounter, employeeAvgCounter)

            Next
            ' The average 1 will display in the average 1 label box
            average2 += total2 / (maxDays + 1)
            'Displays message with the value of the average rounded to 2 decimal places
            lblAverage2.Text = "Average: " & average2.ToString("n2")
        End If
        If counter > 6 And employeeCounter = 2 Then
            ' If counter is greater than 6 and employee counter is two
            ' Calculate the average for employee 3
            For employeeAvgCounter As Integer = 0 To totaldays
                average3 = average3 + soldUnitsArray(employeeCounter, employeeAvgCounter)

            Next
            ' The average 1 will display in the average 1 label box
            average3 += total3 / (maxDays + 1)
            ' Displays message with value of the average rounded to 2 decimal places
            lblAverage3.Text = "Average: " & average3.ToString("n2")
        End If

        If (employeeCounter = amountOfEmployees) Then
            btnEnter.Enabled = False                   ' This will stop user from clicking enter when it reaches the 7th day of the third employee
            txtEmployeeInput.Enabled = False

        End If

        If counter > 6 Then          '
            employeeCounter += 1
            counter = 0

        End If
        ' Output text variables
        lblEmployeeOutput1.Text = output1
        ' Employee ouput text is equal to variable output1
        lblEmployeeOutput2.Text = output2
        ' Empolyee output text is equal to variable output2
        lblEmployeeOutput3.Text = output3
        ' Employee output text is equal to variable ouput 3
    End Sub
    Private Function CheckInput(ByVal employeeInput As String, ByRef employeeInputValidator As Integer) As Boolean
        ' Private Function to for tryParse to see if values entered are valid
        ' Declare variables that will be used in this function
        Dim employeeInputNumber As Integer = 0                 ' This declares the employees input as an integer
        Dim returnValue As Boolean                             ' This will return the value if it passes the validation

        If (Integer.TryParse(employeeInput, employeeInputNumber)) Then   ' Validates to see if the value is numeric

            If employeeInputNumber >= 0 And employeeInputNumber <= 1000 Then ' Validates to see if the employee input is in between the giving range
                employeeInputValidator = employeeInputNumber
                returnValue = True
                ' If value passes validator it will go farward
            Else
                returnValue = False ' It will return false if it does not pass validator
            End If
        Else
            returnValue = False
        End If
        ' Return the return value
        Return returnValue

    End Function
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Allows users to close the program
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' This will allows users to reset the program

        txtEmployeeInput.Text = ""               ' This will make the the employee input clear
        lblEmployeeOutput1.ResetText()           ' This will clear the first employee output box 
        lblEmployeeOutput2.ResetText()           ' This will clear the second employee output box
        lblEmployeeOutput3.ResetText()           ' This will clear the third employee output box
        lblAverage1.ResetText()                  ' This will reset the average label box for employee 1
        lblAverage2.ResetText()                  ' This will reset the average label box for employee 2
        lblAverage3.ResetText()                  ' This will reset the average label box for employee 3
        lblDays.ResetText()                      ' This will reset the day counter to zero
        btnEnter.Enabled = True                  ' This will allow the enter button to be used again
        counter = 0                              ' This will reset the counter back to 0
        total = 0                                ' This will reset the total back to 0
        average = 0                              ' This will reset the average back to 0
        txtEmployeeInput.Focus()                 ' This will focus back on the employee input box
        total2 = 0                               ' This will reset the total2 to zero
        total3 = 0                               ' This will reset the total3 to zero
    End Sub


End Class
