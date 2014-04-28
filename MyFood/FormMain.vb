Imports System.Xml

Public Class FormMain


    Private _FileLoader As CategoryXMLLoader

    Private _StorageLocations As StorageCollection




    Private Sub ButtonAddItem_Click(sender As Object, e As EventArgs) Handles ButtonAddItem.Click
        TabControlMain.SelectedTab = TabPageAddItem
    End Sub

    Private Sub ButtonUpdateItem_Click(sender As Object, e As EventArgs) Handles ButtonUpdateItem.Click
        TabControlMain.SelectedTab = TabPageUpdateItem
    End Sub

    Private Sub ButtonSearchItems_Click(sender As Object, e As EventArgs) Handles ButtonSearchItems.Click
        TabControlMain.SelectedTab = TabPageSearch
    End Sub

    Private Sub ButtonReports_Click(sender As Object, e As EventArgs) Handles ButtonReports.Click
        TabControlMain.SelectedTab = TabPageReports
    End Sub

    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click
        TabControlMain.SelectedTab = TabPageSettings
    End Sub

    Private Sub ButtonAddItemDone_Click(sender As Object, e As EventArgs) Handles ButtonAddItemDone.Click
        TabControlMain.SelectedTab = TabPageMain
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControlMain.SelectedTab = TabPageMain
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControlMain.SelectedTab = TabPageMain
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControlMain.SelectedTab = TabPageMain
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TabControlMain.SelectedTab = TabPageMain
    End Sub

    Private Sub ButtonCreateNewProduct_Click(sender As Object, e As EventArgs)

    End Sub

    ''' <summary>
    ''' This will cast the selectedProduct into the textfields.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListBoxProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxProduct.SelectedIndexChanged
        Dim selectedProduct As Product = Nothing
        If Me.ListBoxProduct.SelectedItem IsNot Nothing Then
            selectedProduct = DirectCast(Me.ListBoxProduct.SelectedItem, Product)
            If selectedProduct IsNot Nothing Then
                'Set the casted object here.
            End If
        End If
    End Sub




    Private Sub InitalizeCollections()





    End Sub

    Public Enum StorageLocations
        Pantry
        Fridge
    End Enum


    Private Sub ButtonAddProduct_Click(sender As Object, e As EventArgs) Handles ButtonAddProduct.Click
        Dim productToAdd As New Product
        Dim productName As System.String
        Dim productID As Integer
        Dim units As Unit
        Dim expirationDate As DateTime?
        Dim notificationDays As Integer
        Dim quantity As Integer







    End Sub


    Private Sub ButtonBrowseFood_Click(sender As Object, e As EventArgs) Handles ButtonBrowseFood.Click
        '##############################################
        'This begins a load sequence when an XML RRF file is selected for load
        Try
            Dim fileBrowser As New OpenFileDialog
            Dim xmlFile As IO.FileInfo
            Dim filePath As String
            Dim fileName As String
            fileBrowser.Title = "Select RRF XML file to Load"
            fileBrowser.Filter = "MyFoodFiles (*.xml)|*.xml|RRF XML Files (*.xml)|*.xml"
            fileBrowser.Multiselect = False
            'fileBrowser.InitialDirectory = My.Settings.DefaultLoadDirectory
            fileBrowser.ShowDialog()
            filePath = fileBrowser.FileName
            fileName = System.IO.Path.GetFileName(fileBrowser.FileName)
            If Not String.IsNullOrEmpty(filePath) Then
                xmlFile = New IO.FileInfo(filePath)
                If Not xmlFile Is Nothing Then
                    If xmlFile.Exists Then
                        'SelectedRrfXml.Text = fileBrowser.FileName
                        'ToolStripLoadStatus.Text = "File Load Success"
                        'ToolStripLoadStatus.ForeColor = Color.Blue
                        'FrmMainCpmInput.Enabled = True
                        'FrmMainImportSummary.Enabled = True
                        'FrmMainViewRrf.Enabled = True
                        '_FileLoader = New FileLoaderXML(xmlFile)
                        '_FrmMainRrfMaskOrderCollection = _FileLoader.RrfMaskOrderSubmissions
                        '_LoadStatus = True
                        '_FrmMainProcessData.SelectedRrfXml = fileName
                        '_FrmSelectedFile.SelectedRrfXml = fileName
                        'ResetButton.Enabled = True
                        'FrmMainCpmInput.Enabled = True



                        Dim m_xmld As XmlDocument
                        Dim m_nodelist As XmlNodeList
                        Dim m_node As XmlNode
                        'Create the XML Document
                        m_xmld = New XmlDocument()
                        'Load the Xml file
                        m_xmld.Load(xmlFile.FullName)
                        'Get the list of name nodes 
                        m_nodelist = m_xmld.SelectNodes("/family/name")
                        'Loop through the nodes
                        For Each m_node In m_nodelist
                            'Get the Gender Attribute Value
                            Dim genderAttribute As String = m_node.Attributes.GetNamedItem("gender").Value
                            'Get the firstName Element Value
                            Dim firstNameValue As String = m_node.ChildNodes.Item(0).InnerText
                            'Get the lastName Element Value
                            Dim lastNameValue As String = m_node.ChildNodes.Item(1).InnerText
                            'Write Result to the Console
                            System.Windows.Forms.MessageBox.Show(genderAttribute)

                        Next
                



                    End If
                End If
            End If
        Catch ex As Exception
            'ToolStripLoadStatus.Text = "File Load Failure"
            'ToolStripLoadStatus.ForeColor = Color.Red
            '_LoadStatus = False
            'ResetButton.Enabled = True
            'FrmMainCpmInput.Enabled = False
        End Try
    End Sub

    Private Sub ButtonCategoryBrowse_Click(sender As Object, e As EventArgs) Handles ButtonCategoryBrowse.Click
        '##############################################
        'This begins a load sequence when an XML RRF file is selected for load
        Try
            Dim fileBrowser As New OpenFileDialog
            Dim xmlFile As IO.FileInfo
            Dim filePath As String
            Dim fileName As String
            fileBrowser.Title = "Select Category XML file."
            fileBrowser.Filter = "MyFoodFiles (*.xml)|*.xml| XML Files (*.xml)|*.xml"
            fileBrowser.Multiselect = False
            'fileBrowser.InitialDirectory = My.Settings.DefaultLoadDirectory
            fileBrowser.ShowDialog()
            filePath = fileBrowser.FileName
            fileName = System.IO.Path.GetFileName(fileBrowser.FileName)
            If Not String.IsNullOrEmpty(filePath) Then
                xmlFile = New IO.FileInfo(filePath)
                If Not xmlFile Is Nothing Then
                    If xmlFile.Exists Then

                        _FileLoader = New CategoryXMLLoader(xmlFile)
                        Me.ComboBoxCategory.DataSource = Nothing
                        Me.ComboBoxCategory.DataSource = _FileLoader.CategoryCollection

                        Me.DataGridViewReport.DataSource = Nothing
                        Me.DataGridViewReport.DataSource = _FileLoader.CategoryCollection

                    End If
                End If
            End If
        Catch ex As Exception
            'ToolStripLoadStatus.Text = "File Load Failure"
            'ToolStripLoadStatus.ForeColor = Color.Red
            '_LoadStatus = False
            'ResetButton.Enabled = True
            'FrmMainCpmInput.Enabled = False
        End Try
    End Sub
    ''' <summary>
    ''' Run the background worker
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BackgroundWorkerTimer_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        System.Windows.Forms.MessageBox.Show("TESTING")
    End Sub

    Private Sub ProductDetail_Click(sender As System.Object, e As System.EventArgs) Handles ProductDetail.Click

    End Sub

    Private Sub Label21_Click(sender As System.Object, e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub Unit_Click(sender As System.Object, e As System.EventArgs) Handles Unit.Click

    End Sub

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub FormMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class