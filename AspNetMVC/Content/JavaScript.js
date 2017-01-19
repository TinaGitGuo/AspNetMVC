(function ($) {
    $(document).ready(function (e) {
        //监听jquery中的appendTo事件而引发的自定义事件
        $(".field-validation-valid").on('appendTochange', function (e) {
            var errText = $(this).children().eq(0).text();
            if (errText.length > 0) {
                alert(errText);
                //alert(this);

                $(this).hide();
                //$(this).parent().children
                $('#strAccessionId').b.attr("data-content", errText).popover()
              //  alert("c")


                //$(this).parent().children('.validImg').attr('title', errText).show();
                //将错误提示信息span隐藏起来

            }
            //此时应该添加上去了一个子元素

        });

        //
        $(".field-validation-valid").on('removeDatachange', function (e) {
            alert("ca")
            //此时已经验证通过了
            //$(this).parent().children('.validImg').hide();
        });

    });
    $.each(["appendTo", "removeData"], function (i, methodname) {
        var oldmethod = $.fn[methodname];
        $.fn[methodname] = function () {
            oldmethod.apply(this, arguments);
            this.trigger(methodname + "change");
            return this;
        }
    });
})(jQuery);