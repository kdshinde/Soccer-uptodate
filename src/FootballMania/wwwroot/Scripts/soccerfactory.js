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

        // We can pass the league id throught the url. When the link is clicked, in Leagues.html, within the href, pass the id as well. We can call a specific function which takes League.self as
        // input and then returns the id, which is added to the url. In the next page, we find a way to read the url and then get the id, which is then passed to the below functions. 

        // A parameter is required in order to identify which league is in context here. Either simply pass the league id here, or send the whole string. 
        function getTeamsinLeague(leagueID) {
            return $http.post("api/Soccer/GetLeagueTeams", "'" + leagueID + "'");
        }

        // A parameter is required in order to identify which league is in context here. Either simply pass the league id here, or send the whole string. 
        function getFixturesinLeague(leagueID) {
            return $http.post("api/Soccer/GetLeagueFixtures", "'" + leagueID + "'");
        }

        // A parameter is required in order to identify which league is in context here. Either simply pass the league id here, or send the whole string. 
        function getSpecificLeagueTable(leagueID) {
            return $http.post("api/Soccer/GetLeagueTable", "'" + leagueID + "'");
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