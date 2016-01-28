(function () {
    'use strict';
   var app = angular.module('app', ['ngRoute']);
    app
     .config(soccerconfig);

    soccerconfig.$inject = ['$httpProvider','$routeProvider','$locationProvider'];

    function soccerconfig($httpProvider,$routeProvider,$locationProvider) {
        $httpProvider.defaults.useXDomain = true;
        $httpProvider.defaults.headers.common["X-Auth-Token"] = '7b049d5b78124b76be75081c53975451';
        delete $httpProvider.defaults.headers.common['X-Requested-With'];

        $routeProvider
            .when('/Home/', {
                templateUrl: '/Assets/Leagues.html',
                controller: 'seasoncontroller'
            })
            .when('/api/Show/GetLeague/', {
             templateUrl: '/Assets/test.html',
             controller: 'LeagueController'
         })            
            .otherwise({
                redirectTo: "/Home/"
            });

       $locationProvider.html5Mode(true);
    }    
})();