﻿'comments coming soon!
Imports System
Imports System.IO
Public Class MainForm
    Dim strPath As String = My.Computer.FileSystem.CurrentDirectory
    Dim itemt As String = "item.txt"
    Dim fullPath0 = Path.Combine(strPath, itemt)
    Dim pricet As String = "price.txt"
    Dim fullPath1 = Path.Combine(strPath, pricet)
    Dim stockt As String = "stock.txt"
    Dim fullPath2 = Path.Combine(strPath, stockt)
    Public Shared Property CurrentDirectory As String
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(fullPath0) And My.Computer.FileSystem.FileExists(fullPath1) And My.Computer.FileSystem.FileExists(fullPath2) Then
            ListBox1.Items.AddRange(System.IO.File.ReadAllLines(fullPath0))
            ListBox2.Items.AddRange(System.IO.File.ReadAllLines(fullPath1))
            ListBox3.Items.AddRange(System.IO.File.ReadAllLines(fullPath2))
        Else
            MessageBox.Show("Please make sure item.txt, price.txt and stock.txt are in the directory you started the program from!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim i As Integer = ListBox1.SelectedIndex
        ListBox2.SelectedIndex = i
        ListBox3.SelectedIndex = i
        itemlab.Text = ListBox1.Items(i)
        pricelab.Text = ListBox2.Items(i)
        stocklab.Text = ListBox3.Items(i)
        pricebut.Enabled = True
        ordstockbut.Enabled = True
        itemtxt.Enabled = True
        paid.Enabled = True
        pricetxt.Enabled = True
        stocktxt.Enabled = True
        itemtxt.Text = "0"
        itemtxt.Text = "1"
        paid.Text = "0"
        pricetxt.Text = ListBox2.Items(i)
        stocktxt.Text = ListBox3.Items(i)
        changelab.Text = "#"
    End Sub
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
        If itemtxt.Text = "" Or "0" Then
            itemtxt.Text = "1"
        End If
        subtotlab.Text = itemtxt.Text * pricelab.Text
        vatlab.Text = subtotlab.Text * 0.2
        totlab.Text = Val(subtotlab.Text) + Val(vatlab.Text)
    End Sub
    Private Sub checkoutbut_Click(sender As Object, e As EventArgs) Handles checkoutbut.Click
        Dim b As Integer = ListBox1.SelectedIndex
        ListBox2.SelectedIndex = b
        ListBox3.SelectedIndex = b
        Dim a As Integer = paid.Text
        If a < totlab.Text Then
            MsgBox("Customer did not pay enough money!")
        ElseIf itemtxt.Text > ListBox3.Items(b) Then
            MsgBox("Not enough stock!")
        Else
            changelab.Text = paid.Text - totlab.Text
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
            ListBox4.Items.Add(ListBox1.Items.Item(b))
            ListBox6.Items.Add(totlab.Text)
            ListBox5.Items.Add(stocklab.Text)
            ListBox7.Items.Add(itemtxt.Text)
        End If
    End Sub
    Private Sub exitbut_Click(sender As Object, e As EventArgs) Handles exitbut.Click
        End
    End Sub
    Private Sub pricebut_Click(sender As Object, e As EventArgs) Handles pricebut.Click
        If pricetxt.Text > 500 Or pricetxt.Text < 50 Then
            MsgBox("Are you the value you entered is correct?")
        Else
            Dim price As String = pricetxt.Text
            Dim i As Integer = ListBox2.SelectedIndex
            ListBox2.Items.RemoveAt(i)
            ListBox2.Items.Insert(i, price)
            pricetxt.Text = ""
            pricetxt.Text = ListBox2.Items(i)
            itemlab.Text = ListBox1.Items(i)
            pricelab.Text = ListBox2.Items(i)
            stocklab.Text = ListBox3.Items(i)
            itemtxt.Text = "0"
            itemtxt.Text = "1"
            Dim output As New IO.StreamWriter("price.txt")
            For Each item As Object In ListBox2.Items
                output.WriteLine(ListBox2.GetItemText(item))
            Next item
            output.Close()
        End If
    End Sub
    Private Sub ordstockbut_Click(sender As Object, e As EventArgs) Handles ordstockbut.Click
        If stocktxt.Text > 100 Or stocktxt.Text < 10 Then
            MsgBox("Are you the value you entered is correct?")
        Else
            Dim stock As String = stocktxt.Text
            Dim i As Integer = ListBox3.SelectedIndex
            ListBox3.Items.RemoveAt(i)
            ListBox3.Items.Insert(i, stock)
            pricetxt.Text = ""
            pricetxt.Text = ListBox3.Items(i)
            itemlab.Text = ListBox1.Items(i)
            pricelab.Text = ListBox2.Items(i)
            stocklab.Text = ListBox3.Items(i)
            itemtxt.Text = "0"
            itemtxt.Text = "1"
            Dim output As New IO.StreamWriter("stock.txt")
            For Each item As Object In ListBox3.Items
                output.WriteLine(ListBox3.GetItemText(item))
            Next item
            output.Close()
        End If
    End Sub
    Private Sub paid_TextChanged(sender As Object, e As EventArgs) Handles paid.TextChanged
        If paid.Text = "" Or paid.Text = "0" Then
            checkoutbut.Enabled = False
        Else
            checkoutbut.Enabled = True
        End If
    End Sub
End Class