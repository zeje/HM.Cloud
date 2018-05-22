// File:    CatConfig.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class CatConfig
using System;
namespace HM.Cloud.EntityFrameworkCore
{
/// 猫配置信息表
public class CatConfig :EntityBase
{
   
   
   /// <summary>
   /// 
   /// </summary>
   public long ID { get ; set ; }
   
   
   /// <summary>
   /// 项目编号
   /// </summary>
   public string ProjectCode { get ; set ; }
   
   
   /// <summary>
   /// 猫编号
   /// </summary>
   public int CatCode { get ; set ; }
   
   
   /// <summary>
   /// 软件版本信息
   /// </summary>
   public string SoftVersion { get ; set ; }
   
   
   /// <summary>
   /// 操作系统信息
   /// </summary>
   public string OSInfo { get ; set ; }
   
   
   /// <summary>
   /// 硬件信息
   /// </summary>
   public string HardwareInfo { get ; set ; }
   
   
   /// <summary>
   /// 开机时间
   /// </summary>
   public string PowerOnTime { get ; set ; }
   
   
   /// <summary>
   /// 运行时间
   /// </summary>
   public string RunTimes { get ; set ; }
   
   
   /// <summary>
   /// 声音配置信息
   /// </summary>
   public string VoiceConfigInfo { get ; set ; }
   
   
   /// <summary>
   /// 广告机配置信息
   /// </summary>
   public string TVConfigInfo { get ; set ; }
   
   
   /// <summary>
   /// GPIO板配置信息
   /// </summary>
   public string GPIOConfigInfo { get ; set ; }
   
   
   /// <summary>
   /// 人脸配置信息
   /// </summary>
   public string FaceConfigInfo { get ; set ; }
   
   
   /// <summary>
   /// 主控程序配置信息
   /// </summary>
   public string ABDoor { get ; set ; }
   
   
   /// <summary>
   /// 是否无人值守
   /// </summary>
   public string Auto { get ; set ; }
   
   
   /// <summary>
   /// 备注
   /// </summary>
   public string Note { get ; set ; }
   
   
   /// <summary>
   /// 时间戳
   /// </summary>
   public DateTime Date { get ; set ; }
}
}