$(function(){
	//页面加载完成之后执行
	pageInit();
});
function pageInit(){
	//创建jqGrid组件
	jQuery("#list2").jqGrid(
			{
				url : 'data/JSONData.json',//组件创建完成之后请求数据的url
				datatype : "json",//请求数据返回的类型。可选json,xml,txt
				colNames : [ 'Inv No', 'Date', 'Client', 'Amount', 'Tax','Total', 'Notes' ],//jqGrid的列显示名字
				colModel : [ //jqGrid每一列的配置信息。包括名字，索引，宽度,对齐方式.....
				             {name : 'id',index : 'id',width : 55}, 
				             {name : 'invdate',index : 'invdate',width : 90}, 
				             {name : 'name',index : 'name asc, invdate',width : 100}, 
				             {name : 'amount',index : 'amount',width : 80,align : "right"}, 
				             {name : 'tax',index : 'tax',width : 80,align : "right"}, 
				             {name : 'total',index : 'total',width : 80,align : "right"}, 
				             {name : 'note',index : 'note',width : 150,sortable : false} 
				           ],
				rowNum : 10,//一页显示多少条
				rowList : [ 10, 20, 30 ],//可供用户选择一页显示多少条
				pager : '#pager2',//表格页脚的占位符(一般是div)的id
				sortname : 'id',//初始化的时候排序的字段
				sortorder : "desc",//排序方式,可选desc,asc
				mtype: "get",//向后台请求数据的ajax的类型。可选post,get
				viewrecords : true,
				caption : "JSON Example"//表格的标题名字
			});
	/*创建jqGrid的操作按钮容器*/
	/*可以控制界面上增删改查的按钮是否显示*/
	jQuery("#list2").jqGrid('navGrid', '#pager2', { edit: false, add: false, del: false })
.navGrid('#pager2', { refresh: true }  )
        .jqGrid('setGroupHeaders', {
            useColSpanStyle: false,
            groupHeaders: [
                { startColumnName: 'amount', numberOfColumns: 2, titleText: '<em>Actions</em>' }
            ]
        })
      
 //.jqGrid('setGroupHeaders', {
 //    useColSpanStyle: false,
 //    groupHeaders: [
 //        { startColumnName: 'amount', numberOfColumns: 2, titleText: '<em>Actions</em>' }
 //    ]
 //})



	//$("#grid").jqGrid({
	//    defaults: {
	//        loadtext: "Loading Data please wait ...",
	//    },
	//    url: "/User/GetUsers",
	//    datatype: 'json',
	//    mtype: 'GET',
	//    colNames: ["Edit", "Delete", 'Id', 'FirstName', 'LastName'],
	//    colModel: [
    //        { name: 'Edit', search: false, width: 30, sortable: false, formatter: editLink },
    //        { name: 'Delete', search: false, width: 45, sortable: false, formatter: deleteLink },
    //        { key: false, name: 'UserId', index: 'UserId', sorttype: "int" },
    //        { key: false, name: 'FirstName', index: 'FirstName' },
    //        { key: false, name: 'LastName', index: 'LastName' }],

	//    pager: jQuery('#pager'),
	//    rowNum: 5,
	//    rowList: [5, 10, 15, 20, 25],
	//    height: '100%',
	//    sortname: 'UserId',
	//    sortorder: 'asc',
	//    viewrecords: true,
	//    jsonReader: {
	//        root: "rows",
	//        page: "page",
	//        total: "total",
	//        records: "records",
	//        repeatitems: false,
	//        Id: "0"
	//    },
	//    autowidth: true,
	//    multiselect: false
	//}).navGrid('#pager', { refresh: true }
    //    .jqGrid('setGroupHeaders', {
    //        useColSpanStyle: false,
    //        groupHeaders: [
    //            { startColumnName: 'Edit', numberOfColumns: 2, titleText: '<em>Actions</em>' }
    //        ]
    //    })
    //    );
    //;
	//jQuery("#list2").jqGrid('setGroupHeaders', {
	//    useColSpanStyle: false,
	//    groupHeaders: [
    //      { startColumnName: 'amount', numberOfColumns: 3, titleText: '<em>Price</em>' },
    //      { startColumnName: 'closed', numberOfColumns: 2, titleText: 'Shiping' }
	//    ]
	//});
}


