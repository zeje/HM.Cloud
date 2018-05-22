// File:    CatContacts.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class CatContacts
using System;
namespace HM.Cloud.EntityFrameworkCore
{
/// 猫与联系人关联表
public class CatContacts :EntityBase
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
   /// 联系人ID
   /// </summary>
   public string ContactsId { get ; set ; }
   
   
   /// <summary>
   /// 姓名
   /// </summary>
   public string Name { get ; set ; }
   
   
   /// <summary>
   /// 联系人类型
   /// </summary>
   public string DutyType { get ; set ; }
   
   
   /// <summary>
   /// 手机号码
   /// </summary>
   public string Phone { get ; set ; }
   
   
   /// <summary>
   /// 邮箱地址
   /// </summary>
   public string Email { get ; set ; }
}
}