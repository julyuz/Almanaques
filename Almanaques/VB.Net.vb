' Mensaje
        DevExpress.XtraEditors.XtraMessageBox.Show("XXX","CIUEMP", MessageBoxButtons.OK, MessageBoxIcon.Information)
' Pregunta
        If DevExpress.XtraEditors.XtraMessageBox.Show("�Desea guardar los cambios?", "Confirmaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) =     DialogResult.Yes Then

'Obtiene valor Editado de una CeldaGRid
        MsgBox(GridV1.EditingValue)

' Radios Seleccionados
     Private Sub Options12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Options12.SelectedIndexChanged
        ra.selectedIndex    
    end Sub

' Dato de GridV1
GridV1.GetRowCellValue(con, GridV1.Columns("mon_nom")).ToString

'Modificar GridV1
GridV1.SetRowCellValue(fil, GridV1.Columns(col), 'Datos a cambiar')

' Dato Vacio � NULL
    String.IsNullOrEmpty(n)

' Evento Check
        Private Sub Check1_CheckedChanged(sender As Object, e As EventArgs) Handles Check1.CheckedChanged
        End Sub

' complementar String SQL (00000000 + N)
        cast(replace(str(pre_ide,8),' ','0')as char(8)) pre_ide
         ' CASE en SQL-SERVER
             CASE   
                WHEN tar_per_id = 'Varios' THEN 'Varios'   
            ELSE (SELECT per_nom FROM PERSONAL WHERE per_id=tar_per_id)   
            END as Involucrados,

' acomodo de Cols    (Ocultas - Des-ocultas)
   .Columns("total1").VisibleIndex = GridV1.Columns("vencido").VisibleIndex + 1
   .Columns("total2").VisibleIndex = GridV1.Columns("total1").VisibleIndex + 1
   .Columns("total3").VisibleIndex = GridV1.Columns("total2").VisibleIndex + 1
   .Columns("total4").VisibleIndex = GridV1.Columns("total3").VisibleIndex + 1
   .Columns("total5").VisibleIndex = GridV1.Columns("total4").VisibleIndex + 1

' Ordenar Gridv1 T-F
GridV1.OptionsCustomization.AllowSort = False

' Ver una columna 1 el la posicion 2 del GridV1 
GridV1.Columns(1).VisibleIndex = 2

' Columna a Decimales N,NNN.00
   GridV1.Columns("Precio").DisplayFormat.FormatType = FormatType.Numeric  
   GridV1.Columns("Precio").DisplayFormat.FormatString = "#,0.00"

' ESC --> Salir del Form
    Private Sub LServiciosCostos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Dispose()
        End If
    End Sub

' Agregar Control a Grid
        Gridv1.Columns("Activo , cam_est").ColumnEdit = RepositoryItemProgressBar1

' Agregar Filas a GridV1
        Dim dt As New DataTable
        dt = Grid1.DataSource
        Dim dr As DataRow = dt.NewRow
        dr("per_id") = per_id.Text
        dr("Nomina") = Text1.Text
        dr("Nombre") = Text2.Text
        dr("Departamento") = Text3.Text
        dt.Rows.Add(dr)
        Grid1.DataSource = dt

' Formato de una Fecha
        Format(Date1.EditValue, "dd-MM-yyyy")

' Filtros Laterales
ADD --> "DockManager" - -> asignar el nombre del Form donde se vera
    Agregar --> "Add Panel at Left"



'RepositoryItemImageComboBox
'DevExpress.XtraEditors.Controls.ImageComboBoxItemCollection
Dim imageCombo As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox = TryCast(Grid1.RepositoryItems.Add("ImageComboBoxEdit"), DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox)
        Dim images As DevExpress.Utils.ImageCollection = New DevExpress.Utils.ImageCollection()
        images.ImageSize = New Size(12, 12)
        images.AddImage(Image.FromFile("../../Resources/Imagenes/16/016_1_floppy_16.png"))

        imageCombo.SmallImages = images
        imageCombo.Items.Add(New ImageComboBoxItem("Error", 1, 0))
        imageCombo.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center

        Dim column As DevExpress.XtraGrid.Columns.GridColumn
        column = GridV1.Columns(19)
        'column = GridV1.Columns("Type")
        Grid1.RepositoryItems.Add(imageCombo)
        GridV1.Columns(19).ColumnEdit = imageCombo
        GridV1.Columns(19).ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor
	
'Obtener el valor de un RepositoryItemImageComboBox en la posici�n indicada
	imageCombo.Items.Item(4).Value

'Editar la apariencia de filas del GridView
    Private Sub GridV1_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridV1.RowStyle
        Dim View As GridView = sender
        For xa = 0 To View.RowCount - 1
            If Not IsDBNull(View.GetRowCellValue(View.GetRowHandle(xa), View.Columns(14))) Then
                If View.GetRowCellValue(View.GetRowHandle(xa), View.Columns(14)) = "PROSPECTO" AndAlso View.GetRowHandle(xa) = e.RowHandle Then
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0FFFF)
                    e.Appearance.ForeColor = Color.Black
                End If
            End If
        Next
    End Sub



