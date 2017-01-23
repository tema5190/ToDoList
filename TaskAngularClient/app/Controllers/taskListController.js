"use strict";

var app = angular.module("taskApp");

app.controller("taskListController", function ($scope, $http) {

    var getTasks = function () {
        $http.get("http://localhost:53179/api/Task")
            .then(function (response) {
                $scope.Tasks = response.data;
            });
    };

    getTasks();
});