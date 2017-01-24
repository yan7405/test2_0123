<Query Kind="Statements" />

 
 
 
 string result = "000";
 string SnFilePath = @"e:\ParkPay\parkpaycode\branch\";
 string FileName = "Asi.txt";
 string Sn = result;
 
File.WriteAllText(SnFilePath + FileName , "N0699999ParkPay停車交易贈點取消§170112100373", Encoding.Default);
 
 string allContent = File.ReadAllText(SnFilePath + FileName, Encoding.GetEncoding(950));
 
 allContent.Dump();
 
 allContent = File.ReadAllText(SnFilePath + FileName);
 allContent.Dump();
 
                 System.IO.StreamReader file = new System.IO.StreamReader(SnFilePath + FileName, Encoding.Default);
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    line.Dump();
					
					
					byte[] lineStr = Encoding.Default.GetBytes(line);
                           var val = Encoding.Default.GetString(lineStr);
						   
						val.Dump();   
                }