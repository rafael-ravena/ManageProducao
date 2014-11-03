'use strict';

angular.module('BisuttiApp.controllers', []);
angular.module('BisuttiApp.services', []);
angular.module('BisuttiApp.directives', []);
angular.module('BisuttiApp.filters', []);

angular.module('BisuttiApp', ['ngRoute', 'ngLocale', 'ngCookies', 'ngAnimate', 'BisuttiApp.controllers', 'BisuttiApp.services', 'BisuttiApp.directives', 'BisuttiApp.filters']);
