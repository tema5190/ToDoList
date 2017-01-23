"use strict";

var app = angular.module("taskApp");

app.controller("taskDetailController", function ($scope, $http, $routeParams) {


    var taskId = $routeParams.id;

    var getTaskDetails = function() {
        $http.get("http://localhost:53179/api/Task/" + taskId)
        .then(function (response)
        {
            $scope.taskDetail = response.data;
        });

        getTaskDetails();
    }
});