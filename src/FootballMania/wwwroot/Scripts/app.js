(function () {
    'use strict';
   var app = angular.module('app', []);
    app
     .config(soccerconfig);

    soccerconfig.$inject = ['$httpProvider'];

    function soccerconfig($httpProvider) {
        $httpProvider.defaults.useXDomain = true;
        $httpProvider.defaults.headers.common["X-Auth-Token"] = '7b049d5b78124b76be75081c53975451';
        delete $httpProvider.defaults.headers.common['X-Requested-With'];
    }
    
})();