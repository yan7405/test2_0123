<Query Kind="Statements" />

//B223
//A123
string target = "停車交易取消-累點返回§170115100109";
Encoding encoding = Encoding.GetEncoding(950);  //Big5
/*
    Encoding  u7    = Encoding.UTF7;
    Encoding  u8    = Encoding.UTF8;
    Encoding  u16LE = Encoding.Unicode;
    Encoding  u16BE = Encoding.BigEndianUnicode;
    Encoding  u32   = Encoding.UTF32;
*/
encoding = Encoding.UTF8;
byte[] lineStr = encoding.GetBytes(target);

//lineStr.Dump();

int iBC  = encoding.GetByteCount( target );
iBC.Dump();

//int currentPos = 7;
//int len = 2;
//string val = encoding.GetString(lineStr, currentPos, len);
//val.Dump();
//
//int 指定長度 = 20;
//string result = target;
////result = target.PadRight(指定長度, ' ');
//char? padChar = ' ';
//
//int 補上長度 = 0;
//補上長度 = 指定長度 - iBC;
//            for (int i = 0; i < 補上長度; i++)
//            {
//				result = result + padChar.Value;
//			}
//
//String.Format("|{0}|", result).Dump();
//
//iBC  = encoding.GetByteCount( result );
//iBC.Dump();
//
