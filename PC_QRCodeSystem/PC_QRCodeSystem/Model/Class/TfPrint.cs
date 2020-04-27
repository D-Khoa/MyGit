namespace PC_QRCodeSystem.Model
{
    public class TfPrint
    {
        public static string printerName = "LUKHAN Label Printer";

        // バーコードプリント機能
        public static void printBarCode(string itemNo, string itemName, string supplier, string invoice,
                                        string date, string qty, string suppliercode)
        {
            //itemNo = "A32-164D-X";
            //itemName = "SHAFT";
            //supplier = "SHINDENSHA CO.,LTD.";
            //invoice = "NDCV160129";
            //date = "2017/12/31";
            //qty = "2500";
            //validity = string.Empty; //"2017/12/31";

            long rtn;
            int x, y;
            //string printerName = "SEWOO Label Printer";

            int xdots, model; // ydots;
            string TwoBAR_Command;
            string QRCode_data = itemNo + ";" + itemName + ";" + supplier + ";" + invoice + ";" + date + ";" + qty + ";" + suppliercode;

            /* 1. LK_OpenPrinter() */
            if (LKBPRINT.LK_OpenPrinter(printerName) != LKBPRINT.LK_SUCCESS)
                throw new System.Exception("Can't open printer!");

            /* 2. LK_SetupPrinter() */
            rtn = LKBPRINT.LK_SetupPrinter("102",   // 10~104 (Unit is mm)
                            "54",       // 5~350 (Unit is mm)
                            0,              // 0=Label with Gap, 1=Label with Black Mark, 2=Label with Continuous.
                            "3",            // if(MediaType==0) <GapHeight> else <BlackMarkHeight>. (Unit is mm)
                            "0",            // if(MediaType==0) <not used> else <distance from BlackMark to perforation>. (Unit is mm)
                            8,              // 0 ~ 15
                            6,              // 2 ~ 6 (Unit is Inch)
                            1               // 1 ~ 9999 copies
                            );

            if (rtn != LKBPRINT.LK_SUCCESS)
            {
                LKBPRINT.LK_ClosePrinter();
                throw new System.Exception("Can't setup printer");
                //return;
            }

            /* 3-1. page 1 test */
            LKBPRINT.LK_StartPage();

            // QR Code のプリントアウト
            // bx,y,Q,1,z,L,"DATA"
            // x = x position.
            // y = y position
            // z = Cell Size. (2 ~ 16)
            // L = ECC Level(L or M or Q or H)
            x = 80 * 8;
            y = 32 * 8;
            xdots = 4; //3
            model = 1;
            TwoBAR_Command = string.Format("b{0},{1},Q,{2},{3},L,\"{4}\"\r\n", x, y, model, xdots, QRCode_data);
            LKBPRINT.LK_DirectCommand(TwoBAR_Command);

            // 文字列のプリントアウト

            x = 5 * 8;
            y = (6 + 9 * 0 - 1) * 8;//5
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, itemName);

            string temp1 = string.Empty;
            string temp2 = string.Empty;
            if (itemNo.Length > 20)
            {
                temp1 = itemNo.Remove(20);
                temp2 = itemNo.Remove(0, 20);
            }
            else
            {
                temp1 = itemNo;
            }
            x = 5 * 8;
            y = (6 + 9 * 0 + 4) * 8;//10
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 5, 1, 1, 0, temp1);

            // 品目番号が２１～３０桁が存在する場合に印字
            if (string.IsNullOrEmpty(temp2))
            {
                x = 70 * 8;
                y = (6 + 9 * 0 - 1) * 8;
                LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, temp2);
            }

            x = 5 * 8;
            y = (6 + 9 * 1 + 5) * 8;//20
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, supplier);

            x = 5 * 8;
            y = (6 + 9 * 2 + 1) * 8;//25
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 5, 1, 1, 0, invoice);

            x = 5 * 8;
            y = (6 + 9 * 2 + 11) * 8;//35
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, "R: ");

            x = (5 + 5) * 8;
            y = (6 + 9 * 2 + 11) * 8;
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, date);

            //if (validity != string.Empty)
            //{
            //    x = (5 + 28) * 8;
            //    y = (6 + 9 * 2 + 11) * 8;
            //    LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, "V: ");

            //    x = (5 + 33) * 8;
            //    y = (6 + 9 * 2 + 11) * 8;
            //    LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, validity);
            //}

            x = 5 * 8;
            y = (6 + 9 * 4) * 8;//42
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 5, 1, 1, 0, qty);


            LKBPRINT.LK_EndPage();

            /* 4. LK_ClosePrinter() */
            LKBPRINT.LK_ClosePrinter();
        }

        public static void printBarCodeNCVH(string materialNo, string lotNo, string poNo, string poLine, string qty)
        {
            //itemNo = "A32-164D-X";
            //itemName = "SHAFT";
            //supplier = "SHINDENSHA CO.,LTD.";
            //invoice = "NDCV160129";
            //date = "2017/12/31";
            //qty = "2500";
            //validity = string.Empty; //"2017/12/31";

            long rtn;
            int x, y;

            int xdots, model; // ydots;
            string TwoBAR_Command;
            string QRCode_data = materialNo + "           " + lotNo + "                     " + qty + poNo + poLine;

            /* 1. LK_OpenPrinter() */
            if (LKBPRINT.LK_OpenPrinter(printerName) != LKBPRINT.LK_SUCCESS) { return; }

            /* 2. LK_SetupPrinter() */
            rtn = LKBPRINT.LK_SetupPrinter("102",   // 10~104 (Unit is mm)
                "54",       // 5~350 (Unit is mm)
                0,              // 0=Label with Gap, 1=Label with Black Mark, 2=Label with Continuous.
                "3",            // if(MediaType==0) <GapHeight> else <BlackMarkHeight>. (Unit is mm)
                "0",            // if(MediaType==0) <not used> else <distance from BlackMark to perforation>. (Unit is mm)
                8,              // 0 ~ 15
                6,              // 2 ~ 6 (Unit is Inch)
                1               // 1 ~ 9999 copies
                );

            if (rtn != LKBPRINT.LK_SUCCESS) { LKBPRINT.LK_ClosePrinter(); return; }

            /* 3-1. page 1 test */
            LKBPRINT.LK_StartPage();

            // QR Code のプリントアウト
            // bx,y,Q,1,z,L,"DATA"
            // x = x position.
            // y = y position
            // z = Cell Size. (2 ~ 16)
            // L = ECC Level(L or M or Q or H)
            x = 80 * 8;
            y = 32 * 8;
            xdots = 4; //3
            model = 1;
            TwoBAR_Command = string.Format("b{0},{1},Q,{2},{3},L,\"{4}\"\r\n", x, y, model, xdots, QRCode_data);
            LKBPRINT.LK_DirectCommand(TwoBAR_Command);

            // 文字列のプリントアウト

            x = 5 * 8;
            y = (6 + 9 * 0 - 1) * 8;
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, "ITEM: " + materialNo);

            x = 5 * 8;
            y = (6 + 9 * 0 + 4) * 8;
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, "LOT: " + lotNo);

            x = 5 * 8;
            y = (6 + 9 * 0 + 5) * 8; //(6 + 9 * 2) * 8;
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, "QTY: " + qty);

            x = 5 * 8;
            y = (6 + 9 * 1 + 5) * 8;
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, "PO: " + poNo + "          " + poLine);

            //x = 5 * 8;
            //y = (10 + 9 * 2 + 1) * 8;
            //LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, poLine);

            LKBPRINT.LK_EndPage();

            /* 4. LK_ClosePrinter() */
            LKBPRINT.LK_ClosePrinter();
        }

        public static void printBarCodeNew(string itemNo, string itemName, string supplier, string invoice,
                                string date, string qty, string supplierCode, string remark, bool isRec)
        {
            //itemNo = "A32-164D-X";
            //itemName = "SHAFT";
            //supplier = "SHINDENSHA CO.,LTD.";
            //invoice = "NDCV160129";
            //date = "2017/12/31";
            //qty = "2500";
            //validity = string.Empty; //"2017/12/31";

            long rtn;
            int x, y;
            int cell = 6;
            //string printerName = "SEWOO Label Printer";

            int xdots, model; // ydots;
            string TwoBAR_Command;
            string QRCode_data = itemNo + ";" + itemName + ";" + supplier + ";" + invoice + ";" + date + ";" + qty + ";" + supplierCode + ";" + remark;

            /* 1. LK_OpenPrinter() */
            if (LKBPRINT.LK_OpenPrinter(printerName) != LKBPRINT.LK_SUCCESS)
                throw new System.Exception("Can't open printer!");

            /* 2. LK_SetupPrinter() */
            rtn = LKBPRINT.LK_SetupPrinter("70",   // 10~104 (Unit is mm)
                            "30",       // 5~350 (Unit is mm)
                            0,              // 0=Label with Gap, 1=Label with Black Mark, 2=Label with Continuous.
                            "3",            // if(MediaType==0) <GapHeight> else <BlackMarkHeight>. (Unit is mm)
                            "0",            // if(MediaType==0) <not used> else <distance from BlackMark to perforation>. (Unit is mm)
                            8,              // 0 ~ 15
                            6,              // 2 ~ 6 (Unit is Inch)
                            1               // 1 ~ 9999 copies
                            );

            if (rtn != LKBPRINT.LK_SUCCESS)
            {
                LKBPRINT.LK_ClosePrinter();
                throw new System.Exception("Can't setup printer");
                //return;
            }

            /* 3-1. page 1 test */
            LKBPRINT.LK_StartPage();

            // QR Code のプリントアウト
            // bx,y,Q,1,z,L,"DATA"
            // x = x position.
            // y = y position
            // z = Cell Size. (2 ~ 16)
            // L = ECC Level(L or M or Q or H)
            x = 70 * cell; //80
            y = 17 * cell; //32
            xdots = 3; //3
            model = 1;
            TwoBAR_Command = string.Format("b{0},{1},Q,{2},{3},L,\"{4}\"\r\n", x, y, model, xdots, QRCode_data);
            LKBPRINT.LK_DirectCommand(TwoBAR_Command);

            // 文字列のプリントアウト

            //LINE 1 - S3
            x = 5 * cell;
            y = (6 + (cell + 1) * 0 - 2) * cell;//Y=4
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 3, 1, 1, 0, itemName);

            //LINE 2 - S4
            string temp1 = string.Empty;
            string temp2 = string.Empty;
            if (itemNo.Length > 20)
            {
                temp1 = itemNo.Remove(20);
                temp2 = itemNo.Remove(0, 20);
            }
            else
            {
                temp1 = itemNo;
            }
            x = 5 * cell;
            y = (6 + (cell + 1) * 0 + 2) * cell; //Y=8
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, temp1);

            // 品目番号が２１～３０桁が存在する場合に印字
            if (string.IsNullOrEmpty(temp2))
            {
                x = 70 * cell;
                y = (6 + (cell + 1) * 0 + 2) * cell;
                LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, temp2);
            }

            //LINE 3 - S2
            x = 5 * cell;
            y = (6 + (cell + 1) * 1) * cell;//Y=13
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 2, 1, 1, 0, supplier);

            //LINE 4 - S4
            x = 5 * cell;
            y = (6 + (cell + 1) * 1 + 4) * cell;//Y=17
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 4, 1, 1, 0, invoice);

            //LINE 5 - S2
            x = 5 * cell;
            y = (6 + (cell + 1) * 2 + 2) * cell;//Y=22
            if (isRec) LKBPRINT.LK_PrintDeviceFont(x, y, 0, 2, 1, 1, 0, "R: ");
            else LKBPRINT.LK_PrintDeviceFont(x, y, 0, 2, 1, 1, 0, "O: ");

            x = (5 + 5) * cell;
            y = (6 + (cell + 1) * 2 + 2) * cell;//Y=22
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 2, 1, 1, 0, date);

            //LINE 6 - S5
            x = 5 * cell;
            y = (6 + (cell + 1) * 3) * cell;//Y=27
            LKBPRINT.LK_PrintDeviceFont(x, y, 0, 5, 1, 1, 0, qty);


            LKBPRINT.LK_EndPage();

            /* 4. LK_ClosePrinter() */
            LKBPRINT.LK_ClosePrinter();
        }
    }
}
