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

        $scope.clickMe = function (clickEvent) {
            alert("hi");
        }

        $scope.leagueNameFilter = function (league) {
            var mapObj = {
                BL: "Bundesliga",
                FL: "Ligue",
                PL: "Premier League",
                PD: "Primera Division",
                SD: "Segunda Division",
                SA: "Serie A",
                PPL: "Primeira Liga",
                DED: "Eredivisie",
                CL: "Champions League"
            };
            league.league = soccerfactory.replaceAll(league.league, mapObj);
            return league;
        }

    }
})();
