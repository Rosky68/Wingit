<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FbParameter1 As FirebirdSql.Data.FirebirdClient.FbParameter = New FirebirdSql.Data.FirebirdClient.FbParameter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.BtmLoadZaznamy = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMISTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAUTORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAUTOR2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDZAVAZNOSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTYPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXCHANGES1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXCHANGES2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVIDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZADANODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZADANODBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ODKDYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOKDYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PREDMETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEXTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HISTORIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NEMCASZADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSetEdenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetEden = New WAgit.DataSetEden()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ZaznamyTableAdapter1 = New WAgit.DataSetEdenTableAdapters.ZAZNAMYTableAdapter()
        Me.FbConnection1 = New FirebirdSql.Data.FirebirdClient.FbConnection()
        Me.FbDataAdapter1 = New FirebirdSql.Data.FirebirdClient.FbDataAdapter()
        Me.FbCSelectZaznamy = New FirebirdSql.Data.FirebirdClient.FbCommand()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEdenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 301)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(641, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(208, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(208, 17)
        Me.ToolStripStatusLabel2.Spring = True
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(208, 17)
        Me.ToolStripStatusLabel3.Spring = True
        Me.ToolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(641, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(641, 276)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Btn3)
        Me.TabPage1.Controls.Add(Me.BtmLoadZaznamy)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(633, 250)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Procesy"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(440, 16)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(75, 23)
        Me.Btn3.TabIndex = 4
        Me.Btn3.Text = "Trojka"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'BtmLoadZaznamy
        '
        Me.BtmLoadZaznamy.Location = New System.Drawing.Point(191, 16)
        Me.BtmLoadZaznamy.Name = "BtmLoadZaznamy"
        Me.BtmLoadZaznamy.Size = New System.Drawing.Size(75, 23)
        Me.BtmLoadZaznamy.TabIndex = 3
        Me.BtmLoadZaznamy.Text = "Load"
        Me.BtmLoadZaznamy.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.IDMISTODataGridViewTextBoxColumn, Me.IDAUTORDataGridViewTextBoxColumn, Me.IDAUTOR2DataGridViewTextBoxColumn, Me.IDZAVAZNOSTDataGridViewTextBoxColumn, Me.IDTYPDataGridViewTextBoxColumn, Me.EXCHANGES1DataGridViewTextBoxColumn, Me.EXCHANGES2DataGridViewTextBoxColumn, Me.PROVIDERDataGridViewTextBoxColumn, Me.ZADANODataGridViewTextBoxColumn, Me.ZADANODBDataGridViewTextBoxColumn, Me.ODKDYDataGridViewTextBoxColumn, Me.DOKDYDataGridViewTextBoxColumn, Me.PREDMETDataGridViewTextBoxColumn, Me.TEXTDataGridViewTextBoxColumn, Me.HISTORIEDataGridViewTextBoxColumn, Me.NEMCASZADDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "ZAZNAMY"
        Me.DataGridView1.DataSource = Me.DataSetEdenBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(627, 202)
        Me.DataGridView1.TabIndex = 2
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'IDMISTODataGridViewTextBoxColumn
        '
        Me.IDMISTODataGridViewTextBoxColumn.DataPropertyName = "ID_MISTO"
        Me.IDMISTODataGridViewTextBoxColumn.HeaderText = "ID_MISTO"
        Me.IDMISTODataGridViewTextBoxColumn.Name = "IDMISTODataGridViewTextBoxColumn"
        '
        'IDAUTORDataGridViewTextBoxColumn
        '
        Me.IDAUTORDataGridViewTextBoxColumn.DataPropertyName = "ID_AUTOR"
        Me.IDAUTORDataGridViewTextBoxColumn.HeaderText = "ID_AUTOR"
        Me.IDAUTORDataGridViewTextBoxColumn.Name = "IDAUTORDataGridViewTextBoxColumn"
        '
        'IDAUTOR2DataGridViewTextBoxColumn
        '
        Me.IDAUTOR2DataGridViewTextBoxColumn.DataPropertyName = "ID_AUTOR2"
        Me.IDAUTOR2DataGridViewTextBoxColumn.HeaderText = "ID_AUTOR2"
        Me.IDAUTOR2DataGridViewTextBoxColumn.Name = "IDAUTOR2DataGridViewTextBoxColumn"
        '
        'IDZAVAZNOSTDataGridViewTextBoxColumn
        '
        Me.IDZAVAZNOSTDataGridViewTextBoxColumn.DataPropertyName = "ID_ZAVAZNOST"
        Me.IDZAVAZNOSTDataGridViewTextBoxColumn.HeaderText = "ID_ZAVAZNOST"
        Me.IDZAVAZNOSTDataGridViewTextBoxColumn.Name = "IDZAVAZNOSTDataGridViewTextBoxColumn"
        '
        'IDTYPDataGridViewTextBoxColumn
        '
        Me.IDTYPDataGridViewTextBoxColumn.DataPropertyName = "ID_TYP"
        Me.IDTYPDataGridViewTextBoxColumn.HeaderText = "ID_TYP"
        Me.IDTYPDataGridViewTextBoxColumn.Name = "IDTYPDataGridViewTextBoxColumn"
        '
        'EXCHANGES1DataGridViewTextBoxColumn
        '
        Me.EXCHANGES1DataGridViewTextBoxColumn.DataPropertyName = "EXCHANGES1"
        Me.EXCHANGES1DataGridViewTextBoxColumn.HeaderText = "EXCHANGES1"
        Me.EXCHANGES1DataGridViewTextBoxColumn.Name = "EXCHANGES1DataGridViewTextBoxColumn"
        '
        'EXCHANGES2DataGridViewTextBoxColumn
        '
        Me.EXCHANGES2DataGridViewTextBoxColumn.DataPropertyName = "EXCHANGES2"
        Me.EXCHANGES2DataGridViewTextBoxColumn.HeaderText = "EXCHANGES2"
        Me.EXCHANGES2DataGridViewTextBoxColumn.Name = "EXCHANGES2DataGridViewTextBoxColumn"
        '
        'PROVIDERDataGridViewTextBoxColumn
        '
        Me.PROVIDERDataGridViewTextBoxColumn.DataPropertyName = "PROVIDER"
        Me.PROVIDERDataGridViewTextBoxColumn.HeaderText = "PROVIDER"
        Me.PROVIDERDataGridViewTextBoxColumn.Name = "PROVIDERDataGridViewTextBoxColumn"
        '
        'ZADANODataGridViewTextBoxColumn
        '
        Me.ZADANODataGridViewTextBoxColumn.DataPropertyName = "ZADANO"
        Me.ZADANODataGridViewTextBoxColumn.HeaderText = "ZADANO"
        Me.ZADANODataGridViewTextBoxColumn.Name = "ZADANODataGridViewTextBoxColumn"
        '
        'ZADANODBDataGridViewTextBoxColumn
        '
        Me.ZADANODBDataGridViewTextBoxColumn.DataPropertyName = "ZADANO_DB"
        Me.ZADANODBDataGridViewTextBoxColumn.HeaderText = "ZADANO_DB"
        Me.ZADANODBDataGridViewTextBoxColumn.Name = "ZADANODBDataGridViewTextBoxColumn"
        '
        'ODKDYDataGridViewTextBoxColumn
        '
        Me.ODKDYDataGridViewTextBoxColumn.DataPropertyName = "OD_KDY"
        Me.ODKDYDataGridViewTextBoxColumn.HeaderText = "OD_KDY"
        Me.ODKDYDataGridViewTextBoxColumn.Name = "ODKDYDataGridViewTextBoxColumn"
        '
        'DOKDYDataGridViewTextBoxColumn
        '
        Me.DOKDYDataGridViewTextBoxColumn.DataPropertyName = "DO_KDY"
        Me.DOKDYDataGridViewTextBoxColumn.HeaderText = "DO_KDY"
        Me.DOKDYDataGridViewTextBoxColumn.Name = "DOKDYDataGridViewTextBoxColumn"
        '
        'PREDMETDataGridViewTextBoxColumn
        '
        Me.PREDMETDataGridViewTextBoxColumn.DataPropertyName = "PREDMET"
        Me.PREDMETDataGridViewTextBoxColumn.HeaderText = "PREDMET"
        Me.PREDMETDataGridViewTextBoxColumn.Name = "PREDMETDataGridViewTextBoxColumn"
        '
        'TEXTDataGridViewTextBoxColumn
        '
        Me.TEXTDataGridViewTextBoxColumn.DataPropertyName = "TEXT"
        Me.TEXTDataGridViewTextBoxColumn.HeaderText = "TEXT"
        Me.TEXTDataGridViewTextBoxColumn.Name = "TEXTDataGridViewTextBoxColumn"
        '
        'HISTORIEDataGridViewTextBoxColumn
        '
        Me.HISTORIEDataGridViewTextBoxColumn.DataPropertyName = "HISTORIE"
        Me.HISTORIEDataGridViewTextBoxColumn.HeaderText = "HISTORIE"
        Me.HISTORIEDataGridViewTextBoxColumn.Name = "HISTORIEDataGridViewTextBoxColumn"
        '
        'NEMCASZADDataGridViewTextBoxColumn
        '
        Me.NEMCASZADDataGridViewTextBoxColumn.DataPropertyName = "NEM_CAS_ZAD"
        Me.NEMCASZADDataGridViewTextBoxColumn.HeaderText = "NEM_CAS_ZAD"
        Me.NEMCASZADDataGridViewTextBoxColumn.Name = "NEMCASZADDataGridViewTextBoxColumn"
        '
        'DataSetEdenBindingSource
        '
        Me.DataSetEdenBindingSource.DataSource = Me.DataSetEden
        Me.DataSetEdenBindingSource.Position = 0
        '
        'DataSetEden
        '
        Me.DataSetEden.DataSetName = "DataSetEden"
        Me.DataSetEden.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "BtnRun"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(633, 250)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Co dělám"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListView1.Location = New System.Drawing.Point(3, 98)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(627, 149)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Čas"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Info"
        Me.ColumnHeader2.Width = 600
        '
        'ZaznamyTableAdapter1
        '
        Me.ZaznamyTableAdapter1.ClearBeforeFill = True
        '
        'FbDataAdapter1
        '
        Me.FbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping(-1) {})})
        '
        'FbCSelectZaznamy
        '
        Me.FbCSelectZaznamy.CommandText = "Select * from zaznamy Where zadano > '1.1.2016'"
        Me.FbCSelectZaznamy.CommandTimeout = 30
        Me.FbCSelectZaznamy.Connection = Me.FbConnection1
        FbParameter1.ParameterName = "Zadano"
        FbParameter1.Size = 10
        FbParameter1.Value = "'1.1.2016'"
        Me.FbCSelectZaznamy.Parameters.Add(FbParameter1)
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(536, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 22)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "čtyřka"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 323)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.Text = "WinGit"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEdenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMISTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDAUTORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDAUTOR2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDZAVAZNOSTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTYPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXCHANGES1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXCHANGES2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROVIDERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZADANODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZADANODBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ODKDYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOKDYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PREDMETDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TEXTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HISTORIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NEMCASZADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataSetEdenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetEden As WAgit.DataSetEden
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ZaznamyTableAdapter1 As WAgit.DataSetEdenTableAdapters.ZAZNAMYTableAdapter
    Friend WithEvents FbConnection1 As FirebirdSql.Data.FirebirdClient.FbConnection
    Friend WithEvents FbDataAdapter1 As FirebirdSql.Data.FirebirdClient.FbDataAdapter
    Friend WithEvents FbCSelectZaznamy As FirebirdSql.Data.FirebirdClient.FbCommand
    Friend WithEvents BtmLoadZaznamy As System.Windows.Forms.Button
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
