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
            giveAlert: giveAlert,
            replaceAll:replaceAll
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

        function replaceAll(str, mapObj) {
            var re = new RegExp(Object.keys(mapObj).join("|"), "gi");

            return str.replace(re, function (matched) {
                return mapObj[matched];
            });
        }
    }
})();