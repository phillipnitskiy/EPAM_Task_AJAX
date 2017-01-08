$(document).ready(function () {
    $('#commentForm_JSON').submit(function (event) {
        event.preventDefault();
        var data = $(this).serialize();
        var url = $(this).attr('action');
        $.post(url, data, function (comment) {
            $("#commentTemplate")
              .tmpl(comment)
              .appendTo('#comments');
        });
    });
});