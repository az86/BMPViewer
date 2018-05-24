namespace BMPViewer
{
    public class BmpInfo
    {
        #region tagBITMAPFILEHEADER

        /// <summary>  
        /// 位图文件的类型，必须为BM(1-2字节）  
        /// </summary>  
        public string bfType { get; set; }

        /// <summary>  
        /// 位图文件的大小，以字节为单位（3-6字节，低位在前）
        /// </summary>  
        public int bfSize { get; set; }

        /// <summary>  
        /// 位图文件保留字，必须为0(7-8字节）
        /// </summary>  
        public short bfReserved0 { get; set; }

        /// <summary>  
        /// 位图文件保留字，必须为0(9-10字节）
        /// </summary>
        public short bfReserved1 { get; set; }

        /// <summary>  
        /// 位图数据的起始位置，以相对于位图（11-14字节，低位在前）
        /// </summary>  
        public int bfOffBits { get; set; }

        #endregion

        #region tagBITMAPINFOHEADER
        /// <summary>  
        /// 本结构所占用字节数（15-18字节）
        /// </summary>  
        public int biSize { get; set; }

        /// <summary>  
        /// 位图的宽度，以像素为单位（19-22字节）
        /// </summary>  
        public int biWidth { get; set; }

        /// <summary>  
        /// 位图的高度，以像素为单位（23-26字节） 
        /// </summary>  
        public int biHeight { get; set; }

        /// <summary>  
        /// 目标设备的级别，必须为1(27-28字节）  
        /// </summary>  
        public int biPlanes { get; set; }

        /// <summary>  
        /// 每个像素所需的位数 （29-30字节）
        /// 1 - 双色位图
        /// 4 - 16 色位图   
        /// 8 - 256 色位图   
        /// 16 - 16bit 高彩色位图   
        /// 24 - 24bit 真彩色位图   
        /// 32 - 32bit 增强型真彩色位图  
        /// </summary>  
        public int biBitCount { get; set; }

        /// <summary>  
        /// 位图压缩类型，必须是0（不压缩），（31-34字节） 
        /// 0 - 不压缩 (使用BI_RGB表示)   
        /// 1 - RLE 8-使用8位RLE压缩方式(用BI_RLE8表示)   
        /// 2 - RLE 4-使用4位RLE压缩方式(用BI_RLE4表示)   
        /// 3 - Bitfields-位域存放方式(用BI_BITFIELDS表示)  
        /// </summary>  
        public int biCompression { get; set; }

        /// <summary>  
        /// 位图的大小(其中包含了为了补齐行数是4的倍数而添加的空字节)，以字节为单位（35-38字节）
        /// </summary>  
        public int biSizeImage { get; set; }

        /// <summary>  
        /// 位图水平分辨率，每米像素数（39-42字节） 
        /// </summary>  
        public int biXPelsPerMeter { get; set; }

        /// <summary>  
        /// 位图垂直分辨率，每米像素数（43-46字节)
        /// </summary>  
        public int biYPelsPerMeter { get; set; }

        /// <summary>  
        /// 位图实际使用的颜色表中的颜色数（47-50字节）  
        /// </summary>  
        public int biClrUsed { get; set; }

        /// <summary>  
        /// 位图显示过程中重要的颜色数（51-54字节）
        /// </summary>  
        public int biClrImportant { get; set; }
        #endregion
    }
}
