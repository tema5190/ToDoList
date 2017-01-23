"use strict";

var app = angular.module("taskApp", ["ngRoute"]);

app.config(function($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "app/Views/Task/Index.html",
            controller: "taskListController"
        })
        .when("Task/Detail/:id", {
            templateUrl: "app/Views/Task/Detail.html",
            controller: "taskDetailController"
        })
        .when("Task/Create/", {
            templateUrl: "app/Views/Task/Create.html",
            controller: "taskCreateController"
        })
        .when("Task/Edit/:id", {
            templateUrl: "app/Views/Task/Edit.html",
            controller: "taskEditController"
        })
        .when("Task/Delete/:id", {
            templateUrl: "app/Views/Task/Delete.html",
            controller: "taskDeleteController"
        });
});