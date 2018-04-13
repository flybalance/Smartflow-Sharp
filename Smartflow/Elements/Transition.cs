﻿/*
 License: https://github.com/chengderen/Smartflow/blob/master/LICENSE 
 Home page: https://github.com/chengderen/Smartflow

 Note: to build on C# 3.0 + .NET 4.0
 Author:chengderen-237552006@qq.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using Dapper;
using Smartflow.Enums;

namespace Smartflow.Elements
{
    [XmlInclude(typeof(Node))]
    public class Transition : Element, IRelationShip
    {
        public string RNID
        {
            get;
            set;
        }

        public long FROM
        {
            get;
            set;
        }
     
        [XmlAttribute("to")]
        public long TO
        {
            get;
            set;
        }

        internal override void Persistent()
        {
            string sql = "INSERT INTO T_TRANSITION(NID,ID,RNID,NAME,[TO],[FROM],INSTANCEID) VALUES(@NID,@ID,@RNID,@NAME,@TO,@FROM,@INSTANCEID)";
            Connection.Execute(sql, new
            {
                NID=Guid.NewGuid().ToString(),
                ID = ID,
                RNID = RNID,
                NAME = NAME,
                TO = TO,
                FROM=FROM,
                INSTANCEID = INSTANCEID
            });
        }
    }
}
