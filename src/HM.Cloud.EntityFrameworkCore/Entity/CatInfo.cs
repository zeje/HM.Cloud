// File:    CatInfo.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class CatInfo
using System;
namespace HM.Cloud.EntityFrameworkCore
{
public class CatInfo :EntityBase
{
   
   
   /// <summary>
   /// ID
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
   /// 安装位置
   /// </summary>
   public string Position { get ; set ; }
   
   
   /// <summary>
   /// 经度
   /// </summary>
   public string Longitude { get ; set ; }
   
   
   /// <summary>
   /// 纬度
   /// </summary>
   public string Latitude { get ; set ; }
   
   
   /// <summary>
   /// 
   /// </summary>
   public int AllCount { get ; set ; }
   
   
   /// <summary>
   /// 
   /// </summary>
   public int InCount { get ; set ; }
   
   
   /// <summary>
   /// 
   /// </summary>
   public int OutCount { get ; set ; }
   
   
   /// <summary>
   /// 
   /// </summary>
   public DateTime LastUpdateTime { get ; set ; }
   
   
   /// <summary>
   /// 
   /// </summary>
   public string ConnectState { get ; set ; }
   
   
   /// <summary>
   /// 
   /// </summary>
   public string State { get ; set ; }
   
   
   /// <summary>
   /// 
   /// </summary>
   public string Use { get ; set ; }
   
   
   /// <summary>
   /// 
   /// </summary>
   public string AutoHand { get ; set ; }
   
   
   /// <summary>
   /// 
   /// </summary>
   public string Mode { get ; set ; }
   
   
   /// <summary>
   /// 
   /// </summary>
   public DateTime LastupdatetimePass { get ; set ; }
   
   
   /// <summary>
   /// 
   /// </summary>
   public string Ip { get ; set ; }
   
   
   /// <summary>
   /// 项目责任人
   /// </summary>
   public string ProjectManager { get ; set ; }
   
   
   /// <summary>
   /// 猫型号的编号
   /// </summary>
   public string CatTypeCode { get ; set ; }
}
}