function AddUserViewModel() {
    var me = this;

    me.addUser = function () {
        jQuery.ajax("/UseCase/Execute", {
            method: "POST",
            success: function (actions) {
                me.callActions(actions);
            },
            error: function () {
                me.showWarning({ text: "Huston, we've got a problem" });
            }
        });
    }

    me.showWarning = function (message) {
        alert(message.text);
    }

    me.callActions = function (actions) {
        for (var i = 0; i < actions.length; i++) {
            var actionName = actions[i].name;
            var arguments = actions[i].arguments;

            if (typeof me[actionName] === "function") {
                me[actionName](arguments);
            }
        }
    }
}

var viewModel = new AddUserViewModel();
viewModel.addUser();