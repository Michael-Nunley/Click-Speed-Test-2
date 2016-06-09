'So this program collects the amount of times you can click a button with in some amount of seconds, 10 by default, 
'and records the highest amount of clicks. This also allows for a change in the duration, it compares the amount of clicks
'"this run" to the highest amount before "High Score",and theres an easy way to reset the "HighestScore".
Public Class frmMain
    'This is the amount of time that the test will take
    Dim interval As Decimal = 10 'Defaults to 10
    'Holds the information of the Highest amount of clicks
    Public HighestScore As Decimal
    'Current seconds counted
    Dim count As Decimal = 0
    'Current amount of clicks clicked 
    Dim clicks As Integer = 0
    'Clicks per second
    Dim cps As Decimal = 0
    'A way for me to check if the amount of clicks was higher than the highest recorded amount of clicks
    Dim isClicksMore As Boolean
    'This is a check if the record and amount of clicks are equal
    Dim isEqualClicks As Boolean
    'These are for the random messages sent when you press the reset button
    Dim rand As New Random
    Dim randnum As Integer
    Private Sub tmrCounter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCounter.Tick
        'Counts up to what ever the interval is set to
        If count < interval Then 'If the time is less than what ever the interval is set to
            count += 0.01 'Add one millisecond to the time counter
            'Updates the label
            lblTimer.Text = count
        Else 'Once it is higher than what ever the interval is set to
            'Gets the clicks per second
            cps = clicks / interval
            If cps > HighestScore Then 'If the clicks per second is higher than the Highest score
                'Sets the click check boolean to true
                isClicksMore = True
                'Then set the amount of clicks to the HighestScore
                HighestScore = cps
                lblHighestClicksPerSecond.Text = "Highest clicks per second - [" & HighestScore & "]"
                isEqualClicks = False
            ElseIf cps = HighestScore Then ' if it is the same, sets isEqualClicks to true
                isEqualClicks = True
                'and isClicksMore to false
                isClicksMore = False
                'Probably unnessissary, but why not?
            Else 'I don't think this is ever used
                isEqualClicks = False
                isClicksMore = False
                'But it's a good idea to have it anyway. Nothing is broken!
            End If
            'Sets the text to the highestScore
            lblHighestClicksPerSecond.Text = "Highest clicks per second - [" & HighestScore & "]"
            'Disables the click button so you don't reset things with out noticing
            cmdClick.Enabled = False
            'Finally disables the timer to start it all over again
            tmrCounter.Enabled = False
        End If
    End Sub
    Private Sub cmdClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClick.Click
        'Makes sure it is less than what ever the interval is set to seconds on the clock
        If count < interval Then
            'Adds one to the amount of clicks
            clicks += 1
            'Enables the counting timer, the timer isn't automatically on
            tmrCounter.Enabled = True
            'Sets the text of the click button to the amount of clicks
            cmdClick.Text = clicks
            'Makes it so you can't cheat!
            cmdSetInterval.Enabled = False
            'Makes a sound!
            System.Console.Beep(1234, 1)
        End If
        'Makes it so you can't hold enter
        cmdReset.Focus.Equals(1)
    End Sub
    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        'Calculates the amount of clicks per second
        cps = clicks / interval
        'Makes the messages gramically correct
        If cps = 1 Then
            'Checks if the amount of clicks this time was more, less, or equal to the previous record
            If isClicksMore Then
                MsgBox("You clicked the button once a second." & vbNewLine & "This is higher than the previously highest record.")
            ElseIf isEqualClicks Then
                MsgBox("You clicked the button once a second." & vbNewLine & "This is the same as the highest record.")
            Else
                MsgBox("You clicked the button once a second." & vbNewLine & "This is lower than the highest record.")
            End If
        ElseIf cps = 0 Then
            'Random messages when you press the reset button with out clicking the "Click!" button
            randnum = rand.Next(7)
            Select Case randnum
                Case 0
                    MsgBox("You clicked the reset button." & vbNewLine & "Congrats.")
                Case 1
                    MsgBox("I bet you feel good after clicking that reset button.")
                Case 2
                    MsgBox("Tell me, how did it feel" & vbNewLine & "To click the reset button?")
                Case 3
                    MsgBox("You clicked the reset button." & vbNewLine & "Aren't you special?")
                Case 4
                    MsgBox("Don't you have anything better to do?" & vbNewLine & "Other than click the reset button, of course?")
                Case 5
                    MsgBox("Don't you think that")
                    MsgBox("Maybe")
                    MsgBox("Just maybe")
                    MsgBox("The reset button has feelings too?")
                Case 6
                    MsgBox("Y U HATE RESET BUTTON?")
                Case 7
                    MsgBox("You clicked the reset button." & vbNewLine & "Aren't you special?")
            End Select
        Else
            If isClicksMore Then
                MsgBox("You clicked the button " & cps & " times a second." & vbNewLine & "This is higher than the previously highest record.")
            ElseIf isEqualClicks Then
                MsgBox("You clicked the button " & cps & " times a second." & vbNewLine & "This is the same as the highest record.")
            Else
                MsgBox("You clicked the button " & cps & " times a second." & vbNewLine & "This is lower than the highest record.")
            End If
        End If
            'Disables the timer, incase the button is pressed mid-run
            tmrCounter.Enabled = False
            'If the clicks per second is higher than the Highest score
            cps = clicks / interval
            If cps > HighestScore Then
                'Sets the click check boolean to true
                isClicksMore = True
                'Then set the amount of clicks to the HighestScore
                HighestScore = cps
                lblHighestClicksPerSecond.Text = "Highest clicks per second - [" & HighestScore & "]"
                isEqualClicks = False
            ElseIf clicks = HighestScore Then
                isEqualClicks = True
                isClicksMore = False
            Else
                isEqualClicks = False
                isClicksMore = False
            End If
            'Re-Enables the click button
            cmdClick.Enabled = True
            cmdClick.Text = "Click!" 'Sets the text of the button back to Click!
            'Resets everything back to it's default value besides the HighestScore
            count = 0
            clicks = 0
            'Sets the text to the highestScore
            lblHighestClicksPerSecond.Text = "Highest clicks per second - [" & HighestScore & "]"
            'Resets the timer text
            cmdSetInterval.Enabled = True
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load the all time highest recorded click amount
        HighestScore = My.Computer.FileSystem.ReadAllText("P:\Programming 2\Other Programs\ClickySpeed\ClickySpeed\highestScore.txt")
        'Sets the text to the highestScore
        lblHighestClicksPerSecond.Text = "Highest clicks per second - [" & HighestScore & "]"
        'Deletes file 
        My.Computer.FileSystem.DeleteFile("P:\Programming 2\Other Programs\ClickySpeed\ClickySpeed\highestScore.txt")
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        'This saves the highestscore to the text document
        My.Computer.FileSystem.WriteAllText("P:\Programming 2\Other Programs\ClickySpeed\ClickySpeed\highestScore.txt", HighestScore, True)
        Me.Close()
    End Sub
    Private Sub cmdSetInterval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetInterval.Click
        'Collects a user imputed timer for the test
        Try 'Makes sure the imput is only a number and not a letter or some other kind of symbol
            interval = InputBox("Click Speed Test", "Set the time for the timer to count to to find your speed")
        Catch 'If it is something besides a number, sends a message to the user informing them
            MsgBox("Can't have a non-numarical as the interval or a non-reasoniable number")
        End Try
        'Lets the user know what the interval is if they go to the file menu again
        cmdSetInterval.Text = "Set Interval [" & interval & "]"
    End Sub
    Private Sub cmdResetHighestScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResetHighestScore.Click
        'Resets the value of HighestScore
        HighestScore = 0
        'Updates the information
        lblHighestClicksPerSecond.Text = "Highest clicks per second - [" & HighestScore & "]"
    End Sub
End Class