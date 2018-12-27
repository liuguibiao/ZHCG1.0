﻿/*
* Slickflow 工作流引擎遵循LGPL协议，也可联系作者商业授权并获取技术支持；
* 除此之外的使用则视为不正当使用，请您务必避免由此带来的商业版权纠纷。

The Slickflow Designer project.
Copyright (C) 2014  .NET Workflow Engine Library

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, you can access the official
web page about lgpl: https://www.gnu.org/licenses/lgpl.html
*/

var transitionproperty = (function () {
    function transitionproperty() {
    }

    transitionproperty.load = function () {
        var line = kgraph.mcurrentSelectedDomElement.line;

        if (line) {
            $("#txtDescription").val(line.sdata.description);
            if (line.sdata.receiver) {
                if (line.sdata.receiver.type)
                    $("#ddlReceiverType").val(line.sdata.receiver.type);
            }

            if (line.sdata.condition)
                $("#txtCondition").val($.trim(line.sdata.condition.text));
        }
    }

    transitionproperty.save = function () {
        var description = $("#txtDescription").val();
        var receiver = {};
        var receiverType = $("#ddlReceiverType").val();
        if (receiverType !== "default") receiver.type = receiverType;

        var condition = {};
        condition.type = "Expression";
        condition.text = $.trim($("#txtCondition").val());

        var line = kgraph.mcurrentSelectedDomElement.line;

        line.sdata.description = description;
        line.sdata.receiver = receiver;
        line.sdata.condition = condition;

		//update line label text
        jsptoolkit.setConnectionText(line.connection, line.sdata.description);
    }

    return transitionproperty;
})()