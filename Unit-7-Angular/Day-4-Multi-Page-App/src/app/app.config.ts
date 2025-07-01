import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';

// Tell the router where to find the array with the routes
//  that connect a URL to a component
// the import name must match the export name in your app.routes.ts

//appConfig object identifies things that you are usig that
//   are not apart of base Angular processing 
// (the router is not required for basic Angular processing)
//
//the providers attribute is a list of 
// provideRouter indicates is a list of optional Angular processes you are using



import { theRoutes } from './app.routes';

export const appConfig: ApplicationConfig = {
  providers: [provideRouter(theRoutes)]
};