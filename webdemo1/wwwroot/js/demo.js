var tww = function () {
    //页面数据
    var _pageData = {
        pageIndex: 1,
        city: "上海",
    };

    return {
        init: function () {
            alert(_pageData.city);
        },
    };
}();

//页面加载完成
$(function () {
    tww.init();
});