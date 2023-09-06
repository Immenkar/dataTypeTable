using dataTypeTable.include;

var table = new Table();
table.SetHeaders("Type", "Range");
foreach (var tpDict in data.dict)
{
   table.AddRow(tpDict.Key, tpDict.Value);
}
Console.WriteLine(table.ToString());
Console.ReadKey();
