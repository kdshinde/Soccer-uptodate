(function () {
    'use strict';

    angular
        .module('app')
        .controller('seasoncontroller', seasoncontroller);

    seasoncontroller.$inject = ['$scope', 'soccerfactory'];

    function seasoncontroller($scope, soccerfactory) {
        /* jshint validthis:true */
       // alert('controller');
        //var vm = this;
        //vm.title = 'Seasoncontroller';
        soccerfactory.getData();
        //activate();
       // function activate() { }
    }
})();
