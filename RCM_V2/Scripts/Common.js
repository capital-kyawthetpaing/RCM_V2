function CalltoApiController(url, model) {
    var result;
    $.ajax({
        url: url.replace("%2F", "/"),
        method: 'POST',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(model),
        async: false,
        headers:
        {
            Authorization: 'Basic ' + btoa('Capital_MM' + ':' + 'CKM12345!')
        },
        success: function (data) {           
            result = data;
        },
    });
    return result;
}

function ShowMessage(msgid, functionname) {
    var Mmodel = {
        MessageID: msgid,
    };

    var data = CalltoApiController($("#MessageURL").val(), Mmodel)

    var msgdata = JSON.parse(data);

    Swal.fire({
        icon: msgdata[0].MessageIcon,
        title: msgdata[0].MessageID,
        text: msgdata[0].MessageText,
    }).then(function () {
        if (functionname) {
            var fn = window[functionname];
            fn('NG');
        }
    })
}

function RequiredCheck(ctrl) {
    $(ctrl).attr("data-Required", "1");
}

function AlreadyExistsCheck(ctrl, apiURL, val1, val2, val3) {
    $(ctrl).attr("data-AlreadyExistsCheck", "1");
    $(ctrl).attr("data-AlreadyExistsApiUrl", apiURL);   
    $(ctrl).attr("data-AlreadyExistsValue1", val1);
    if(val2.val())
        $(ctrl).attr("data-AlreadyExistsValue2", val2);
    if (val3.val())
        $(ctrl).attr("data-AlreadyExistsValue3", val3);
}

function KeyDown(e, ctrl, functionname) {
    if (e.which == 13) {
        e.preventDefault();
        var result = ErrChk(ctrl);
        if (result == "0") {
            moveNext(ctrl);
            if (functionname) {
                var fn = window[functionname];
                fn('OK');
            }
        }
        else {
            ShowMessage(result, functionname);
        }
    }
}

function ErrChk(ctrl) {
    var req = $(ctrl).attr("data-Required");
    if (req == "1") {
        if (!$(ctrl).val()) {
            return "E102";
        }
    }

    var aec = $(ctrl).attr("data-AlreadyExistsCheck");
    if (aec == "1") {
        var ApiURL = $(ctrl).attr("data-AlreadyExistsApiUrl");
        var val1 = $(ctrl).attr("data-AlreadyExistsValue1");
        var val2 = $(ctrl).attr("data-AlreadyExistsValue2");
        var val3 = $(ctrl).attr("data-AlreadyExistsValue2");

        var model = {
            Val1: $(val1).val(),
            Val2: $(val2).val(),
            Val3: $(val3).val()
        };
        var response = CalltoApiController(ApiURL, model);
        var data = JSON.parse(response);

    }

    return "0";
}

function moveNext(ctrl) {
    do {
        ctrl = $('[tabIndex=' + (+$(ctrl).attr("tabIndex") + 1) + ']');
        if (!$(ctrl).length) {
            ctrl = $('[tabIndex=1]');
            break;
        }
    } while ($(ctrl).is('[disabled=disabled]'));
    $(ctrl).select();
    $(ctrl).focus();
}

function ErrorCheckOnClick(e1) {
    var r1 = "0";
    $('#'+e1+' *').filter(':input').each(function () {
        var result = ErrChk(this);
        if (result != "0") {
            $(this).focus();
            r1 = result;
            return result;
        }
    });
    return r1;
}

function isNumberKey(evt) {    
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;

    return true;
}

function Comma(Num) { //function to add commas to textboxes
    Num += '';
    Num = Num.replace(',', ''); Num = Num.replace(',', ''); Num = Num.replace(',', '');
    Num = Num.replace(',', ''); Num = Num.replace(',', ''); Num = Num.replace(',', '');
    x = Num.split('.');
    x1 = x[0];
    x2 = x.length > 1 ? '.' + x[1] : '';
    var rgx = /(\d+)(\d{3})/;
    while (rgx.test(x1))
        x1 = x1.replace(rgx, '$1' + ',' + '$2');
    return x1 + x2;

}
