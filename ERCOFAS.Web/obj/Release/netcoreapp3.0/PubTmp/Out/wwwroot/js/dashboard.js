var Dashboard = function () {
    var form = this;

    form._constructor = function () {
        console.log("this is a test");
    }
}

var dashboard = new Dashboard();
dashboard._constructor();