'Detectar cambio de fila posicionada en Grid
Private Sub GridView_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView.FocusedRowChanged
    Try            
        Console.WriteLine("*valorCelda (en GridView_FocusedRowChanged()): " & valorCelda & vbNewLine & "    GridView.FocusedColumn.AbsoluteIndex: " & GridView.FocusedColumn.AbsoluteIndex & vbNewLine & "    GridView.FocusedRowHandle: " & GridView.FocusedRowHandle)
    Catch ex As Exception
        CError(ex) : Exit Try
    End Try
End Sub


' Personalizar celda con imagen
    Private Sub GridView1_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        If e.Column.Equals(GridView1.Columns("veh_est")) Then
            Dim cellInfo As GridCellInfo = CType(e.Cell, GridCellInfo)
            Dim buttonEditViewInfo As ButtonEditViewInfo = CType(cellInfo.ViewInfo, ButtonEditViewInfo)
            Select Case GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns("veh_est"))
                Case "DISPONIBLE"
                    buttonEditViewInfo.RightButtons(0).Button.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png")
                Case "OCUPADO"
                    buttonEditViewInfo.RightButtons(0).Button.ImageOptions.Image = My.Resources.est_orange
                Case "BAJA"
                    buttonEditViewInfo.RightButtons(0).Button.ImageOptions.Image = My.Resources.cancel_16x16
                Case "OTRO"
                    buttonEditViewInfo.RightButtons(0).Button.ImageOptions.Image = New Bitmap(My.Resources.TileComPro_32, 50, 50)

            End Select
        End If
        If e.Column.Equals(GridView1.Columns("boton_check")) Then
            Dim cellInfo As GridCellInfo = CType(e.Cell, GridCellInfo)
            Dim buttonEditViewInfo As ButtonEditViewInfo = CType(cellInfo.ViewInfo, ButtonEditViewInfo)
            buttonEditViewInfo.RightButtons(0).Button.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/filter%20elements/checkbuttons_16x16.png")
        End If

    End Sub


' Filtrar ocultando filas
Private Sub GridView1_CustomRowFilter(sender As Object, e As RowFilterEventArgs) Handles GridView1.CustomRowFilter
    Dim gridView As GridView = TryCast(sender, GridView)
    If Not IsNothing(gridView) Then
        Dim view As ColumnView = sender
        Dim id = view.GetListSourceRowCellValue(e.ListSourceRow, "id").ToString

        If id <> "1" Then
            e.Visible = False
            e.Handled = True
        End If
    End If
End Sub


' Permanecer en el id (fila seleccionada) al actualizar datos de Grid
Dim id_seleccionado As Object = Nothing, rowHandle As Integer = 0
id_seleccionado = GridView1.GetFocusedRowCellValue(GridView1.Columns("id"))
'
' ... Llenar Grid
'...
rowHandle = GridView1.LocateByValue("id", id_seleccionado, Nothing)
GridView1.FocusedRowHandle = rowHandle


' Agregar evento a un control
AddHandler repComboBox.SelectedIndexChanged, AddressOf repComboBox_SelectedIndexChanged

' Editor en una columna de Grid
Gridview1.Columns("id").ColumnEdit = RepositoryItemComboBox1
"Poner como "Editable" el Grid, y en el evento "GridView1_ShowEditor", validar que no se cancele esta columna"

