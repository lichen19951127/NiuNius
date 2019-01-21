﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NiuNiu.IDAL
{
    using Entity;
    /// <summary>
    /// ** 描述：用户DAL接口
    /// ** 创始时间：2019-01-21
    /// ** 修改时间：-
    /// ** 作者：lc
    /// </summary>
    public interface IUsersDAL:IBase<Users>
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        List<Users> Query();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="Name">用户名</param>
        /// <param name="Pwd">密码</param>
        /// <returns></returns>
        Users Login(string Name,string Pwd);
    }
}
