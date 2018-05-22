// File:    CatCountPerHour.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class CatCountPerHour
using System;
namespace HM.Cloud.EntityFrameworkCore
{
/// 每小时人流量
public class CatCountPerHour :EntityBase
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
   /// 年
   /// </summary>
   public int Year { get ; set ; }
   
   
   /// <summary>
   /// 月
   /// </summary>
   public int Month { get ; set ; }
   
   
   /// <summary>
   /// 日
   /// </summary>
   public int Day { get ; set ; }
   
   
   /// <summary>
   /// 时
   /// </summary>
   public int Hour { get ; set ; }
   
   
   /// <summary>
   /// IC卡刷卡数
   /// </summary>
   public int ICCount { get ; set ; }
   
   
   /// <summary>
   /// ID卡刷卡数
   /// </summary>
   public int IDCardCount { get ; set ; }
   
   
   /// <summary>
   /// 人脸识别数
   /// </summary>
   public int FaceCount { get ; set ; }
   
   
   /// <summary>
   /// 对讲开门数
   /// </summary>
   public int InterComCount { get ; set ; }
   
   
   /// <summary>
   /// 手机识别数
   /// </summary>
   public int MoibleCount { get ; set ; }
   
   
   /// <summary>
   /// 每小时总数
   /// </summary>
   public int AllCountPerHour { get ; set ; }
   
   
   /// <summary>
   /// 每小时进入总数
   /// </summary>
   public int InCountPerHour { get ; set ; }
   
   
   /// <summary>
   /// 每小时外出总数
   /// </summary>
   public int OutCountPerHour { get ; set ; }
   
   
   /// <summary>
   /// 创建时间
   /// </summary>
   public DateTime CreateTime { get ; set ; }
   
   
   /// <summary>
   /// 修改时间
   /// </summary>
   public DateTime ModifyTime { get ; set ; }
}
}