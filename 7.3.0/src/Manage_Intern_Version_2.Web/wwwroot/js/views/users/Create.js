(function ($) {
    $(function () {
        var _$form = $('#UserCreationForm');
        

        _$form.find('input:first').focus();

        _$form.validate();
        console.log(abp.services.app);
        _$form.find('button[type=submit]')
            .click(function (e) {
                e.preventDefault();

                if (!_$form.valid()) {
                    return;
                }
                
                var input = _$form.serializeFormToObject();
                console.log(input);
                if (input.PassWord == input.ConfirmPassWord) {// fixx
                    abp.services.app.user.create(input)
                        .done(function () {
                            location.href = '/Users';
                        });
                  /*  abp.services.app.user.create(input)
                        .done(function () {
                            //location.href = '/Users';
                        });
                    if (input.Role == 1) {

                    } else if (input.Role == 2) {
                        abp.services.app.intern.create(input.id)
                            .done(function () {
                                location.href = '/Users';
                            });
                    }*/
                } else {
                    alert("Kiểm tra lại Confirm Password")
                    return;
                }

            });
    });
})(jQuery);