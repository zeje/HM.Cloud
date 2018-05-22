// File:    CatTypeAlarmNode.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class CatTypeAlarmNode
using System;
namespace HM.Cloud.EntityFrameworkCore
{
/// 猫型号与报警节点关联表
public class CatTypeAlarmNode :EntityBase
{
   
   
   /// <summary>
   /// ID
   /// </summary>
   public string Id { get ; set ; }
   
   
   /// <summary>
   /// 猫型号的编号
   /// </summary>
   public string CatTypeCode { get ; set ; }
   
   
   /// <summary>
   /// 报警节点编号
   /// </summary>
   public string AlarmNodeCode { get ; set ; }
   
   
   /// <summary>
   /// 节点名称
   /// </summary>
   public string Name { get ; set ; }
   
   
   /// <summary>
   /// 报警类型
   /// </summary>
   public string AlarmType { get ; set ; }
   
   
   /// <summary>
   /// 信号规则配置（json）
   /// </summary>
   public string Rule { get ; set ; }
   
   
   /// <summary>
   /// 节点呈现位置信息（多属性）
   /// </summary>
   public string Position { get ; set ; }
}
}