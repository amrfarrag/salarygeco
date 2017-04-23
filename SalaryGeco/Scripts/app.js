var app = angular.module("salaryapp",[]);
app.controller("projectcontroller", function ($scope,$http) {
    $scope.project = {
        ProjectID: 0,
        ProjectName: ""
    };
    $scope.projects = [];

});