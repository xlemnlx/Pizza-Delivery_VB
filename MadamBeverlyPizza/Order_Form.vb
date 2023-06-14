Public Class Order_Form

    Private Sub Order_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit() 'pag click ng "x" sa taas, mag exit ung application... kapag wala nito, mag continue lang sa pag run ung application natin, kasi naka hide lang ung first form natin - ung welcome page - un ang main form..
    End Sub

    Private Sub Button_SUPREME_Click(sender As Object, e As EventArgs) Handles Button_SUPREME.Click
        Label1.Text = "SUPA! SUPREME!"  'malalagay ung name ng napiling pizza sa label 1.... ganun lang ka simple...
        Label2.Text = "550"             'price... malalagay lang din sa label 2....
        Label2.Visible = True           'hm... hindi nyo na kailangan to... hindi narin kailngan sabihin sa panel... pero basta, by default kasi ay naka hide ung label 2... pag may na click na ung customer ay mag show ung label 2...
    End Sub

    Private Sub Button_HAWAIIAN_Click(sender As Object, e As EventArgs) Handles Button_HAWAIIAN.Click
        Label1.Text = "SUPA! HAWAIIAN!" 'parehas lang... name lang
        Label2.Text = "550"             'parehas
        Label2.Visible = True           'parehas
    End Sub

    Private Sub Button_CHEESE_Click(sender As Object, e As EventArgs) Handles Button_CHEESE.Click
        Label1.Text = "SUPA! CHEESE!"   'parehas lang... name lang.
        Label2.Text = "550"             'parehas lang
        Label2.Visible = True           'parehas lang.
    End Sub

    Private Sub Button_BACOONN_Click(sender As Object, e As EventArgs) Handles Button_BACOONN.Click
        Label1.Text = "SUPA! BACOONN!"  'parehas lang... name lang.
        Label2.Text = "550"             'parehas lang.
        Label2.Visible = True           'parehas lang
    End Sub

    Private Sub Button_MEATTY_Click(sender As Object, e As EventArgs) Handles Button_MEATTY.Click
        Label1.Text = "SUPA! MEATTY!"   'parehas lang, name lang.
        Label2.Text = "550"             'parehas lang.
        Label2.Visible = True           'parehas lang.
    End Sub

    Private Sub Button_VEGGIE_Click(sender As Object, e As EventArgs) Handles Button_VEGGIE.Click
        Label1.Text = "SUPA! VEGGIE!"   'parehas lang, name lang.
        Label2.Text = "550"             'parehas lang.
        Label2.Visible = True           'parehas lang.
    End Sub

    Private Sub radio_thinncrust_CheckedChanged(sender As Object, e As EventArgs) Handles radio_thinncrust.CheckedChanged
        Label2.Text = 550 + 100         'e2 ung mga isa dun sa tatlo na pagpipilian... PAN, THIN, at STUFFED... bali ang nangyayari dito ay kapag napili ung THIN, mag plus sya ng 100..
    End Sub

    Private Sub radio_stuffedcrust_CheckedChanged(sender As Object, e As EventArgs) Handles radio_stuffedcrust.CheckedChanged
        Label2.Text = 550 + 100         'e2 ung mga isa dun sa tatlo na pagpipilian... PAN, THIN, at STUFFED... bali ang nangyayari dito ay kapag napili ung STUFFED, mag plus sya ng 100..
    End Sub

    Private Sub radio_panpizza_CheckedChanged(sender As Object, e As EventArgs) Handles radio_panpizza.CheckedChanged
        Label2.Text = 550               'e2 ung mga isa dun sa tatlo na pagpipilian... PAN, THIN, at STUFFED... bali ang nangyayari dito ay kapag napili ung PAN, balik lang sa default price..
    End Sub

    'all about hiding and showing the right groupbox and buttons...
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox2.Visible = False       'e2ng groupbox na ito ay ung mga laman ay ung mga thin, pan at stuffed... 
        GroupBox3.Visible = True        'e2ng groupbox na ito ay ung kung 2-4 persons or 5-8 persons...
        Button1.Visible = True
        Button2.Visible = False
    End Sub
    'all about hiding and showing the right groupbox and buttons...
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox3.Visible = False
        GroupBox2.Visible = True
        Button2.Visible = True
        Button1.Visible = False
    End Sub

    'final computations....
    Private Sub radio_24persons_CheckedChanged(sender As Object, e As EventArgs) Handles radio_24persons.CheckedChanged
        If radio_thinncrust.Checked = True Then         'first condition, kung ang napili ay thin
            Label2.Text = 650                           'e2 ang mangyayari... wala, kasi yan ung default... nakalagay sa ilalim nung mga pagpipilian na pizza..
        ElseIf radio_stuffedcrust.Checked = True Then   'second condition, pag ang napili ay stuffed
            Label2.Text = 650                           'result, nothing - default kasi.
        ElseIf radio_panpizza.Checked = True Then       'third conditionm pana ang napili
            Label2.Text = 550                           'result, nothing, default.
        End If
    End Sub

    Private Sub radio_58persons_CheckedChanged(sender As Object, e As EventArgs) Handles radio_58persons.CheckedChanged
        If radio_thinncrust.Checked = True Then         'dito may nagababgo, same sa condition..... 
            Label2.Text = 650 + 250                     'nag plus 250 na kasi ang napiling size ang 5-8 persons... 
        ElseIf radio_stuffedcrust.Checked = True Then
            Label2.Text = 650 + 250
        ElseIf radio_panpizza.Checked = True Then
            Label2.Text = 550 + 250
        End If
    End Sub


    'e2 ung button na "Proceed to Check-out"
    'bali ang nangyayari dito ay pag na click ung button, mag show sya ng messagebox na ang nakalagay ay ung nasa baba...
    'ung unang set ng "asdadad" - ay ung nakalgay sa loob ng messagebox
    'ung second set ng "asasdasd" - ay ung title ng messagebox..
    'tapos ung messageboxbuttons.yesno ay ung pagpipilian ng user/costumer, Yes or No... literal... dali diba???
    'tapos ung messageboxicon.exclamation ay kung ano gusto mo ilagay na icon... literal din... 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Please check all the information you've enter, it cannot be re-enter once you click Yes", "Reminder!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Thanks_for_ordering_form.Show()     'ok, kunyari nakapili na ng sagot ung user/customer, kunyari YES... ang mangyayari ay mag show ung third form natin - ung thank you form natin...
            Me.Hide()                           'tapos e2ng form na to ay mag hide...
        ElseIf Windows.Forms.DialogResult.No Then 'kung NO naman ang napili ng user/customer natin.
            Me.Show()                           'e2 ang mangyayari, balik lang sa dati... 
        End If
    End Sub
End Class