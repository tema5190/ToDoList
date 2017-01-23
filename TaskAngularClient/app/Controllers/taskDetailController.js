(function() {
    var taskDetailController = function($scope, $http, $routeParams) {

        var taskId = $routeParams.id;

        var getTaskDetail = function() {
            $http.get("http://localhost:53179/api/Task" + "//" + taskId)
                .then(function(response) {
                    $scope.taskInfo = response.data;
                });
        };

        getTaskDetail();
    };

    app.controller("taskDetailController", ["$scope", "$http", "$routeParams", taskDetailController]);

})