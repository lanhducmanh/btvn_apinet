$(document).ready(function () {
    function sendData() {
        var banKinhDay = parseFloat($('#txtA').val());
        var chieuCao = parseFloat($('#txtH').val());

        if (isNaN(banKinhDay) || isNaN(chieuCao) || banKinhDay <= 0 || chieuCao <= 0) {
            alert('Vui lòng nhập giá trị hợp lệ cho bán kính đáy và chiều cao.');
            return;
        }

        var dataToSend = {
            radius: banKinhDay,
            height: chieuCao
        };

        $.ajax({
            url: "WebForm1.aspx", 
            type: "POST",
            data: JSON.stringify(dataToSend),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                $('#result').text('Thể tích hình nón là: ' + response.volume);
            },
            error: function (xhr, status, error) {
                $('#result').text('Có lỗi xảy ra: ' + xhr.responseText);
            }
        });
    }

    $("#btnSendData").click(function () {
        sendData();
    });
});
