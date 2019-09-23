Imports System.ComponentModel

Public Class frmDiceGame
    Dim Die1, Die2 As Integer
    Dim DicePoints As Integer = 0
    Dim DealerPoints As Integer = 0
    Dim DiceCount As Integer = 0
    Dim DealerCount As Integer = 0
    Dim random As Random
    Dim RollCount As Integer = 0
    Dim DealerRollCount As Integer = 0
    Dim Chips As Integer = 100
    Dim DealerLoadCount As Integer = 0
    Dim GameScore, DealerScore As Integer
    Dim DealerCanChoose1 As Boolean
    Dim DealerCanChoose2 As Boolean
    Dim DealerCanChooseBoth As Integer

    Dim PlayerStood As Boolean = False
    Dim DealerStood As Boolean = False
    Private Sub frmDiceGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Initialises dice images to 6
        pbxPlayerDie1.Image = My.Resources.dieface6
        pbxPlayerDie2.Image = My.Resources.dieface6

        pbxDealerDie1.Image = My.Resources.reddieface6
        pbxDealerDie2.Image = My.Resources.reddieface6
        'Initialises Chips


    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Starts the timer when Start is clicked
        tmrPlayer.Start()
        btnReset.Enabled = False
        btnStart.Enabled = False

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clears variable and list values when reset is clicked
        GameScore = 0
        DealerScore = 0
        Die1 = 0 : Die2 = 0
        RollCount = 0
        DealerRollCount = 0
        DealerCount = 0
        lblPlayerScore.Text = "Player: 0"
        lblDealerScore.Text = "Dealer: 0"
        lblPlayerScore.ForeColor = Color.White
        lblDealerScore.ForeColor = Color.White
        btnStart.Enabled = True
        btnHit.Enabled = False
        btnStand.Enabled = False
        DealerStood = False
        PlayerStood = False

    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrPlayer.Tick
        'Increments the load bar every tick
        random = New Random

        prbLoad.Increment(4)

        If prbLoad.Value = 100 Then

            btnStart.Enabled = False
            btnStand.Enabled = True

            'Adds the necessary points on the random dice when the load bar reaches 100
            tmrPlayer.Stop()
            prbLoad.Value = 0
            RollCount += 1

            DiceCount = Die1 + Die2
            DicePoints = DiceCount * 2

            If RollCount = 1 Then
                GameScore += DicePoints
            End If
            lblPlayerScore.Text = "Player: " & GameScore
            DicePoints = 0
            btnReset.Enabled = True
            'Checks if a score improvement is possible
            If GameScore + 2 < 22 Then
                btnHit.Enabled = True
            End If
            'Checks if player has gone bust
            If GameScore > 21 Then
                tmrPlayer.Stop()
                PlayerGoneBust()
            End If

            If RollCount >= 2 Then
                'Populates option preview
                btnUseDie1.Text = "Add First Die (" & Die1 * 2 & ")"
                btnUseDie2.Text = "Add Second Die (" & Die2 * 2 & ")"
                btnUseBothDice.Text = "Add Both Dice (" & (Die1 + Die2) * 2 & ")"
                btnStand.Enabled = False
                btnHit.Enabled = False
                'Presents dice add options if they are available
                If GameScore + Die1 * 2 <= 21 Then
                    btnUseDie1.Enabled = True
                End If

                If GameScore + Die2 * 2 <= 21 Then
                    btnUseDie2.Enabled = True
                End If

                If GameScore + (Die1 + Die2) * 2 <= 21 Then
                    btnUseBothDice.Enabled = True
                End If
                'If no options are available then the player is bust
                If Not (btnUseDie1.Enabled Or btnUseDie2.Enabled Or btnUseBothDice.Enabled) Then
                    tmrPlayer.Stop()
                    PlayerGoneBust()
                End If
            End If


        Else
            'Sets dice to random number when the timer ticks before the load bar is full
            Die1 = random.Next(1, 7)
            Die2 = random.Next(1, 7)

            MatchImage(True, Die1, pbxPlayerDie1)
            MatchImage(True, Die2, pbxPlayerDie2)

        End If

    End Sub

    Private Sub TmrDealer_Tick(sender As Object, e As EventArgs) Handles tmrDealer.Tick
        tmrDealer.Interval = 100
        random = New Random
        If GameScore > 21 Then
            tmrDealer.Stop()
            DealerStand()
        End If

        DealerLoadCount += 4

        If DealerLoadCount = 100 Then
            tmrDealer.Stop()
            'Resets dealer load bar and resets the dealers choices
            DealerLoadCount = 0
            DealerCanChoose1 = False
            DealerCanChoose2 = False
            DealerCanChooseBoth = False
            btnReset.Enabled = True
            'Adds the necessary points on the random dice when the load bar reaches 100
            DealerRollCount += 1
            'Sets the number of dots on the dice (count) and the corresponding points
            DealerCount = Die1 + Die2
            DealerPoints = DealerCount * 2

            If DealerRollCount = 1 Then
                'Adds the points if its the first roll
                DealerScore += DealerPoints
                If DealerScore > GameScore Then
                    DealerStand()
                End If

            Else
                'Checks if the dealer can add any more score after hitting
                If DealerScore + Die1 * 2 <= 21 Then
                    DealerCanChoose1 = True
                End If
                If DealerScore + Die2 * 2 <= 21 Then
                    DealerCanChoose2 = True
                End If
                If DealerScore + (Die1 + Die2) * 2 <= 21 Then
                    DealerCanChooseBoth = True
                End If
                'Picks the highest option for the dealer out of those available and will roll again
                If DealerCanChoose1 And Not (DealerCanChoose2 Or DealerCanChooseBoth) Then
                    DealerScore += Die1 * 2
                ElseIf DealerCanChoose2 And Not (DealerCanChoose1 Or DealerCanChooseBoth) Then
                    DealerScore += Die2 * 2
                ElseIf DealerCanChooseBoth Then
                    DealerScore += (Die1 + Die2) * 2
                ElseIf DealerCanChoose1 And DealerCanChoose2 Then
                    If Die1 > Die2 Then
                        DealerScore += Die1 * 2
                    Else
                        DealerScore += Die2 * 2
                    End If
                End If
                If Not (DealerCanChoose1 Or DealerCanChoose2 Or DealerCanChooseBoth) Then
                    'Dealer goes bust if no options are available
                    If Die1 < Die2 Then
                        DealerScore += Die1 * 2
                    Else
                        DealerScore += Die2 * 2
                    End If
                    DealerStand()
                    tmrDealer.Stop()

                ElseIf DealerScore > GameScore Then
                    'Dealer stands if their score is more than the player's
                    DealerStand()
                Else
                    DealerRoll()
                End If



            End If

            'Adds Score to list
            lblDealerScore.Text = "Dealer: " & DealerScore
            DealerPoints = 0
            'Adds 2 second pause between dealer rolls
            tmrDealer.Interval = 2000
            'Checks if the dealer has gone over 21
            If DealerScore > 21 Then
                DealerStand()
                tmrDealer.Stop()

                'Dealer will stand if it has a score over 16
            ElseIf DealerScore > 16 Then
                DealerStand()
                tmrDealer.Stop()
                btnReset.Enabled = True
            Else
                DealerRoll()
            End If

        ElseIf Not DealerStood Then
            'Sets random dice while the roll is ongoing
            Die1 = random.Next(1, 7)
            Die2 = random.Next(1, 7)

            MatchImage(False, Die1, pbxDealerDie1)
            MatchImage(False, Die2, pbxDealerDie2)

        End If

    End Sub

    Private Sub TmrGameControl_Tick(sender As Object, e As EventArgs) Handles tmrGameControl.Tick
        If DealerStood And PlayerStood Then
            tmrDealer.Stop()
            tmrPlayer.Stop()
            DealerStood = False
            PlayerStood = False
            btnReset.Enabled = True

            lblDealerScore.Text = "Dealer: " & DealerScore
            If GameScore > 21 Then
                MsgBox("Player Went Bust, Dealer Wins!")
                lstScore.Items.Add("Dealer Won")
            ElseIf DealerScore > 21 Then
                MsgBox("Dealer Went Bust, Player Wins!")
                lstScore.Items.Add("Player Won")
            ElseIf GameScore > DealerScore Then
                MsgBox("Player Wins")
                lstScore.Items.Add("Player Won")
            Else
                MsgBox("Dealer Wins")
                lstScore.Items.Add("Dealer Won")
            End If

        End If
    End Sub

    Private Sub BtnUseDie1_Click(sender As Object, e As EventArgs) Handles btnUseDie1.Click
        'Disables other options
        GameScore += Die1 * 2
        DisableOptions()

    End Sub
    Private Sub BtnUseDie2_Click(sender As Object, e As EventArgs) Handles btnUseDie2.Click
        GameScore += Die2 * 2
        DisableOptions()

    End Sub
    Private Sub BtnUseBothDice_Click(sender As Object, e As EventArgs) Handles btnUseBothDice.Click
        GameScore += (Die1 + Die2) * 2
        DisableOptions()
    End Sub


    Private Sub BtnHit_Click(sender As Object, e As EventArgs) Handles btnHit.Click
        'Prevents the player from choosing options while hitting and restarts timer
        btnReset.Enabled = False
        btnHit.Enabled = False
        btnStand.Enabled = False
        tmrPlayer.Start()
    End Sub

    Private Sub BtnStand_Click(sender As Object, e As EventArgs) Handles btnStand.Click
        PlayerStand()

    End Sub

    Sub DealerRoll()
        'Prevents resetting during a roll
        btnReset.Enabled = False
        tmrDealer.Start()
    End Sub

    Sub PlayerStand()
        'When the player stands, font becomes yellow and the dealer timer starts
        btnHit.Enabled = False
        btnStand.Enabled = False
        PlayerStood = True

        lblPlayerScore.ForeColor = Color.FromArgb(255, 255, 102)
        tmrDealer.Start()
        btnReset.Enabled = False
    End Sub

    Sub DealerStand()
        'When the player stands, font becomes yellow
        tmrDealer.Stop()
        lblDealerScore.Text = "Dealer: " & DealerScore
        lblDealerScore.ForeColor = Color.FromArgb(255, 255, 102)
        DealerStood = True
    End Sub

    Sub DisableOptions()
        'Prevents player from selecting any more score adding options after one has been chosen
        btnUseDie1.Enabled = False
        btnUseDie2.Enabled = False
        btnUseBothDice.Enabled = False

        lblPlayerScore.Text = "Player: " & GameScore
        btnStand.Enabled = True
        If GameScore + 2 > 21 Then
            btnHit.Enabled = False
        Else
            btnHit.Enabled = True
        End If

    End Sub

    Sub DealerGoneBust()
        'Updates Score when the dealer goes bust
        If DealerStood = False Then 'Checks the dealer isn't already bust
            If DealerScore < 22 Then
                If Die1 > Die2 Then
                    DealerScore += Die1 * 2
                Else
                    DealerScore += Die2 * 2
                End If
            End If
            DealerStand()

        End If

    End Sub


    Sub PlayerGoneBust()
        'Updates labels if the player goes bust
        If GameScore < 22 Then
            If Die1 > Die2 Then
                GameScore += Die1 * 2
            Else
                GameScore += Die2 * 2
            End If
        End If
        lblPlayerScore.Text = "Player: " & GameScore
        PlayerStand()
    End Sub

    Sub MatchImage(isPlayer As Boolean, Die As Integer, pbxDie As PictureBox)
        'Sets correct dice images for the count
        If isPlayer Then
            If Die = 1 Then
                pbxDie.Image = My.Resources.dieface1

            ElseIf Die = 2 Then
                pbxDie.Image = My.Resources.dieface2

            ElseIf Die = 3 Then
                pbxDie.Image = My.Resources.dieface3

            ElseIf Die = 4 Then
                pbxDie.Image = My.Resources.dieface4

            ElseIf Die = 5 Then
                pbxDie.Image = My.Resources.dieface5

            ElseIf Die = 6 Then
                pbxDie.Image = My.Resources.dieface6
            End If
        Else
            If Die = 1 Then
                pbxDie.Image = My.Resources.reddieface1

            ElseIf Die = 2 Then
                pbxDie.Image = My.Resources.reddieface2

            ElseIf Die = 3 Then
                pbxDie.Image = My.Resources.reddieface3

            ElseIf Die = 4 Then
                pbxDie.Image = My.Resources.reddieface4

            ElseIf Die = 5 Then
                pbxDie.Image = My.Resources.reddieface5

            ElseIf Die = 6 Then
                pbxDie.Image = My.Resources.reddieface6
            End If
        End If
    End Sub

    Private Sub frmDiceGame_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmSplash.Close()
    End Sub
End Class




