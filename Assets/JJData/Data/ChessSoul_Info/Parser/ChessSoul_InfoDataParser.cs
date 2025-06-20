using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;




public static class ChessSoul_InfoDataParser
{
    readonly private static string _dataFilePath = "JJData/";
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void SetXlsxData()
    {
        ConvertRowData2ChessSoul();
    }
    public static void ConvertRowData2ChessSoul()
    {
        int stringLength = 0;
        TextAsset binAsset = Resources.Load<TextAsset>(Path.Combine(_dataFilePath, "ChessSoul_Info/ChessSoul"));
        Span<byte> buffer = binAsset.bytes;
        int offset = 0;
        long rows = TypeByte2TypeConverter.ConvertTypeByte2long(buffer.Slice(offset, 8));
        offset += 8;
        ChessSoul_Info.ChessSoul = new ChessSoul_Info_ChessSoul[rows];
        for(int row = 0; row < rows; row++)
        {
            ChessSoul_Info_ChessSoul sheetRowData = new();
            sheetRowData.TimeA = TypeByte2TypeConverter.ConvertTypeByte2float(buffer.Slice(offset, 4));
            offset += 4;
            sheetRowData.Testing = TypeByte2TypeConverter.ConvertTypeByte2Vector3(buffer.Slice(offset, 12));
            offset += 12;
            ChessSoul_Info.ChessSoul[row] = sheetRowData;
        }
        Resources.UnloadAsset(binAsset);
    }

}
