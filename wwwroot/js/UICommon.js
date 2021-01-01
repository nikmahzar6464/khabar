function OpenWindow(url) {

    var width = window.innerWidth * 0.7;
    var height = window.innerHeight * 0.7;
    var left = window.innerWidth * .15 + window.screenX;
    var top = window.innerHeight * 0.15;
    return window.open(url, "", "width=" + width + ",height=" + height + ",left=" + left + ", top=" + top);

}



function OPenModal(Content,Option) {

    var x = document.getElementById('Modal' + Content.id);
    if (x == null) {

        var title = "";
        if (Option && Option.title) {
            title = Option.title;
        }
        var applybtn = "";
        if (Option && Option.applyEvent) {
            applybtn = '<button data-dismiss="modal" class="btn btn-primary" id="Modal' + Content.id +'applyEvent" type="button">تایید</button>';
        }
        var str = '<div class="modal fade" id="Modal' + Content.id + '"> <div class="modal-dialog modal-lg"><div class="modal-content"><div class="modal-header">';
        str += '<h4 class="modal-title" >' + title + '</h4>';
        str += '<button type="button" class="close" data-dismiss="modal">&times;</button></div > <div class="modal-body">' + Content.innerHTML + '</div>';
        str += '<div class="modal-footer">' + applybtn+' </div></div ></div ></div >';

        Content.style.display = 'block';

        Content.innerHTML = str;

        if (Option && Option.applyEvent) {
            document.getElementById('Modal' + Content.id +'applyEvent').addEventListener("click", function () {
                Option.applyEvent();

            });
        }

        if (Option && Option.eventLoad) {
            $('#Modal' + Content.id).on('show.bs.modal', function () {
                Option.eventLoad();
            });
        }

        var setting = {};
        if (Option && Option.backdrop != null) {
            setting.backdrop = Option.backdrop;

        }
    }



    $('#Modal' + Content.id).modal(setting);
}