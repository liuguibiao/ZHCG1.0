(function ($) {
    var myflow = $.myflow;

    $.extend(true, myflow.config.rect, {
        attr: {
            r: 8,
            fill: '#F6F7FF',
            stroke: '#03689A',
            "stroke-width": 2
        }
    });

    $.extend(true, myflow.config.props.props, {
        name: { name: 'name', label: '名 称', value: '新建流程', editor: function () { return new myflow.editors.inputEditor(); } },
        identifier: { name: 'identifier', label: '标 识', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
        remark: { name: 'remark', label: '备 注', value: '', editor: function () { return new myflow.editors.inputEditor(); } }
    });


    $.extend(true, myflow.config.tools.states, {
        start: {
            showType: 'image',
            type: 'start',
            name: { text: '<<start>>' },
            text: { text: '开 始' },
            img: { src: 'img/48/start_event_empty.png', width: 48, height: 48 },
            attr: { width: 50, heigth: 50 },
            props: {
                text: { name: 'text', label: '名 称', value: '', editor: function () { return new myflow.editors.textEditor(); } },
                identifier: { name: 'identifier', label: '标 识', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                remark: { name: 'remark', label: '备 注', value: '', editor: function () { return new myflow.editors.selectEditor([{ name: 'qqq', value: 1 }, { name: 'www', value: 2 }]); } }
            }
        },
        end: {
            showType: 'image', type: 'end',
            name: { text: '<<end>>' },
            text: { text: '结 束' },
            img: { src: 'img/48/end_event_terminate.png', width: 48, height: 48 },
            attr: { width: 50, heigth: 50 },
            props: {
                text: { name: 'text', label: '名 称', value: '', editor: function () { return new myflow.editors.textEditor(); }, value: '结束' },
                identifier: { name: 'identifier', label: '标 识', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                minute: { name: 'minute', label: '时限(分钟)', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                remark: { name: 'remark', label: '备 注', value: '', editor: function () { return new myflow.editors.selectEditor([{ name: 'aaa', value: 1 }, { name: 'bbb', value: 2 }]); } }
            }
        },
        'end-cancel': {
            showType: 'image', type: 'end-cancel',
            name: { text: '<<end-cancel>>' },
            text: { text: '取 消' },
            img: { src: 'img/48/end_event_cancel.png', width: 48, height: 48 },
            attr: { width: 50, heigth: 50 },
            props: {
                text: { name: 'text', label: '名 称', value: '', editor: function () { return new myflow.editors.textEditor(); }, value: '取消' },
                identifier: { name: 'identifier', label: '标 识', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                minute: { name: 'minute', label: '时限(分钟)', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                remark: { name: 'remark', label: '备 注', value: '', editor: function () { return new myflow.editors.selectEditor([{ name: 'aaa', value: 1 }, { name: 'bbb', value: 2 }]); } }
            }
        },
        'end-error': {
            showType: 'image', type: 'end-error',
            name: { text: '<<end-error>>' },
            text: { text: '错 误' },
            img: { src: 'img/48/end_event_error.png', width: 48, height: 48 },
            attr: { width: 50, heigth: 50 },
            props: {
                text: { name: 'text', label: '名 称', value: '', editor: function () { return new myflow.editors.textEditor(); }, value: '错误' },
                identifier: { name: 'identifier', label: '标 识', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                minute: { name: 'minute', label: '时限(分钟)', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                remark: { name: 'remark', label: '备 注', value: '', editor: function () { return new myflow.editors.selectEditor([{ name: 'aaa', value: 1 }, { name: 'bbb', value: 2 }]); } }
            }
        },
        state: {
            showType: 'text', type: 'state',
            name: { text: '<<state>>' },
            text: { text: '状态' },
            img: { src: 'img/48/task_empty.png', width: 48, height: 48 },
            props: {
                text: { name: 'text', label: '名 称', value: '', editor: function () { return new myflow.editors.textEditor(); }, value: '状态' },
                identifier: { name: 'identifier', label: '标 识', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                minute: { name: 'minute', label: '时限(分钟)', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                remark: { name: 'remark', label: '备 注', value: '', editor: function () { return new myflow.editors.selectEditor([{ name: 'aaa', value: 1 }, { name: 'bbb', value: 2 }]); } }
            }
        },
        fork: {
            showType: 'image', type: 'fork',
            name: { text: '<<fork>>' },
            text: { text: '分支' },
            img: { src: 'img/48/gateway_parallel.png', width: 48, height: 48 },
            attr: { width: 50, heigth: 50 },
            props: {
                text: { name: 'text', label: '名 称', value: '', editor: function () { return new myflow.editors.textEditor(); }, value: '分支' },
                identifier: { name: 'identifier', label: '标 识', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                minute: { name: 'minute', label: '时限(分钟)', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                remark: { name: 'remark', label: '备 注', value: '', editor: function () { return new myflow.editors.selectEditor('select.json'); } }
            }
        },
        join: {
            showType: 'image', type: 'join',
            name: { text: '<<join>>' },
            text: { text: '合并' },
            img: { src: 'img/48/gateway_parallel.png', width: 48, height: 48 },
            attr: { width: 50, heigth: 50 },
            props: {
                text: { name: 'text', label: '名 称', value: '', editor: function () { return new myflow.editors.textEditor(); }, value: '合并' },
                identifier: { name: 'identifier', label: '标 识', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                minute: { name: 'minute', label: '时限(分钟)', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                remark: { name: 'remark', label: '备 注', value: '', editor: function () { return new myflow.editors.selectEditor('select.json'); } }
            }
        },
        task: {
            showType: 'text', type: 'task',
            name: { text: '<<task>>' },
            text: { text: '任 务' },
            img: { src: 'img/48/task_empty.png', width: 48, height: 48 },
            props: {
                text: { name: 'text', label: '名 称', value: '', editor: function () { return new myflow.editors.textEditor(); }, value: '任务' },
                identifier: { name: 'identifier', label: '标 识', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                minute: { name: 'minute', label: '时限(分钟)', value: '', editor: function () { return new myflow.editors.inputEditor(); } },
                remark: { name: 'remark', label: '备 注', value: '', editor: function () { return new myflow.editors.inputEditor(); } }
            }
        }
    });
})(jQuery);