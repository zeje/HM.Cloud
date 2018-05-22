// File:    CatTypeComputer.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class CatTypeComputer
using System;
namespace HM.Cloud.EntityFrameworkCore
{
/// 猫型号与主机关联表
public class CatTypeComputer :EntityBase
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
   /// 主机编号
   /// </summary>
   public string ComputerCode { get ; set ; }
   
   
   /// <summary>
   /// 主机名称
   /// </summary>
   public string Name { get ; set ; }
   
   
   /// <summary>
   /// IP
   /// </summary>
   public string Ip { get ; set ; }
   
   
   /// <summary>
   /// 端口
   /// </summary>
   public int Port { get ; set ; }
   
   
   /// <summary>
   /// 用户名
   /// </summary>
   public string UserName { get ; set ; }
   
   
   /// <summary>
   /// 密码
   /// </summary>
   public string Password { get ; set ; }
   
   
   /// <summary>
   /// 状态：1正常；0停用
   /// </summary>
   public byte Status { get ; set ; }
}
}