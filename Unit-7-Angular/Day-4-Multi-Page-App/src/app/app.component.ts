// import gives us access to external features and components
// Most imported name must be included in imports property of @Component
import { Component }       from '@angular/core';
import { RouterOutlet }    from '@angular/router';

//We must import any components used by this component 
import { NavBarComponent } from './components/nav-bar/nav-bar.component';
import { HomeComponent }   from './components/home/home.component';

//The home component is used in the nav-bar component
// whic is in includeded in this component
// this component indirectly uses the home component
@Component({ // Metadata for the component - gives Angular some basic info
  selector: 'app-root',  // This is what is used to include this component 
                         //      on a page 

 standalone: true,      // Added in Angular 17 to allow components to ne independent
  /// Include the important name for any component in the imports attribute of @Component 
  imports: [RouterOutlet, NavBarComponent, HomeComponent], // identifies things used
  templateUrl: './app.component.html',  // Where to find the html file
  styleUrl: './app.component.css'       //       and css file
})
// This defines a module for this component
// export - say let things outside this component have access to it
// class - This is a group of things associated with this component 
export class AppComponent {
 
}
