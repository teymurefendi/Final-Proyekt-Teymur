
(function ($) {
    "use strict";
    let c = 0;
    let CalcI = () => {
        c = $(".social-item").length - 1;
    }
    CalcI();

    $('#addSocial').click(function (e) {
        $.ajax({
            url: "GetSocials",
            type: "GET",
            dataType: "JSON",
            success: function (response) {
                console.log(response);

                c++;
                let social = $(".social-menu-basqasi");
                let divItem = $('<div class="social-item"></div>');

                let label = $('<label for="TeamToSocials[' + c + '].TeamSocialId">Social</label>');
                let divSocial = $('<div class="mt-2"></div>');
                let select = $('<select name="TeamToSocials[' + c + '].TeamSocialId" data-placeholder="Select your favorite actors" class="select2 w-full"></select>');
                let defaultOption = $('<option selected="" disabled>Select Social</option>');
                select.append(defaultOption);
                let labellink = $('<label for="TeamToSocials[' + c + '].TeamSocialId">Link</label>');   
                let divLink = $('<input name="TeamToSocials[' + c + '].Link" class="input w-full border mt-2" placeholder="Input text">');

                
                let deleteButton = $('<span class="deleteSocial">x</span>');

                for (var f = 0; f < response.length; f++) {
                    let option = $('<option value="' + response[f].id + '" >' + response[f].icon + '</option>');
                    select.append(option);
                }

                let hr = $('<hr style="margin:10px 0px"/>');


                divItem.append(label);
                divSocial.append(select);
                divItem.append(divSocial);
                divItem.append(labellink);
                divItem.append(divLink);
                divItem.append(deleteButton);

                social.append(divItem);
                social.append(hr);

                
            },
            error: function () { },
            complete: function () {
                $('.select2').select2()
            }
        });
    });

    //$(".deleteSocial").on("click", function (e) {
    //    console.log("slvnkljb ");
    //    $(this).parent().remove();
    //})

    $(document).on('click', '.deleteSocial', function () {
        $(this).parent().remove();
        CalcI();
    });

    CKEDITOR.replace('Content');
})($);