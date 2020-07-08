Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.IO.Compression
Imports System.Net
Imports IWshRuntimeLibrary
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions


Public Class Form1
    Private Declare Function SetCursorPos Lib "user32" (ByVal x As Integer, ByVal y As Integer) As Integer
    Public lap As Integer = 0
    Public wheremousestarted As Point
    Private Sub moveto_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles moveto.DoWork
        'This is the part that actually calculates everything and moves the mouse. It's made into a single instance of a backgroundworker 
        'so that only one mouse stroke can be happening at once AND it's conveniently hyperthreaded.

        Try



            Randomize()

            'Length of mouse stroke
            Dim length As Integer = Math.Sqrt((My.Settings.topointx - MousePosition.X) ^ 2 + (My.Settings.topointy - MousePosition.Y) ^ 2)

            'Where the raw stroke is read to
            Dim strokedata As String

            'Figuring out which file to pick
            Dim lengthrounded As Integer = (Math.Ceiling(length / 20) * 20)
            Dim temporaryarrayforfilenames As String() = Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\clickdata\" + lengthrounded.ToString)
            Dim numberoftextfiles As Integer = temporaryarrayforfilenames.Count

            'Select random stroke with given length





            'Randomize a textfile and read it
            Dim textfilename As Integer = Int(numberoftextfiles * Rnd()) + 1
            Dim objReader As New System.IO.StreamReader(My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString + "\clickdata\" + lengthrounded.ToString + "\" + textfilename.ToString + ".txt")
            strokedata = objReader.ReadLine()
            objReader.Close()


            Dim pointold As Point = MousePosition
            Dim pointnew As Point = MousePosition
            Dim startx As Integer = Cursor.Position.X
            Dim starty As Integer = Cursor.Position.Y
            Dim string1 As String = strokedata
            Dim tempx As Integer
            Dim tempy As Integer
            Dim tempoldx As Integer = Cursor.Position.X
            Dim tempoldy As Integer = Cursor.Position.Y
            Dim msadd As Integer = 0
            Dim ts As DateTime

            Dim totime As Date = DateTime.Now
            Dim fastdate1 As Date = DateTime.Now

            Dim rotated As ArrayList = New ArrayList
            rotated.Clear()


            lap = 0
            Dim array As String() = string1.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            'Total angle of the curve


            Dim arraymin As String() = array(0).Split(".".ToCharArray())
            Dim arraymax As String() = array(array.Count - 1).Split(".".ToCharArray())



            'Delta angle between p2 (start) and p1 (target location)
            Dim p1 As Point = New Point(My.Settings.topointx.ToString, My.Settings.topointy.ToString)
            '^^ INPUT HERE ^^

            Dim p2 As Point = New Point(arraymax(0), arraymax(1))
            Dim Center As Point = New Point(MousePosition)
            Dim angle1 As Double = Math.Atan2(p1.Y - MousePosition.Y, p1.X - MousePosition.X)
            Console.WriteLine(angle1.ToString + "    " + p1.Y.ToString + "     " + p1.X.ToString)

            'Let's calculate the length difference in percentages to give a multiplier to the coordinate generator
            Dim multiplier1 As Double = (Math.Sqrt(Math.Abs(((p1.X - MousePosition.X) ^ 2)) + Math.Abs(((p1.Y - MousePosition.Y) ^ 2)))) / (Math.Sqrt(Math.Abs((arraymax(0)) ^ 2) + Math.Abs((arraymax(1)) ^ 2)))

            Console.WriteLine("this is the multiplier: " + multiplier1.ToString)


            Dim tempsplit As String()

            ts = DateTime.Now
            For Each value1 In array

                'Rotation precalculation

                tempsplit = value1.Split(".".ToCharArray())


                'Precalculate Pythagoras
                'Dim pyth As Double = Math.Sqrt(Math.Abs((tempsplit(0) ^ 2)) + (Math.Abs((tempsplit(1) ^ 2))))
                'Rotate X
                rotated.Add((multiplier1 * ((Math.Sqrt(Math.Abs((tempsplit(0) ^ 2)) + (Math.Abs((tempsplit(1) ^ 2))))) * (Math.Cos(angle1)))).ToString)
                'Rotate y
                rotated.Add((multiplier1 * ((Math.Sqrt(Math.Abs((tempsplit(0) ^ 2)) + (Math.Abs((tempsplit(1) ^ 2))))) * (Math.Sin(angle1)))).ToString)

            Next

            Dim ts2 As TimeSpan = DateTime.Now.Subtract(ts)
            Console.WriteLine("Calculation of " + array.Count.ToString + " coordinates took " + ts2.TotalMilliseconds.ToString + " milliseconds!")



            'Mouse movement
            wheremousestarted = Cursor.Position
            Dim rotatedvalue As Integer = 0


            For Each i In array
                Dim array2 As String() = i.Split(".".ToCharArray())

                'At least 8ms delay
                'If array2(2) <= 6 Then

                'ts = DateTime.Now.AddMilliseconds(6)
                'Else
                ts = DateTime.Now.AddMilliseconds(array2(2).ToString)


                tempx = startx + rotated(rotatedvalue)

                tempy = starty + rotated(rotatedvalue + 1)


                rotatedvalue += 2
                'Console.WriteLine(tempx.ToString + "," + tempy.ToString + "    " + Val(array2(0)).ToString + "," + Val(array2(1)).ToString)
                'Console.WriteLine(startx.ToString + "|" + i(0) + "|" + tempx)


                Do Until DateTime.Compare(ts, DateTime.Now) <= 0
                    'Console.WriteLine("1")
                    Application.DoEvents()
                    'Console.WriteLine("2")
                Loop




                If pointold = MousePosition Then
                    Console.WriteLine("skipped")
                    GoTo skip1
                End If
                ' Console.WriteLine(pointold.ToString + "  " + MousePosition.ToString)
                Do Until pointold <> MousePosition
                    Application.DoEvents()
                Loop

                'ADD A MILLISECOND DELAYER HERE ----------------------------------

                'Do Until tempoldx <> Cursor.Position.X Or tempoldy <> Cursor.Position.Y
                'Application.DoEvents()
                'Loop
skip1:
                pointold = MousePosition

                'Exclusive code to the swappiebois to not have excessive mouse rubberbanding outside of client borders
                If tempx > zoneend.X Then
                    tempx = zoneend.X
                ElseIf tempx < zonestart.X Then
                    tempx = zonestart.X
                End If

                If tempy > zoneend.Y Then
                    tempy = zoneend.Y
                ElseIf tempy < zonestart.Y Then
                    tempy = zonestart.Y
                End If

                SetCursorPos(tempx, tempy)

                tempoldx = tempx
                tempoldy = tempy

                'INTEGER VALUE COMPARISON A MUST, BECAUSE NEED TO KNOW HOW TO CALCULATE NEW FUTURE ENDPOINT
            Next
            rotated.Clear()
        Catch ex As Exception

        End Try

        moveto.CancelAsync()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public zonestart As Point
    Public zoneend As Point
    Public blockedzonestart As Point
    Public blockedzoneend As Point
    Public delaytimebot As Integer
    Public delaytimeceiling As Integer
    Public checkerbool As Boolean = False
    Public percbot As Integer
    Public percceil As Integer
    Public intensitytimebot As Integer
    Public intensitytimeceil As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Start!" Then



            Try
                zonestart = New Point(startx.Text, starty.Text)
                zoneend = New Point(endx.Text, endy.Text)
                blockedzonestart = New Point(bstartx.Text, bstarty.Text)
                blockedzoneend = New Point(bendx.Text, bendy.Text)
                delaytimebot = movements1.Text
                delaytimebot *= 1000
                delaytimeceiling = movements2.Text
                delaytimeceiling *= 1000

                If checkerbool = True Then
                    percbot = perc1.Text
                    percceil = perc2.Text
                    intensitytimebot = intensitys1.Text
                    intensitytimeceil = intensitys2.Text
                End If
                exctor.RunWorkerAsync()

            Catch ex As Exception
                MsgBox("You somehow fucked up the input.")
                GoTo endd
            End Try

            Button1.Text = "Stop"

        Else
            Try
                exctor.CancelAsync()
                Button1.Text = "Start!"
            Catch ex As Exception
                MsgBox("Couldn't stop backgroundworker! I suggest restarting the program.")
            End Try

        End If


endd:
    End Sub


    Private Sub movemouse(ByVal tox As Point)
        My.Settings.topointx = tox.X
        My.Settings.topointy = tox.Y

        'Just to be sure, waiting for the settings to have been changed
        Do Until My.Settings.topointx = tox.X And My.Settings.topointy = tox.Y
            Application.DoEvents()
        Loop

        moveto.RunWorkerAsync()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            checkerbool = True
            qwe1.Visible = True
            qwe2.Visible = True
            qwe3.Visible = True
            qwe4.Visible = True
            qwe5.Visible = True
            qwe6.Visible = True
            perc1.Visible = True
            perc2.Visible = True
            intensitys1.Visible = True
            intensitys2.Visible = True
        Else
            checkerbool = False
            qwe1.Visible = False
            qwe2.Visible = False
            qwe3.Visible = False
            qwe4.Visible = False
            qwe5.Visible = False
            qwe6.Visible = False
            perc1.Visible = False
            perc2.Visible = False
            intensitys1.Visible = False
            intensitys2.Visible = False
        End If
    End Sub

    Private Sub exctor_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles exctor.DoWork
        Do While 1 = 1

            Dim ts As DateTime = DateTime.Now
            Dim ts2 As DateTime = DateTime.Now.AddMilliseconds(secondsuntil)

            Do Until DateTime.Compare(ts2, DateTime.Now) <= 0
                Application.DoEvents()
            Loop
doublehappening:
            My.Settings.isdone = False
            Dim secondsun As Integer = secondsuntil()
            Console.WriteLine(secondsun.ToString)

            Dim finalpoint1 As Point = getrandomcoord()
            movemouse(finalpoint1)

            Console.WriteLine("moving to" + finalpoint1.X.ToString + "," + finalpoint1.Y.ToString)

            Do Until moveto.IsBusy = False

                Application.DoEvents()
            Loop
            Try
                moveto.CancelAsync()
            Catch ex As Exception

            End Try
            Dim possibledoublemove As Integer = (99 * Rnd()) + 1
            Dim textboxint As Integer = TextBox1.Text
            If possibledoublemove <= textboxint Then
                GoTo doublehappening
            End If

        Loop
    End Sub

    Private Function getrandomcoord()
        Randomize()
        Dim finalpoint As Point

        'For X
        Dim xrnd As Integer = 0
        Dim yrnd As Integer = 0
        Dim ifdone As Boolean = False


        Do Until ifdone = True
            Dim fixx1 As Integer = 0
            Dim fixx2 As Integer = 0



            xrnd = zonestart.X + ((zoneend.X - zonestart.X) * Rnd())
            Dim tempintxstart As Integer = blockedzonestart.X
            Dim tempintxend As Integer = blockedzoneend.X

            If tempintxstart <= xrnd Then
                fixx1 = 1
            Else
                fixx1 = 0
            End If

            If xrnd <= tempintxend Then
                fixx2 = 1
            Else
                fixx2 = 0
            End If


            If fixx1 + fixx2 = 2 Then
                fixx1 = 0
                fixx2 = 0
                Console.WriteLine(blockedzonestart.X.ToString + "<=" + xrnd.ToString + "<=" + blockedzoneend.X.ToString)

                Delay(0.1)
            Else
                fixx1 = 0
                fixx2 = 0

                finalpoint.X = xrnd
                ifdone = True
            End If
        Loop


        'For Y

        Dim ifdone2 As Boolean = False
        Do Until ifdone2 = True
            Dim fixx1 As Integer = 0
            Dim fixx2 As Integer = 0

            yrnd = zonestart.Y + ((zoneend.Y - zonestart.Y) * Rnd())



            Dim tempintxstart As Integer = blockedzonestart.Y
            Dim tempintxend As Integer = blockedzoneend.Y

            If tempintxstart <= yrnd Then
                fixx1 = 1
            Else
                fixx1 = 0
            End If

            If yrnd <= tempintxend Then
                fixx2 = 1
            Else
                fixx2 = 0
            End If




            If fixx1 + fixx2 = 2 Then
                fixx1 = 0
                fixx2 = 0
                Console.WriteLine(yrnd.ToString + " yrnd in the blocked zone, randomizing a new one")
                Delay(0.1)

            Else
                fixx1 = 0
                fixx2 = 0
                finalpoint.Y = yrnd
                ifdone2 = True
            End If
        Loop

        Return finalpoint
    End Function

    Public intensitychangepercentage As Double
    Public intensitytimeframe As DateTime = DateTime.Now
    Private Function secondsuntil()
        Dim secondsuntil2 As Integer = 0


        If checkerbool = True Then
            If DateTime.Compare(intensitytimeframe, DateTime.Now) <= 0 Then




                Dim ifnegative As Boolean = False
                Dim i As Integer = Rnd() * 1
                If i = 0 Then
                    ifnegative = True
                Else
                    ifnegative = False
                End If

                intensitychangepercentage = (percbot + ((percceil - percbot) * Rnd())) / 100

                If ifnegative = True Then
                    intensitychangepercentage *= -1

                End If
                intensitychangepercentage = 1 + intensitychangepercentage

                'To make sure it doesn't change until the timer destines it to
                intensitytimeframe = DateTime.Now.AddSeconds(intensitytimebot + ((intensitytimeceil - intensitytimebot) * Rnd()))

            End If
            secondsuntil2 = delaytimebot + (((delaytimeceiling * intensitychangepercentage) - (delaytimebot * intensitychangepercentage)) * Rnd())
        Else
            secondsuntil2 = delaytimebot + ((delaytimeceiling - delaytimebot) * Rnd())
        End If
        Return secondsuntil2


    End Function



End Class
