(function () {
    'use strict';

    angular
        .module('app')
        .controller('seasoncontroller', seasoncontroller);

       seasoncontroller.$inject = ['$scope', 'soccerfactory'];

    function seasoncontroller($scope, soccerfactory) {
        soccerfactory.getLeagues().success(function (leagues) {
            $scope.leagues = leagues;
        });

        soccerfactory.getFixtures().success(function (fixtures) {
            console.log(fixtures);
            $scope.fixtures = fixtures;
        });
    }
})();
