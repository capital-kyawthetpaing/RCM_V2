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

function Comma(ctrl_id) { //function to add commas to textboxes
var obj=$("#"+ctrl_id);
var cleave = new Cleave(obj, {
    numeral: true,
    numeralThousandsGroupStyle: 'thousand'
    });
}
