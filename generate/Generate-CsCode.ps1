$XsdToCodeExePath = "C:\Program Files (x86)\Xsd2Code\Xsd2Code.exe"

Get-ChildItem -Path .\schemas | ForEach-Object {
  $namespace = "Aldsoft.Acord.LA"
  $baseName = $_.BaseName
  $outputDirectoryBase = "..\src\" + $namespace + "."
  $outputDirectory = $outputDirectoryBase + $baseName.TrimStart("TXLife") + "\"
  $outputDirectoryExists = test-path $outputDirectory
  If(!($outputDirectoryExists))
  {
    New-Item -ItemType Directory -Force -Path $outputDirectory
  }
  $outputFile = "..\" + $outputDirectory + "TXLife.cs"
  $argumentList = @($_.FullName,$namespace,$outputFile,"/c List","clean","/lazy","/s","/xml","/ssp","/gbc","/gbcn EntityBase","/sc","/cl","/hp")
  & $XsdToCodeExePath $argumentList
  
  $outputFile = $outputFile.replace("..\..\","..\")
  
  # Fix bugs with generation
  # 1. array of possible types should be object[] and not a specific type.
  (Get-Content $outputFile) | ForEach-Object { $_ -replace "public ComboRelationship_Type\[\] Items", "public object[] Items"} | Set-Content $outputFile
  (Get-Content $outputFile) | ForEach-Object { $_ -replace "private ComboRelationship_Type\[\] _items;", "private object[] _items;"} | Set-Content $outputFile
}
