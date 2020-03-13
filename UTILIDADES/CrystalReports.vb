Module CrystalReportsConexion2
    Public Function LoadReportViewer2(ByRef Viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer, ByVal objReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, Optional ByVal NoShow As Boolean = False, Optional ByVal con As String = "") As Boolean
        'Declaring variablesables
        'Parameter value object of crystal report RptViewer
        ' parameters used for adding the value to parameter.
        'Current parameter value object(collection) of crystal report parameters.
        'Sub report object of crystal report.
        'Sub report document of crystal report.
        Dim intCounter As Integer
        Dim intCounter1 As Integer 'Crystal Report's report document object
        'Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo 'object of table Log on info of Crystal report
        Dim paraValue As New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim currValue As CrystalDecisions.Shared.ParameterValues
        Dim mySubReportObject As CrystalDecisions.CrystalReports.Engine.SubreportObject
        Dim mySubRepDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strParValPair() As String
        Dim strVal() As String
        Dim index As Integer
        Dim SQLConexion As New Conexion
        If con.Equals("") Then
            SQLConexion.SQLStringConexion = Configuracion.Claves.Conexion("Contabilidad")
        Else
            SQLConexion.SQLStringConexion = con
        End If

        SQLConexion.Conectar()

        Try
            'objReport.Load(sReportName)         'Sub report document of crystal report.
            'intCounter = objReport.DataDefinition.ParameterFields.Count 'Check if there are parameters or not in report.
            'As parameter fields collection also picks the selection 
            ' formula which is not the parametermeter
            ' so if total parameter count is 1 then we check whether 
            ' its a parameter or selection formula.
            'If intCounter = 1 Then
            '    If InStr(objReport.DataDefinition.ParameterFields(0).ParameterFieldName, ".", CompareMethod.Text) > 0 Then
            '        intCounter = 0
            '    End If
            'End If

            'If there are parameters in report and 
            'user has passed them then split the 
            'parameter string and Apply the values 
            'to there concurent parameters.

            'If intCounter > 0 And Trim(Param) <> "" Then
            '    strParValPair = Param.Split("&")
            '    For index = 0 To UBound(strParValPair)
            '        If InStr(strParValPair(index), "=") > 0 Then
            '            strVal = strParValPair(index).Split("=")
            '            paraValue.Value = strVal(1)
            '            currValue = objReport.DataDefinition.ParameterFields(strVal(0)).CurrentValues
            '            currValue.Add(paraValue)
            '            objReport.DataDefinition.ParameterFields(strVal(0)).ApplyCurrentValues(currValue)
            '        End If
            '    Next
            'End If
            'Set the connection information to ConInfo object so that we can apply the 
            ' connection information on each table in the reporteport

            'ConInfo.ConnectionInfo.UserID = "SEESOFT"
            'ConInfo.ConnectionInfo.Password = "123"
            ConInfo.ConnectionInfo.IntegratedSecurity = True
            ConInfo.ConnectionInfo.ServerName = SQLConexion.sQlconexion.DataSource
            ConInfo.ConnectionInfo.DatabaseName = SQLConexion.sQlconexion.Database

            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
            Next
            ' Loop through each section on the report then look 
            ' through each object in the section
            ' if the object is a subreport, then apply logon info 
            ' on each table of that sub report
            For index = 0 To objReport.ReportDefinition.Sections.Count - 1
                For intCounter = 0 To _
                      objReport.ReportDefinition.Sections(index).ReportObjects.Count - 1
                    With objReport.ReportDefinition.Sections(index)
                        If .ReportObjects(intCounter).Kind = _
                           CrystalDecisions.Shared.ReportObjectKind.SubreportObject Then
                            mySubReportObject = CType(.ReportObjects(intCounter),  _
                            CrystalDecisions.CrystalReports.Engine.SubreportObject)
                            mySubRepDoc = _
                             mySubReportObject.OpenSubreport(mySubReportObject.SubreportName)
                            For intCounter1 = 0 To mySubRepDoc.Database.Tables.Count - 1
                                mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                                'mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                            Next
                        End If
                    End With
                Next
            Next
            'If sSelectionFormula.Length > 0 Then 'If there is a selection formula passed to this function then use that
            '    objReport.RecordSelectionFormula = sSelectionFormula
            'End If
            'Re setting control 
            'rptViewer.ReportSource = Nothing
            'Set the current report object to report.
            If NoShow = False Then Viewer.ReportSource = objReport
            'Show the report
            'RptViewer.Show()
            Return True
        Catch ex As System.Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function LoadReportViewer(ByRef Viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer, ByVal objReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, Optional ByVal NoShow As Boolean = False, Optional ByVal con As String = "") As Boolean
        'Declaring variablesables
        'Parameter value object of crystal report RptViewer
        ' parameters used for adding the value to parameter.
        'Current parameter value object(collection) of crystal report parameters.
        'Sub report object of crystal report.
        'Sub report document of crystal report.
        Dim intCounter As Integer
        Dim intCounter1 As Integer 'Crystal Report's report document object
        'Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo 'object of table Log on info of Crystal report
        Dim paraValue As New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim currValue As CrystalDecisions.Shared.ParameterValues
        Dim mySubReportObject As CrystalDecisions.CrystalReports.Engine.SubreportObject
        Dim mySubRepDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strParValPair() As String
        Dim strVal() As String
        Dim index As Integer
        Dim SQLConexion As New Conexion
        SQLConexion.SQLStringConexion = Configuracion.Claves.Conexion("Contabilidad")
        SQLConexion.Conectar()

        Try
            'objReport.Load(sReportName)         'Sub report document of crystal report.
            'intCounter = objReport.DataDefinition.ParameterFields.Count 'Check if there are parameters or not in report.
            'As parameter fields collection also picks the selection 
            ' formula which is not the parametermeter
            ' so if total parameter count is 1 then we check whether 
            ' its a parameter or selection formula.
            'If intCounter = 1 Then
            '    If InStr(objReport.DataDefinition.ParameterFields(0).ParameterFieldName, ".", CompareMethod.Text) > 0 Then
            '        intCounter = 0
            '    End If
            'End If

            'If there are parameters in report and 
            'user has passed them then split the 
            'parameter string and Apply the values 
            'to there concurent parameters.

            'If intCounter > 0 And Trim(Param) <> "" Then
            '    strParValPair = Param.Split("&")
            '    For index = 0 To UBound(strParValPair)
            '        If InStr(strParValPair(index), "=") > 0 Then
            '            strVal = strParValPair(index).Split("=")
            '            paraValue.Value = strVal(1)
            '            currValue = objReport.DataDefinition.ParameterFields(strVal(0)).CurrentValues
            '            currValue.Add(paraValue)
            '            objReport.DataDefinition.ParameterFields(strVal(0)).ApplyCurrentValues(currValue)
            '        End If
            '    Next
            'End If
            'Set the connection information to ConInfo object so that we can apply the 
            ' connection information on each table in the reporteport

            ConInfo.ConnectionInfo.UserID = ""
            ConInfo.ConnectionInfo.Password = ""
            ConInfo.ConnectionInfo.ServerName = SQLConexion.sQlconexion.DataSource
            ConInfo.ConnectionInfo.DatabaseName = SQLConexion.sQlconexion.Database
            ConInfo.ConnectionInfo.IntegratedSecurity = True

            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
            Next
            ' Loop through each section on the report then look 
            ' through each object in the section
            ' if the object is a subreport, then apply logon info 
            ' on each table of that sub report
            For index = 0 To objReport.ReportDefinition.Sections.Count - 1
                For intCounter = 0 To _
                      objReport.ReportDefinition.Sections(index).ReportObjects.Count - 1
                    With objReport.ReportDefinition.Sections(index)
                        If .ReportObjects(intCounter).Kind = _
                           CrystalDecisions.Shared.ReportObjectKind.SubreportObject Then
                            mySubReportObject = CType(.ReportObjects(intCounter),  _
                            CrystalDecisions.CrystalReports.Engine.SubreportObject)
                            mySubRepDoc = _
                             mySubReportObject.OpenSubreport(mySubReportObject.SubreportName)
                            For intCounter1 = 0 To mySubRepDoc.Database.Tables.Count - 1
                                mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                                'mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                            Next
                        End If
                    End With
                Next
            Next
            'If sSelectionFormula.Length > 0 Then 'If there is a selection formula passed to this function then use that
            '    objReport.RecordSelectionFormula = sSelectionFormula
            'End If
            'Re setting control 
            'rptViewer.ReportSource = Nothing
            'Set the current report object to report.
            If NoShow = False Then Viewer.ReportSource = objReport
            'Show the report
            'RptViewer.Show()
            Return True
        Catch ex As System.Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    'Public Sub VerSplit()

    '    Dim delimStr As String = " ,.:"
    '    Dim delimiter As Char() = delimStr.ToCharArray()
    '    Dim words As String = "one two,three:four."
    '    Dim split As String() = Nothing

    '    Console.WriteLine("The delimiters are -{0}-", delimStr)
    '    Dim x As Integer
    '    For x = 1 To 5
    '        split = words.Split(delimiter, x)
    '        Console.WriteLine(ControlChars.Cr + "count = {0,2} ..............", x)
    '        Dim s As String
    '        For Each s In split
    '            Console.WriteLine("-{0}-", s)
    '        Next s
    '    Next x
    'End Sub 'Main
    Public Function LoadReportBancos(ByRef Viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer, ByVal objReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, Optional ByVal NoShow As Boolean = False, Optional ByVal con As String = "") As Boolean
        'Declaring variablesables
        'Parameter value object of crystal report RptViewer
        ' parameters used for adding the value to parameter.
        'Current parameter value object(collection) of crystal report parameters.
        'Sub report object of crystal report.
        'Sub report document of crystal report.
        Dim intCounter As Integer
        Dim intCounter1 As Integer 'Crystal Report's report document object
        'Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo 'object of table Log on info of Crystal report
        Dim paraValue As New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim currValue As CrystalDecisions.Shared.ParameterValues
        Dim mySubReportObject As CrystalDecisions.CrystalReports.Engine.SubreportObject
        Dim mySubRepDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strParValPair() As String
        Dim strVal() As String
        Dim index As Integer
        Dim SQLConexion As New Conexion
        If con.Equals("") Then
            SQLConexion.SQLStringConexion = Configuracion.Claves.Conexion("Contabilidad")
        Else
            SQLConexion.SQLStringConexion = con
        End If

        SQLConexion.Conectar()

        Try
            'objReport.Load(sReportName)         'Sub report document of crystal report.
            'intCounter = objReport.DataDefinition.ParameterFields.Count 'Check if there are parameters or not in report.
            'As parameter fields collection also picks the selection 
            ' formula which is not the parametermeter
            ' so if total parameter count is 1 then we check whether 
            ' its a parameter or selection formula.
            'If intCounter = 1 Then
            '    If InStr(objReport.DataDefinition.ParameterFields(0).ParameterFieldName, ".", CompareMethod.Text) > 0 Then
            '        intCounter = 0
            '    End If
            'End If

            'If there are parameters in report and 
            'user has passed them then split the 
            'parameter string and Apply the values 
            'to there concurent parameters.

            'If intCounter > 0 And Trim(Param) <> "" Then
            '    strParValPair = Param.Split("&")
            '    For index = 0 To UBound(strParValPair)
            '        If InStr(strParValPair(index), "=") > 0 Then
            '            strVal = strParValPair(index).Split("=")
            '            paraValue.Value = strVal(1)
            '            currValue = objReport.DataDefinition.ParameterFields(strVal(0)).CurrentValues
            '            currValue.Add(paraValue)
            '            objReport.DataDefinition.ParameterFields(strVal(0)).ApplyCurrentValues(currValue)
            '        End If
            '    Next
            'End If
            'Set the connection information to ConInfo object so that we can apply the 
            ' connection information on each table in the reporteport

            'ConInfo.ConnectionInfo.UserID = "SEESOFT"
            'ConInfo.ConnectionInfo.Password = "123"
            ConInfo.ConnectionInfo.IntegratedSecurity = True
            ConInfo.ConnectionInfo.ServerName = SQLConexion.sQlconexion.DataSource
            ConInfo.ConnectionInfo.DatabaseName = "Bancos"

            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
            Next
            ' Loop through each section on the report then look 
            ' through each object in the section
            ' if the object is a subreport, then apply logon info 
            ' on each table of that sub report
            For index = 0 To objReport.ReportDefinition.Sections.Count - 1
                For intCounter = 0 To _
                      objReport.ReportDefinition.Sections(index).ReportObjects.Count - 1
                    With objReport.ReportDefinition.Sections(index)
                        If .ReportObjects(intCounter).Kind =
                           CrystalDecisions.Shared.ReportObjectKind.SubreportObject Then
                            mySubReportObject = CType(.ReportObjects(intCounter),
                            CrystalDecisions.CrystalReports.Engine.SubreportObject)
                            mySubRepDoc =
                             mySubReportObject.OpenSubreport(mySubReportObject.SubreportName)
                            For intCounter1 = 0 To mySubRepDoc.Database.Tables.Count - 1
                                mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                                'mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                            Next
                        End If
                    End With
                Next
            Next
            'If sSelectionFormula.Length > 0 Then 'If there is a selection formula passed to this function then use that
            '    objReport.RecordSelectionFormula = sSelectionFormula
            'End If
            'Re setting control 
            'rptViewer.ReportSource = Nothing
            'Set the current report object to report.
            If NoShow = False Then Viewer.ReportSource = objReport
            'Show the report
            'RptViewer.Show()
            Return True
        Catch ex As System.Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Module