' Tooltip en celda en específico (en el diseño establecer un "ToolTipController" al GridControl)
Private Sub ToolTipController1_GetActiveObjectInfo(sender As Object, e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles ToolTipController1.GetActiveObjectInfo
    If e.Info Is Nothing AndAlso e.SelectedControl Is tabTraspasos Then
        Dim view As GridView = TryCast(tabTraspasos.FocusedView, GridView)
        Dim info As GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)

        If info.InRowCell Then
            Dim columna_nombre As String = ""
            columna_nombre = info.Column.FieldName
            Select Case columna_nombre
                Case "columna1" 
                    Dim text_Renamed As String = view.GetRowCellDisplayText(info.RowHandle, info.Column)
                    Dim cellKey As String = info.RowHandle.ToString() & " - " & info.Column.ToString()
                    e.Info = New ToolTipControlInfo(cellKey, text_Renamed)
            End Select
        End If

    End If
End Sub


' Crear "WaitSplashScreen" por código
Dim WithEvents wait As New SplashScreenManager(Me, GetType(WaitForm1), True, True, 200)

' Cargar archivo
Private Sub SimpleButton_CargarPDF_Click(sender As Object, e As EventArgs) Handles SimpleButton_CargarPDF.Click
    Try
        If txtProId.Text = Nothing Then
            MsgBox("Primero guarde el registro", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If System.IO.Directory.Exists(RUTA) = True Then
            OpenFileDialog1.Filter = "Documentos PDF|*.pdf"
            OpenFileDialog1.InitialDirectory = "C:\"
            OpenFileDialog1.FileName = "Archivo.pdf"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                subirArchivo()
            End If
        Else
            MsgBox("No se tiene acceso a la carpeta", vbCritical)
        End If
    Catch ex As Exception
        If wait.IsSplashFormVisible Then wait.CloseWaitForm()
        CError(ex) : Exit Try
    End Try
End Sub

Sub subirArchivo()
    Dim extension As String = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
    If System.IO.Directory.Exists(RUTA) = False Then
        System.IO.Directory.CreateDirectory(RUTA)
    End If
    Dim archivo = txtProId.Text & "_" & "doc_" & OpenFileDialog1.SafeFileName
    Dim ruta_archivo = RUTA & archivo
    If System.IO.File.Exists(ruta_archivo) Then
        Dim Msg As MsgBoxResult
        Msg = MsgBox("¿Desea actualizar el documento?", vbQuestion + vbYesNo, "CIU")
        If Msg = MsgBoxResult.Yes Then
            wait.ShowWaitForm()
            wait.SetWaitFormCaption("Por Favor,Espere")
            wait.SetWaitFormDescription("Cargando...")
            System.IO.File.Delete(ruta_archivo)
            System.IO.File.Copy(OpenFileDialog1.FileName, ruta_archivo, True)
            ExecuteIns("Update Proveedores Set pro_pdf = '" & archivo & "' WHERE pro_id=" & txtProId.Text & "")
            wait.CloseWaitForm()
            MsgBox("Cargado correctamente", vbOKOnly + vbInformation)
            TextEdit_Pdf.Text = archivo
        Else
            Exit Sub
        End If
    Else
        wait.ShowWaitForm()
        wait.SetWaitFormCaption("Por Favor,Espere")
        wait.SetWaitFormDescription("Cargando...")
        System.IO.File.Copy(OpenFileDialog1.FileName, ruta_archivo, True)
        ExecuteIns("Update Proveedores Set pro_pdf = '" & archivo & "' WHERE pro_id=" & txtProId.Text & "")
        wait.CloseWaitForm()
        MsgBox("Cargado correctamente", vbOKOnly + vbInformation)
        TextEdit_Pdf.Text = archivo
    End If
End Sub

' cb_empresa (ComboboxEdit)
Dim frmMenu As Menu = DirectCast(Application.OpenForms("Menu"), Menu)
Dim ids_emp As ArrayList
Public emp_id As String

'Load()
Dim emps = consulta.getPerEmp(frmMenu.col_id)
ids_emp = consulta.llenarCBEdit(cb_empresa, "SELECT * FROM EMPRESAS WHERE emp_est='ACTIVO' And emp_id IN (" & IIf(emps.ToArray.Length = 0, 0, String.Join(",", emps.ToArray)) & ")  ORDER BY emp_nom_com", "emp_id", "emp_nom_com")
cb_empresa.SelectedIndex = ids_emp.IndexOf(frmMenu.emp_id)
If emp_id <> Nothing Then
    cb_empresa.SelectedIndex = ids_emp.IndexOf(emp_id)
End If

' SQL - Actualizar campo con Consulta Join
UPDATE PP SET     PP.emp_id = CLI.emp_id
FROM PEDIDOS_PALLET PP
INNER JOIN CLIENTES CLI ON PP.cli_id = PP.cli_id

' ComboboxEdit en columna de Grid
Private Sub columnaCombo()
    Dim repComboBox As New RepositoryItemComboBox
    repComboBox.Items.Add("")
    AddHandler repComboBox.SelectedIndexChanged, AddressOf repComboBox_SelectedIndexChanged

    RS_ART = CN.Execute("SELECT con_nom FROM CONTINGENCIAS WHERE con_est=1 And gastos=1 ORDER BY con_nom")
    If RS_ART.Rows.Count > 0 Then
        For Each fila As DataRow In RS_ART.Rows
            If Not IsNothing(fila("con_nom")) Then
                repComboBox.Items.Add(fila("con_nom"))
            End If
        Next
    End If

    tabTraspasos.RepositoryItems.Add(repComboBox)
    GridView1.Columns("covid").ColumnEdit = repComboBox
End Sub

' Enviar correo ("SendCIUMail" es otro método aparte)
SendCIUMail(25, "191.168.32.6", "info@ciumx.com", mailaEnviar, "Proyecto " & nombre_proy,
                                            "Persona quien " & texto & " el proyecto: " & selec & vbCrLf & "Actualizado por: " & MenuUITab.ItemUser.Caption & vbCrLf & "Día de modificación: " & Format(DateTime.Now, "dd/MM/yyyy hh:mm") & vbCrLf & "Desde la IP: " & MenuUITab.LblDirIP.Text & vbCrLf & "FAVOR DE VOLVER A COTIZAR.", "", False)

' Id usuario logueado
 MenuUITab.ItemUser.Caption

' Ip usuario logueado
MenuUITab.LblDirIP.Text

' Columna (en el Footer) como suma (ó el tipo que se especifique)
' Poner "Show Footer" en True en el GridControl
.Columns("Stock").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
.Columns("Stock").SummaryItem.DisplayFormat = "{0: 0,0}"

' SQL -  Cantidades en una sola fila
Select *, (tot_pend + tot_comp) As suma_total from 
( Select COUNT(tar_id) As tot_pend, 1 As id from TAREAS As tar Left Join USUARIOS As usu On Tar.usu_id = usu.usu_id
	Where 'a' = 'a' and tar_est = 'PENDIENTE' " & filtros_count & " And tar_est = 'PENDIENTE' 
) As tab1  
Left Join  
( Select COUNT(tar_id) As tot_comp, 1 As id from TAREAS As tar Left Join USUARIOS As usu On Tar.usu_id = usu.usu_id
	Where 'a' = 'a' and tar_est = 'COMPLETO' " & filtros_count & " And tar_est = 'COMPLETO' 
) As tab2 On tab1.id = tab2.id

' Detectar combinación de teclas (evento "KeyDown" del Form)
If (e.Modifiers = Keys.Control) AndAlso e.KeyCode = Keys.B Then
    MsgBox("ctrl + b")
End If
If (e.KeyCode And Not Keys.Modifiers) = Keys.B AndAlso e.Control Then
    MsgBox("CTRL + B")
End If

' Cargar imagen en un "PictureEdit"
foto.Image = Image.FromStream(New MemoryStream(File.ReadAllBytes(RUTA & "Personal\" + Data("col_fot").ToString)))
PictureEdit1.Image = Image.FromFile(ruta_archivo)
' Con tamaño predefinido de la imagen
foto.Image = New Bitmap(Image.FromStream(New MemoryStream(File.ReadAllBytes(RUTA & "Personal\" + Data("col_fot").ToString))), 50, 50)
foto.Image = New Bitmap(DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/borole_32x32.png")), 20, 20)

' Tooltip como imagen en GridControl
Private Sub ToolTipController1_GetActiveObjectInfo(sender As Object, e As ToolTipControllerGetActiveObjectInfoEventArgs) Handles ToolTipController1.GetActiveObjectInfo
    If Not (e.SelectedControl.Equals(GridControl1)) Then
        Exit Sub
    End If

    If e.Info Is Nothing AndAlso e.SelectedControl Is GridControl1 Then
        Dim view As GridView = TryCast(GridControl1.FocusedView, GridView)
        Dim info As GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)

        If info.InRowCell Then
            Dim columna_nombre As String = ""
            columna_nombre = info.Column.FieldName
            Select Case columna_nombre
                Case "per_img"

                    Dim SuperToolTip As SuperToolTip = New SuperToolTip()

                    Dim ToolTipControlInfo As ToolTipControlInfo = New ToolTipControlInfo(GridControl1, "Test")

                    Dim item1 As ToolTipItem = New ToolTipItem
                    'item1.Image = New Bitmap(Image.FromStream(New MemoryStream(File.ReadAllBytes(GridView1.GetRowCellValue(info.RowHandle, info.Column)))), 320, 320)
                    item1.Image = New Bitmap(Image.FromStream(New MemoryStream(File.ReadAllBytes(GridView1.GetRowCellValue(info.RowHandle, info.Column)))))

                    SuperToolTip.Items.Add(item1)

                    ToolTipControlInfo.SuperTip = SuperToolTip
                    e.Info = ToolTipControlInfo
            End Select
        End If
    End If
End Sub

' Formatear valor
e.DisplayText = Format(CDbl(e.Value), "#,0.00")

Dim ciUSA As CultureInfo = New CultureInfo("en-US")
e.DisplayText = String.Format(ciUSA, "{0:#,0.00}", CDbl(e.Value))

' SQL - Buscar en Sql sin distinción de Mayúsculas, acentos, etc..
Select Count(art_id) As cont From Articulos Where art_des collate SQL_Latin1_General_Cp1_CI_AI = '" & art_des & "'

' SQL - Edad de 1 persona a partir de su Fecha de nacimiento
Select CONVERT(Varchar, CAST( (DATEDIFF(dd, fec_nac, GetDate()) / 365) As SmallInt ))

Declare @fecha_nac As Date Set @fecha_nac = DATEFROMPARTS(1992, 02, 20)
Declare @fecha_act As Date Set @fecha_act = GETDATE()

Select DATEDIFF(year, @fecha_nac, @fecha_act) -
	Case When @fecha_act < DATEFROMPARTS(YEAR(@fecha_act), Month(@fecha_nac), Day(@fecha_nac) ) Then 1
	Else 0 End
	-- Ó Iif(@fecha_act < DateFromParts(Year(@fecha_act), MONTH(@fecha_nac), Day(@fecha_nac) ), 1, 0)
	As Edad

' SQL - Obtener una fecha a partir de sus 3 componentes (Año, Mes, Día)
Declare @fecha_nac As Date Set @fecha_nac = DATEFROMPARTS(1992, 02, 20)
Select DATEFROMPARTS(1992, 02, 20) 

' SQL - Formatear cantidades
Select Format(1334234.569, 'n2', 'en-US')
Select Format(1334234.569, 'n4', 'es-MX')
	













' Dibujar, escribir en un documento para imprimir
Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) 'Handles PrintDocument1.BeginPrint
    Dim Margins = New Margins()
    'Margins.Left = 50      ' 5mm (500)
    'Margins.Top = 100      ' 10mm (1000)
    Dim margDer As Integer

    Margins.Left = 0
    Margins.Top = 0
    Margins.Right = margDer

    PrintDocument1.DefaultPageSettings.Margins = Margins
    PrintDocument1.PrinterSettings.DefaultPageSettings.Margins = Margins
End Sub

Private Sub PrintDocument_Diseños_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) 'Handles PrintDocument1.PrintPage
    Dim font35 As Font = New Font("barcode 128", 35, FontStyle.Regular)
    Dim font12 As Font = New Font("Tahoma", 12, FontStyle.Regular)
    Dim font10 As Font = New Font("Tahoma", 10, FontStyle.Regular)
    Dim font8 As Font = New Font("Tahoma", 8, FontStyle.Regular)
    Dim bold18 As Font = New Font("Tahoma", 18, FontStyle.Bold)
    Dim bold16 As Font = New Font("Tahoma", 16, FontStyle.Bold)
    Dim bold12 As Font = New Font("Tahoma", 12, FontStyle.Bold)
    Dim bold10 As Font = New Font("Tahoma", 10, FontStyle.Bold)
    Dim bold8 As Font = New Font("Tahoma", 8, FontStyle.Bold)
    e.Graphics.PageUnit = GraphicsUnit.Millimeter
    'e.Graphics.PageUnit = GraphicsUnit.Pixel
    Dim drawFormat As New StringFormat
    Dim x As Double = 5

    ' 1 Pixel = 0.2645 mm
    Dim xB As Integer = 0
    Dim yB As Integer = 0
    Dim anB As Integer, alB As Integer

    e.Graphics.ResetTransform() ' Limpiar cualquier "transform" previo
    e.Graphics.SetClip(New Rectangle(0, 0, Int(anchoContenedorImpresion), Int(altoContenedorImpresion)))

    ' /*** Prueba
    'e.Graphics.DrawRectangle(New Pen(Color.DarkSlateBlue, 1), 0, 0, CInt(anchoContenedorImpresion), CInt(altoContenedorImpresion))
    'e.Graphics.DrawLine(New Pen(Color.LightGray, 1), New Point(CInt(anchoContenedorImpresion / 2), 0),
    '                    New Point(CInt(anchoContenedorImpresion / 2), CInt(altoContenedorImpresion)))
    'e.Graphics.DrawLine(New Pen(Color.LightGray, 1), New Point(0, CInt(altoContenedorImpresion / 2)),
    '                    New Point(anchoContenedorImpresion, CInt(altoContenedorImpresion / 2)))
    ' Prueba ***/


    Dim cont_imprimidos As Integer = 1, consulta_str As String = ""

    consulta_str = "Select * From DETALLES_DISEÑOS_ETIQUETAS Where dis_eti_id = '" & dis_eti_id & "' and det_de_est = 'Activo' "

    Dim tabla_datos As DataTable = consulta.getTable(consulta_str)
    If tabla_datos.Rows.Count > 0 Then
        Dim fuente As Font = Nothing, brush_control As Brush = Nothing
        Dim fuente_sender_negrita As FontStyle
        Dim fuente_sender_cursiva As FontStyle
        Dim fuente_sender_tachado As FontStyle
        Dim fuente_sender_subrayado As FontStyle

        Dim estatus_ As String

        For Each data_Row As DataRow In tabla_datos.Rows

            Dim color_ As Color
            If Not IsDBNull(data_Row(tabla_datos.Columns("det_de_r"))) AndAlso Not IsDBNull(data_Row("det_de_g")) AndAlso Not IsDBNull(data_Row("det_de_b")) Then
                color_ = Color.FromArgb(data_Row("det_de_r"), data_Row("det_de_g"), data_Row("det_de_b"))
            End If

            estatus_ = data_Row.Item("det_de_est").ToString

            If Not IsDBNull(data_Row("det_de_x")) Then xB = data_Row.Item("det_de_x")
            If Not IsDBNull(data_Row("det_de_y")) Then yB = data_Row.Item("det_de_y")

            If Not IsDBNull(data_Row("det_de_anc")) Then anB = data_Row.Item("det_de_anc")
            If Not IsDBNull(data_Row("det_de_alt")) Then alB = data_Row.Item("det_de_alt")

            Dim det_de_tag As String = data_Row.Item("det_de_tag"), det_de_anc As String = IIf(Not IsDBNull(data_Row.Item("det_de_anc")), data_Row.Item("det_de_anc"), "")

            ' Etiquetas
            If IsDBNull(data_Row.Item("det_de_anc")) Then
                fuente_sender_negrita = IIf(data_Row("det_de_neg").ToString = "True", FontStyle.Bold, FontStyle.Regular)
                fuente_sender_cursiva = IIf(data_Row("det_de_cur").ToString = "True", FontStyle.Italic, FontStyle.Regular)
                fuente_sender_tachado = IIf(data_Row("det_de_tac").ToString = "True", FontStyle.Strikeout, FontStyle.Regular)
                fuente_sender_subrayado = IIf(data_Row("det_de_sub").ToString = "True", FontStyle.Underline, FontStyle.Regular)

                fuente = New Font(data_Row("det_de_fue").ToString, data_Row("det_de_fue_tam"), fuente_sender_negrita Or fuente_sender_cursiva Or fuente_sender_tachado Or fuente_sender_subrayado)
                brush_control = New SolidBrush(color_)
            End If

            Select Case data_Row.Item("det_de_tag")
                Case "barras_texto"
                    drawFormat.Alignment = StringAlignment.Near
                    'Dim Barcode As New BarcodeCodabar
                    'Barcode.StartStopText = False
                    'e.Graphics.DrawString("(01) 1-" & datos("cod_pais") & datos("cod_estado") & datos("cod_empaque") & "-0010-1 (10) " & datos("barras"), fuente, brush_control, xB, yB, drawFormat)

                    Dim art_clave As String = ""
                    art_clave = datos_art("art_cla")
                    e.Graphics.DrawString(art_clave, fuente, brush_control, xB, yB, drawFormat)

                Case "articulo_descripcion"
                    e.Graphics.DrawString(datos_art("art_des"), fuente, brush_control, xB, yB)

                Case Else

                    ' Imágenes
                    If Not IsDBNull(data_Row.Item("det_de_anc")) Then
                        If data_Row.Item("det_de_tag") = "barras" Then
                            'e.Graphics.DrawImage(Codigos.codigo128("A1" & datos("cod_pais") & datos("cod_estado") & datos("cod_empaque") & "0010110" & datos("barras") & "B", False, alB), xB, yB, anB, alB)
                            Dim art_clave As String = ""
                            art_clave = datos_art("art_cla")
                            e.Graphics.DrawImage(Codigos.codigo128("A" & art_clave & "B", False, alB), xB, yB, anB, alB)

                        Else
                            ' Las agregadas nuevas                                              

                            ' Si la ruta esta vacía y es un "picture_agregado", quiere decir que no se cambió la imagen por defecto
                            If Not data_Row("det_de_img_rut") = Nothing Then
                                e.Graphics.DrawImage(Image.FromStream(New MemoryStream(File.ReadAllBytes(RUTA & data_Row("det_de_img_rut").ToString))), xB, yB, anB, alB)
                            Else
                                e.Graphics.DrawImage(DevExpress.Images.ImageResourceCache.Default.GetImage("images/toolbox%20items/picturebox_32x32.png"), xB, yB, anB, alB)
                            End If
                        End If
                    Else
                        If data_Row.Item("det_de_tag").ToString().StartsWith("control_texto_agregado") Then
                            e.Graphics.DrawString(data_Row.Item("det_de_texto"), fuente, brush_control, xB, yB)
                        Else
                            e.Graphics.DrawString(data_Row.Item("det_de_tag"), fuente, brush_control, xB, yB)
                        End If
                    End If

            End Select

        Next
    End If


    Private Sub SetDataSource(gv As GridView, dt As DataTable)
        Dim gc As GridControl = gv.GridControl
        gc.BeginUpdate()
        gv.Columns.Clear()
        gc.DataSource = Nothing
        gc.DataSource = dt
        gc.EndUpdate()
    End Sub


        Private Sub GridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        With GridView1
           If .GetRowCellValue(e.RowHandle, .Columns("imprimiendo")) = "imprimiendo" Then
               If e.Column.FieldName = "cant_imp" Then
                   If bandera_imprimiendo Then
                       For jjj As Byte = 0 To .RowCount - 1
                           e.Appearance.Font = fuente_negrita
                       Next
                   Else
                       For jjj As Byte = 0 To .RowCount - 1
                           e.Appearance.Font = fuente_normal
                       Next
                   End If
               End If
           End If
        End With
    End Sub
End Sub

buttonEditViewInfo.RightButtons(0).Button.ImageOptions.Image = New Bitmap(My.Resources.tileAlmEnt_32, 320, 320)


' ProgressBar en columna de Grid
Gridview1.Columns("por").Caption = "%"
Gridview1.Columns("por").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
' Editar los colores del ProgressBar
Private Sub GridView1_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles GridView1.CustomRowCellEdit
    If e.Column.FieldName = "por" Then
        Dim value = GridView1.GetRowCellValue(e.RowHandle, GridView1.Columns("por"))
        If CDbl(value) < 25 Then
            e.RepositoryItem = CreateRepositoryItemProgressBar(ColorTranslator.FromHtml("#ed969e"), GridControl1) 'danger LIGHT
        ElseIf CDbl(value) < 75 Then
            e.RepositoryItem = CreateRepositoryItemProgressBar(ColorTranslator.FromHtml("#FFC080"), GridControl1) 'warning LIGHT
        Else
            e.RepositoryItem = CreateRepositoryItemProgressBar(ColorTranslator.FromHtml("#8fd19e"), GridControl1) 'success LIGHT
        End If
    End If
End Sub

' Obtener el índice del RepositoryItemCombobox Seleccionado
Dim index_combo As SByte = -1
Private Sub RepositoryItemComboBox2_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles RepositoryItemComboBox2.EditValueChanging
    Console.WriteLine("index_combo: " & index_combo)
    index_combo = RepositoryItemComboBox2.Items.IndexOf(e.NewValue)
    Console.WriteLine("index_combo: " & index_combo)
End Sub

' Guardar Excel en una ruta
' exLibro.Save()  ' Lo guarda en Mis Documentos con nombre LibroX
' exLibro.SaveAs("C:\libro1Excel")
' exLibro.SaveAs("C:\bookrecord", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault)  ' xlCSV
exLibro.SaveAs(SaveFileDialog1.FileName)

' Formato con la cantidad de dígitos especificados
objWorkbook.ActiveSheet.cells(f + 1, col1).numberFormat = "#0000000000"

' Establecer una fecha en un DateEdit
DateEdit_FechaImp.Text = Convert.ToDateTime(datos_inc("pro_fec")).ToString("dd/MM/yyyy")

' Varios filtros a la vez para un "OpenFileDialog"
OpenFileDialog1.Filter = "Imagenes jpg|*.jpg|Imagenes jpeg|*.jpeg|Imagenes |*.png|Todas las imagenes|*.jpg;*.jpeg;*.png"

' SQL - Retornar el ID insertado
Insert Into Proveedores_Categorias (pro_cat_des, pro_cat_est) Output Inserted.pro_cat_id Values ('cat_nom', 'ACTIVO')

' SQL - Retornar el ID actualizado
Update Proveedores_Categorias Set pro_cat_des = 'cat_nom' Output Inserted.pro_cat_id Where pro_cat_id = 'pro_cat_id'


' MDI - Multiple-Document Interface Interfaz de Multiples Documentos/Varios Documentos

' Imprimir posición y valor de un Array (con For Each)
Dim jjj As Byte = 0
For Each valor In ids
    Console.WriteLine("valor [{0}]:  {1}", jjj, valor)
    jjj += 1
Next

' Crear los valores de un "IN" de SQL usando un ArrayList con los datos que se quieran
dim In As String = ""
In = IIf(arrayKPI.Count = 0, 0, String.Join(",", arrayKPI.ToArray))

' Saltar 1 vez en el ciclo For
For i As Integer = 0 To 5
    If 1 = 0 Then
        Continue For
    End If
Next i

' Salir del ciclo For
For i As Integer = 0 To 5
    If 1 = 0 Then
        Exit For
    End If
Next i

' Conectar con Sql Server
Dim sqlCon as new SqlConnection("Data Source = 192.168.1.101; uid = sa; pwq = pass; database = db")
sqlCon.Open()

' Ejecutar consulta sin retorno de datos
Dim sqlComm As New SqlCommand(str, sqlCon)
sqlCon.Open
sqlComm.ExecuteNonQuery()
sqlCon.Close()


' Ejecutar consulta con retorno de datos
Dim sqlComm As New SqlCommand(str, sqlCon)
sqlCon.Open

Dim datos As SqlDataReader = sqlComm.ExecuteReader()
If datos.HasRows = True Then
    While datos.Read() =  True
        For jjj as integer = 0 To datos.FieldCount - 1
            Dim valor = datos.GetName(jjj)
        Next jjj
    End While
End If

datos.Close()
sqlCon.Close()

' Ejecutar consulta y llenar un DataTable
Dim sqlComm As New SqlCommand(str, sqlCon)
sqlCon.Open

Dim sqlAdap As New SqlDataAdapter(query, sqlCon)
Dim dataTable As New DataTable()
sqlAdap.Fill(dataTable)

sqlCon.Close()


