Imports System.Drawing.Imaging
Imports System.Threading

Public Class Main

    Private v_moveDir As MoveDirection = 0
    Private v_moveInObject As Object
    Private v_moveOutObject As Object
    Private v_msgBoxAnswered As Boolean
    Private v_msgboxResult As MsgBoxResult
    Private v_newScreen As Form

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadScreen(New Inicio, MoveDirection.BackIn)
    End Sub

    Public Sub LoadScreen(new_screen As Form, moveDir As MoveDirection)

        v_newScreen = new_screen

        v_moveDir = moveDir

        v_moveOutObject = Nothing
        v_moveInObject = Nothing

        For Each item In Me.Screen.Controls
            v_moveOutObject = item
            UnDock(v_moveOutObject)
        Next

        v_moveInObject = new_screen.Controls(0)

        If v_moveInObject.Name = "AgendaScreen" Then
            vg_showCalendar = True
            Try
                CType(v_newScreen, Object).loadMonth()
            Catch ex As Exception
            End Try
        End If

        Me.Screen.Controls.Remove(v_moveOutObject)
        Me.Screen.Controls.Add(v_moveInObject)

        'UnDock(v_moveInObject)
        'Select Case v_moveDir
        '    Case MoveDirection.BackIn
        '        v_moveInObject.Left = Screen.Width + 100
        '    Case MoveDirection.Out
        '        v_moveInObject.Left = (v_moveInObject.Width) * (-1)
        'End Select

        'movePanel(moveDir)



        'SetDock(v_moveInObject)

        'MsgBox(new_screen.GetType().ToString())

        If new_screen.GetType().ToString().Equals("StyleSalon.Calendario") Then
            Dim c As Calendario = new_screen
            c.Seleccionar_DataGridView()

        End If

    End Sub

    Public Sub movePanel(ByVal moveDir As MoveDirection, Optional ByVal newTabIndex As Integer = -1)

        v_moveDir = moveDir
        'Me.FormsMove.Enabled = True

    End Sub

    Private Sub UnDock(ByVal control As Control)

        If control IsNot Nothing Then
            control.Dock = DockStyle.None
            control.Size = Screen.Size
            control.Top = 0
            control.BringToFront()
            control.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Bottom
            control.Show()
        End If

    End Sub

    Private Sub SetDock(ByVal control As Control)

        control.Dock = DockStyle.Fill
        control.BringToFront()

        If control.Name = "AgendaScreen" Then
            vg_showCalendar = True
            CType(v_newScreen, Object).loadMonth()
        End If

    End Sub

    Private Sub move_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormsMove.Tick

        Select v_moveDir
            Case MoveDirection.BackIn

                If v_moveOutObject IsNot Nothing Then
                    v_moveOutObject.Left -= 100
                    Me.Refresh()
                End If

                If v_moveInObject IsNot Nothing Then
                    v_moveInObject.Left -= 100
                    Me.Refresh()
                    If Me.v_moveInObject.Left <= 100 Then
                        FormsMove.Enabled = False
                        Me.Screen.Controls.Remove(v_moveOutObject)
                        SetDock(v_moveInObject)
                    End If
                End If

                'Case MoveDirection.Out2

                'v_moveObject.Left += 100
                'Me.Refresh()

                'If Me.v_moveObject.Left >= v_moveObject.Width - 100 Then
                '    FormsMove.Enabled = False
                '    SetDock(v_moveObject)
                '    For Each item As Control In Me.Screen.Controls
                '        Try
                '            UnDock(item)
                '            item.Left = -100 - item.Width
                '            movePanel(MoveDirection.BackIn2)
                '            Exit For
                '        Catch ex As Exception
                '        End Try
                '    Next

                'End If

            Case MoveDirection.Out


                'Case MoveDirection.BackIn2

                If v_moveOutObject IsNot Nothing Then
                    v_moveOutObject.Left += 100
                    Me.Refresh()
                End If

                If v_moveInObject IsNot Nothing Then
                    v_moveInObject.Left += 100
                    Me.Refresh()
                    If Me.v_moveInObject.Left >= 100 Then
                        FormsMove.Enabled = False
                        Me.Screen.Controls.Remove(v_moveOutObject)
                        SetDock(v_moveInObject)
                    End If
                End If

                'Case MoveDirection.OutUp

                'v_moveObject.top += 100
                'Me.Refresh()

                'If Me.v_moveObject.top + v_moveObject.Height <= -100 Then
                '    FormsMove.Enabled = False
                '    For Each item As Control In Me.Screen.Controls
                '        Try
                '            item.Top = 100 + item.Height
                '            movePanel(MoveDirection.BackInUp)
                '            Exit For
                '        Catch ex As Exception
                '        End Try
                '    Next

                'End If

                'Case MoveDirection.BackInUp

                'v_moveObject.top -= 100
                'Me.Refresh()

                'If Me.v_moveObject.top <= -100 Then
                '    FormsMove.Enabled = False
                '    v_moveObject.top = 0
                '    v_moveDir = MoveDirection.Out
                'End If

        End Select

    End Sub

    Private Sub Main_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Maximized Then
            Me.Padding = New Padding(10, 30, 10, 10)
        Else
            Me.Padding = New Padding(2, 30, 2, 2)
        End If
    End Sub

    Public Function ShowMessage(ByVal title As String, ByVal message As String, ByVal backColor As Color, ByVal buttons As MsgBoxStyle) As MsgBoxResult


        msgBoxOkButton.Visible = False
        msgBoxNoButton.Visible = False

        msgBoxContainer.BackgroundImage = ScreenCapture.CaptureWindow(Me.Handle)

        msgBoxContainer.Dock = DockStyle.None
        msgBoxContainer.Location = New Point(-1, -1)
        msgBoxContainer.Height = Me.Height + 1
        msgBoxContainer.Width = Me.Width + 3

        Me.msgBoxContainer.Refresh()
        Me.msgBoxContainer.Visible = True

        Me.msgBoxMessage.Text = message
        Me.msgBoxTitle.Text = title

        Me.msgBoxPanel.BackColor = backColor

        Select Case buttons

            Case MsgBoxStyle.OkOnly

                msgBoxOkButton.Visible = True

            Case MsgBoxStyle.OkCancel

                msgBoxOkButton.Visible = True
                msgBoxNoButton.Visible = True

        End Select

        msgBoxPanel.Focus()

        While v_msgBoxAnswered = False
            My.Application.DoEvents()
        End While

        v_msgBoxAnswered = False

        Me.msgBoxContainer.Visible = False

        Return v_msgboxResult

    End Function

    Private Sub msgBoxOcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msgBoxOkButton.Click
        'Me.mainPanel.Visible = True
        Me.msgBoxContainer.Visible = False
        v_msgboxResult = MsgBoxResult.Ok
        v_msgBoxAnswered = True
    End Sub

    Private Sub msgBoxNoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msgBoxNoButton.Click
        'Me.mainPanel.Visible = True
        Me.msgBoxContainer.Visible = False
        v_msgboxResult = MsgBoxResult.Cancel
        v_msgBoxAnswered = True
    End Sub

End Class

Public Enum MoveDirection
    Out = 0
    BackIn = 1
    Out2 = 2
    BackIn2 = 3
    OutUp = 4
    BackInUp = 5
End Enum
