Imports System
Imports System.IO
Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'declaring paths of text files to the current exe dir
        Dim strPath As String = My.Computer.FileSystem.CurrentDirectory
        Dim itemt As String = "item.txt"
        Dim fullPath0 = Path.Combine(strPath, itemt)
        Dim pricet As String = "price.txt"
        Dim fullPath1 = Path.Combine(strPath, pricet)
        Dim stockt As String = "stock.txt"
        Dim fullPath2 = Path.Combine(strPath, stockt)
        'text file existence check
        If My.Computer.FileSystem.FileExists(fullPath0) And My.Computer.FileSystem.FileExists(fullPath1) And My.Computer.FileSystem.FileExists(fullPath2) Then
            ListBox1.Items.AddRange(System.IO.File.ReadAllLines(fullPath0))
            ListBox2.Items.AddRange(System.IO.File.ReadAllLines(fullPath1))
            ListBox3.Items.AddRange(System.IO.File.ReadAllLines(fullPath2))
            'text file contents check
            'making sure the text files actually have something in them
        ElseIf File.ReadAllText(fullPath0).Length = 0 And File.ReadAllText(fullPath1).Length = 0 And File.ReadAllText(fullPath2).Length = 0 Then
            MessageBox.Show("Please make sure all text files have valid values!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        Else
            MessageBox.Show("Please make sure item.txt, price.txt and stock.txt are in the directory you started the program from!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'on selecting the first listbox item
        'the other two listboxes will mirror the selection
        Dim i As Integer = ListBox1.SelectedIndex
        ListBox2.SelectedIndex = i
        ListBox3.SelectedIndex = i
        'copying selected listbox item to lables
        itemlab.Text = ListBox1.Items(i)
        pricelab.Text = ListBox2.Items(i)
        stocklab.Text = ListBox3.Items(i)
        'when a listbox item is selected then enable the 'action'
        'buttons, if we were to have them enabled earlier they could
        'cause errors if clicked
        pricebut.Enabled = True
        ordstockbut.Enabled = True
        itemtxt.Enabled = True
        paid.Enabled = True
        pricetxt.Enabled = True
        stocktxt.Enabled = True
        'crash prevention
        itemtxt.Text = "0"
        itemtxt.Text = "1"
        paid.Text = "0"
        'copying selected listbox item to current price and stock values
        pricetxt.Text = ListBox2.Items(i)
        stocktxt.Text = ListBox3.Items(i)
        'crash prevention
        changelab.Text = "#"
    End Sub
    'only allowing numeric input in textboxes
    Private Sub item_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles itemtxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
    Private Sub paid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles paid.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
    Private Sub price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pricetxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
    Private Sub stock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles stocktxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
    Private Sub item_TextChanged(sender As Object, e As EventArgs) Handles itemtxt.TextChanged
        'crash prevention
        If itemtxt.Text = "" Or "0" Then
            itemtxt.Text = "1"
        End If
        'calculating VAT and total price
        subtotlab.Text = itemtxt.Text * pricelab.Text
        vatlab.Text = subtotlab.Text * 0.2
        totlab.Text = Val(subtotlab.Text) + Val(vatlab.Text)
    End Sub
    Private Sub checkoutbut_Click(sender As Object, e As EventArgs) Handles checkoutbut.Click
        Dim b As Integer = ListBox1.SelectedIndex
        Dim a As Integer = paid.Text
        'if customer has paid less then the value of total price show msg box
        If a < totlab.Text Then
            MsgBox("Customer did not pay enough money!")
            ' if there isn't enough stock value show text box
        ElseIf itemtxt.Text > ListBox3.Items(b) Then
            MsgBox("Not enough stock!")
        Else
            'calculating change to give customer 
            changelab.Text = paid.Text - totlab.Text
            'writing new stock value after payment to text file and listbox
            Dim output As New IO.StreamWriter("stock.txt")
            ListBox3.Items.Item(b) = ListBox3.Items.Item(b) - Val(itemtxt.Text)
            For Each item As Object In ListBox3.Items
                output.WriteLine(ListBox3.GetItemText(item))
            Next item
            output.Close()
            pricetxt.Text = ListBox2.Items(b)
            stocktxt.Text = ListBox3.Items(b)
            MsgBox("Item(s) bought successfully!")
            paid.Text = "0"
            'history
            'just mirroring any checkout with the listbox value that
            'was selected at the time
            ListBox4.Items.Add(ListBox1.Items.Item(b))
            ListBox6.Items.Add(totlab.Text)
            ListBox5.Items.Add(stocklab.Text)
            ListBox7.Items.Add(itemtxt.Text)
        End If
    End Sub
    Private Sub exitbut_Click(sender As Object, e As EventArgs) Handles exitbut.Click
        'exit button added since the top right X doesn't really exit the whole form
        'the login page will still be running in the background unless this button
        'is pressed
        End
    End Sub
    Private Sub pricebut_Click(sender As Object, e As EventArgs) Handles pricebut.Click
        'setting logical limits on how much price one can or can't add at any one time
        If pricetxt.Text > 500 Or pricetxt.Text < 50 Then
            MsgBox("Are you the value you entered is correct?")
        Else
            Dim price As String = pricetxt.Text
            Dim i As Integer = ListBox2.SelectedIndex
            'deleting selected listbox price value
            ListBox2.Items.RemoveAt(i)
            'adding selected listbox price value from textbox
            ListBox2.Items.Insert(i, price)
            'crash prevention
            'updating price textbox with new updated value
            pricetxt.Text = ""
            pricetxt.Text = ListBox2.Items(i)
            itemlab.Text = ListBox1.Items(i)
            pricelab.Text = ListBox2.Items(i)
            stocklab.Text = ListBox3.Items(i)
            'crash prevention
            itemtxt.Text = "0"
            itemtxt.Text = "1"
            Dim output As New IO.StreamWriter("price.txt")
            're-writing price text file with new data
            For Each item As Object In ListBox2.Items
                output.WriteLine(ListBox2.GetItemText(item))
            Next item
            output.Close()
        End If
    End Sub
    Private Sub ordstockbut_Click(sender As Object, e As EventArgs) Handles ordstockbut.Click
        'setting logical limits on how much stock one can or can't add at any one time
        If stocktxt.Text > 100 Or stocktxt.Text < 10 Then
            MsgBox("Are you the value you entered is correct?")
        Else
            Dim stock As String = stocktxt.Text
            Dim i As Integer = ListBox3.SelectedIndex
            'deleting selected listbox stock value
            ListBox3.Items.RemoveAt(i)
            'adding selected listbox stock value from textbox
            ListBox3.Items.Insert(i, stock)
            'crash prevention
            'updating stock textbox with new updated value
            pricetxt.Text = ""
            pricetxt.Text = ListBox3.Items(i)
            itemlab.Text = ListBox1.Items(i)
            pricelab.Text = ListBox2.Items(i)
            stocklab.Text = ListBox3.Items(i)
            'crash prevention
            itemtxt.Text = "0"
            itemtxt.Text = "1"
            Dim output As New IO.StreamWriter("stock.txt")
            're-writing price text file with new data
            For Each item As Object In ListBox3.Items
                output.WriteLine(ListBox3.GetItemText(item))
            Next item
            output.Close()
        End If
    End Sub
    Private Sub paid_TextChanged(sender As Object, e As EventArgs) Handles paid.TextChanged
        'enable checkout button once a value is entered into paid textbox
        If paid.Text = "" Or paid.Text = "0" Then
            checkoutbut.Enabled = False
        Else
            checkoutbut.Enabled = True
        End If
    End Sub
End Class