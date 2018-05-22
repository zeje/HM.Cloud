// File:    CatICCardEntranceDetail.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class CatICCardEntranceDetail
using System;
namespace HM.Cloud.EntityFrameworkCore
{
/// IC卡进出详情
public class CatICCardEntranceDetail :EntityBase
{
   
   
   /// <summary>
   /// 
   /// </summary>
   public long ID { get ; set ; }
   
   
   /// <summary>
   /// 编目编码
   /// </summary>
   public string ProjectCode { get ; set ; }
   
   
   /// <summary>
   /// 猫编号
   /// </summary>
   public int CatCode { get ; set ; }
   
   
   /// <summary>
   /// 卡号
   /// </summary>
   public string CardNo { get ; set ; }
   
   
   /// <summary>
   /// 房号
   /// </summary>
   public string RoomNo { get ; set ; }
   
   
   /// <summary>
   /// 人员名称
   /// </summary>
   public string PersonName { get ; set ; }
   
   
   /// <summary>
   /// 创建时间
   /// </summary>
   public DateTime CreateTime { get ; set ; }
   
   
   /// <summary>
   /// 刷卡时间
   /// </summary>
   public DateTime IdCreatetime { get ; set ; }
}
}