using System;
using Aspose.Cells;

namespace BlazorApp1.Utils
{
    public class ExportarXlsx
    {
        public static byte[] Exportar<T>(List<T> Dados, string titulo) {
            Workbook WorkBook = new();
            Worksheet WorkSheet = WorkBook.Worksheets[0];

            WorkSheet.Cells.ImportCustomObjects(Dados, 0, 0, new ImportTableOptions());

            using(MemoryStream ms = new()) {
                WorkBook.Save(ms, SaveFormat.Xlsx);
                return ms.ToArray();
            }
        }
    }
}
