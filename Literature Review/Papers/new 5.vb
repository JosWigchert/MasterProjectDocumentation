Sub CreateTimeline()
    ' Specify the sheet and cell in which the condition exists
    Dim inputSheet As Worksheet
    Set inputSheet = ThisWorkbook.Sheets("Inputs")
    
    Dim total As Range
    Set total = inputSheet.Range("F1")
    
    ' Specify the sheet and cell to be colored
    Dim targetSheet As Worksheet
    Set targetSheet = ThisWorkbook.Sheets("Timeline")
  
    Dim valueColumn As Long
    valueColumn = 3
    
    Dim currentRow As Long
    currentRow = 2 ' Starting from the first row, you can adjust this based on your actual data

    Dim startCol As Long
    startCol = 1
    
    Dim endCol As Long
    endCol = 1
    
    Dim colors As Variant
    colors = Array( _
        RGB(255, 182, 182), _
        RGB(182, 255, 182), _
        RGB(182, 182, 255), _
        RGB(255, 255, 182), _
        RGB(255, 182, 255), _
        RGB(182, 255, 255), _
        RGB(182, 91, 91), _
        RGB(91, 182, 91), _
        RGB(91, 91, 182), _
        RGB(182, 182, 91) _
    )
    Dim colorIndex As Long
    colorIndex = 1

    ' Get the last column in the row with data
    Dim lastColumn As Long
    lastColumn = 1000
    
    Dim targetRow As Long
    targetRow = 1
    ' Clear the fill color for each cell in the row
    targetSheet.Rows(targetRow).Interior.colorIndex = xlNone
    targetSheet.Rows(targetRow).Value = ""
    targetSheet.Rows(targetRow + 1).Interior.colorIndex = xlNone
    targetSheet.Rows(targetRow + 1).Value = ""


    Do While inputSheet.Cells(currentRow, valueColumn).Value <> ""
        endCol = inputSheet.Cells(currentRow, valueColumn).Value + startCol
        For i = startCol To endCol
            ' Change the fill color to your desired color
            targetSheet.Cells(targetRow, i).Interior.Color = colors(currentRow) ' Red color
            targetSheet.Cells(targetRow, i).Value = inputSheet.Cells(currentRow, valueColumn - 2).Value
            targetSheet.Cells(targetRow + 1, i).Interior.Color = colors(currentRow) ' Red color
            
			' Round the value to the nearest whole number
            Dim roundedValue As Double
            roundedValue = Application.WorksheetFunction.Round((total.Value * inputSheet.Cells(currentRow, valueColumn - 1).Value) / (endCol - startCol), 0)
    
            ' Ensure that the rounded value is rounded upwards
            If roundedValue < (total.Value * inputSheet.Cells(currentRow, valueColumn - 1).Value) / (endCol - startCol) Then
                roundedValue = Application.WorksheetFunction.Ceiling(roundedValue, 2)
            End If
    
            targetSheet.Cells(targetRow + 1, i).Value = roundedValue
        Next i
        startCol = endCol
        
        currentRow = currentRow + 1
    Loop
    
    targetSheet.Activate
End Sub