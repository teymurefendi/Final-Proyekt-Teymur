
(function ($) {
    "use strict";
    let i = 0;
    let CalcI = () => {
        i = $(".tag-item").length - 1;
    }
    CalcI();

    $('#addTag').click(function (e) {
        $.ajax({
            url: "GetTags",
            type: "GET",
            dataType: "JSON",
            success: function (response) {
                console.log(response);

                i++;
                let tag = $(".tag-menu-basqasi");
                let divItem = $('<div class="tag-item"></div>');

                let label = $('<label for="NewsToTags[' + i + '].TagId">Tag</label>');
                let divTag = $('<div class="mt-2"></div>');
                let select = $('<select name="NewsToTags[' + i + '].TagId" data-placeholder="Select your favorite actors" class="select2 w-full"></select>');
                let defaultOption = $('<option selected="" disabled>Select Tag</option>');
                select.append(defaultOption);


                let deleteButton = $('<span class="deleteTag">x</span>');

                for (var j = 0; j < response.length; j++) {
                    let option = $('<option value="' + response[j].id + '" >' + response[j].name + '</option>');
                    select.append(option);
                }

                let hr = $('<hr style="margin:10px 0px"/>');


                divItem.append(label);
                divTag.append(select);
                divItem.append(divTag);

                divItem.append(deleteButton);

                tag.append(divItem);
                tag.append(hr);
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

    $(document).on('click', '.deleteTag', function () {
        $(this).parent().remove();
        CalcI();
    });
})($);