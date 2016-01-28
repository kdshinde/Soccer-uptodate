(function () {
    'use strict';
    angular
        .module('app')
        .controller('LeagueController', LeagueController);

    LeagueController.$inject = ['$scope']; 

    function LeagueController($scope) {
        $scope.title = 'LeagueController';
        alert('In League controller');
    }
})();
