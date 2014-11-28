﻿$(document).ready(function() {

    //knockout/////////////

    var viewModel = function () {
        var self = this;
        self.plants = ko.observableArray();
        self.url = ko.observable('/Content/Pictures/1.jpg');

        var booksUri = '/api/plants';

        //общая функция аякс
        function ajaxHelper(uri, method, data) {
            //self.error(''); // Clear error message
            return $.ajax({
                type: method,
                url: uri,
                dataType: 'json',
                contentType: 'application/json',
                data: data ? JSON.stringify(data) : null

            });
        }

        //получение всех элементов Plants
        function getAllPlants() {
            ajaxHelper(booksUri, 'GET').done(function(data) {
                self.plants(data);
            });
        };

        getAllPlants();
    };
    ko.applyBindings(viewModel);

    /////////////////////////////////////////////////

    //$("ul.nav li a").click(function() {
    //    $(this).parent().addClass("active");
    //});


});