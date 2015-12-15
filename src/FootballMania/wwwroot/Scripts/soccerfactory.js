(function () {
    'use strict';

    angular
        .module('app')
        .factory('soccerfactory', soccerfactory);

    soccerfactory.$inject = ['$http'];

    function soccerfactory($http) {
        var service = {
            getData: getData
        };

        return service;

        function getData() {
           $http.get("api/Soccer/GetSoccerSeasons")
                .then(function (data) { console.log(data); });
        }
    }
})();