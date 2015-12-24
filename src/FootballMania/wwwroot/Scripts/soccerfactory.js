(function () {
    'use strict';

    angular
        .module('app')
        .factory('soccerfactory', soccerfactory);

    soccerfactory.$inject = ['$http'];

    function soccerfactory($http) {
        var service = {
            getLeagues: getLeagues,
            getFixtures: getFixtures,
            giveAlert:giveAlert
        };

        return service;

        function getLeagues() {
            return $http.get("api/Soccer/GetSoccerSeasons");                
        }

        function getFixtures() {
            return $http.get("api/Soccer/GetAllFixtures");
        }

        function giveAlert() {
            alert('hi');
        }
    }
})();