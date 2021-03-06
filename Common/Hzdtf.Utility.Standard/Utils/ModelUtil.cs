﻿using Hzdtf.Utility.Standard.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hzdtf.Utility.Standard.Utils
{
    /// <summary>
    /// 模型辅助类
    /// @ 黄振东
    /// </summary>
    public static class ModelUtil
    {
        /// <summary>
        /// 设置创建信息
        /// </summary>
        /// <param name="model">模型</param>
        /// <param name="currUser">当前用户</param>
        public static void SetCreateInfo(this PersonTimeInfo model, BasicUserInfo currUser = null)
        {
            var user = UserTool.GetCurrUser(currUser);
            if (user == null)
            {
                return;
            }

            model.CreaterId = model.ModifierId = user.Id;
            model.Creater = model.Modifier = user.Name;
            model.CreateTime = model.ModifyTime = DateTime.Now;
        }

        /// <summary>
        /// 设置修改信息
        /// </summary>
        /// <param name="model">模型</param>
        /// <param name="currUser">当前用户</param>
        public static void SetModifyInfo(this PersonTimeInfo model, BasicUserInfo currUser = null)
        {
            var user = UserTool.GetCurrUser(currUser);
            if (user == null)
            {
                return;    
            }

            model.ModifierId = user.Id;
            model.Modifier = user.Name;
            model.ModifyTime = DateTime.Now;
        }
    }
}
