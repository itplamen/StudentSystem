const studentSystemApi = (function () {
    'use strict';

    function send(method, url, requestModel) {
        let promise = new Promise(function (resolve, reject) {
            $.ajax({
                url: url,
                dataType: 'json',
                method: method,
                contentType: 'application/json',
                data: JSON.stringify(requestModel),
                success: function (data) {
                    resolve(data);
                },
                error: function (err) {
                    reject(err);
                }
            });
        });

        return promise;
    }

    function post(url, requestModel) {
        return send('POST', url, requestModel);
    }

    function get(url, requestModel) {
        return send('GET', url, requestModel);
    }

    return {
        post: post,
        get: get
    };
}());