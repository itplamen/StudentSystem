const studentSystemApi = (function () {
    'use strict';

    function post(url, requestModel, seccess, additionalInfo) {
        $.ajax({
            url: url,
            dataType: 'json',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(requestModel),
            success: function (data) {
                seccess(data, additionalInfo);
            },
            error: function (err) {
                alert('POST request failed!');

                console.log("Error ", err);
            }
        });
    }

    return {
        post: post
    };
}());