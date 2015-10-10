Public Class KalkulatorFirman
    Dim tembak1 As String = ""

    Dim tembak2 As String = ""

    Dim hasil As Decimal = 0

    Dim tambah As Boolean = False

    Dim kurang As Boolean = False

    Dim kali As Boolean = False

    Dim bagi As Boolean = False
    Private Sub KalkulatorFirman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub kal1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kal1.Click
        If (tambah = False And kurang = False And kali = False And bagi = False) Then

            tembak1 += "1"

            kaldisplay.Text = tembak1

        Else

            tembak2 += "1"

            kaldisplay.Text = tembak2

        End If
    End Sub
    Private Sub kal2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kal2.Click
        If (tambah = False And kurang = False And kali = False And bagi = False) Then

            tembak1 += "2"

            kaldisplay.Text = tembak1

        Else

            tembak2 += "2"

            kaldisplay.Text = tembak2

        End If
    End Sub

    Private Sub kal3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kal3.Click
        If (tambah = False And kurang = False And kali = False And bagi = False) Then

            tembak1 += "3"

            kaldisplay.Text = tembak1

        Else

            tembak2 += "3"

            kaldisplay.Text = tembak2

        End If
    End Sub

    Private Sub kal4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kal4.Click
        If (tambah = False And kurang = False And kali = False And bagi = False) Then

            tembak1 += "4"

            kaldisplay.Text = tembak1

        Else

            tembak2 += "4"

            kaldisplay.Text = tembak2

        End If
    End Sub

    Private Sub kal5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kal5.Click
        If (tambah = False And kurang = False And kali = False And bagi = False) Then

            tembak1 += "5"

            kaldisplay.Text = tembak1

        Else

            tembak2 += "5"

            kaldisplay.Text = tembak2

        End If
    End Sub

    Private Sub kal6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kal6.Click
        If (tambah = False And kurang = False And kali = False And bagi = False) Then

            tembak1 += "6"

            kaldisplay.Text = tembak1

        Else

            tembak2 += "6"

            kaldisplay.Text = tembak2

        End If
    End Sub

    Private Sub kal7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kal7.Click
        If (tambah = False And kurang = False And kali = False And bagi = False) Then

            tembak1 += "7"

            kaldisplay.Text = tembak1

        Else

            tembak2 += "7"

            kaldisplay.Text = tembak2

        End If
    End Sub

    Private Sub kal8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kal8.Click
        If (tambah = False And kurang = False And kali = False And bagi = False) Then

            tembak1 += "8"

            kaldisplay.Text = tembak1

        Else

            tembak2 += "8"

            kaldisplay.Text = tembak2

        End If
    End Sub

    Private Sub kal9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kal9.Click
        If (tambah = False And kurang = False And kali = False And bagi = False) Then

            tembak1 += "9"

            kaldisplay.Text = tembak1

        Else

            tembak2 += "9"

            kaldisplay.Text = tembak2

        End If
    End Sub

    Private Sub kal0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kal0.Click
        If (tambah = False And kurang = False And kali = False And bagi = False) Then

            tembak1 += "0"

            kaldisplay.Text = tembak1

        Else

            tembak2 += "0"

            kaldisplay.Text = tembak2

        End If
    End Sub

    Private Sub kalsamadengan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kalsamadengan.Click
        If tambah = True Then

            hasil = Val(tembak1) + Val(tembak2)

            kaldisplay.Text = hasil

            tembak1 = hasil

            tembak2 = ""

            tambah = False

        ElseIf kurang = True Then

            hasil = Val(tembak1) - Val(tembak2)

            kaldisplay.Text = hasil

            tembak1 = hasil

            tembak2 = ""

            kurang = False

        ElseIf kali = True Then

            hasil = Val(tembak1) * Val(tembak2)

            kaldisplay.Text = hasil

            tembak1 = hasil

            tembak2 = ""

            kali = False

        ElseIf bagi = True Then

            If tembak2 = "0" Then

                kaldisplay.Text = "Error"

                tembak2 = ""

            Else

                hasil = Val(tembak1) / Val(tembak2)

                kaldisplay.Text = hasil

                tembak1 = hasil

                tembak2 = ""

                bagi = False

            End If

        End If
    End Sub

    Private Sub kalkali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kalkali.Click
        kaldisplay.Text = "x"

        kali = True
    End Sub

    Private Sub kaltambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kaltambah.Click
        kaldisplay.Text = "+"

        tambah = True
    End Sub

    Private Sub kalkurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kalkurang.Click
        kaldisplay.Text = "-"

        kurang = True
    End Sub

    Private Sub kalbagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kalbagi.Click
        kaldisplay.Text = ":"

        kurang = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tembak1 = ""

        tembak2 = ""

        kaldisplay.Text = "0"

        kali = False

        bagi = False

        kurang = False

        tambah = False
    End Sub

    Private Sub kaldisplay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kaldisplay.TextChanged

    End Sub
End Class
