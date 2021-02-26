
var devAjax = function () {
    this.XHR = null;


};


devAjax.prototype.get = function (url,sendData,callBackFunction,responseType='json') {

    this.XHR = this.GetNewXHR();
    this.XHR.onreadystatechange = function () {
        if (this.readyState == 4) {
            if (this.status >= 200 && this.status < 300) {
                callBackFunction(this.response);
            }
            else {
                showError(this.status);
            }
        }

    }

    this.XHR.responseType = responseType;
    this.XHR.open("Get", url + getQueryString(sendData), true);
    this.XHR.setRequestHeader("X-Requested-With", "XMLHttpRequest");

    this.XHR.send();
}

devAjax.prototype.post = function (url, sendData, callBackFunction, responseType = 'json') {

    this.XHR = this.GetNewXHR();
    this.XHR.onreadystatechange = function () {
        if (this.readyState == 4) {
            if (this.status >= 200 && this.status < 300) {

                if (this.response && this.response.isNotValid) {
                    alert(this.response.errorMessage);
                }
                else
                callBackFunction(this.response);
            }
            else {
                showError(this.status);
            }
        }

    }
  

    this.XHR.responseType = responseType;
    this.XHR.open("Post", url, true);
    this.XHR.setRequestHeader("X-Requested-With", "XMLHttpRequest");
    this.XHR.send(getFormData(sendData));
}

function showError(status) {
    var errorMessage = "خطا";
    if (status >= 400 && status < 500) {
        errorMessage = " خطای سمت مشتری ";
    }
    if (status == 403 || status == 401) {
        errorMessage = " شما مجوز انجام چنین عملیاتی را ندارید ";
    }
    if (status >= 500) {
        errorMessage = "خطای سمت سرور";
        if (status == 521)
            errorMessage = "خطای تقسیم بر صفر";
    }

    alert(errorMessage);
}

function getQueryString(ob) {

    if (ob == null)
        return "";
    var str = "?"
    for (var prop in ob) {
        if (str == "?")
            str += prop + "=" + ob[prop];
        else
        str += "&" + prop+"=" + ob[prop]
    }
    return str;
}

function getFormData(ob) {

    if (ob == null)
        return null;

    var form = new FormData();
    for (var prop in ob) {
        form.append(prop, ob[prop]);
    }
    return form;
}

devAjax.prototype.GetNewXHR = function () {

    var xhr = new XMLHttpRequest();
    xhr.onloadstart = function () {
        imgLoading.style.display = "block";
    }
    xhr.onloadend = function () {
        imgLoading.style.display = "none";
    }

    return xhr;

}


var AJX = new devAjax();



var Upload = function (file, url, callBack, progress_id) {
    this.file = file;
    this.URL = url;
    this.progress_bar_id = progress_id;
    this.callBack = callBack;
};

Upload.prototype.getType = function () {
    return this.file.type;
};
Upload.prototype.getSize = function () {
    return this.file.size;
};
Upload.prototype.getName = function () {
    return this.file.name;
};
Upload.prototype.devsharpUpload = function () {
    var that = this;
    var formData = new FormData();


    formData.append("file", this.file, this.getName());
    formData.append("upload_file", true);

    $("#" + that.progress_bar_id + ".progress-bar").css("width", "0%");
    $("#" + that.progress_bar_id + " span").text("0%");

    $.ajax({
        type: "POST",
        url: that.URL,
        xhr: function () {
            var myXhr = $.ajaxSettings.xhr();
            if (myXhr.upload) {
                myXhr.upload.addEventListener('progress', function (event) {

                    var percent = 0;
                    var position = event.loaded || event.position;

                    var total = event.total;


                    if (event.lengthComputable) {
                        percent = Math.ceil(position / total * 100);
                    }
                    $("#" + that.progress_bar_id + ".progress-bar").css("width", +percent + "%");
                    $("#" + that.progress_bar_id + " span").text(percent + "%");
                }, false);
            }
            return myXhr;
        },
        success: function (data) {
            that.callBack(data);
        },
        error: function (error) {

        },
        async: true,
        data: formData,
        cache: false,
        contentType: false,
        processData: false,
        timeout: 60000
    });
};