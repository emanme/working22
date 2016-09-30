Public Class HFUKioskSytem

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'GeckoWebBrowser1.f()
        browser.Navigate("https://bsz.ibs-bw.de/aDISWeb/app?service=direct/0/Home/$DirectLink&sp=S127.0.0.1:23298")
        browser.Show()
        browser.Dock = DockStyle.Fill

    End Sub

    Private Sub GeckoWebBrowser1_Click(sender As System.Object, e As System.EventArgs) Handles browser.Click

    End Sub
End Class
