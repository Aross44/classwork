import { Routes }        from '@angular/router';        // Give me acess to Angular router
import { HomeComponent } from './components/home/home.component';   // Give me access to the HomeComponent
import { SampleFormComponent } from './components/sample-form/sample-form.component';
import { StateSealsComponent } from './components/state-seals/state-seals.component';
import { StudentListComponent } from './components/student-list/student-list.component';

// The Routes object is an array of objects to associate a URL pathe to a component 
//
// Each entry in the array contains the following attributes:
//
// path - the URL path  to be associated with a component 
// component - name of the component for the associated with the path
// redirect - optional attribute to rediresct a URL path to a different page 
// pathMatch - indicates if a full match too a URL path is necessary to use this entry 
//
// we are defining an object called routes with a data type of Routes 
//We tell the router the name of  array with the Routes in app.config.ts
export const theRoutes: Routes = [
    {path: '', redirectTo: '/home', pathMatch: 'full' },  // empty path should redirect to /home
    {path: 'home', component: HomeComponent},            // /home should displahy the HomeComponent, (/) is the seperator to direct to the path /home
    {path: 'whatever', component: SampleFormComponent },   // whatever should display the SampleFormComponent
    {path: 'seals', component:StateSealsComponent    },    // seals should display the StateSealsComponent
    {path: 'student-list', component:StudentListComponent} // student list should display the STudentListComponent
];
