﻿using System;
using System.ComponentModel.DataAnnotations;

namespace NiuNiu.Entity
{
    /// <summary>
    /// ** 描述：博客表
    /// ** 创始时间：2019-01-21
    /// ** 修改时间：-
    /// ** 作者：lc
    /// </summary>
    public partial class Blogs
    {
        public Blogs() {

        }
           /// <summary>
           /// Desc:博客ID
           /// Default:
           /// Nullable:False
           /// </summary>   
           [Key]
           public int Id {get;set;}

           /// <summary>
           /// Desc:博客标题
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Title {get;set;}

           /// <summary>
           /// Desc:文字概要
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Outline {get;set;}

           /// <summary>
           /// Desc:博客内容
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Content {get;set;}

           /// <summary>
           /// Desc:类型ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TypeId {get;set;}

           /// <summary>
           /// Desc:是否精华
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int IsEssence {get;set;}

           /// <summary>
           /// Desc:是否置顶
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int IsStick {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int State {get;set;}

           /// <summary>
           /// Desc:标签(以英文,分隔)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Labels {get;set;}

           /// <summary>
           /// Desc:浏览量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Pageview {get;set;}

           /// <summary>
           /// Desc:点赞量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int PointPraise {get;set;}

           /// <summary>
           /// Desc:评论数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int CommentNum {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateDate {get;set;}

           /// <summary>
           /// Desc:最后修改时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime UpdateDate {get;set;}

           /// <summary>
           /// Desc:创建人ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int UserId {get;set;}

    }
}
