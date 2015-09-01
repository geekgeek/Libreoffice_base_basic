REM  *****  BASIC  *****

Sub openform1
const sNewDocumentName="kontoer"
oNewFormDocument=ThisDatabaseDocument.FormDocuments.getbyname(sNewDocumentName).open

End Sub

Sub openform2
const sNewDocumentName="Bilagsføring"
oNewFormDocument=ThisDatabaseDocument.FormDocuments.getbyname(sNewDocumentName).open

End Sub

Sub openreport
const sNewDocumentName="kontoplan"
oNewReportDocument=ThisDatabaseDocument.ReportDocuments.getbyname(sNewDocumentName).open

End Sub

Sub openreport2
const sNewDocumentName="Bilagsliste"
oNewReportDocument=ThisDatabaseDocument.ReportDocuments.getbyname(sNewDocumentName).open

End Sub
