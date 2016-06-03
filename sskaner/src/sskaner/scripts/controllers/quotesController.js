(function () {
    'use strict';

    angular
        .module('myQuotesApp', [])
        .service('quotesService', function () { /* ... */ })
        .controller('quotesController', quotesController);

    quotesController.$inject = ['$scope', 'Quotes']; 

    function quotesController($scope, Quotes) {

        $scope.quotes = Quotes.query();

    }
})();
