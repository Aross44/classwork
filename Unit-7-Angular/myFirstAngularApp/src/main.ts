// This is the Angular application
// When you do ng serve it looks for main.ts to start app
// This is where you define the component representing your homepage

import { bootstrapApplication } from '@angular/platform-browser';  // Starts the Angular app
import { appConfig } from './app/app.config';  // Angular app configuration information

// This is here you specify the folder containing the homepage and its name

// import {name-used-in-this-code} from 'path-to-component-files'
// The component path contains folder and high-level name of the component
// The component path is relatie to src folder
// ./app/app
//
// .- the folder you are in (src folder)
//app - the folder named in the app you are in
//app - all files related to the component will start with the 'app'
//      .component is assume
// The name of the import must match an exoport class in a Typescript file
import { App } from './app/app';  // Get the Angular component stuff from './app/app'

//Clearer coding technique
//import { App } from './app/app.component, configuration'


//bootstrapApplication function is what the Angular server calls to start the app 
// Give it: (name-of-impot-for-component-configuration)
bootstrapApplication(App, appConfig)
  .catch((err) => console.error(err));
