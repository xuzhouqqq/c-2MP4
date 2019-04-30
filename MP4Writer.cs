using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WinCamera.juyi
{
    class MP4Writer
    {
        /// <summary>
        /// 初始化
        /// </summary>
        [DllImport("gpac.dll", EntryPoint = "MP4WriterInit", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MP4WriterInit();
        /// <summary>
        /// 创建MP4文件
        /// <param name="hMP4File">文件句柄</param>
        /// <param name="fileName">文件生成路径</param>
        /// <param name="videoType">0 h264 1 h265</param>
        /// <param name="nWidth">nWidth</param>
        /// <param name="nHeight">nHeight</param>
        /// <param name="nFps">最大FPS</param>
        /// </summary>
        [DllImport("gpac.dll", EntryPoint = "MP4WriterCreateFile", CallingConvention = CallingConvention.Cdecl)]
        public static extern int MP4WriterCreateFile(IntPtr hMP4File, string fileName, int videoType, int nWidth, int nHeight, int nFps);
        /// <summary>
        /// 保存MP4
        /// <param name="hMP4File">文件句柄</param>
        /// </summary>
        [DllImport("gpac.dll", EntryPoint = "MP4WriterSaveFile", CallingConvention = CallingConvention.Cdecl)]
        public static extern int MP4WriterSaveFile(IntPtr hMP4File);
        /// <summary>
        /// 写入视频流
        /// <param name="hMP4File">文件句柄</param>
        /// <param name="pData">H264 或H265 码流</param>
        /// <param name="nSize">码流大小</param>
        /// <param name="bKey">是否关键帧</param>
        /// <param name="nTimeStamp">同步时间戳</param>
        /// </summary>
        [DllImport("gpac.dll", EntryPoint = "MP4WriterWriteVideo2File", CallingConvention = CallingConvention.Cdecl)]
        public static extern int MP4WriterWriteVideo2File(IntPtr hMP4File, byte[] pData, int nSize, bool bKey, UInt64 nTimeStamp);
        /// <summary>
        /// 写入音频流
        /// <param name="hMP4File">文件句柄</param>
        /// <param name="pData">AAC音频流</param>
        /// <param name="nSize">码流大小</param>
        /// <param name="nTimeStamp">同步时间戳</param>
        /// <param name="nSampleRate">采样率</param>
        /// <param name="nChannel">通道</param>
        /// <param name="nBitsPerSample">比特率</param>
        /// </summary>
        [DllImport("gpac.dll", EntryPoint = "MP4WriterWriteAudio2File", CallingConvention = CallingConvention.Cdecl)]
        public static extern int MP4WriterWriteAudio2File(IntPtr hMP4File, byte[] pData, int nSize, UInt64 nTimeStamp, int nSampleRate, int nChannel, int nBitsPerSample);

    }
}
