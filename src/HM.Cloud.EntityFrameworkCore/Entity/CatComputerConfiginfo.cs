// File:    CatComputerConfiginfo.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class CatComputerConfiginfo
using System;
namespace HM.Cloud.EntityFrameworkCore
{
/// 猫的主机与标准配置关联表
public class CatComputerConfiginfo :EntityBase
{
   
   
   /// <summary>
   /// ID
   /// </summary>
   public string Id { get ; set ; }
   
   
   /// <summary>
   /// 猫编号
   /// </summary>
   public int CatCode { get ; set ; }
   
   
   /// <summary>
   /// 主机编号
   /// </summary>
   public string ComputerCode { get ; set ; }
   
   
   /// <summary>
   /// 标准配置编号
   /// </summary>
   public string ConfigCode { get ; set ; }
   
   
   /// <summary>
   /// 标准配置名称
   /// </summary>
   public string Name { get ; set ; }
   
   
   /// <summary>
   /// 模板内容（xml）
   /// </summary>
   public string Template { get ; set ; }
}
}