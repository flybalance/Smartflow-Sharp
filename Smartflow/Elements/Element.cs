﻿/*
 License: https://github.com/chengderen/Smartflow/blob/master/LICENSE 
 Home page: https://github.com/chengderen/Smartflow

 Note: to build on C# 3.0 + .NET 4.0
 Author:chengderen-237552006@qq.com
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using Smartflow.Enums;
namespace Smartflow.Elements
{
    public abstract class Element
    {
        [XmlAttribute("id")]
        public virtual long ID
        {
            get;
            set;
        }

        /// <summary>
        /// 节点唯一标识
        /// </summary>
        [XmlIgnore]
        public string NID
        {
            get;
            set;
        }

        [XmlAttribute("name")]
        public virtual string NAME
        {
            get;
            set;
        }


        [XmlIgnore]
        public virtual string INSTANCEID
        {
            get;
            set;
        }

        internal abstract void Persistent();

        protected IDbConnection Connection
        {
            get { return DapperFactory.CreateWorkflowConnection(); }
        }

    }
}
