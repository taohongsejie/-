@charset "utf-8";
/*!
 * 173tv css
 * Date modified 2018.8
 *
 */
/*递归样式写法*/
html > body > table >  tr [id="total"] > td  > ul > li { color:#ff0000;}

/*弹性图片*/
img {max-width:100%;height:1;width:auto9; /* ie8 */}
/*弹性内嵌元素(视频)*/
.video embed,.video object,.video iframe {width: 100%;height: auto;}
/*字号自动调整的问题(通过-webkit-txt-size-adjust:none禁用iPhone中Safari的字号自动调整)*/
body{
	-webkit-txt-size-adjust:none;
}
  
/* 网站样式重写 */body, select, input, textarea {
    color: #323232; color:#333;
    background-color: #F7F7F7;
    font-family:"Microsoft Yahei","Hiragino Sans GB","Helvetica Neue",Helvetica,tahoma,arial,Verdana,sans-serif,"WenQuanYi Micro Hei","\5B8B\4F53";
    font-size:12px;
    color: #333;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing:grayscale;
}
 * {}
a{outline:none; text-decoration:none; 
    

	} a:hover{ text-decoration:none;}
html{zoom:1;}html *{outline:0;zoom:1;} html button::-moz-focus-inner{border-color:transparent!important;} 
body{overflow-x: hidden;} 
body,div,dl,dt,dd,ul,ol,li/*,h1,h2,h3,h4,h5,h6*/,pre,code,form,input,textarea,/*p,*/blockquote,th,td{margin:0;padding:0; font-weight: normal;} table{/*border-collapse:collapse;border-spacing:0;*/}
p{
	margin:0 0 10px 0;
}
 /*fieldset,*/a img{border:0;} address,caption,cite,code,dfn,em,th,var{font-style:normal;font-weight:normal;} 
li{/*list-style:none;*/ /*list-style-position:inside; 不兼容ie6,ie7*/}
  caption,th{text-align:left;} h1,h2,h3,h4,h5,h6{/*font-size:100%;*/font-weight:normal; } 
q:before,q:after{content:'';}
hr{
	border:none; clear:both; height:0; background:none; margin:0; padding:0; border-bottom:#eee solid 1px;  margin:10px 0;
}
img { border: 0 none; height: 100%; max-width: 100%;
/*_width:expression((document.documentElement.clientWidth||document.body.clientWidth)<"100%"?"100%":"");*/ /*_width:100%;*/}

blockquote { border-left: 5px solid #EEEEEE; margin: 10px; padding: 10px; }

ul{
	margin-left:0px;
}
ul.unstyled, ol.unstyled{ list-style:none; }
ul.circle{ list-style-type:circle; }
ul.square{ list-style-type:square; }
ul.cjk{ list-style-type:cjk-ideographic; }

.mt-0{ margin-top: 0px !important;}
.mt-3{ margin-top: 3px !important;}
.mt-5{ margin-top: 5px !important;}
.mt-10{margin-top: 10px !important;}
.mt-15{margin-top: 10px !important;}
.mt-20{margin-top: 20px !important;}
.mt-25{margin-top: 25px !important;}
.mt-30{margin-top: 30px !important;}
.mt-35{margin-top: 35px !important;}
.mt-40{margin-top: 40px !important;}

.ml-5{ margin-left: 5px !important;}
.ml-10{margin-left: 10px !important;}
.ml-15{margin-left: 15px !important;}
.ml-20{margin-left: 20px !important;}
.ml-25{margin-left: 25px !important;}
.ml-30{margin-left: 30px !important;}

.mr-5{ margin-right: 5px !important;}
.mr-10{margin-right: 10px !important;}
.mr-15{margin-right: 15px !important;}
.mr-20{margin-right: 20px !important;}
.mr-25{margin-right: 25px !important;}
.mr-30{margin-right: 30px !important;}



/*首字母*/
.firstletter:first-letter{ font-size:200%;}

/**重写样式*/
.clearfix:after {content:"."; display:block; height:0; clear:both; visibility:hidden; }.clearfix {display:block;}.clear{ clear:both;}/* 清除浮动*/
.colwrapper { overflow:hidden; zoom:1 /*for ie*/; margin:5px auto; }/* 高度自适应 */ 
.strong{ font-weight: bold;} .left{ float: left;} .right{ float: right !important;} .center{ margin:0 auto; text-align:center;}
.show{ display:block; visibility:visible;}.hide{ display: none !important; /*visibility:hidden;*/}
.block{ display:block;} .inline{ display:inline;}
.transparent{filter:alpha(opacity=50); -moz-opacity:0.5;/** Firefox 3.5即将原生支持opacity属性，所以本条属性只在Firefox3以下版本有效 ***/ -khtml-opacity: 0.5; opacity: 0.5; } .break{ word-wrap:break-word;overflow:hidden; /*word-break:break-all;*/}

.canvas { position: relative; }
.relative { position: relative; }
code, pre { color: #333; font-family: Menlo,Monaco,"Courier New",monospace; font-size: 12px; padding: 0 3px 2px; }

abbr{background: none repeat scroll 0 0 #f3f3f3;
    border-bottom: medium none;
    border-left: 0.25em solid #639c8f;
    display: inline-block;
    margin-right: 0.5em;
    padding: 0 0.25em;} abbr:hover{ border-left:#da6a88 solid 3px;}

pre{ font-family:consolas,"Courier New",courier,monospace; /*color:#0088CC;*/ background-color: #fafafa ;  display: block; font-size: 14px; line-height: 1.7; margin: 0 0 9px; padding: 2em; white-space: pre-wrap; word-break: break-all; word-wrap: break-word; color:#333;}

code { background-color: #f5f2f0; padding: 0.5em; font-size:14px; margin: 0 0.5em; }
pre ol{
	margin: 0 0 0 14px;
}
pre.unstyled{
	background:none; color:#333; border:none;
}

/*插入flash默认灰色*/
object{ background:gray; display:block;}

.pink{ color:#ff00ff;} .blue{ color:#0000ff;} .deepblue{ color:#000099;} .gray{ color:#999999;} .red{ color:#ff0000;} .black{ color:#000;} .white{ color:white;} .green{color:green;}

.underline{ text-decoration:underline;} .dashedline{ border-bottom:dashed 1px #666;} ol.dashedline{ border:none; } ol.dashedline li{ border-bottom:dashed 1px #666; padding:5px; }


/* 固定不动 */
.fixedly{
	position:fixed; clip:rect(0 100% 100% 0); _position:absolute;
	
	/* 底部 */
	bottom:0px; left:0px; 

}
.fixedly.scrolltotop, .fixedly.livechat{
	 bottom:0px; right:20px; left:auto;  width:50px; height:50px; text-align:center; line-height:50px; font-size:40px; color:#ccc; display:block; _display:none;/* txt-shadow:#bbb 1px 1px;*/
	 background:#fff; border-radius: 2px 2px 2px 2px; border:#ccc solid 1px;
}
.fixedly.scrolltotop{ bottom:100px;}
a:hover.fixedly.scrolltotop, a:hover.fixedly.livechat{
	text-decoration:none;
}
.fixedly.livechat{
	bottom:20px;
}
.fixedly.scrolltotop.blue, .fixedly.livechat.blue{
	background:#85c2f2; txt-shadow:#2d96e9 1px 1px;
}
a:hover.fixedly.scrolltotop.blue, a:hover.fixedly.livechat.blue{
	background:#2d96e9; text-decoration:none;
}

*html{ background-image:url(about:blank); background-attachment:fixed; /* 解决固定层在IE6下闪的问题 */}


/* png透明 */
.pngfix{filter: progid:DXImageTransform.Microsoft.AlphaImageLoader(enabled=true, sizingMethod=scale, src='images/x.png');}

/* 渐变 */
.gradient{filter: progid:DXImageTransform.Microsoft.Gradient(GradientType=0, StartColorStr=#ffffff, EndColorStr=#dedede); background: -moz-linear-gradient(top, #ffffff, #dedede); /*火狐*/  background:-webkit-gradient(linear, 0 0, 0 bottom, from(#ffffff), to(#dedede)); /*webkit*/}
	
.radius { -webkit-border-radius: 20px;   /*只支持webkit内核的浏览器*/ border-radius: 20px;  /*只支持IE内核的浏览器（IE>=7)*/ -moz-border-radius : 4px; /*只支持Mozilla内核的浏览器*/ border:#ddd solid 1px; padding:7px; }

.highlighted {
    background: none repeat scroll 0 0 #00ADEE;
    color: #FFFFFF;
    padding: 0 5px;
}

/*超出省略号显示*/
.ellipsis{
	white-space:nowrap;/*设置不折行*/
	text-overflow:ellipsis;
	-o-text-overflow:ellipsis;/*兼容opera*/
	-webkit-text-overflow:ellipsis;
	width:80px;
	overflow:hidden;
}
/*文字闪动*/
.blink{
	text-decoration:blink;
}


/* 解决ie下连接加粗的鼠标样式问题*/
a strong{ cursor:pointer;}

/**FCK 兼容解决方案*/
em{ font-style:italic !important;} strike{ text-decoration:line-through !important;} strong{ font-weight:bold !important;} u{ text-decoration:underline !important;}

/**表单样式*/
/* input[type=text]:focus, input.text:focus, input.title:focus, textarea:focus, select:focus {  border-color:#666;} */
input{/*behavior:url(input.htc);*/ border:1px #ccc solid;}/*Only for ie 5.0+*/
/*label input{width:14px;height:14px;border:0;}*/ /*For input type is Radio*/
input:hover{}/*For orther browsers*/
 form{}

input[type=text],input[type=password],textarea, .text{ background:#fff; border: 1px solid #ccc; /*box-shadow: 0 1px 1px #ccc inset;*/ font-size: 16px;  line-height: 100%; display:inline-block; margin: 0; outline: medium none;/*border-radius: 4px;*/}
.text.radius{ }

input[class*="span"], select[class*="span"], textarea[class*="span"], .uneditable{
    float: none;
    margin-left: 0;
}
input:focus, textarea:focus {
    border-color: rgba(82, 168, 236, 0.8);
    box-shadow: 0 1px 1px rgba(0, 0, 0, 0.075) inset, 0 0 8px rgba(82, 168, 236, 0.6);
    outline: 0 none;}
	
	
	
fieldset{ padding:20px; border:#ccc solid 1px; }
label{ display:block; font-size:14px; margin:10px 0 0 0; }


/*网站整体颜色总汇*/
.ff8600,ff86aa a{ color:#ff8600;}

/*网站整字体大小*/
.font14px{ font-size:14px;}
.font9pt{ font-size:9pt;}

/*自定义字体*/
 @font-face {  font-family: danley;  src: url('../font/danley.ttf');  }  .danley {  font-family: danley; } @font-face {  font-family: cutter;  src: url('../font/quick.ttf');  }  .cutter {  font-family: cutter; }


/*网站整布局命名规范*/
 
/*外部链接*/
 a[rel=external]{
 	background:url(../imgs/external.png) no-repeat right center; padding:0 12px 0 0;
 }
 
 /*格子系统*/
 
.row{
	height:auto; overflow:hidden; clear:both; padding-bottom: 5px;
}

 
.col1, .col2, .col3, .col4, .col5, .col6, .col7, .col8, .col9, .col10, .col11, .col12, .col13, .col14 , .aside, .main{
  display: inline; float: left; /*margin-right: 10px;*/ min-height: 1px;
}
 
/* 第一个元素 */ .alpha { margin-left: 0; } /* 最后一个元素 */ .omega { margin-right: 0; }


.wrapper{ width:1420px ; height: ; margin:0 auto; padding: ; /*background:url(../imgs/grid.png) repeat;*/ clear:both; height:auto; /*overflow:hidden;*/ margin-top:20px; /*解决ie8居中的问题*/ /*position:relative; left:50%; margin-left:-480px;*/ position:relative;
}

	.col1{ width: 80px;} 
	.col2, .aside{ width: 19.5%; margin-right: 0.5%; } 
	.col3{ width: 280px; } .col4{ width: 380px; } .col5{ width: 446px; }.col6{ width: 350px; } .col7{ width: 680px; } .col8{ width: 1000px; } .col9{ width: 880px; } 
    .col10, .main{ width: 980px; } 
    .col11{ width: 1080px; } 
    .col12{ width:100%; } 
    .col13{ width: 1280px; }
    .col14{ width: 1380px; }

   .offset1{ }

@media (min-width: 1440px){
	.col8{ width: 950px; }
	.col6 {width: 420px;}
}

@media (min-width: 980px) and (max-width: 1440px) {
	.wrapper{ width:1230px ;}
	.col1{ width: 80px;} .col2, .aside{ width: 19.5%; } .col3{ width: 280px; } .col4{ width: 380px; } .col5{ width: 380px; }.col6{ width: 580px; } .col7{ width: 680px; } .col8{ width: 1000px; } .col9{ width: 880px; } .col10, .main{ width: 980px; } .col11{ width: 1080px; } .col12{ width: 100%; }.col13{ width: 1280px; }.col14{ width: 1380px; }
	.index-slider .col6{ width: 350px; }
	.index-slider .col8{ width: 830px; }
	.topbox-all .col14,.player-box .col14{
    	width: 1180px;
	}
	.search-item .col10, .main {
    	width: 780px;
	}
} 

.w1200 .wrapper{ width:1180px ;}
	.w1200 .col1{ width: 80px;} .w1200 .col2, .w1200 .aside{ width: 180px; } .w1200 .col3{ width: 280px; } .w1200 .col4{ width: 380px; } .w1200 .col5{ width: 480px; }.w1200 .col6{ width: 580px; } .w1200 .col7{ width: 680px; } .w1200 .col8{ width: 780px; } .w1200 .col9{ width: 880px; } .w1200 .col10, .w1200 .main{ width: 980px; } .w1200 .col11{ width: 1080px; } .w1200 .col12{ width: 980px; }
	.w1200 .col14{ width: 1380px; }
	.w1200 .index-slider .col6{ width: 280px; }
	.w1200 .index-slider .col8{ width: 880px; }


@media (min-width: 768px) and (max-width: 1300px) {
	.wrapper{ width:780px ;}
	.col1{ width: 80px;} .col2, .aside{ width: 180px; } .col3{ width: 280px; } .col4{ width: 380px; } .col5{ width: 100%; }.col6{ width: 580px; } .col7{ width: 680px; } .col8{ width: 780px; } .col9{ width: 880px; } .col10, .main{ width: 980px; } .col11{ width: 1080px; } .col12{ width: 580px; }.col13{ width: 1280px; }.col14{ width: 1380px; }
	.index-slider .col6{ display: none;}
	.index-slider .col8{ width: 780px; }
	
} 

@media (min-width: 980px) and (max-width: 1300px) {
	.wrapper{ width:980px ;}
	.col1{ width: 80px;} .col2, .aside{ width: 19.5%; } .col3{ width: 280px; } .col4{ width: 380px; } .col5{ width: 480px; }.col6{ width: 580px; } .col7{ width: 680px; } .col8{ width: 780px; } .col9{ width: 880px; } .col10, .main{ width: 980px; } .col11{ width: 1080px; } .col12{ width: 100%; }.col13{ width: 1280px; }.col14{ width: 1380px; }
	.index-slider .col8{ width: 980px; }
	.topbox-all .col14,.player-box .col14 {
    	width: 980px;
	}
	.search-item .col10, .main {
   		width: 580px;
	}
	.search-item .col6 {
    	width: 380px;
	}
	
}
.w960 .wrapper{ width:780px ; }
	.w960 .col1{ width: 60px;} .w960 .col2, .w960 .aside{ width: 180px; } .w960 .col3{ width: 220px; } .w960 .col4{ width: 380px; } .w960 .col5{ width: 480px; }.w960 .col6{ width: 580px; } .w960 .col7{ width: 540px; } .w960 .col8{ width: 780px; } .w960 .col9{ width: 700px; } .w960 .col10, .w960 .main{ width: 780px; } .w960 .col11{ width: 860px; } .w960 .col12{ width: 580px; }
	.w960 .col14{ width: 780px; }
	.w960 .index-slider .col6{ display: none;}
	.w960 .index-slider .col8{ width: 780px; }

.w768 .wrapper{ width:auto; padding:0 20px; position:static; margin:0 20px;}
.w768 .row{ margin:0;}
.w768 .col1, .w768 .col2, .w768 .aside, .w768 .col3, .w768 .col4, .w768 .col5, .w768 .col6, .w768 .col7, .w768 .col8, .w768 .col9, .w768 .col10, .w768 .main, .w768 .col11, .w768 .col12{ width:100%; margin:0;}
 @media only screen and (device-width 768px) {  
   /*For general iPad layouts*/  
   
}  
 
@media only screen and (min-device-width 481px) and (max-device-width 1024px) and (orientationportrait) {  
   /*For portrait layouts only */ 
}  
 
@media only screen and (min-device-width 481px) and (max-device-width 1024px) and (orientationlandscape) {  
   /*For landscape layouts only*/  
} 


   /*百分比格子系统( 若想兼容ie6不建议使用)*/
	/*.percent .wrapper{ width:118% !important;}*/
	.percent{ /*margin:0 20px;*/ margin:0;}
    .wrapper.percent{ margin:0 auto;}
	.percent .row{ margin-left:-1%; width:105%; _width:101%;}
	.percent .col1, .percent .col2, .percent .col3, .percent .col4, .percent .col5, .percent .col6, .percent .col7, .percent .col8, .percent .col9, .percent .col10, .percent .col11, .percent .col12, .percent .aside, .percent .main{ margin-left:1% ;}
	.percent .col1{ width: 7% ;} .percent .col2, .percent .aside{ width: 15% ;} .percent .col3{ width: 23%; } .percent .col4{ width: 31% ;} .percent .col5{ width: 39% ;}.percent .col6{ width: 47%; } .percent .col7{ width: 55% ;} .percent .col8{ width: 63% ;} .percent .col9{ width: 71%; } .percent .col10, .percent .main{ width: 79% ;} .percent .col11{ width: 87% ;} .percent .col12{ width: 95% ;}

@media (min-width: 0px) and (max-width: 768px) {
	.percent .row{ margin-left:0%; width:auto; _width:auto;}
	.percent .col1, .percent .col2, .percent .col3, .percent .col4, .percent .col5, .percent .col6, .percent .col7, .percent .col8, .percent .col9, .percent .col10, .percent .col11, .percent .col12, .percent .aside, .percent .main{ margin-left:0 !important; width: auto !important; float: none; display: block; margin-bottom: 5px;}
}

/* 网站外围阴影 */
.shardow{}



h1 small, h2 small, h3 small, h4 small, h5 small, h6 small{ /*color:#999; */font-size:80%; } * small{ margin-left:10px;}
h1{
	*margin:25px 0; font-size:26px; line-height:1em;
}
h1 small{font-size:20px;}
h2{
	font-size:20px;
}
/*导航*/
.naver{
	z-index:99; 
	position:relative; 
	z-index:99; 
	height: 60px;
	border-bottom: #EEEEEE solid 1px;
	background-color: #FFFFFF;
	
}
.naver .wrapper{
	overflow:visible; margin-top:0; position:static;height: 45px;background: white;
}
.naver ul{
	height: 60px;
	display:inline; float: left;
}
.naver li{
	height: 60px;
	 display:inline; float: left; position: relative;
}
.naver.menu li{
		height: 45px;
	}
.naver a{ 
    font-size:14px; margin: 0 20px; position: relative; white-space: nowrap; color: #333;
}
.naver a:hover,
.naver li.selected a{
	 text-decoration:none;
} 

/*logo*/
.naver .brand{
	float: left; display: inline; height: 60px; overflow: hidden;
}
.naver .brand img{
    height: 50px;
    padding: 5px 0;
}
.naver .brand a{
	font-size:25px; padding-left:0 !important;  border-right:0; font-weight: bold; padding-left: 0; display:block !important;
} 
.naver .brand a:hover{ 
	background:none;
}

/*主菜单*/
.naver .module{
	margin:0 10px 0 0px; margin-left:80px; float: left; display:inline;
}
.naver .module ul{
	margin-left:0;
}
/*副菜单*/
.naver .sub{ 
	height: 60px;
	float:right; 
	display:inline;
}

/*导航搜索*/
.naver .search{
	float:left; display:inline;  _background:none; overflow:hidden; line-height:1em; margin-top:8px;
}
.naver .search .text{
	float:left; display:inline;
}
.naver .search .btn{
	float:left; display:inline;
}

/*二级菜单*/
.naver .droper{
	top:50px;
}
.naver .droper {
	position:absolute; 
	left:50%; 
	right:0; 
	z-index:1000; 
	margin:0; 
	display:none; 
	top:60px; 
	background:#fff; 
	text-align:center; 
	width: 100px; 
	box-shadow: 0 0 8px rgba(0,0,0,0.15);
	margin-left: -50px;
}
.naver li.selected .droper{
	display:block;
}

.naver .droper dd a{
	text-align:left; white-space:nowrap;/*设置不折行*/ txt-overflow:ellipsis;/*这就是省略号喽*/ -o-txt-overflow:ellipsis;/*兼容opera*/ overflow:hidden; border:none; display: block;
}
.naver .droper dd.selected a, .naver .droper dd a:hover{
	color: #008eb7 ;
}

/*展开按钮*/
.naver .collapse{
	 padding: 6px 12px 10px 12px; background:#444444; color:#fff; display:none; position:absolute; right:5px; top:10px;
}
.naver .collapse span{ border-radius: 1px 1px 1px 1px;
    display: block; height: 2px; width: 22px; background:#fff; margin-top: 4px;
}

 
.naver.unstyled{ background:none;} .naver.unstyled a{ color:#333 !important; border-right:0 !important;} .naver.unstyled a:hover, .naver.unstyled a.selected{ background:none !important;}

.naver.fixed{
	position:fixed; top:0; width:100%; _position:absolute; _top: expression(documentElement.scrollTop + "px"); z-index:999; opacity:0.8;
}




/*@media (min-width: 768px) and (max-width: 1250px) {
	.naver .module a, .naver .sub a, .naver .brand a{ padding:0 15px;}
}*/

 

.naver .caret{
	border:#333 solid 4px; border-top:#999 solid 4px; margin:25px 0 0 5px; content: ""; display: inline-block; height: 0; vertical-align: top; width: 0;
}
.naver .selected .caret{
	border-top-color:#222; border-bottom-color:#999; margin-top:20px;
}


.naver .btn,
.naver .btn:hover{
	position:relative; padding:0 20px !important; height:30px !important; line-height:30px !important; background:#639c8f !important; color:#fff !important; display:inline-block !important; _top:10px;
}

/*滚动条*/
.swiper-scrollbar {
	border-radius: 10px;
	position: relative;
	-ms-touch-action: none;
	background: rgba(0,0,0,0.1)
}
.swiper-scrollbar-drag {
	height: 100%;
	width: 100%;
	position: relative;
	background: rgba(0,0,0,0.5);
	border-radius: 10px;
}
.swiper-scrollbar-cursor-drag {
	cursor: move;
}

header , .header{
	margin: 0px auto 0px auto; height:auto; overflow:hidden; clear:both;
}
header h1, .header h1{
	font-size: 60px; line-height:60px; margin:0;
}
header h2, .header h2{
	font-size:20px; line-height:30px;
}
.header .search{
	margin:10px 0 0 0;
}
.header .search .text{
	padding:9px;
}
.header .search .btn{
	padding:9px;
}

.navbar{ margin: 0px auto 0 auto; background-color: #2C2C2C; background-repeat: repeat-x; border-color: rgba(0, 0, 0, 0.1) rgba(0, 0, 0, 0.1) rgba(0, 0, 0, 0.25); box-shadow: 0 1px 0 rgba(255, 255, 255, 0.1) inset, 0 1px 0 rgba(255, 255, 255, 0.075); 
}
.navbar a{ margin:0 10px 0 10px; padding:5px 5px; display:inline-block; color:#666; }
.navbar a.selected{ background:#EDF7FC; }
.navbar a:hover{ text-decoration:none; background:#F1F9FD; }
.navbar .divider{ margin:5px 2px; border-left:#5cadd8 solid 1px; border-right:#fff solid 1px; }

/*段落*/
.phead{ 
	font-size:26px; margin-bottom: 10px;
}
.phead h4{
	font-size: 70%; margin-top: 0.5em;
}
.phead .more{
	position:absolute; right:0; bottom:7px;
}
.pbody{  font-size:16px; margin-bottom: 30px;}
.pfoot{ }


/*底部*/
.footer{
	padding:0px 0 5px 0; margin-top:20px; text-align:center; display: block; font-size: 14px; font-family: arial;
}
.footer .wrapper{ margin-top:0 !important;}
.footer.black{
	background:#333; color:#fff;
}
.footer a{
}
.footer .left{
	width:60%;
}
.footer .right{
	width:40%; text-align:right;
}

table { background-color: transparent; _background:none !important; border-collapse: collapse; border-spacing: 0; max-width: 100%; font-size:13px;  margin-bottom: 20px; width: 100%; }
table td.selected, table th.selected{ background:#F9F9F9; }
/*table th, table td { border-top: 1px solid #DDDDDD; line-height: 20px; padding: 4px 5px; text-align: left; vertical-align: top; }*/
table th { font-weight: bold; }
table thead th, table thead td { vertical-align: bottom; background:#DBEFF9; }

.table-bordered { -moz-border-bottom-colors: none; -moz-border-left-colors: none; -moz-border-right-colors: none; -moz-border-top-colors: none; border-collapse: separate; border-color: #DDDDDD #DDDDDD #DDDDDD -moz-use-txt-color; border-image: none; border-style: none solid solid none; border-width: 1px 1px 1px 0; padding:0 !important; }
.table-bordered th, .table-bordered td { border-left: 1px solid #DDDDDD; border-top: 1px solid #DDDDDD; }
.table-bordered thead:first-child tr:first-child th:first-child, .table-bordered tbody:first-child tr:first-child td:first-child {}
.table-bordered{ border: 1px solid #DDDDDD; box-shadow: 0 1px 3px rgba(0, 0, 0, 0.055); padding:5px; border-radius:2px; }
.table-bordered:hover{ border-color:#bbb; }

/*公共边框*/
.bordered{ border: 1px solid #DDDDDD; padding:5px; border-radius:2px; }
.bordered:hover{ border-color:#bbb; }

/*斑马条纹*/
.table-zebra{}
.table-zebra tr:nth-child(odd){ }
.table-zebra tr:nth-child(even){ background:#F9F9F9;}


/*css3漂浮的云*/
@-webkit-keyframes cloud{ from { background-position: 600px 100%; } to { background-position: 0 100%; } }
@-moz-keyframes cloud { from { background-position: 600px 100%; } to { background-position: 0 100%; } }
@-ms-keyframes cloud { from { background-position: 600px 100%; } to { background-position: 0 100%; } }
@-o-keyframes cloud { from { background-position: 600px 100%; } to { background-position: 0 100%; } }

/*css3浮动的波浪*/
@-webkit-keyframes wave{ from { background-position: 600px 100%; } to { background-position: 0 100%; } }
@-moz-keyframes wave { from { background-position: 600px 100%; } to { background-position: 0 100%; } }
@-ms-keyframes wave { from { background-position: 600px 100%; } to { background-position: 0 100%; } }
@-o-keyframes wave { from { background-position: 600px 100%; } to { background-position: 0 100%; } }

/*头部*/
.heading,
.masthead{ 
	padding:80px 20px 80px 20px; margin-bottom:30px; background:#f1f6fa; text-align: center;
}
.heading a{
}
.heading-unstyled{ 
	background:none; color:#333; border-bottom:#eee solid 1px;
}
.heading .wrapper{ 
	left:auto; margin-left:auto; 
}
.heading h2{ 
	font-size: 30px; margin: 0;
}
.heading h3{ 
	font-size:18px; line-height: 1.7; margin: 0; margin-top: 20px;
}
.heading .lead {
    font-weight: 300; line-height: 1.5;
}


.marketing, .support, .feature{}
.marketing h1, .support h1, .feature h1{
	text-align:center; font-size:30px;
}
.marketing h1 small, .support h1 small, .feature h1 small{
	display:block; font-size:16px;
}

/*侧边栏*/
.sidebar{ 
	list-style:none; padding-bottom:1px; margin-left:0 !important; font-size: 14px;
}
.sidebar li{ 
	display: block; 
}
.sidebar li.nav-head,
.sidebar li a{
	padding: 4px 14px; 
}
.sidebar li.nav-head{
	margin-top: 20px; 
}
.sidebar li a{  
	display:block; color: #999;
}
.sidebar li a:hover{
	background: #e9e9e9;
}
.sidebar li.selected{ 
	cursor:default; background:#f1f6fa ; 
}
.sidebar li.selected a{ 
}
.sidebar li.selected a:hover{ 
	text-decoration:none; 
}
.sidebar li ul{ 
	margin-left:0;
}
/*二级菜单*/
.sidebar li ul li{ 
	border-left:none; border-right:none; background:#fff; 
}
.sidebar li ul li.selected{ 
	background:#eee;
}
.sidebar li ul li a{ 
	color:#333 !important;
}
/*新版，dl更适用，工作项目总结*/
dl.sidebar{ 
	list-style:none; padding-bottom:1px; margin:0;
}
.sidebar dd{ 
	border: 1px solid #E5E5E5; display: block; margin: 0 0 -1px; padding: 8px 14px;
}
.sidebar dd:hover{
	background:#eee;
}
.sidebar dd.selected{ 
	cursor:default; color:#999; 
}
.sidebar dd.selected a:hover{ 
	text-decoration:none; 
}
/*粘贴*/
.sidebar.affixed{
	position:fixed; top:20px;
}

@media (min-width: 10px) and (max-width: 940px) {
	.sidebar{ display:none;}
}


.pager{ padding-top:5px; }
.pager a{ padding:4px 10px; border: 1px solid #ddd; background: #fff; }
.pager a:hover{ background: none repeat scroll 0 0 #0099FF; border-color: #0099FF; color: #FFFFFF; }
.pager a.selected{ background:none; border:none; }

.pager.unstyled a{ border:none;}
.pager.unstyled a:hover, .pager.unstyled a.selected{ background:none; color:#333;}

.alert{ background-color: #D9EDF7; border-color: #BCE8F1; color: #3A87AD; padding:10px; }
.alert.error{ background-color: #F2DEDE !important; border-color: #EED3D7; color: #B94A48; }
.alert.success{ background-color: #DFF0D8 !important; border-color: #D6E9C6; color: #468847; }

.footbar{ background:#; margin:50px 0 0 0; border-top:#EAEAEA solid 1px; }
.footbar .head{ background:#; padding:5px; text-align:center; }
.footbar .body{ padding:20px 0; }
.footbar .col3{ /*width:180px; display: inline; float: left; margin-left: 20px; padding:0 0 0 20px;*/ }
/*写法不兼容ie6,ie7*/
.footbar .col3 + .col3 { /*border-left: 1px solid #DDDDDD; */}
/*hack*/

.footbar dl{
	margin:20px 0 0 0; line-height:2em;
}


/*美版风格*/
.usa ul, .usa ol{ font-size:11px; }
.hero{ background:#eee; padding:30px 60px;}
.hero h1{ font-size: 54px; }


/*幻灯片*/
.slider{ 
	background:#44BDFD; clear:both; position:relative; height:300px; padding-top:60px; background:url(../imgs/loading.gif) #eee no-repeat center center;
} 
.slider-wrap{ 
	margin-top:0 !important;
}
.slider-prev, .slider-next{ 
	font-size:100px; position:absolute; left:0; top:50%; margin-top: -40px; color:#fff; cursor:pointer; background: #ccc; width: 50px; height: 80px; line-height: 80px;
}
.slider-next{ 
	right:0; left:auto; 
}
.slider-list li{ 
	text-align:center; line-height:1; display:none; list-style: none;
}
.slider-list li.selected{
}
.slider h1{ 
	font-size:30px; margin-bottom:20px; font-weight:bold; 
}
.slider h2{ 
	line-height:1.5; 
}
.slider-list li .btn{ 
	padding:15px 20px; 
}
.slider-number{
}


.rotate:hover{
	transform: rotate(360deg);
	transition: all 1s ease-out 0s;
}


/*选项卡*/
.taber{ }
.taber .head,.ph-taber .head{ border-left: 1px solid #E5E5E5; height:30px; }
.taber .head a,.ph-taber .head a{ border: 1px solid #E5E5E5; float:left; display:inline; padding:0px 20px; border-left:none; height:30px; line-height:30px; }
.taber .head a.selected,.ph-taber .head a.selected{ border-bottom:none; }
.taber .body,.ph-taber .body{ clear:both; padding:10px; }

.tooltip{ padding:4px; background:#000; position:absolute; z-index:1001; color:#fff; font-size:12px;
filter:alpha(opacity=80); -moz-opacity:0.8;/** Firefox 3.5即将原生支持opacity属性，所以本条属性只在Firefox3以下版本有效 ***/ -khtml-opacity: 0.8; opacity: 0.8; 
}
.tooltip .arrow{ width:0; height:0; border-top:0px; border-bottom:5px solid #000; border-right:5px solid transparent; border-left:5px solid transparent; position:absolute; top:-4px; *top:-30px; left:8px; }


.spring{ background:#f6e5e5; color:#de0000;  position: relative; z-index: 99; font-size:16px; line-height:1.5em;}
.spring .wrapper{ margin-top:0; padding: 17px 0; position:relative;}
.spring del{ cursor:pointer; text-decoration:none; color: #de0000; font-size: 18px; font-weight:bold; border:#de0000 solid 2px; border-radius:100px; width:16px; height:16px; line-height:16px; display:block; text-align:center; position:absolute; right:10px; top:50%; margin-top:-8px;}
.spring-text{
	padding-right:30px;
}

/*仿苹果时间样式*/
.label.time{ background:#666; color:#fff; padding:2px 5px; margin:0 2px 0 2px; position:relative;
}
.label.time:before{ position:absolute; width:100%; height:1px; background:#fff; content:""; left:0; top:50%; }

/*弹窗*/
.dialog{ width:600px; height:auto; overflow:hidden; position:fixed; _position:absolute; left:50%; margin-left:-300px; top:50%; margin-top:-200px; border:#333 solid 1px; background:#fff; z-index:999; display:none;}
.dialog del{ display:block; position:absolute; right:20px; top:20px; width:20px; height:20px; font-family:Arial, Helvetica, sans-serif; text-decoration:none; font-size:30px; txt-shadow: 0 1px 0 #FFFFFF; cursor:pointer; color:#ccc;  }
.dialog-head{ border-bottom:#eee solid 1px; padding:20px; font-size:20px; position:relative; }
.dialog-body{ padding:20px; }
.dialog-foot{ background:#f5f5f5; padding:10px; border-top: 1px solid #DDDDDD; box-shadow: 0 1px 0 #FFFFFF inset; text-align:right;  }

.popover{ padding-right:20px; padding-left:20px;Z-INDEX:100;padding-bottom:20px; WIDTH:300px;padding-top:20px; POSITION:absolute; background:#fff; border:2px solid #333; box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2); }
.popover:before { border-bottom: 7px solid #333; border-left: 7px solid transparent; border-right: 7px solid transparent; content: ""; display: inline-block; left: 9px; position: absolute; top: -7px;
	}

@-webkit-keyframes bar_ {  from { background-position: 40px 0; } to { background-position: 0 0; } }
@-moz-keyframes bar_ { from { background-position: 40px 0; } to { background-position: 0 0; } }
@-ms-keyframes bar_ { from { background-position: 40px 0; } to { background-position: 0 0; } }
@-o-keyframes bar_ { from { background-position: 0 0; } to { background-position: 40px 0; } }
@keyframes bar_ { from { background-position: 40px 0; } to { background-position: 0 0; } }

.progress{
	background-color: #F7F7F7; background-repeat: repeat-x; box-shadow: 0 1px 2px rgba(0, 0, 0, 0.1) inset; height: 20px; margin-bottom: 20px; overflow: hidden;
}
.progress .bar{ 
	-moz-box-sizing: border-box; background-color: #0E90D2; background-repeat: repeat-x; box-shadow: 0 -1px 0 rgba(0, 0, 0, 0.15) inset; color: #FFFFFF; float: left; font-size: 12px; height: 100%; text-align: center; txt-shadow: 0 -1px 0 rgba(0, 0, 0, 0.25); transition: width 0.6s ease 0s; width: 0;
}
.progress.striped .bar { background-color: #149BDF; background-size: 40px 40px;
}
/*css3滚动效果*/
.progress.active .bar { animation: 2s linear 0s normal none infinite bar_; }
.progress.success .bar{
    background-color: #5EB95E; background-repeat: repeat-x;
}
.progress.warning .bar{
    background-color: #FAA732; background-repeat: repeat-x;
}
.progress.danger .bar{
    background-color: #DD514C; background-repeat: repeat-x;
}

/*分割线*/
.partbar{
	background:#244668; padding:10px 0; color:#fff; text-align:center; position:relative;
}
.partbar .arrow{
	border-top:#244668 solid 10px; border-left:#fff solid 10px; border-right:#fff solid 10px; position:absolute; bottom:-10px; width:0; height:0; left:50%;
}

 
	
/*广告*/
.banner{} .banner .wrapper{ margin-top:0 !important;}
.banner img{ float:left; display:inline; }

/*页面主体*/
.pagebody{ width:100%; height:auto; overflow:hidden; border:#CCC solid 1px; clear:both;}

.leftpage, .mainpage, .rightpage{ float:left; margin-right:10px; background:#fff; }

/*页面左侧*/ .leftpage{} /*页面右侧*/ .mainpage{} /* 页面右侧 */ .rightpage{} /* 列表模型 */ .list{} /*侧栏*/  .column{} /*登录条*/
.loginbar{} /*热点*/ .hot{} /*新闻*/ .news{} /*下载*/ .download{} /*子导航*/ .subnav{} /*菜单*/ .menu{} /*子菜单*/ .submenu{} /*搜索*/ .search{} 

/*友情链接*/ .friendlink{} /*版权*/ .copyright{} /*滚动*/ .scroll{} /*内容*/ .content{} /*标签页*/ .tab{} /*文章列表*/ .list{} /*提示信息*/ .msg{} /*小技巧*/ .tips{} /*栏目标题*/ .title{} /*加入*/ .joinus{} /*指南*/ .guild{} /*服务*/ .service{} /*注册*/ .regsiter{} /*状态*/ .status{} /*投票*/ .vote{} /*合作伙伴*/ .partner{}

 


	
 
@-webkit-keyframes animate-qq { from { margin-top: 10px; } 50% { margin-top: 0; }  to { margin-top: 10px; } }
@-moz-keyframes animate-qq { from { margin-top: 10px; } 50% { margin-top: 0; } to { margin-top: 10px; } }
@-ms-keyframes animate-qq { from { margin-top: 10px; } 50% { margin-top: 0; } to { margin-top: 10px; } }
@-o-keyframes animate-qq { from { margin-top: 10px; } 50% { margin-top: 0; } to { margin-top: 10px; } }
.animate-qq-key from { margin-top: 10px; }
.animate-qq-key 50% { margin-top: 0; }
.animate-qq-key to { margin-top: 10px; }
.qq{
	background:url(../imgs/qq.png) no-repeat; width:144px; height:153px; position:absolute; display:block; right:5%; top:150px; /*调用css3动画*/ -webkit-animation: animate-qq 3s ease-in-out infinite; -moz-animation: animate-qq 3s ease-in-out infinite; -ms-animation: animate-qq 3s ease-in-out infinite; -o-animation: animate-qq 3s ease-in-out infinite; animation: animate-qq 3s ease-in-out infinite;
}

/*slicy卡通形象*/
.cartoon{
	background:url(../imgs/cartoon.png) no-repeat; width:302px; height:172px; position:absolute; top:350px; left:5%;
}

/*百叶窗*/
.shutter{
	 margin: 0 auto;
    max-width: 1600px;
    overflow: hidden;
    position: relative; background:#f2f2f2;
}
.shutter .item{
	background:url(../imgs/shutter.jpg) no-repeat;
}
.shutter .text{
	    background: none repeat scroll 0 0 #E23300;
    color: #FFFFFF;
    font-size: 0.8em;
    padding: 1.4em 25px;
    width: 23.4375em; top:5%;
	
	pointer-events: none;
    position: absolute;
    width: 26em;
}
.shutter .text h3{
	font-size:1.9em;
}
.shutter .media{
	padding-bottom: 30%;
}
.shutter .status{
	text-align:right; font-size:30px;  txt-shadow: 0 0 4px rgba(0, 0, 0, 0.15); position:absolute; bottom:30px; left:0; width:100%;
}


/*分享栏*/
.sharebar{
	color:#fff; font-size:16px;
}
.sharebar h2{
	font-size:38px;
}
.sharebar .highlight{
	
}
.sharebar .highlight a{
	padding:1.75em; border: 1px solid transparent; background:#10537B; display:block; color:#fff;
}
.sharebar .highlight a:hover{
	background:#10537B;
}
.sharebar .highlight h3{
	font-size:24px;
}
.sharebar .highlight img{
	float:left; margin-right:24px;
}

/*二维码*/
/*.qrcode{
	position:fixed; bottom:30%; right:5px; width:100px; padding:10px; background:#EBEBEB;
}
.qrcode:hover{ background:#D5DFE8;}
.qrcode img{
	max-width:100%;
}*/

.current{ border: 1px solid #E5E5E5; padding:5px 10px; clear:both; height:auto; overflow:hidden; text-align:right; position:relative;}
.current dt{
	position:absolute; left:10px; top:5px;
}
.current dd{
	display:inline;
}
.current.unstyled{ border:none; padding:0;}

.label{background-color: #999999; color: #FFFFFF; font-size: 12px; font-weight: bold; line-height: 22px; padding: 3px 4px; txt-shadow: 0 -1px 0 rgba(0, 0, 0, 0.25); vertical-align: middle; white-space: nowrap;} .label.success{background-color: #468847;} .label.warning{background-color: #F89406;} .label.error{background-color: #B94A48;}
	
.well{ background-color: #F5F5F5; border: 1px solid rgba(0, 0, 0, 0.05); box-shadow: 0 1px 1px rgba(0, 0, 0, 0.05) inset; margin-bottom: 20px; min-height: 20px; padding: 19px;} .well .wrapper{ margin-top:0 !important;}
	
	
	.page{}
	.page.gray{  background:#EDEDEB;}
	.page.black{background:#454D50;}
	.page.red{ background:#EE3728; color:#8C2018;} .page.red a{ color:#fff;}
	
	/*一般用在BANNER图下的内容条*/
	.purchase{box-shadow: 0 0 4px #EEEEEE inset;
    padding: 30px 0 20px; background:#FEFEFE;}
	.purchase .wrapper{ margin-top:0 !important;}
	
	
	/*时间轴*/
	.timeline { list-style-type: none; padding: 30px 0 50px; position: relative; margin-left: 0;
	background: url("data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAUAAAAFCAYAAACNbyblAAAAJUlEQVQIW2NkQAP/gYARWQwkAOLDBeECjEAAkkEWAKtEFwAJAgAZEBP+oM1IkwAAAABJRU5ErkJggg==") repeat-y scroll 165px 0 #eee; }
	.timeline ul{list-style-type: none; margin-left:0;}
	.timeline .event { margin-bottom: 80px; padding-right: 40px; position: relative;
}
.timeline .thumb { background-repeat: no-repeat; border-radius: 50% 50% 50% 50%; border: solid 4px #ddd; box-shadow:0 1px 1px rgba(200, 200, 200, 0.5); height: 100px; position: absolute; transform: scale(0.8) translateX(24px); width: 100px; left:0; *left:20px; top:0;}
.timeline .thumb span { bottom: -40px; color: #999; font-size: 15px; font-weight: 700; position: absolute; text-align: center; txt-transform: uppercase; width: 100%; left:0;}
.timeline .inner { margin-left: 230px; perspective: 600px; position: relative; border-color: #F26328; /*box-shadow: 10px 0 10px -6px rgba(0, 0, 0, 0.1);*/ background:#fff; padding:20px; text-align:left;}
.timeline .inner:before {
    border-bottom: 20px solid transparent;
    border-top: 20px solid transparent;
    border-right: 20px solid #fff;
    content: "";
    display: inline-block;
    top: 37px;
    position: absolute;
    left: -20px;
}
.timeline label{ display: block; height: 24px; left: 152px; position: absolute; top: 36px; width: 24px; background: none repeat scroll 0 0 #fff; border-radius: 50% 50% 50% 50%; color: #41838E; font-size: 26px;  border:#ddd solid 4px; }
.timeline .event:hover label{ border:#ccc solid 4px; }

/*单行滚动*/
.singlerolling{
	height:22px; overflow:hidden; line-height:22px;
}

/*报头*/
.masthead {  position: relative; margin-bottom: 20px; padding: 30px 15px; text-align: center; }
.masthead h1 { font-size: 100px; line-height: 1; }
.masthead p { font-size: 30px; margin-left: 10%; margin-right: 10%; font-size: 21px; font-weight: 200; line-height: 1.4; margin-bottom: 20px;}
.masthead .social { }




.lead {
    font-size: 16px;
    font-weight: 200;
    line-height: 1.4;
    margin-bottom: 20px;
}

.intro{}

/*圆形*/
.rounder{
	/*transform: scale(0.8) translateX(24px);*/ 
	border-radius: 50% 50% 50% 50%;
    border: solid 4px #ddd;
	box-shadow:0 1px 1px rgba(200, 200, 200, 0.5);
}

.loading{background:url(../imgs/loading.gif) no-repeat center center;}

/*扩大*/
.expand{}

.postfix.btn {
    line-height: 2.125em;
    padding: 0;
    text-align: center;
}


/*后缀*/
.postfix{}
.prefix, .postfix { border-style: solid; border-width: 1px; display: block; font-size: 0.875em; height: 2.3125em; line-height: 2.3125em; overflow: hidden; padding-bottom: 0; padding-top: 0; position: relative; text-align: center; width: 100%; z-index: 2; }
/*标注*/
.callout{}
.well.callout { background: none repeat scroll 0 0 #2BA6CB; border-color: #2284A1; border-style: solid; border-width: 1px; box-shadow: 0 1px 0 rgba(255, 255, 255, 0.5) inset; margin-bottom: 1.25em; padding: 1.25em; }


/*浮动菜单*/
.absbar{ position:fixed; _position:absolute; bottom:20px; right:20px; z-index:99; width:50px;}
.absbar ul{ padding:0; margin:0; list-style:none;}
.absbar li{ position:relative; margin:3px 0 0 0; height:50px; line-height:50px; text-align:center; padding:0;}
.absbar li a{ display:block; color:#fff; background:#79c4b3; position:relative; z-index:9;}
.absbar li .toggle{ width:50px; height:50px; background:#eee; display:block; cursor:pointer; line-height:50px; text-align:center;}  
.absbar .droper{ position:absolute; right:60px; top:0; background:#eee; padding:20px;}
 /*二级*/
.absbar ul ul{ position:absolute; bottom:50px; left:0; width:100%; z-index:3; display:none;}
.absbar ul ul li{ margin-top:0px;  border-bottom:#67a093 solid 1px;}
.absbar ul ul li a{ background:#70b0a1;}
.absbar ul ul li .qrcode{ width:110px; padding:10px; position:absolute; right:60px; top:50%; margin-top:-50px; background:#8dddcb; font-size:12px; line-height:22px; display:none;}
/*选中*/
.absbar ul li.selected ul{ display:block;}
.absbar ul ul li.selected .qrcode{ display:block;}
 
 



/*按钮*/
.btn{ 
	display: inline-block; zoom: 1; vertical-align: baseline; margin: 0 2px; outline: none; cursor: pointer; text-align: center; text-decoration: none; font-size:16px; line-height:100%; border:none; /* gray */ color: #999; background: #E6E6E6; border-radius:4px; padding: 0.5em 1.5em;
}
.btn:hover { text-decoration:none;}
.btn:active { position: relative; top: 1px; /* white */ color: #999; }
/*反向*/
.btn-inverse{ background:none; color:#fff; border:#fff solid 1px; }
.btn-inverse:hover,
.btn-inverse-selected{ background:#fff !important; color:#666 !important; }
.btn-little { font-size: 9px; padding: .2em 1em .275em; }
.btn-small { font-size: 11px; padding: .2em 1em .275em; }
.btn-medium { font-size: 12px; padding: .4em 1.5em .42em; }
.btn-large{ 
	font-size:150%; padding: 0.8em 1.8em;
}
.btn-xlarge { font-size: 200%; }
.btn.unstyled{ background:none; border: 1px solid rgba(255, 255, 255, 0.5); } 
a:hover.btn.unstyled{ background:border: 1px solid rgba(255, 255, 255, 0.1);}
/*expand扩大*/
button.expand, .btn.expand { padding-left: 0; padding-right: 0; width: 100%; }
.btn-outline{
	 background-color: transparent;
    border: #666 solid 1px;
    color: #666;
}
.btn-outline:hover{
	background:#666; color:#fff;
}
.btn-large.btn-rounded{
	border-radius: 50px;
}
.btn.btn-empty{
	border: #fff solid 2px; background: none; color: #fff;
}

/*颜色*/
.txt-red{ color:#e33;}
.txt-yellow{ color:#f60;}
.txt-blue{ color:#0ae;}
.txt-green{ color:#2c7;}
/*左右*/
.txt-left{ text-align:left;}
.txt-right{ text-align:right;}
.txt-center{ text-align:center;}
/*左右对齐*/
.txt-justify{ text-align:justify;}

.bg-red{ background:#e33;}
.bg-yellow{ background:#f60;}
.bg-blue{ background:#03a9f4;}
.bg-green{ background:#2c7;}
.bg-red-light{ background:#fee;}
.bg-yellow-light{ background:#ffd;}
.bg-blue-light{ background:#eff;}
.bg-green-light{ background:#efd;}
/*反相*/
.bg-inverse{ color:#fff;}

.pd-small { padding:10px;}
.pd-large{ padding:20px; }
.pd-xlarge {  padding:40px; }

.bdr{ border:#ddd solid 1px;}
.bdr-red{ border-color:#e33;}
.bdr-yellow{ border-color:#f60;}
.bdr-blue{ border-color:#0ae;}
.bdr-green{ border-color:#2c7;}
.bdr-small { border-width:1px;}
.bdr-large{ border-width:2px;}
.bdr-xlarge { border-width:4px; }


.mt10{
	margin-top: 10px;
}
.mt15{ margin-top: 15px;} .mt20{ margin-top: 20px;}

.fs18{ font-size: 18px;}

.pricing-tables{margin: 0 auto;
    width: 95%; height:auto; overflow:hidden; padding-top:20px; padding-bottom:20px;}
    .pricing-tables h3{ font-size:24px;}
.pricing-box{
	background: none repeat scroll 0 0 #fff;
    border: 1px solid #ccc;
    float: left;
    margin-right: -1px;
    padding: 0 0 20px;
    text-align: center;
    width: 30%;
}
.pricing-head{
	border-bottom: 3px solid #da6a88;
    color: #000;
    font-family: Verdana,Geneva,sans-serif;
    font-size: 18px;
	height: 48px;
    width: 100%;
    padding-top:20px;
}
.pricing-body ul{
	list-style: none outside none;
    margin: 0 0 15px !important;
    text-align: left;
}
.pricing-body ul li{
	line-height: 4em;
    list-style-type: none !important;
    margin-left: 0;
    border-bottom:#ccc solid 1px;
    text-align:center;
}
.pricing-box.large{
    margin-top: -20px;
    padding: 0 0 40px;
    position: relative;
    z-index: 9;
}
.pricing-box.large .pricing-head{

    background: #da6a88;
    color: #fff;
    font-size: 24px;
    height: 55px; 
    padding-top:30px;
}

/*计数器*/
.counter{
	font-size:36px;
}
.counter-btns{
	position:relative;
}
.counter-btns i{
	width:36px; height:60px; line-height:60px; text-align:center; font-size:36px; background:#333; color:#fff; display:inline-block; margin:0 1px;  
}
/*line-through*/
.counter-btns-lt{
	position:absolute; left:0; top:50%; margin-top:-1px; right:0; height:1px; background:#fff;
}


/*图片*/
.img-scale {
    transform: scale(1);
    transition: all 0.5s cubic-bezier(0.25, 0.1, 0.25, 1.5) 0s;
}
a:hover .img-scale{
    transform: scale(1.2);
}


.hide {
	display:none
}
.show {
	display:block
}



/*abs-faq*/
.abs-faq{
	position: fixed; right: -400px; top: 100px; border: #669988 solid 5px; background: #eee; width: 390px; 
}
.faq-selected{
	right: 0;
}
.abs-faq .faq-btn{
	position: absolute; left:-50px ; width: 45px; top: -5px; height: 145px; background: #003e79; background:url(../imgs/abs-faq-btn.jpg) #669988 no-repeat center; cursor: pointer;
}
.abs-faq ul,
.abs-faq li{
	list-style: none; padding: 0; margin: 0;
}
.abs-faq li a{
	text-decoration: underline;
}
.abs-faq li .q a{
	background:url(../imgs/abs-faq-ico.png) no-repeat left 8px; display: inline-block; padding-left: 20px;
}
.abs-faq li .a{
	background: #fff; border: #669988 solid 1px; padding: 10px; txt-indent: 2em; position: relative; margin-top: 10px; display: none;
}
.abs-faq li.selected .a{
	display: block;
}
.abs-faq li .a .arrow{
	background: url(../imgs/abs-faq-arrow.png) no-repeat; width: 14px; height: 12px; display: block; position: absolute; left: 20px; top: -12px;
}
.faq-head{
	padding: 5px 15px; text-align: center; border-bottom: #003e79 solid 1px; margin: 0 15px;
}
.faq-head h2{
	margin: 0; margin-top: 10px;
}
.faq-body{
	padding: 15px; height: 450px; overflow-y: scroll; overflow-x: hidden;
}
.faq-foot{
	background: #669988; line-height: 35px; padding:0 15px; color: #fff; padding-top: 5px;
}
.faq-close{
	background: url(../imgs/abs-faq-close.png) no-repeat; width: 15px; height: 15px; position: absolute; right: 20px; top: 20px; cursor: pointer;
}


/*imgroll*/
.imgroll{
	padding: 0 50px; position: relative;
}
.imgroll-prev,
.imgroll-next{
	width: 50px; height: 150px; background: #bbb; position: absolute; left: 0; top: 0; line-height: 150px; text-align: center; color: #fff; font-size: 32px; font-family: arial; cursor: pointer;
}
.imgroll-next{
	left: auto; right: 0;
}
.imgroll-list{
	overflow: hidden; margin: 0 10px;
}
.imgroll ul{
	height: auto; overflow: hidden; width: 9999999px; margin-left: 0;
}
.imgroll li{
	width: 200px; height: 200px; float: left; display: inline; margin-right: 10px; text-align:center
}
.imgroll li h2{
	margin: 0; margin-top: 5px;
}

/*响应式*/
/*响应式导航*/
/*导航*/
.gh {
    display: block;
    height: 60px;
    line-height: 60px;
    outline: medium none;
    width: 60px;
	position:absolute; right:0; top:0; cursor:pointer; display:none;
}

.gh i{
	font-size: 24px;
	color: #999999;
}
/*@media only screen and (max-width:940px) {
	.gh{
		display:block;
	}
}*/

@media only screen and (max-width:800px) {
	.timeline{
		background-position:20px 0;
	}
	.timeline .event{
		padding-right:20px;
	}
	.timeline .thumb{
		display:none;
	}
	.timeline .inner{
		margin-left:50px;
	}
	.timeline label{
		left:13px; width:10px; height:10px;
	}
}



@media only screen and (min-width:640px) {
	.topBarAd {
		display: none!important;
	}
}
@media only screen and (max-width:640px) {
	
	.naver {
		height: auto!important;
	}
	.naver .brand {
		position: relative;
	    float: none;
        display: block;
	}
	.naver .brand img{
	    height: 44px;
	    text-align: center;
	    display: block;
	    margin: 0 auto;
	}
	.wrapper-indexheader .brand a {
		font-size: 0 !important;
        margin: 0!important;
	}
	.wrapper-indexheader .brand .logo-box {
        margin: 0 auto!important;
        width: 50%;
	}
}


@media only screen and (max-width:480px) {

}



.show-phone {
	display:none!important
}
.show-pad {
	display:none!important
}
.hide-pc {
	display:none!important
}
.show-pc {
	display:inherit!important
}
@media(min-width:768px) and (max-width:979px) {
.hide-pc {
display:inherit!important
}
.show-pc {
display:none!important
}
.show-pad {
display:inherit!important
}
.hide-pad {
display:none!important
}
}
@media(max-width:767px) {
.hide-pc {
display:inherit!important
}
.show-pc {
display:none!important
}
.show-phone {
display:inherit!important
}
.show-phone {
display:none!important
}
}

.gradient{
    background: #4cd964;
    background: -moz-linear-gradient(45deg, #4cd964 0%, #5ac8fa 100%);
    background: -webkit-gradient(left bottom, right top, color-stop(0%, #4cd964), color-stop(100%, #5ac8fa));
    background: -webkit-linear-gradient(45deg, #4cd964 0%, #5ac8fa 100%);
    background: -o-linear-gradient(45deg, #4cd964 0%, #5ac8fa 100%);
    background: -ms-linear-gradient(45deg, #4cd964 0%, #5ac8fa 100%);
    background: linear-gradient(45deg, #4cd964 0%, #5ac8fa 100%);
    filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#4cd964', endColorstr='#5ac8fa', GradientType=1 );
    margin: 0 auto;
}

.subnav{
	background: #e9e9e9 ; text-align: center; padding:10px 0 ; clear: both; font-size: 16px; font-weight: bold;
}
.subnav li{
	list-style: none; display: inline;
}
.subnav li a{
	display: inline-block; padding: 0.4em 1em; color: #555555; border-radius: 50px;
}
.subnav li a:hover{
	background: #f2f2f2; text-decoration: none;
}

.subnav li.selected a,
.subnav li.selected a:hover{
	background: #33b5d4; color: #fff;
}
ul,ol,li{
	list-style: inside;
}
.auto_out{
	font-size: 16px;
	color: #333333;
    overflow: hidden;
    margin-top: 10px;
    height: 24px;
    line-height: 24px;
    text-overflow: ellipsis;
    text-decoration: none;
}
.auto_out:hover{
	color: #fd4c5d;
	cursor: pointer;
}
strong{
	color: #fd4c5d;
}

